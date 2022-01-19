using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmCheckAmountsBySupplier : Form
    {
        int month, year;
        public frmCheckAmountsBySupplier()
        {
            InitializeComponent();
        }
        private void fillSuppliers()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewSuppCmd = new SqlCommand("select SUPPLIER_ID,NAME from SUPPLIER", RedundantData.con);
                var reader = viewSuppCmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = reader["SUPPLIER_ID"].ToString();
                    item.Text = reader["NAME"].ToString();
                    supplierListView.Items.Add(item);
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
        private void frmCheckAmountsBySupplier_Load(object sender, EventArgs e)
        {
            fillSuppliers();
            if (supplierListView.SelectedItems.Count == 0)
            {
                addButton.Enabled = false;
            }
        }
        private void loadViewData(SqlCommand cmd)
        {
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(cmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewSuppGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string Vin = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[8]);
                string purshaseDate = Convert.ToDateTime(carData.Tables[0].Rows[i].ItemArray[12]).ToString("dd-MM-yyyy");
                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewSuppGrid);
                pushData.Cells[0].Value = Vin;
                pushData.Cells[1].Value = Name;
                pushData.Cells[2].Value = Model;
                pushData.Cells[3].Value = Company;
                pushData.Cells[4].Value = Price;
                pushData.Cells[5].Value = purshaseDate;
                viewSuppGrid.Rows.Add(pushData);
            }
            lblTotalCars.Text = viewSuppGrid.Rows.Count.ToString();

        }
        private void loadAccountDate(SqlCommand cmd)
        {
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(cmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            amountGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string amountId = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string amount = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string passDate = Convert.ToDateTime(carData.Tables[0].Rows[i].ItemArray[2]).ToString("dd-MM-yyyy");
                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(amountGrid);
                pushData.Cells[0].Value = amountId;
                pushData.Cells[1].Value = amount;
                pushData.Cells[2].Value = passDate;
                amountGrid.Rows.Add(pushData);
            }

        }
        private void updateCarsToOld()
        {
            SqlCommand carUpdateCmd = new SqlCommand($@"UPDATE CAR SET 
                                                        CAR.COMPANY='OLD'
                                                        WHERE supp_id={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                        AND MONTH(PurchaseDate)={month} AND YEAR(PurchaseDate)={year}", RedundantData.con);
            carUpdateCmd.ExecuteNonQuery();
        }
        private void updateCarsToNew()
        {
            SqlCommand carUpdateCmd = new SqlCommand($@"UPDATE CAR SET 
                                                        CAR.COMPANY='NEW'
                                                        WHERE supp_id={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                        AND MONTH(PurchaseDate)={month} AND YEAR(PurchaseDate)={year}", RedundantData.con);
            carUpdateCmd.ExecuteNonQuery();
        }
        private void loadData()
        {
            addButton.Enabled = true;
            RedundantData.con.Open();
            SqlCommand viewCarCmd = new SqlCommand($@"select * from CAR 
                                                              WHERE supp_id={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND MONTH(PurchaseDate)={month} AND YEAR(PurchaseDate)={year}", RedundantData.con);
            SqlCommand viewtotalCmd = new SqlCommand($@"select SUM(Price) from CAR 
                                                              WHERE supp_id={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND MONTH(PurchaseDate)={month} AND YEAR(PurchaseDate)={year}", RedundantData.con);
            SqlCommand viewamountCmd = new SqlCommand($@"select SUM(AMOUNT) from SUPPLIER_ACCOUNT
                                                              WHERE SuppId={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND SUPPLIER_ACCOUNT.MONTH={month} AND SUPPLIER_ACCOUNT.YEAR={year}", RedundantData.con);
            SqlCommand viewamountGridCmd = new SqlCommand($@"select Id,AMOUNT,PASSDATE from SUPPLIER_ACCOUNT
                                                              WHERE SuppId={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND SUPPLIER_ACCOUNT.MONTH={month} AND SUPPLIER_ACCOUNT.YEAR={year}", RedundantData.con);
            loadViewData(viewCarCmd);

            int total = (Convert.IsDBNull(viewtotalCmd.ExecuteScalar()) ? 0 : Convert.ToInt32(viewtotalCmd.ExecuteScalar()));
            int amount = (Convert.IsDBNull(viewamountCmd.ExecuteScalar()) ? 0 : Convert.ToInt32(viewamountCmd.ExecuteScalar()));
            lbltotalPay.Text = total + "$";
            lblTotalRecent.Text = amount + "$";
            lblRemain.Text = (total - amount) + "$";
            if (lblRemain.Text != "0$")
            {
                updateCarsToNew();
                lblRemain.ForeColor = Color.Red;
                loadViewData(viewCarCmd);
                addButton.Enabled = true;
            }
            else
            {
                updateCarsToOld();
                lblRemain.ForeColor = Color.Green;
                loadViewData(viewCarCmd);
                addButton.Enabled = false;
            }
            loadAccountDate(viewamountGridCmd);
            if (viewSuppGrid.Rows.Count == 0)
            {
                addButton.Enabled = false;
            }
        }

        private void supplierListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (supplierListView.SelectedItems.Count > 0)
            {
                try
                {
                    if (frmUpdateDate.Show() == DialogResult.OK)
                    {
                        year = frmUpdateDate.year;
                        month = frmUpdateDate.month;
                        loadData();
                        DateTime date = new DateTime(2020, month, 1);
                        lblDate.Text = "Records on "+date.ToString("MMMM") + "-" + year;
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

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmAccountMangement().Show();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (amountBox.Text != "")
                {
                    RedundantData.con.Open();
                    int amount = int.Parse(amountBox.Text);
                    DateTime date = dtpPassDate.Value;
                    int supplierId = int.Parse(supplierListView.SelectedItems[0].Tag + "");
                    string customerAddQuery = @"INSERT INTO SUPPLIER_ACCOUNT(AMOUNT,PASSDATE,MONTH,YEAR,SuppID)
                                            VALUES(@amount,@date,@month,@year,@suppId)";
                    SqlCommand suppAccountAddCmd = new SqlCommand(customerAddQuery, RedundantData.con);
                    suppAccountAddCmd.Parameters.AddWithValue("@amount", amount);
                    suppAccountAddCmd.Parameters.AddWithValue("@date", date);
                    suppAccountAddCmd.Parameters.AddWithValue("@month", month);
                    suppAccountAddCmd.Parameters.AddWithValue("@year", year);
                    suppAccountAddCmd.Parameters.AddWithValue("@suppId", supplierId);
                    suppAccountAddCmd.ExecuteNonQuery();
                    CustomSuccessBox.Show("Amount Has Been Added Successfully.");
                    amountBox.Text = "";
                    if (RedundantData.con.State == ConnectionState.Open)
                    {
                        RedundantData.con.Close();
                        loadData();
                    }
                }
                else
                {
                    CustomMsgBox.Show("Enter A Valid Amount!!", "OK");
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

        private void amountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (amountGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
                {
                    int amountID = int.Parse(amountGrid.SelectedRows[0].Cells[0].Value.ToString());

                    if (CustomQuestionBox.Show("Are You Sure You Wanna Delete This Car?") == DialogResult.Yes)
                    {
                        try
                        {
                            RedundantData.con.Open();
                            string amountDeleteQuery = $@"DELETE FROM SUPPLIER_ACCOUNT WHERE Id='{amountID}'";
                            SqlCommand amountDeleteCmd = new SqlCommand(amountDeleteQuery, RedundantData.con);
                            amountDeleteCmd.ExecuteNonQuery();
                            amountGrid.Rows.RemoveAt(e.RowIndex);
                            if (RedundantData.con.State == ConnectionState.Open)
                            {
                                RedundantData.con.Close();
                                loadData();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewSuppGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in viewSuppGrid.Rows)
            {
                if (row.Cells[3].Value.ToString().ToLower().Trim() == "old")
                {
                    row.Cells[3].Style.ForeColor = Color.Red;
                }
                else if (row.Cells[3].Value.ToString().ToLower().Trim() == "new")
                {
                    row.Cells[3].Style.ForeColor = Color.Green;
                }
            }
        }

        private void supplierListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
