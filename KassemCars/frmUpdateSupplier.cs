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
    public partial class frmUpdateSupplier : Form
    {
        string suppId;
        public frmUpdateSupplier()
        {
            InitializeComponent();
        }
        public frmUpdateSupplier(string id)
        {
            suppId = id;
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RedundantData.con.Open();
                string carAddQuery = @"UPDATE SUPPLIER
                                    SET NAME=@sName,CONTACT=@sContact,LOCATION=@sLocation WHERE SUPPLIER_ID=" + int.Parse(suppId);
                SqlCommand carAddCMD = new SqlCommand(carAddQuery, RedundantData.con);
                carAddCMD.Parameters.AddWithValue("@sName", nameBox.Text);
                carAddCMD.Parameters.AddWithValue("@sContact", contactBox.Text);
                carAddCMD.Parameters.AddWithValue("@sLocation", locationBox.Text);
                carAddCMD.ExecuteNonQuery();
                CustomSuccessBox.Show("Supplier Data Has Been Updated Successfully.");
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

        private void frmUpdateSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewSuppCmd = new SqlCommand("select * from SUPPLIER WHERE SUPPLIER_ID=" + int.Parse(suppId), RedundantData.con);
                SqlDataAdapter viewSuppAdapter = new SqlDataAdapter(viewSuppCmd);
                DataSet suppData = new DataSet();
                viewSuppAdapter.Fill(suppData);
                nameBox.Text = suppData.Tables[0].Rows[0].ItemArray[1].ToString();
                contactBox.Text = suppData.Tables[0].Rows[0].ItemArray[2].ToString();
                locationBox.Text = suppData.Tables[0].Rows[0].ItemArray[3].ToString();
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBuyCar().Show();
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
    }
}
