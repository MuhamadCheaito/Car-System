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
    public partial class frmTransitShipment : Form
    {
        string carID;
        int served;
        public frmTransitShipment()
        {
            InitializeComponent();
        }
        public frmTransitShipment(string id,int service)
        {
            carID = id;
            served = service;
            InitializeComponent();
        }
        private void fillTransitLocation()
        {
            try
            {
                if (transitBox.Text != "")
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand("select LOCATION from TRANSIT WHERE ID=" + transitBox.SelectedValue, RedundantData.con);
                    SqlDataReader reader = viewCarCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        transitLocation.Text = reader["LOCATION"].ToString();
                    }
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
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmSMMenu().Show();
        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmAddTransit(carID,served).Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmUpdateTransit(transitBox.SelectedValue.ToString(), served, carID).Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CustomQuestionBox.Show("Are You Sure You Wanna Delete This Transit?") == DialogResult.Yes)
            {
                try
                {
                    RedundantData.con.Open();
                    string suppDeleteQuery = @"DELETE FROM Transit WHERE ID=" + transitBox.SelectedValue;
                    SqlCommand suppDeleteCmd = new SqlCommand(suppDeleteQuery, RedundantData.con);
                    suppDeleteCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    CustomMsgBox.Show(ex.Message, "OK");
                }
                finally
                {
                    transitBox.Text = "";
                    RedundantData.con.Close();
                }
                fillTransitors();
                fillTransitLocation();
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

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        
        private void shipBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (transitBox.Text != "" && served == 0)
                {
                    RedundantData.con.Open();
                    int transitID = (int)transitBox.SelectedValue;
                    string transitAddQuery = @"INSERT INTO Shipped_To(CAR_ID,Transit_ID,ShipDate)
                                            VALUES(@CARID,@TransitID,@ShipDate)";
                    SqlCommand transitAddCMD = new SqlCommand(transitAddQuery, RedundantData.con);
                    transitAddCMD.Parameters.AddWithValue("@CARID", carID);
                    transitAddCMD.Parameters.AddWithValue("@TransitID", transitID);
                    transitAddCMD.Parameters.AddWithValue("@ShipDate", dtpShipDate.Value);
                    string shipStatusQuery = @"UPDATE CAR
                                            SET STATUS = 'SHIPPED' WHERE VIN_No=@CARID";
                    SqlCommand shipStatusCmd = new SqlCommand(shipStatusQuery, RedundantData.con);
                    shipStatusCmd.Parameters.AddWithValue("@CARID", carID);
                    transitAddCMD.ExecuteNonQuery();
                    shipStatusCmd.ExecuteNonQuery();
                    CustomSuccessBox.Show("This car has been successfully shipped to " + transitLocation.Text);
                }
                else if(transitBox.Text != "" && served == 1)
                {
                    RedundantData.con.Open();
                    int transitID = (int)transitBox.SelectedValue;
                    string transitUpdateQuery = $@"UPDATE Shipped_To SET
                                                CAR_ID=@CARID,Transit_ID=@TransitID
                                                WHERE CAR_ID='{carID}'";
                    SqlCommand transitUpdateCMD = new SqlCommand(transitUpdateQuery, RedundantData.con);
                    transitUpdateCMD.Parameters.AddWithValue("@CARID", carID);
                    transitUpdateCMD.Parameters.AddWithValue("@TransitID", transitID);
                    transitUpdateCMD.ExecuteNonQuery();
                    CustomSuccessBox.Show("Transitor Has Been Changed Successfully.");
                }
                else
                {
                    CustomMsgBox.Show("Please Fill In The Transit Data.","OK");
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
                new frmSMMenu().Show();
            }
        }
        private void fillTransitors()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewTransitCmd = new SqlCommand("select ID,NAME,LOCATION from TRANSIT", RedundantData.con);
                SqlDataAdapter viewTransitAdapter = new SqlDataAdapter(viewTransitCmd);
                DataSet transitData = new DataSet();
                viewTransitAdapter.Fill(transitData, "TRANSIT");
                transitBox.DisplayMember = "NAME";
                transitBox.ValueMember = "ID";
                transitBox.DataSource = transitData.Tables["TRANSIT"];
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
        private void fillCarInfo()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand($"select VIN_No,NAME,MODEL,COMPANY from CAR WHERE VIN_No='{carID}'", RedundantData.con);
                SqlDataReader reader = viewCarCmd.ExecuteReader();
                while (reader.Read())
                {
                    lblVin.Text = reader["VIN_No"].ToString();
                    lblname.Text = reader["NAME"].ToString();
                    lblModel.Text = reader["MODEL"].ToString();
                    lblCompany.Text = reader["COMPANY"].ToString();
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
        private void frmTransitShipment_Load(object sender, EventArgs e)
        {
            if(served == 1)
            {
                lblShip.Visible = false;
                dtpShipDate.Visible = false;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
            }
            else
            {
                lblShip.Visible = true;
                dtpShipDate.Visible = true;
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
            }
            fillTransitors();
            fillCarInfo();
            fillTransitLocation();
        }

        private void transitBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RedundantData.con.State == ConnectionState.Open)
            {
                RedundantData.con.Close();
            }
            fillTransitLocation();
        }
    }
}
