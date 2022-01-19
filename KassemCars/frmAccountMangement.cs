using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MsExcel = Microsoft.Office.Interop.Excel;

namespace KassemCars
{
    public partial class frmAccountMangement : Form
    {
        decimal exchange;
        public frmAccountMangement()
        {
            InitializeComponent();
        }
        private void loadViewData(SqlCommand cmd)
        {

            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(cmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string suppName = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string carPrice = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string payWithDuty = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string totalRepairs = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);
                string SellPrice = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[6]);
                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = ID;
                pushData.Cells[1].Value = Name;
                pushData.Cells[2].Value = suppName;
                pushData.Cells[3].Value = (carPrice == "") ? "0" : string.Format("{0:#}", Convert.ToDecimal(carPrice));
                pushData.Cells[4].Value = (payWithDuty == "") ? "0" : string.Format("{0:#}", Convert.ToDecimal(payWithDuty));
                pushData.Cells[5].Value = (totalRepairs == "") ? "0" : string.Format("{0:#}", Convert.ToDecimal(totalRepairs));
                pushData.Cells[6].Value = (SellPrice == "") ? "0" : string.Format("{0:#}", Convert.ToDecimal(SellPrice));
                viewCarGrid.Rows.Add(pushData);

            }
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {

            new frmMain().Show();
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
        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.White;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void gridSearchByVIN()
        {
            try
            {

                RedundantData.con.Open();
                if(currBox.SelectedIndex == 0)
                {
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.NAME,s.NAME,c.PRICE,
                                                     ACCOUNT.PayWithDuty,
                                                     ACCOUNT.TotalRepairs,
                                                     c.SELL_PRICE
                                                     from CAR as c
                                                     LEFT JOIN SUPPLIER as s 
                                                     ON s.SUPPLIER_ID = c.Supp_ID
                                                     LEFT JOIN ACCOUNT 
                                                     ON ACCOUNT.CAR_ID = c.VIN_No
                                                     WHERE MONTH(c.SoldDate)={int.Parse(monthBox.Text)}
                                                     AND YEAR(c.SoldDate)={int.Parse(yearBox.Text)}
                                                     AND c.VIN_No like '{searchBox.Text}%'", RedundantData.con);

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
                FillRecords();
            }
        }
        private void displayTotalCars()
        {
            lblTotalCars.Text = viewCarGrid.Rows.Count.ToString();
        }
        private void gridFill()
        {
            try
            {
                RedundantData.con.Open();
                if(currBox.SelectedIndex == 0)
                {
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.NAME,s.NAME,c.PRICE,
                                                     ACCOUNT.PayWithDuty,
                                                     ACCOUNT.TotalRepairs,
                                                     c.SELL_PRICE
                                                     from CAR as c
                                                     LEFT JOIN SUPPLIER as s 
                                                     ON s.SUPPLIER_ID = c.Supp_ID
                                                     LEFT JOIN ACCOUNT 
                                                     ON ACCOUNT.CAR_ID = c.VIN_No
                                                     WHERE MONTH(c.SoldDate)={int.Parse(monthBox.Text)}
                                                     AND YEAR(c.SoldDate)={int.Parse(yearBox.Text)}", RedundantData.con);
                    loadViewData(viewCarCmd);

                }
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                FillRecords();
                displayTotalCars();
            }

        }
        private void FillRecords()
        {
            try
            {
                if (viewCarGrid.SelectedRows.Count != 0)
                {
                    string id = viewCarGrid.SelectedRows[0].Cells[0].Value.ToString();
                    RedundantData.con.Open();
                    SqlCommand totalCostsCmd = new SqlCommand($@"SELECT (a.PayWithDuty+a.TotalRepairs)
                                                            FROM ACCOUNT as a
                                                            WHERE a.CAR_ID='{id}'", RedundantData.con);
                    SqlCommand totalDebtCmd = new SqlCommand($@"SELECT SUM(c.paid_price)-SUM(CAR.PRICE)
                                                           FROM Cost as c
                                                           INNER JOIN CAR ON c.CAR_ID = CAR.VIN_No
                                                           WHERE CAR.VIN_No='{id}'", RedundantData.con);
                    SqlCommand totalProfitCmd = new SqlCommand($@"SELECT CAR.SELL_PRICE-a.PayWithDuty-a.TotalRepairs
                                                           FROM ACCOUNT as a
                                                           INNER JOIN CAR ON a.CAR_ID = CAR.VIN_No
                                                           WHERE CAR.SOLD = 1 AND CAR.VIN_No='{id}'", RedundantData.con);
                    SqlCommand totalProfitByMonthCmd = new SqlCommand($@"SELECT SUM(CAR.SELL_PRICE)-SUM(a.PayWithDuty)-SUM(a.TotalRepairs)
                                                           FROM ACCOUNT as a
                                                           INNER JOIN CAR ON a.CAR_ID = CAR.VIN_No
                                                           WHERE CAR.SOLD = 1
                                                           AND MONTH(CAR.SoldDate)={int.Parse(monthBox.Text)}
                                                           AND YEAR(CAR.SoldDate)={int.Parse(yearBox.Text)}", RedundantData.con);
                    var costResult = totalCostsCmd.ExecuteScalar();
                    int totalCost = (costResult != DBNull.Value) ? Convert.ToInt32(costResult) : 0;
                    var debtResult = totalDebtCmd.ExecuteScalar();
                    int totalDebt = (debtResult != DBNull.Value) ? Convert.ToInt32(debtResult) : 0;
                    var profitResult = totalProfitCmd.ExecuteScalar();
                    int totalProfit = (profitResult != DBNull.Value) ? Convert.ToInt32(profitResult) : 0;
                    var profitByMonth = totalProfitByMonthCmd.ExecuteScalar();
                    int totalProfitsByMonth = (profitByMonth != DBNull.Value) ? Convert.ToInt32(profitByMonth) : 0;
                    amountSpentLbl.Text = totalCost.ToString() + "$";
                    amountRecLbl.Text = totalDebt < 0 ? Convert.ToDecimal(totalDebt).ToString() + "$" : "Not Debts";
                    netAmountLbl.Text = totalProfit != 0 ? totalProfit.ToString() + "$" : "Not Sold Yet";
                    lbltotalProfits.Text = totalProfitsByMonth != 0 ? totalProfitsByMonth + "$" : "0$";
                    if (currBox.Text == "NAIRA(₦)")
                    {
                        amountSpentLbl.Text = (Convert.ToDecimal(totalCost) * exchange).ToString("#.##") + "₦";
                        amountRecLbl.Text = totalDebt < 0 ? (Convert.ToDecimal(totalDebt) * exchange).ToString("#.##") + "₦" : "Not Debts";
                        netAmountLbl.Text = totalProfit != 0 ? (Convert.ToDecimal(totalProfit) * exchange).ToString("#.##") + "₦" : "Not Sold Yet";
                        lbltotalProfits.Text = (Convert.ToDecimal(totalProfitsByMonth) * exchange).ToString("#.##") + "₦";
                    }
                }
                else
                {
                    amountSpentLbl.Text = "?";
                    amountRecLbl.Text = "?";
                    netAmountLbl.Text = "?";
                    lbltotalProfits.Text = "0$";
                    lblTotalCars.Text = "0";
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
        private void frmAccountMangement_Load(object sender, EventArgs e)
        {
            searchByBox.SelectedIndex = 0;
            if (yearBox.Text != "" && monthBox.Text != "")
            {
                gridFill();
                FillRecords();
            }
            int currentYear = DateTime.UtcNow.Year;
            for(int i = 2017; i <= currentYear; i++)
            {
                var item = i;
                yearBox.Items.Add(item);
            }
        }

        private void viewCarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void viewCarGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
              FillRecords();
        }

        private void currBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillRecords();
        }
        private void ExportToExcel()
        {
            if (viewCarGrid.Rows.Count > 0)
            {
                MsExcel.Application excapp = new Microsoft.Office.Interop.Excel.Application();
                excapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < viewCarGrid.Columns.Count + 1; i++)
                {
                    excapp.Cells[1, i] = viewCarGrid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < viewCarGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < viewCarGrid.Columns.Count; j++)
                    {
                        excapp.Cells[i + 2, j + 1] = viewCarGrid.Rows[i].Cells[j].Value.ToString();
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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(searchBox.Text != "")
            {
               switch(searchByBox.Text)
                {
                    case "VIN #":
                        currBox.SelectedIndex = 0;
                        gridSearchByVIN();
                        displayTotalCars();
                        break;
                    case "Car Name":
                        currBox.SelectedIndex = 0;
                        gridSearchByName();
                        displayTotalCars();
                        break;
                }
            }
            else
            {
                gridFill();
                displayTotalCars();
            }
        }

        private void gridSearchByName()
        {
            try
            {

               if(currBox.SelectedIndex == 0)
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.NAME,s.NAME,c.PRICE,
                                                     ACCOUNT.PayWithDuty,
                                                     ACCOUNT.TotalRepairs,
                                                     c.SELL_PRICE
                                                     from CAR as c
                                                     LEFT JOIN SUPPLIER as s 
                                                     ON s.SUPPLIER_ID = c.Supp_ID
                                                     LEFT JOIN ACCOUNT 
                                                     ON ACCOUNT.CAR_ID = c.VIN_No
                                                     WHERE MONTH(c.SoldDate)={int.Parse(monthBox.Text)}
                                                     AND YEAR(c.SoldDate)={int.Parse(yearBox.Text)}
                                                     AND c.NAME like '{searchBox.Text}%'", RedundantData.con);

                    loadViewData(viewCarCmd);
                }
                else
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.NAME,s.NAME,c.PRICE,
                                                     ACCOUNT.PayWithDuty,
                                                     ACCOUNT.TotalRepairs,
                                                     c.SELL_PRICE
                                                     from CAR as c
                                                     LEFT JOIN SUPPLIER as s 
                                                     ON s.SUPPLIER_ID = c.Supp_ID
                                                     LEFT JOIN ACCOUNT 
                                                     ON ACCOUNT.CAR_ID = c.VIN_No
                                                     WHERE MONTH(c.SoldDate)={int.Parse(monthBox.Text)}
                                                     AND YEAR(c.SoldDate)={int.Parse(yearBox.Text)}
                                                     AND c.NAME like '{searchBox.Text}%'", RedundantData.con);

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
                FillRecords();
            }
        }

        private void suppCheckPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new frmCheckAmountsBySupplier().Show();
            this.Hide();
        }

        private void suppCheckPanel_MouseEnter(object sender, EventArgs e)
        {
            suppCheckPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void suppCheckPanel_MouseLeave(object sender, EventArgs e)
        {
            suppCheckPanel.BackColor = Color.Transparent;
        }

        private void searchByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmCheckAmountByMonths().Show();
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Transparent;
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearBox.Text == "")
            {
                searchByBox.Enabled = false;
                searchBox.Enabled = false;
            }
            else
            {
                searchByBox.Enabled = true;
                searchBox.Enabled = true;
                currBox.SelectedIndex = 0;
                gridFill();
            }
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(monthBox.Text == "")
            {
                searchByBox.Enabled = false;
                searchBox.Enabled = false;
            }
            else
            {
                searchByBox.Enabled = true;
                searchBox.Enabled = true;
                currBox.SelectedIndex = 0;
                gridFill();
            }
        }

        private void currBox_TextChanged(object sender, EventArgs e)
        {
            if (currBox.Text == "USD($)")
            {
                if (searchBox.Text != "" && searchByBox.Text == "VIN #")
                {
                    gridSearchByVIN();
                }
                else if (searchBox.Text != "" && searchByBox.Text == "Car Name")
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
                try
                {
                    RedundantData.con.Open();
                    SqlCommand nairaCmd = new SqlCommand("SELECT TOP 1 NIARA_PRICE FROM NAIRA_CUR ORDER BY ID DESC", RedundantData.con);
                    exchange = Convert.ToDecimal(nairaCmd.ExecuteScalar());
                    foreach (DataGridViewRow row in viewCarGrid.Rows)
                    {
                        row.Cells[4].Value = (decimal.Parse(row.Cells[4].Value.ToString()) * exchange).ToString("#.##");
                        row.Cells[5].Value = (decimal.Parse(row.Cells[5].Value.ToString()) * exchange).ToString("#.##");
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
        }
    }
}
