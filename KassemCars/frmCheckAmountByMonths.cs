using CSM_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmCheckAmountByMonths : Form
    {
        public frmCheckAmountByMonths()
        {
            InitializeComponent();
        }
        private void fillYears(ComboBox box1, ComboBox box2)
        {
            var currentYear = DateTime.UtcNow.Year;
            for (int i = 2017; i <= currentYear; i++)
            {
                var item = i;
                box1.Items.Add(item);
                box2.Items.Add(item);
            }

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

        private void frmCheckAmountByMonthcs_Load(object sender, EventArgs e)
        {
            fillSuppliers();
            fillYears(fromYearBox,toYearBox);
        }

        private void viewButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (fromYearBox.Text == "" || toYearBox.Text == "" || fromMonthBox.Text == "" || toMonthBox.Text == "")
            {
            }
            else if (int.Parse(fromYearBox.Text) > int.Parse(toYearBox.Text))
            {
                CustomMsgBox.Show("Enter Valid Years!!", "OK");
            }
            else if (int.Parse(fromYearBox.Text) == int.Parse(toYearBox.Text) && int.Parse(fromMonthBox.Text) > int.Parse(toMonthBox.Text))
            {
                CustomMsgBox.Show("Enter Valid Months!!", "OK");
            }
            else if (supplierListView.SelectedItems.Count == 0)
            {
                CustomMsgBox.Show("Select A Supplier Please!!", "OK");
            }
            else
            {
                gridFillByToMonthYear();
            }
            if (lblRemain.Text != "0$")
            {
                lblRemain.ForeColor = Color.Red;
            }
            else
            {
                lblRemain.ForeColor = Color.Green;
            }
        }
        private void gridFillByToMonthYear()
        {
            RedundantData.con.Open();
            SqlCommand viewCarCmd = new SqlCommand($@"select * from CAR 
                                                              WHERE supp_id={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND (Month(PurchaseDate) >= {int.Parse(fromMonthBox.Text)}
                                                              AND Year(PurchaseDate) >= {int.Parse(fromMonthBox.Text)})
                                                              AND (Month(PurchaseDate) <= {int.Parse(toMonthBox.Text)}
                                                              AND Year(PurchaseDate) <= {int.Parse(toYearBox.Text)})", RedundantData.con);

            SqlCommand viewtotalCmd = new SqlCommand($@"select SUM(Price) from CAR 
                                                              WHERE supp_id={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND (Month(PurchaseDate) >= {int.Parse(fromMonthBox.Text)}
                                                              AND Year(PurchaseDate) >= {int.Parse(fromMonthBox.Text)})
                                                              AND (Month(PurchaseDate) <= {int.Parse(toMonthBox.Text)}
                                                              AND Year(PurchaseDate) <= {int.Parse(toYearBox.Text)})", RedundantData.con);

            SqlCommand viewamountCmd = new SqlCommand($@"select SUM(AMOUNT) from SUPPLIER_ACCOUNT
                                                              WHERE SuppId={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND (SUPPLIER_ACCOUNT.MONTH >= {int.Parse(fromMonthBox.Text)}
                                                              AND SUPPLIER_ACCOUNT.YEAR >= {int.Parse(fromMonthBox.Text)})
                                                              AND (SUPPLIER_ACCOUNT.MONTH <= {int.Parse(toMonthBox.Text)}
                                                              AND SUPPLIER_ACCOUNT.YEAR <= {int.Parse(toYearBox.Text)})", RedundantData.con);

            SqlCommand viewamountGridCmd = new SqlCommand($@"select Id,AMOUNT,PASSDATE from SUPPLIER_ACCOUNT
                                                              WHERE SuppId={int.Parse(supplierListView.SelectedItems[0].Tag + "")}
                                                              AND (SUPPLIER_ACCOUNT.MONTH >= {int.Parse(fromMonthBox.Text)}
                                                              AND SUPPLIER_ACCOUNT.YEAR >= {int.Parse(fromMonthBox.Text)})
                                                              AND (SUPPLIER_ACCOUNT.MONTH <= {int.Parse(toMonthBox.Text)}
                                                              AND SUPPLIER_ACCOUNT.YEAR <= {int.Parse(toYearBox.Text)})", RedundantData.con);
            loadViewData(viewCarCmd);

            int total = (Convert.IsDBNull(viewtotalCmd.ExecuteScalar()) ? 0 : Convert.ToInt32(viewtotalCmd.ExecuteScalar()));
            int amount = (Convert.IsDBNull(viewamountCmd.ExecuteScalar()) ? 0 : Convert.ToInt32(viewamountCmd.ExecuteScalar()));
            lbltotalPay.Text = total + "$";
            lblTotalRecent.Text = amount + "$";
            lblRemain.Text = (total - amount) + "$";
            loadViewData(viewCarCmd);
            RedundantData.con.Close();
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

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new frmAccountMangement().Show();
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
    }
}
