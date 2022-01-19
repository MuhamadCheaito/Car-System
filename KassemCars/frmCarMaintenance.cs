using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmCarMaintenance : Form
    {
        int main_id, occurencies;
        public frmCarMaintenance()
        {
            InitializeComponent();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdNoLight_CheckedChanged(object sender, EventArgs e)
        {
            var lightTexts = grpLight.Controls.OfType<TextBox>().ToList();
            foreach (var text in lightTexts)
            {
                if (rdNoLight.Checked)
                {
                    text.Enabled = false;
                    text.Text = "";
                }
                else
                    text.Enabled = true;
            }
        }

        private void rdNoTier_CheckedChanged(object sender, EventArgs e)
        {
            var tierTexts = grpTier.Controls.OfType<TextBox>().ToList();

            foreach (var text in tierTexts)
            {
                if (rdNoTier.Checked)
                {
                    text.Enabled = false;
                    text.Text = "";
                }
                else
                    text.Enabled = true;
            }
        }

        private void rdNoEngine_CheckedChanged(object sender, EventArgs e)
        {
            var engineTexts = grpEngine.Controls.OfType<TextBox>().ToList();
            foreach (var text in engineTexts)
            {
                if (rdNoEngine.Checked)
                {
                    text.Enabled = false;
                    text.Text = "";
                }
                else
                    text.Enabled = true;
            }
        }

        private void rdNoBattery_CheckedChanged(object sender, EventArgs e)
        {
            var batteryTexts = grpBattery.Controls.OfType<TextBox>().ToList();
            foreach (var text in batteryTexts)
            {
                if (rdNoBattery.Checked)
                {
                    text.Enabled = false;
                    text.Text = "";
                }
                else
                    text.Enabled = true;
            }
        }

        private void rdNoSpray_CheckedChanged(object sender, EventArgs e)
        {
            var sparyTexts = grpSpray.Controls.OfType<TextBox>().ToList();
            foreach (var text in sparyTexts)
            {
                if (rdNoSpray.Checked)
                {
                    text.Enabled = false;
                    text.Text = "";
                }
                else
                    text.Enabled = true;
            }
        }

        private void rdNoFur_CheckedChanged(object sender, EventArgs e)
        {
            var furTexts = grpFur.Controls.OfType<TextBox>().ToList();
            foreach (var text in furTexts)
            {
                if (rdNoFur.Checked)
                {
                    text.Enabled = false;
                    text.Text = "";
                }

                else
                    text.Enabled = true;
            }
        }
        private void fillCarBox()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand(@"select CAR.VIN_No,CAR.NAME from CAR 
                                                         WHERE MONTH(PurchaseDate)="+int.Parse(monthBox.Text)
                                                         + " AND YEAR(PurchaseDate)="+int.Parse(yearBox.Text)
                                                         + " AND CAR.Supp_ID =" + supplierBox.SelectedValue, RedundantData.con);
                SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
                DataSet carData = new DataSet();
                viewCarAdapter.Fill(carData, "CAR");
                carIdBox.DisplayMember = "VIN_No";
                carIdBox.ValueMember = "NAME";
                carIdBox.DataSource = carData.Tables["CAR"];
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
        private void fillComboBox()
        {

            try
            {
                RedundantData.con.Open();
                SqlCommand viewSuppCmd = new SqlCommand("select SUPPLIER_ID,NAME from SUPPLIER", RedundantData.con);
                SqlDataAdapter viewSuppAdapter = new SqlDataAdapter(viewSuppCmd);
                DataSet suppData = new DataSet();
                viewSuppAdapter.Fill(suppData, "SUPPLIER");
                supplierBox.DisplayMember = "NAME";
                supplierBox.ValueMember = "SUPPLIER_ID";
                supplierBox.DataSource = suppData.Tables["SUPPLIER"];
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
        private void fillCarInfo()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand($"select MODEL,PRICE from CAR WHERE VIN_No='{carIdBox.Text}'", RedundantData.con);
                SqlDataReader reader = viewCarCmd.ExecuteReader();
                while (reader.Read())
                {
                    lblModel.Text = reader["MODEL"].ToString();
                    lblCarName.Text = carIdBox.SelectedValue.ToString();
                    lblPrice.Text = reader["Price"].ToString();
                }
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
        private void frmCarMaintenance_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }

        private void carIdBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        private void clearValues()
        {
            paidBox.Text = "";
            dutyBox.Text = "";
            lightPriceBox.Text = "";
            lightDescBox.Text = "";
            sprayPriceBox.Text = "";
            sprayDescBox.Text = "";
            tierDescBox.Text = "";
            tierPriceBox.Text = "";
            batteryPriceBox.Text = "";
            batteryDescBox.Text = "";
            enginePriceBox.Text = "";
            engineDescBox.Text = "";
            furPriceBox.Text = "";
            furDescBox.Text = "";
        }
        private void carIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (RedundantData.con.State == ConnectionState.Open)
                RedundantData.con.Close();
            fillCarInfo();
            DisplayData();
        }
        private void DisplayData() 
        {
            try
            {
                clearValues();
                if(RedundantData.con.State == ConnectionState.Closed)
                {
                    RedundantData.con.Open();
                }
                string readData = $@"SELECT COUNT(CAR_ID) FROM COST WHERE CAR_ID='{carIdBox.Text}'";
                SqlCommand cmd = new SqlCommand(readData, RedundantData.con);
                occurencies = Convert.ToInt32(cmd.ExecuteScalar());
                if(occurencies == 1)
                {
                    addBtn.Text = "Update";
                    string displayDataQuery = $@"SELECT c.custom_fees,c.paid_price,m.LIGHTS,m.LIGHTS_Desc,m.TIERS,m.TIERS_Desc,
                                                m.ENGINE,m.ENGINE_Desc,m.BATTERY,m.BATTERY_Desc,m.SPRAY,m.SPRAY_Desc,
                                                m.FURNISHING,m.FURNISHING_Desc,m.Maintenance_ID
                                                FROM COST as c INNER JOIN MAINTENANCE as m
                                                ON c.maintenance_id = m.Maintenance_ID
                                                WHERE c.CAR_ID='{carIdBox.Text}'";

                    SqlCommand displayCMD = new SqlCommand(displayDataQuery, RedundantData.con);
                    SqlDataAdapter displayAdapter = new SqlDataAdapter(displayCMD);
                    DataSet carData = new DataSet();
                    displayAdapter.Fill(carData);
                    dutyBox.Text = carData.Tables[0].Rows[0].ItemArray[0].ToString();
                    paidBox.Text = carData.Tables[0].Rows[0].ItemArray[1].ToString();
                    lightPriceBox.Text = carData.Tables[0].Rows[0].ItemArray[2].ToString();
                    lightDescBox.Text = carData.Tables[0].Rows[0].ItemArray[3].ToString();
                    tierPriceBox.Text = carData.Tables[0].Rows[0].ItemArray[4].ToString();
                    tierDescBox.Text = carData.Tables[0].Rows[0].ItemArray[5].ToString();
                    enginePriceBox.Text = carData.Tables[0].Rows[0].ItemArray[6].ToString();
                    engineDescBox.Text = carData.Tables[0].Rows[0].ItemArray[7].ToString();
                    batteryPriceBox.Text = carData.Tables[0].Rows[0].ItemArray[8].ToString();
                    batteryDescBox.Text = carData.Tables[0].Rows[0].ItemArray[9].ToString();
                    sprayPriceBox.Text = carData.Tables[0].Rows[0].ItemArray[10].ToString();
                    sprayDescBox.Text = carData.Tables[0].Rows[0].ItemArray[11].ToString();
                    furPriceBox.Text = carData.Tables[0].Rows[0].ItemArray[12].ToString();
                    furDescBox.Text = carData.Tables[0].Rows[0].ItemArray[13].ToString();
                    main_id = int.Parse(carData.Tables[0].Rows[0].ItemArray[14].ToString());
                }
                else
                {
                    addBtn.Text = "Add";
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
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (addBtn.Text.ToLower() == "add")
                {
                    RedundantData.con.Open();
                    string maintainQuery = @"INSERT INTO MAINTENANCE(LIGHTS,LIGHTS_Desc,TIERS,TIERS_Desc,ENGINE,ENGINE_Desc,BATTERY,BATTERY_Desc,SPRAY,SPRAY_Desc,FURNISHING,FURNISHING_Desc) 
                                        Values(@mLights,@mLightDesc,@mTiers,@mTiersDesc,@mEngine,@mEngineDesc,@mBattery,@mBatteryDesc,@mSpray,@mSprayDesc,@mFur,@mFurDesc); SELECT SCOPE_IDENTITY();";
                    string costsQuery = @"INSERT INTO Cost(custom_fees,paid_price,maintenance_id,CAR_ID) 
                                        Values(@cDuty,@cPaid,@cMaintenance_id,@cCarID)";
                    SqlCommand mainAddCMD = new SqlCommand(maintainQuery, RedundantData.con);
                    mainAddCMD.Parameters.AddWithValue("@mLights", (lightPriceBox.Text != "") ? decimal.Parse(lightPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mLightDesc", lightDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mTiers", (tierPriceBox.Text != "") ? decimal.Parse(tierPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mTiersDesc", tierDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mEngine", (enginePriceBox.Text != "") ? decimal.Parse(enginePriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mEngineDesc", engineDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mBattery", (batteryPriceBox.Text != "") ? decimal.Parse(batteryPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mBatteryDesc", batteryDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mSpray", (sprayPriceBox.Text != "") ? decimal.Parse(sprayPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mSprayDesc", sprayDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mFur", (furPriceBox.Text != "") ? decimal.Parse(furPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mFurDesc", furDescBox.Text);
                    int maintenance_id = Convert.ToInt32(mainAddCMD.ExecuteScalar());
                    SqlCommand costAddCMD = new SqlCommand(costsQuery, RedundantData.con);
                    costAddCMD.Parameters.AddWithValue("@cDuty", (dutyBox.Text != "") ? decimal.Parse(dutyBox.Text, NumberStyles.Currency) : 0);
                    costAddCMD.Parameters.AddWithValue("@cPaid", (paidBox.Text != "") ? decimal.Parse(paidBox.Text, NumberStyles.Currency) : 0);
                    costAddCMD.Parameters.AddWithValue("@cMaintenance_id", maintenance_id);
                    costAddCMD.Parameters.AddWithValue("@cCarID", carIdBox.Text);
                    costAddCMD.ExecuteNonQuery();
                    CustomSuccessBox.Show("Data Has Been Entered for " + lblCarName.Text);
                }
                else
                {
                    RedundantData.con.Open();
                    string maintainQuery = $@"UPDATE MAINTENANCE SET
                                        LIGHTS=@mLights,LIGHTS_Desc=@mLightDesc,TIERS=@mTiers,TIERS_Desc=@mTiersDesc,
                                        ENGINE=@mEngine,ENGINE_Desc=@mEngineDesc,BATTERY=@mBattery,BATTERY_Desc=@mBatteryDesc,
                                        SPRAY=@mSpray,SPRAY_Desc=@mSprayDesc,FURNISHING=@mFur,FURNISHING_Desc=@mFurDesc
                                        WHERE Maintenance_ID={main_id}";

                    string costsQuery = $@"UPDATE Cost SET 
                                        custom_fees=@cDuty,paid_price=@cPaid
                                        WHERE CAR_ID='{carIdBox.Text}'";

                    SqlCommand mainAddCMD = new SqlCommand(maintainQuery, RedundantData.con);
                    mainAddCMD.Parameters.AddWithValue("@mLights", (lightPriceBox.Text != "") ? decimal.Parse(lightPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mLightDesc", lightDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mTiers", (tierPriceBox.Text != "") ? decimal.Parse(tierPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mTiersDesc", tierDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mEngine", (enginePriceBox.Text != "") ? decimal.Parse(enginePriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mEngineDesc", engineDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mBattery", (batteryPriceBox.Text != "") ? decimal.Parse(batteryPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mBatteryDesc", batteryDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mSpray", (sprayPriceBox.Text != "") ? decimal.Parse(sprayPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mSprayDesc", sprayDescBox.Text);
                    mainAddCMD.Parameters.AddWithValue("@mFur", (furPriceBox.Text != "") ? decimal.Parse(furPriceBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.Parameters.AddWithValue("@mFurDesc", furDescBox.Text);
                    SqlCommand costUpdateCmd = new SqlCommand(costsQuery, RedundantData.con);
                    costUpdateCmd.Parameters.AddWithValue("@cDuty", (dutyBox.Text != "") ? decimal.Parse(dutyBox.Text, NumberStyles.Currency) : 0);
                    costUpdateCmd.Parameters.AddWithValue("@cPaid", (paidBox.Text != "") ? decimal.Parse(paidBox.Text, NumberStyles.Currency) : 0);
                    mainAddCMD.ExecuteNonQuery();
                    costUpdateCmd.ExecuteNonQuery();
                    CustomSuccessBox.Show("Data Has Been Updated");
                }
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                DisplayData();
            }
        }

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RedundantData.con.State == ConnectionState.Open)
                RedundantData.con.Close();
            if(yearBox.Text != "" && monthBox.Text != "")
            {
                fillCarBox();
                if (carIdBox.Items.Count == 0)
                {
                    lblCarName.Text = "";
                    lblModel.Text = "";
                }
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCarCostsData().Show();
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(monthBox.Text != "" && supplierBox.Text != "")
            {
                fillCarBox();
                if (carIdBox.Items.Count == 0)
                {
                    lblCarName.Text = "";
                    lblModel.Text = "";
                }
            }
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(yearBox.Text != "")
            {
                fillCarBox();
                if (carIdBox.Items.Count == 0)
                {
                    lblCarName.Text = "";
                    lblModel.Text = "";
                }
            }
        }
    }
}
