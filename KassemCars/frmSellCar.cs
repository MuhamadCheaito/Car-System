using CSM_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmSellCar : Form
    {
        string carID;
        bool sellFlag, paidFlag;
        decimal totalPay,totalRepairs;
        decimal exchange;
        public frmSellCar()
        {
            InitializeComponent();
        }
        public frmSellCar(string carid)
        {
            InitializeComponent();
            carID = carid;
        }
        private void fillTotalCosts()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand nairaCmd = new SqlCommand("SELECT TOP 1 NIARA_PRICE FROM NAIRA_CUR ORDER BY ID DESC", RedundantData.con);
                exchange = Convert.ToDecimal(nairaCmd.ExecuteScalar());
                SqlCommand viewCostCmd = new SqlCommand($@"select SUM(c.paid_price+(c.custom_fees/{exchange})) as 'PayWithDuty', +
                                                        SUM(m.LIGHTS+m.TIERS+m.ENGINE+m.BATTERY+m.SPRAY+m.FURNISHING)/{exchange} as 'TotalRepairs'
                                                        from Cost as c INNER JOIN MAINTENANCE as m ON 
                                                        c.maintenance_id = m.Maintenance_ID
                                                        WHERE c.CAR_ID='{carID}'", RedundantData.con);
                var reader = viewCostCmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader["PayWithDuty"]) || !Convert.IsDBNull(reader["TotalRepairs"]))
                    {
                        totalPay = Convert.ToDecimal(reader["PayWithDuty"].ToString());
                        totalRepairs = Convert.ToDecimal(reader["TotalRepairs"].ToString());
                    }
                    else
                    {
                        break;
                    }
                }
                reader.Close();
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
        private void startChecker()
        {
            if (sellPriceBox.Text == "")
            {
                sellFlag = true;
            }

            if (txtpaidPrice.Text == "")
            {
                paidFlag = true;
            }
        }
        private void validateBox(TextBox text, PictureBox errorIcon, PictureBox validIcon)
        {
            if (text.Text != "")
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
        private void fillCustomers()
        {
            try
            {
                startChecker();
                string sellPrice, paidPrice;
                sellPrice = sellPriceBox.Text;
                paidPrice = txtpaidPrice.Text;
                if ((sellFlag || paidFlag) == true)
                {
                    if (sellFlag)
                    {
                        sellErrorIcon.Visible = true;
                        sellValidIcon.Visible = false;
                    }
                    if (paidFlag)
                    {
                        paidErrorIcon.Visible = true;
                        paidValidIcon.Visible = false;
                    }
                }
                    RedundantData.con.Open();
                    SqlCommand viewSuppCmd = new SqlCommand("select ID,NAME from CUSTOMER", RedundantData.con);
                    SqlDataAdapter viewSuppAdapter = new SqlDataAdapter(viewSuppCmd);
                    DataSet suppData = new DataSet();
                    viewSuppAdapter.Fill(suppData, "CUSTOMER");
                    customersBox.DisplayMember = "NAME";
                    customersBox.ValueMember = "ID";
                    customersBox.DataSource = suppData.Tables["CUSTOMER"];
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
        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
            exitBtn.ForeColor = Color.Red;
        }


        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new frmSMMenu().Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }


        private void sellBtn_MouseEnter(object sender, EventArgs e)
        {
            sellBtn.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void sellBtn_MouseLeave(object sender, EventArgs e)
        {
            sellBtn.BackColor = Color.FromArgb(77, 74, 82);
        }


        private void frmSellCar_Load(object sender, EventArgs e)
        {
            fillCustomers();
            fillCarInfo();
            fillTotalCosts();
            MessageBox.Show(totalPay.ToString() + " " + totalRepairs.ToString());
        }

        private void sellPriceBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(sellPriceBox, sellErrorIcon, sellValidIcon);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmUpdateCustomer(lblVin.Text, customersBox.SelectedValue.ToString()).Show();
            this.Hide();
        }
        private void fillCarInfo()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand($"select VIN_No,NAME,MODEL,PRICE from CAR WHERE VIN_No='{carID}'", RedundantData.con);
                SqlDataReader reader = viewCarCmd.ExecuteReader();
                while (reader.Read())
                {
                    lblVin.Text = reader["VIN_No"].ToString();
                    lblname.Text = reader["NAME"].ToString();
                    lblModel.Text = reader["MODEL"].ToString();
                    lblCompany.Text = reader["PRICE"].ToString();
                }
                reader.Close();
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
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CustomQuestionBox.Show("Are You Sure You Wanna Delete This Customer?") == DialogResult.Yes)
            {
                try
                {
                    RedundantData.con.Open();
                    string customerDeleteQuery = @"DELETE FROM CUSTOMER WHERE ID =" + customersBox.SelectedValue;
                    string getCarsQuery = @"SELECT CUSTOMER_HAS.CAR_ID FROM CUSTOMER_HAS
										    WHERE CUSTOMER_HAS.CUSTOMER_ID =" + customersBox.SelectedValue;
                    string soldUpdatQuery;
                    SqlCommand getCarsCmd = new SqlCommand(getCarsQuery, RedundantData.con);
                    SqlCommand customerDeleteCmd = new SqlCommand(customerDeleteQuery, RedundantData.con);
                    var reader = getCarsCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        soldUpdatQuery = $"UPDATE CAR SET SOLD = 0,STATUS='IN',SELL_PRICE=NULL WHERE Car.VIN_No='{reader["VIN_No"]}'";
                        SqlCommand soldUpdateCmd = new SqlCommand(soldUpdatQuery, RedundantData.con);
                        soldUpdateCmd.ExecuteNonQuery();
                    }
                    customerDeleteCmd.ExecuteNonQuery();
                    reader.Close();
                }
                catch (Exception ex)
                {

                    CustomMsgBox.Show(ex.Message, "OK");
                }
                finally
                {
                    customersBox.Text = "";
                    RedundantData.con.Close();
                }
                fillCustomers();
            }
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {

        }

        private void sellPriceBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpaidPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sellBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (sellPriceBox.Text == "" || txtpaidPrice.Text == "")
                {
                    CustomMsgBox.Show("Please Fill In The Blanks", "OK");
                }
                else
                {
                    string cID = carID;
                    decimal sellPrice = decimal.Parse(sellPriceBox.Text);
                    decimal paidPrice = decimal.Parse(txtpaidPrice.Text);
                    RedundantData.con.Open();
                    string customerAddQuery = @"INSERT INTO CUSTOMER_HAS(CAR_ID,CUSTOMER_ID,Paid_Price)
                                                VALUES(@cCarID,@CustomerID,@paid)";
                    string sellUpdateQuery = @"UPDATE CAR SET SELL_PRICE=@cSell,STATUS='SOLD',SOLD=1,SoldDate=@cSellDate WHERE VIN_No=@cCarID";
                    string accountAddQuery = @"INSERT INTO ACCOUNT(PayWithDuty,TotalRepairs,CAR_ID) 
                                               VALUES(@aPay,@totalRepairs,@aCarID)";
                    SqlCommand customerCMD = new SqlCommand(customerAddQuery, RedundantData.con);
                    SqlCommand sellCMD = new SqlCommand(sellUpdateQuery, RedundantData.con);
                    SqlCommand accountCMD = new SqlCommand(accountAddQuery, RedundantData.con);
                    customerCMD.Parameters.AddWithValue("@cCarID", cID);
                    customerCMD.Parameters.AddWithValue("@CustomerID", customersBox.SelectedValue);
                    customerCMD.Parameters.AddWithValue("@paid", paidPrice);
                    sellCMD.Parameters.AddWithValue("@cSell", sellPrice);
                    sellCMD.Parameters.AddWithValue("@cSellDate", dtpSellDate.Value);
                    sellCMD.Parameters.AddWithValue("@cCarID", cID);
                    accountCMD.Parameters.AddWithValue("@aPay", totalPay);
                    accountCMD.Parameters.AddWithValue("@totalRepairs", totalRepairs);
                    accountCMD.Parameters.AddWithValue("@aCarID", cID);
                    customerCMD.ExecuteNonQuery();
                    sellCMD.ExecuteNonQuery();
                    accountCMD.ExecuteNonQuery();
                    CustomSuccessBox.Show("Car Sold Successfully. On " + dtpSellDate.Value.ToString("dd-MM-yyyy"));
                }
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                this.Hide();
                new frmSMMenu().Show();
            }
        }

        private void backBtn_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmSMMenu().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpaidPrice_TextChanged(object sender, EventArgs e)
        {
            validateBox(txtpaidPrice, paidErrorIcon, paidValidIcon);
        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAddCustomer(carID).Show();
            this.Hide();
        }
    }
}
