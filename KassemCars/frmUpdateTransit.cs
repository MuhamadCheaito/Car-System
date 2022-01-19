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
    public partial class frmUpdateTransit : Form
    {
        string transitID;
        int served;
        string carID;
        public frmUpdateTransit()
        {
            InitializeComponent();
        }
        public frmUpdateTransit(string id)
        {
            transitID = id;
            InitializeComponent();
        }
        public frmUpdateTransit(string id,int service,string car)
        {
            transitID = id;
            served = service;
            carID = car;
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
                string carAddQuery = @"UPDATE Transit
                                    SET NAME=@tName,CONTACT=@tContact,LOCATION=@tLocation WHERE ID=" + int.Parse(transitID);
                SqlCommand carAddCMD = new SqlCommand(carAddQuery, RedundantData.con);
                carAddCMD.Parameters.AddWithValue("@tName", nameBox.Text);
                carAddCMD.Parameters.AddWithValue("@tContact", contactBox.Text);
                carAddCMD.Parameters.AddWithValue("@tLocation", locationBox.Text);
                carAddCMD.ExecuteNonQuery();
                CustomSuccessBox.Show("Transit Data Has Been Updated Successfully.");
            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                this.Hide();
                new frmTransitShipment(carID,served).Show();
            }
        }

        private void frmUpdateTransit_Load(object sender, EventArgs e)
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewTransitCmd = new SqlCommand("select * from Transit WHERE ID=" + int.Parse(transitID), RedundantData.con);
                SqlDataAdapter viewTransitAdapter = new SqlDataAdapter(viewTransitCmd);
                DataSet transitData = new DataSet();
                viewTransitAdapter.Fill(transitData);
                nameBox.Text = transitData.Tables[0].Rows[0].ItemArray[1].ToString();
                contactBox.Text = transitData.Tables[0].Rows[0].ItemArray[2].ToString();
                locationBox.Text = transitData.Tables[0].Rows[0].ItemArray[3].ToString();
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

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTransitShipment(carID,served).Show();
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
