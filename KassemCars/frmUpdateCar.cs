using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmUpdateCar : Form
    {
        string carID;
        public frmUpdateCar()
        {
            InitializeComponent();
        }
        public frmUpdateCar(string carid)
        {
            InitializeComponent();
            carID = carid;
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
        private void browseButton_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void saveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string cID = cIDBox.Text;
            string carName = cNameBox.Text;
            string carModel = cModelBox.Text;
            string carCompany = accountBox.Text;
            long carKilo = long.Parse(cKiloBox.Text);
            decimal carPrice = decimal.Parse(cPriceBox.Text);
            string carColor = colorBox.Text;
            
            try
            {
                RedundantData.con.Open();
                string carAddQuery = $@"UPDATE CAR
                                       SET VIN_No=@cID,NAME=@cName,MODEL=@cModel,COMPANY=@cCompany,KILOMETERS=@cKm,PRICE=@cPrice,COLOR=@carColor,PurchaseDate=@purchasedate
                                       WHERE VIN_No='{carID}'" ;
                SqlCommand carAddCMD = new SqlCommand(carAddQuery, RedundantData.con);
                carAddCMD.Parameters.AddWithValue("@cID", cID);
                carAddCMD.Parameters.AddWithValue("@cName", carName);
                carAddCMD.Parameters.AddWithValue("@cModel", carModel);
                carAddCMD.Parameters.AddWithValue("@cCompany", carCompany);
                carAddCMD.Parameters.AddWithValue("@cKm", carKilo);
                carAddCMD.Parameters.AddWithValue("@cPrice", carPrice);
                carAddCMD.Parameters.AddWithValue("@carColor", carColor);
                carAddCMD.Parameters.AddWithValue("@purchasedate", dtpPurchaseDate.Value);
                carAddCMD.ExecuteNonQuery();
                CustomSuccessBox.Show("Car Data Has Been Updated Successfully.");
            }
            catch (Exception ex)
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

        private void frmUpdateCar_Load(object sender, EventArgs e)
        {
            RedundantData.con.Open();
            SqlCommand viewCarCmd = new SqlCommand("select * from CAR WHERE VIN_No='" + carID+"'", RedundantData.con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);
            cIDBox.Text = carData.Tables[0].Rows[0].ItemArray[1].ToString();
            cNameBox.Text = carData.Tables[0].Rows[0].ItemArray[2].ToString();
            cModelBox.Text = carData.Tables[0].Rows[0].ItemArray[4].ToString();
            accountBox.Text = carData.Tables[0].Rows[0].ItemArray[5].ToString();
            colorBox.Text = carData.Tables[0].Rows[0].ItemArray[6].ToString();
            cKiloBox.Text = carData.Tables[0].Rows[0].ItemArray[7].ToString();
            cPriceBox.Text = carData.Tables[0].Rows[0].ItemArray[8].ToString();
            dtpPurchaseDate.Text = carData.Tables[0].Rows[0].ItemArray[12].ToString();
            RedundantData.con.Close();
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            new frmSMMenu().Show();
            this.Hide();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(77, 74, 82);

        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
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
            validateBox(cKiloBox, kiloErrorIcon, kiloBoxValid);
        }

        private void cPriceBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(cPriceBox, carPriceErrorIcon, priceValidBox);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
