using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MsExcel = Microsoft.Office.Interop.Excel;

namespace KassemCars
{
    public partial class frmCarCostsData : Form
    {
        decimal exchange;
        public frmCarCostsData()
        {
            InitializeComponent();
        }
        private void loadViewData(SqlCommand cmd)
        {
            SqlDataAdapter viewCostAdapter = new SqlDataAdapter(cmd);
            DataSet costsData = new DataSet();
            viewCostAdapter.Fill(costsData);

            viewCostsGrid.Rows.Clear();
            for (int i = 0; i < (costsData.Tables[0].Rows.Count); i++)
            {
                string vin = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[3]);
                string dutyCosts = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[4]);
                string lights = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[5]);
                string tiers = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[6]);
                string engine = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[7]);
                string battery = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[8]);
                string spray = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[9]);
                string furnish = Convert.ToString(costsData.Tables[0].Rows[i].ItemArray[10]);
                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCostsGrid);
                pushData.Cells[0].Value = vin;
                pushData.Cells[1].Value = Name;
                pushData.Cells[2].Value = Model;
                pushData.Cells[3].Value = Company;
                pushData.Cells[4].Value = string.Format("{0:#0}", Convert.ToDecimal(dutyCosts));
                pushData.Cells[5].Value = string.Format("{0:#0}", Convert.ToDecimal(lights));
                pushData.Cells[6].Value = string.Format("{0:#0}", Convert.ToDecimal(tiers));
                pushData.Cells[7].Value = string.Format("{0:#0}", Convert.ToDecimal(engine));
                pushData.Cells[8].Value = string.Format("{0:#0}", Convert.ToDecimal(battery));
                pushData.Cells[9].Value = string.Format("{0:#0}", Convert.ToDecimal(spray));
                pushData.Cells[10].Value = string.Format("{0:#0}", Convert.ToDecimal(furnish));
                viewCostsGrid.Rows.Add(pushData);

            }

        }
        private void gridFill()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand nairaCmd = new SqlCommand("SELECT TOP 1 NIARA_PRICE FROM NAIRA_CUR ORDER BY ID DESC", RedundantData.con);
                exchange = Convert.ToDecimal(nairaCmd.ExecuteScalar());
                if (currBox.SelectedIndex == 0)
                {
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.Name,c.Model,c.Company,COST.custom_fees / {exchange},
                                                         m.LIGHTS / {exchange},m.TIERS / {exchange},m.ENGINE / {exchange},m.BATTERY / {exchange},
                                                         m.SPRAY / {exchange},m.FURNISHING / {exchange} 
                                                         from CAR as c INNER JOIN COST ON Cost.CAR_ID = c.VIN_No
                                                         INNER JOIN MAINTENANCE as m ON m.Maintenance_ID = Cost.maintenance_id", RedundantData.con);
                    loadViewData(viewCarCmd);
                }
                else
                {
                    SqlCommand viewCarCmd = new SqlCommand(@"select c.VIN_No,c.Name,c.Model,c.Company,COST.custom_fees,
                                                         m.LIGHTS,m.TIERS,m.ENGINE,m.BATTERY,m.SPRAY,m.FURNISHING 
                                                         from CAR as c INNER JOIN COST ON Cost.CAR_ID = c.VIN_No
                                                         INNER JOIN MAINTENANCE as m ON m.Maintenance_ID = Cost.maintenance_id", RedundantData.con);
                    loadViewData(viewCarCmd);
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
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmCarMaintenance().Show();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void frmCarCostsData_Load(object sender, EventArgs e)
        {
            gridFill();
        }

        private void currBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currBox.Text == "USD($)")
            {
                if(searchByBox.Text == "VIN #")
                {
                    gridSearchByVIN();
                }
                else if(searchByBox.Text == "Car Name")
                {
                    gridSearchByName();
                }
                else
                {
                    gridFill();
                }
            }
            else
            {
                if (searchByBox.Text == "VIN #")
                {
                    gridSearchByVIN();
                }
                else if (searchByBox.Text == "Car Name")
                {
                    gridSearchByName();
                }
                else
                {
                    gridFill();
                }

            }
        }
        private void ExportToExcel()
        {
            if (viewCostsGrid.Rows.Count > 0)
            {
                MsExcel.Application excapp = new Microsoft.Office.Interop.Excel.Application();
                excapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < viewCostsGrid.Columns.Count; i++)
                {
                    excapp.Cells[1, i] = viewCostsGrid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < viewCostsGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < viewCostsGrid.Columns.Count - 1; j++)
                    {
                        excapp.Cells[i + 2, j + 1] = viewCostsGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excapp.Columns.AutoFit();
                excapp.Visible = true;
            }
        }
        private void exportToExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToExcel();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchByBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                switch (searchByBox.Text)
                {
                    case "VIN #":
                        gridSearchByVIN();
                        break;
                    case "Car Name":
                        gridSearchByName();
                        break;
                }
            }
            else
            {
                gridFill();
            }
        }
        private void gridSearchByName()
        {
            try
            {
                RedundantData.con.Open();
                if (currBox.SelectedIndex == 0)

                {
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.Name,c.Model,c.Company,COST.custom_fees / {exchange},
                                                         m.LIGHTS / {exchange},m.TIERS / {exchange},m.ENGINE / {exchange},m.BATTERY / {exchange},
                                                         m.SPRAY / {exchange},m.FURNISHING / {exchange} 
                                                         from CAR as c INNER JOIN COST ON Cost.CAR_ID = c.VIN_No
                                                         INNER JOIN MAINTENANCE as m ON m.Maintenance_ID = Cost.maintenance_id
                                                         WHERE c.Name like '{searchBox.Text}%'", RedundantData.con);
                    loadViewData(viewCarCmd);
                }
                else
                {
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.Name,c.Model,c.Company,COST.custom_fees,
                                                         m.LIGHTS,m.TIERS,m.ENGINE,m.BATTERY,m.SPRAY,m.FURNISHING 
                                                         from CAR as c INNER JOIN COST ON Cost.CAR_ID = c.VIN_No
                                                         INNER JOIN MAINTENANCE as m ON m.Maintenance_ID = Cost.maintenance_id
                                                         WHERE c.Name like '{searchBox.Text}%'", RedundantData.con);
                    loadViewData(viewCarCmd);
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
        private void gridSearchByVIN()
        {
            try
            {

                RedundantData.con.Open();
                if (currBox.SelectedIndex == 0)

                {
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.Name,c.Model,c.Company,COST.custom_fees / {exchange},
                                                         m.LIGHTS / {exchange},m.TIERS / {exchange},m.ENGINE / {exchange},m.BATTERY / {exchange},
                                                         m.SPRAY / {exchange},m.FURNISHING / {exchange} 
                                                         from CAR as c INNER JOIN COST ON Cost.CAR_ID = c.VIN_No
                                                         INNER JOIN MAINTENANCE as m ON m.Maintenance_ID = Cost.maintenance_id
                                                         WHERE c.VIN_No like '{searchBox.Text}%'", RedundantData.con);
                    loadViewData(viewCarCmd);
                }
                else
                {
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.Name,c.Model,c.Company,COST.custom_fees,
                                                         m.LIGHTS,m.TIERS,m.ENGINE,m.BATTERY,m.SPRAY,m.FURNISHING 
                                                         from CAR as c INNER JOIN COST ON Cost.CAR_ID = c.VIN_No
                                                         INNER JOIN MAINTENANCE as m ON m.Maintenance_ID = Cost.maintenance_id
                                                         WHERE c.VIN_No like '{searchBox.Text}%'", RedundantData.con);
                    loadViewData(viewCarCmd);
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

        private void viewCostsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (viewCostsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
                {
                    string vin = viewCostsGrid.SelectedRows[0].Cells[0].Value.ToString();

                    if (CustomQuestionBox.Show("Are You Sure You Wanna Delete This Car?") == DialogResult.Yes)
                    {
                        try
                        {
                            RedundantData.con.Open();
                            string maintenanceDeleteQuery = $@"DELETE FROM COST WHERE CAR_ID='{vin}'";
                            SqlCommand maintenanceDeleteCmd = new SqlCommand(maintenanceDeleteQuery, RedundantData.con);
                            maintenanceDeleteCmd.ExecuteNonQuery();
                            viewCostsGrid.Rows.RemoveAt(e.RowIndex);
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
                }
            }
        }
    }
}