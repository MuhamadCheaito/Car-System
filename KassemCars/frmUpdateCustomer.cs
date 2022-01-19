using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmUpdateCustomer : Form
    {
        string ctId;
        string carId;
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }
        public frmUpdateCustomer(string car,string id)
        {
            carId = car;
            ctId = id;
            InitializeComponent();
        }
  
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RedundantData.con.Open();
                string ctUpdateQuery = @"UPDATE CUSTOMER
                                        SET CNIC=@cnic,NAME=@ctName,CONTACT=@ctContact,ADDRESS=@ctAddress WHERE ID=" + int.Parse(ctId);
                SqlCommand ctUpdateCMD = new SqlCommand(ctUpdateQuery, RedundantData.con);
                ctUpdateCMD.Parameters.AddWithValue("@cnic", long.Parse(cnicBox.Text));
                ctUpdateCMD.Parameters.AddWithValue("@ctName", nameBox.Text);
                ctUpdateCMD.Parameters.AddWithValue("@ctContact", contactBox.Text);
                ctUpdateCMD.Parameters.AddWithValue("@ctAddress", addressBox.Text);
                ctUpdateCMD.ExecuteNonQuery();
                CustomSuccessBox.Show("Customer Data Has Been Updated Successfully.");
            }
            catch (Exception ex)
            {

                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                this.Hide();
                new frmSellCar(carId).Show();
            }
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            RedundantData.con.Open();
            SqlCommand viewCustomerCmd = new SqlCommand("select * from CUSTOMER WHERE ID=" + int.Parse(ctId), RedundantData.con);
            SqlDataAdapter viewCustomerAdapter = new SqlDataAdapter(viewCustomerCmd);
            DataSet customerData = new DataSet();
            viewCustomerAdapter.Fill(customerData);
            cnicBox.Text = customerData.Tables[0].Rows[0].ItemArray[1].ToString();
            nameBox.Text = customerData.Tables[0].Rows[0].ItemArray[2].ToString();
            contactBox.Text = customerData.Tables[0].Rows[0].ItemArray[3].ToString();
            addressBox.Text = customerData.Tables[0].Rows[0].ItemArray[4].ToString();
            RedundantData.con.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSellCar(carId).Show();
        }
    }
}
