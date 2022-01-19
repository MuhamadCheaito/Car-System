using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmBuyCar : Form
    {
        public frmBuyCar()
        {
            InitializeComponent();
        }
        private void browseButton_Click(object sender, EventArgs e)
        {
        }
        private void validateBox(TextBox text,PictureBox errorIcon,PictureBox validIcon)
        {
            if(text.Text != "")
            {
                validIcon.Visible = true;
                errorIcon.Visible = false;
            }
            else
            {
                validIcon.Visible = false;
                errorIcon.Visible = true;
            }
        }
        private void buyBtn_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (suppliersBox.Text != "")
                {
                    string vinNo = cIDBox.Text;
                    string status = carStatus.Text;
                    string carName = cNameBox.Text;
                    string carModel = cModelBox.Text;
                    string carCompany = accountBox.Text;
                    long carKilo = long.Parse(cKiloBox.Text);
                    RedundantData.con.Open();
                    string carAddQuery = @"INSERT INTO CAR(VIN_No,NAME,MODEL,COMPANY,KILOMETERS,PRICE,COLOR,STATUS,SOLD,PurchaseDate,Supp_ID) 
                                   Values(@cID,@cName,@cModel,@cCompany,@cKm,@cPrice,@Color,@cStatus,0,@pDate,@SuppID)";
                    SqlCommand carAddCMD = new SqlCommand(carAddQuery, RedundantData.con);
                    carAddCMD.Parameters.AddWithValue("@cID", vinNo.ToUpper());
                    carAddCMD.Parameters.AddWithValue("@cName", carName);
                    carAddCMD.Parameters.AddWithValue("@cModel", carModel);
                    carAddCMD.Parameters.AddWithValue("@cCompany", carCompany);
                    carAddCMD.Parameters.AddWithValue("@cKm", carKilo);
                    carAddCMD.Parameters.AddWithValue("@cPrice", (cPriceBox.Text == "" || cPriceBox.Text == "0") ? 0 : decimal.Parse(cPriceBox.Text));
                    carAddCMD.Parameters.AddWithValue("@Color", colorBox.Text);
                    carAddCMD.Parameters.AddWithValue("@cStatus", status);
                    carAddCMD.Parameters.AddWithValue("@pDate", dtpPurchaseDate.Value);
                    carAddCMD.Parameters.AddWithValue("@SuppID", suppliersBox.SelectedValue);
                    carAddCMD.ExecuteNonQuery();
                    CustomSuccessBox.Show("New Car has been Successfuly Added.");
                    CustomSuccessBox.Show("You Bought this car on " + dtpPurchaseDate.Value);
                }
                else
                {
                    CustomMsgBox.Show("Make Sure You Entered Supplier Name.","OK");
                }

            }
            catch (SqlException ex)
            {

                CustomMsgBox.Show(ex.Message,"OK");
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
            }
            
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmSMMenu().Show();
        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAddSupplier().Show();
            this.Hide();
        }
        private void fillSuppliers()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewSuppCmd = new SqlCommand("select SUPPLIER_ID,NAME from SUPPLIER", RedundantData.con);
                SqlDataAdapter viewSuppAdapter = new SqlDataAdapter(viewSuppCmd);
                DataSet suppData = new DataSet();
                viewSuppAdapter.Fill(suppData, "SUPPLIER");
                suppliersBox.DisplayMember = "NAME";
                suppliersBox.ValueMember = "SUPPLIER_ID";
                suppliersBox.DataSource = suppData.Tables["SUPPLIER"];
            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
            }
        }
        private void frmBuyCar_Load(object sender, EventArgs e)
        {
            fillSuppliers();
        }

        private void suppliersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void colorBox_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CustomQuestionBox.Show("Are You Sure You Wanna Delete This Supplier?") == DialogResult.Yes)
            {
                try
                {
                    RedundantData.con.Open();
                    string suppDeleteQuery = @"DELETE FROM SUPPLIER WHERE SUPPLIER_ID=" + suppliersBox.SelectedValue;
                    SqlCommand suppDeleteCmd= new SqlCommand(suppDeleteQuery, RedundantData.con);
                    suppDeleteCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    CustomMsgBox.Show(ex.Message, "OK");
                }
                finally
                {
                    suppliersBox.Text = "";
                    RedundantData.con.Close();
                }
                fillSuppliers();
            }
        }

        private void cIDBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(cIDBox, carIDErrorIcon, vinBoxValid);
        }

        private void cNameBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(cNameBox, carNameErrorIcon, nameBoxValid);
        }

        private void cModelBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(cModelBox, carModelErrorIcon, modelBoxValid);
        }

        private void cKiloBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(cKiloBox, kiloErrorIcon , kiloBoxValid);
        }

        private void cPriceBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(cPriceBox, carPriceErrorIcon, priceValidBox);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmUpdateSupplier(suppliersBox.SelectedValue.ToString()).Show();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {

        }

        private void cKiloBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }

        private void cPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }

        private void cModelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }
    }
}
