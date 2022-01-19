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
    public partial class frmAddTransit : Form
    {
        string carID;
        int served;
        bool nameFlag, contactFlag, locationFlag;
        public frmAddTransit()
        {
            InitializeComponent();
        }
        private void startChecker()
        {
            if (nameBox.Text == "")
            {
                nameFlag = true;
            }

            if (contactBox.Text == "")
            {
                contactFlag = true;
            }
            if (locationBox.Text == "")
            {
                locationFlag = true;
            }
        }
        public frmAddTransit(string id,int service)
        {
            carID = id;
            served = service;
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
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                startChecker();
                string trans_name, trans_contact, trans_location;
                trans_name = nameBox.Text;
                trans_contact = contactBox.Text;
                trans_location = locationBox.Text;
                if ((nameFlag || contactFlag || locationFlag) == true)
                {
                    if (nameFlag)
                    {
                        transitNameErrorIcon.Visible = true;
                        transitNameBoxValid.Visible = false;
                    }
                    if (contactFlag)
                    {
                        transitContactErrorIcon.Visible = true;
                        transitContactBoxValid.Visible = false;
                    }
                    if (locationFlag)
                    {
                        transitLocationErrorIcon.Visible = true;
                        transitLocationBoxValid.Visible = false;
                    }
                }
                else
                {
                    RedundantData.con.Open();
                    string transitName = nameBox.Text;
                    string transitContact = contactBox.Text;
                    string transitLocation = locationBox.Text;
                    string transitAddQuery = @"INSERT INTO TRANSIT(NAME,CONTACT,LOCATION)
                                            VALUES(@tName,@tContact,@tLocation)";
                    SqlCommand transitAddCMD = new SqlCommand(transitAddQuery, RedundantData.con);
                    transitAddCMD.Parameters.AddWithValue("@tName", transitName);
                    transitAddCMD.Parameters.AddWithValue("@tContact", transitContact);
                    transitAddCMD.Parameters.AddWithValue("@tLocation", transitLocation);
                    transitAddCMD.ExecuteNonQuery();
                    CustomSuccessBox.Show("Transit Has Been Added Successfully.");
                }
            }
            catch (Exception ex)
            {

                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                this.Hide();
                new frmTransitShipment(carID, served).Show();
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(nameBox, transitNameErrorIcon, transitNameBoxValid);
        }

        private void contactBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(contactBox, transitContactErrorIcon, transitContactBoxValid);
        }

        private void locationBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(locationBox, transitLocationErrorIcon, transitLocationBoxValid);
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmTransitShipment(carID,served).Show();
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
    }
}
