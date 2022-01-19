using CSM_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmAddCustomer : Form
    {
        string carID;
        bool nameFlag, cnicFlag, addressFlag, contactFlag;
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private void startChecker()
        {
            if (nameBox.Text == "")
            {
                nameFlag = true;
            }

            if (cnicBox.Text == "")
            {
                cnicFlag = true;
            }
            if (addressBox.Text == "")
            {
                addressFlag = true;
            }

            if (contactBox.Text == "")
            {
                contactFlag = true;
            }
        }
      
        public frmAddCustomer(string id)
        {
            carID = id;
            InitializeComponent();
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
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {

            new frmSellCar(carID).Show();
            this.Hide();
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
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                startChecker();
                string cust_name, cust_cnic, cust_address, cust_contact;
                cust_name = nameBox.Text;
                cust_cnic = cnicBox.Text;
                cust_address = addressBox.Text;
                cust_contact = contactBox.Text;
                if ((nameFlag || cnicFlag || addressFlag || contactFlag) == true)
                {
                    if (nameFlag)
                    {
                        nameBoxErrorIcon.Visible = true;
                        ctNameValidBox.Visible = false;
                    }
                    if (cnicFlag)
                    {
                        cnicBoxErrorIcon.Visible = true;
                        ctCNICBoxValid.Visible = false;
                    }
                    if (addressFlag)
                    {
                        addressBoxErrorIcon.Visible = true;
                        ctAddressBoxValid.Visible = false;
                    }
                    if (contactFlag)
                    {
                        contactBoxErrorIcon.Visible = true;
                        ctAddressBoxValid.Visible = false;
                    }

                    CustomMsgBox.Show("The given input is invalid.\nPlease enter correct information and fill fields to required information.", "OK");
                }
                else
                {
                    RedundantData.con.Open();
                    string customerName = nameBox.Text;
                    string customerContact = contactBox.Text;
                    long customerCNIC = long.Parse(cnicBox.Text);
                    string customerAddress = addressBox.Text;
                    string customerAddQuery = @"INSERT INTO CUSTOMER(CNIC,NAME,CONTACT,ADDRESS)
                                            VALUES(@cCNIC,@cName,@cContact,@cADDRESS)";
                    SqlCommand customerAddCMD = new SqlCommand(customerAddQuery, RedundantData.con);
                    customerAddCMD.Parameters.AddWithValue("@cCNIC", customerCNIC);
                    customerAddCMD.Parameters.AddWithValue("@cName", customerName);
                    customerAddCMD.Parameters.AddWithValue("@cContact", customerContact);
                    customerAddCMD.Parameters.AddWithValue("@cADDRESS", customerAddress);
                    customerAddCMD.ExecuteNonQuery();
                    CustomSuccessBox.Show("Customer Has Been Added Successfully.");
                }

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
            exitBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(nameBox, nameBoxErrorIcon, ctNameValidBox);
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(addressBox, addressBoxErrorIcon, ctAddressBoxValid);
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }
        }

        private void addressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '/')
                   || (e.KeyChar == '#') || (e.KeyChar == ',') || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CustomMsgBox.Show("Input Incorrect.\nPlease Input in the way shown below each text field.", "OK");
                e.Handled = true;
            }

        }

        private void cnicBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void contactBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void cnicBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(cnicBox, cnicBoxErrorIcon, ctCNICBoxValid);
        }

        private void contactBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(contactBox, contactBoxErrorIcon, ctContactValidBox);
        }
    }
}
