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
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
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

            new frmBuyCar().Show();
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
        private void addBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RedundantData.con.Open();
                string suppName = nameBox.Text;
                string suppContact = contactBox.Text;
                string suppLocation = locationBox.Text;
                string suppAddQuery = @"INSERT INTO SUPPLIER(NAME,CONTACT,LOCATION)
                                    VALUES(@sName,@sContact,@sLocation)";
                SqlCommand suppAddCMD = new SqlCommand(suppAddQuery, RedundantData.con);
                suppAddCMD.Parameters.AddWithValue("@sName", suppName);
                suppAddCMD.Parameters.AddWithValue("@sContact", suppContact);
                suppAddCMD.Parameters.AddWithValue("@sLocation", suppLocation);
                suppAddCMD.ExecuteNonQuery();
                CustomSuccessBox.Show("Supplier Added Successfully");
            }
            catch (Exception ex)
            {

                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                this.Hide();
                new frmBuyCar().Show();
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
            validateBox(nameBox, suppNameErrorIcon, suppNameBoxValid);
        }

        private void contactBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(contactBox, suppContactErrorIcon, suppContactBoxValid);
        }

        private void locationBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(locationBox, suppLocationErrorIcon, suppLocationBoxValid);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
