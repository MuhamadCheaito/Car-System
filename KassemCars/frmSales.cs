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
using MsExcel = Microsoft.Office.Interop.Excel;

namespace KassemCars
{
    public partial class frmSales : Form
    {
        DataGridViewLinkColumn view = new DataGridViewLinkColumn();
        public frmSales()
        {
            InitializeComponent();
        }
        private void viewCars()
        {

        }
        private void transitDataFill()
        {
            try
            {
                view.Visible = true;
                view.DataPropertyName = "View";
                view.Name = "View";
                view.Text = "view cars";
                view.UseColumnTextForLinkValue = true;
                if(!viewTransitData.Columns.Contains("View"))
                {
                    viewTransitData.Columns.Add(view);
                }
                viewTransitData.DataSource = null;
                RedundantData.con.Open();
                SqlCommand viewTransitCmd = new SqlCommand(@"SELECT t.NAME,t.CONTACT,t.LOCATION,COUNT(shipped.CAR_ID) as 'No. Of Cars',t.ID
                                                            FROM Transit as t
                                                            INNER JOIN Shipped_To as shipped ON t.ID = shipped.Transit_ID
                                                            INNER JOIN CAR ON shipped.CAR_ID = CAR.VIN_No
                                                            WHERE CAR.STATUS='SHIPPED'
                                                            GROUP BY t.ID,t.NAME,t.CONTACT,t.LOCATION", RedundantData.con);

                SqlDataAdapter viewTransitAdapter = new SqlDataAdapter(viewTransitCmd);
                DataSet transitData = new DataSet();
                viewTransitAdapter.Fill(transitData);
                viewTransitData.DataSource = transitData.Tables[0];
                viewTransitData.Columns["ID"].Visible = false;
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
        private void searchForCustomerName()
        {
            try
            {
                if (statusBox.Visible == false)
                {
                    RedundantData.con.Open();
                    SqlCommand viewSalesCmd = new SqlCommand($@"SELECT ct.CNIC,ct.NAME,ct.CONTACT,c.NAME as 'Car Name',c.MODEL,
                                                           ch.Paid_Price as Paid,(ch.Paid_Price - c.SELL_PRICE) as Debt,ct.ID,c.VIN_No
                                                           FROM CUSTOMER_HAS as ch
                                                           INNER JOIN CAR as c ON c.VIN_No = ch.CAR_ID
                                                           INNER JOIN CUSTOMER as ct ON ct.ID = ch.CUSTOMER_ID
                                                           WHERE ct.NAME like '{searchBox.Text}%'", RedundantData.con);

                    SqlDataAdapter viewSalesAdapter = new SqlDataAdapter(viewSalesCmd);
                    DataSet salesData = new DataSet();
                    viewSalesAdapter.Fill(salesData);
                    viewCarGrid.Rows.Clear();
                    for (int i = 0; i < (salesData.Tables[0].Rows.Count); i++)
                    {
                        string cnic = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[0]);
                        string ctName = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[1]);
                        string ctContact = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[2]);
                        string cName = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[3]);
                        string cModel = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[4]);
                        string ctPaid = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[5]);
                        string ctDebt = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[6]);
                        string ctid = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[7]);
                        string vin = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[8]);
                        DataGridViewRow pushData = new DataGridViewRow();
                        pushData.CreateCells(viewCarGrid);
                        pushData.Cells[0].Value = cnic;
                        pushData.Cells[1].Value = ctName;
                        pushData.Cells[2].Value = ctContact;
                        pushData.Cells[3].Value = cName;
                        pushData.Cells[4].Value = cModel;
                        pushData.Cells[5].Value = string.Format("{0:#}", Convert.ToDecimal(ctPaid));
                        pushData.Cells[6].Value = (ctDebt == "") ? "0" : string.Format("{0:#}", Convert.ToDecimal(ctDebt));
                        pushData.Cells[7].Value = ctid;
                        pushData.Cells[8].Value = vin;
                        viewCarGrid.Rows.Add(pushData);
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
        private void searchByOut()
        {
            try
            {
                if (statusBox.Visible == true)
                {
                    if (searchBox.Text == "")
                    {
                        viewTransitData.DataSource = null;
                        RedundantData.con.Open();
                        SqlCommand viewInOutCmd = new SqlCommand(@"SELECT c.VIN_No as 'VIN #',c.Name,c.STATUS,s.NAME as 'Supplier'
                                                                   FROM CAR as c
                                                                   INNER JOIN SUPPLIER as s 
                                                                   ON s.SUPPLIER_ID = c.Supp_ID
                                                                   WHERE c.STATUS = 'OUT'", RedundantData.con);

                        SqlDataAdapter viewInOutAdapter = new SqlDataAdapter(viewInOutCmd);
                        DataSet inOutData = new DataSet();
                        viewInOutAdapter.Fill(inOutData);
                        viewTransitData.DataSource = inOutData.Tables[0];
                        view.Visible = false;
                    }
                    else
                    {
                        viewTransitData.DataSource = null;
                        RedundantData.con.Open();
                        SqlCommand viewInOutCmd = new SqlCommand($@"SELECT c.VIN_No as 'VIN #',c.Name,c.STATUS,s.NAME as 'Supplier'
                                                           FROM CAR as c
                                                           INNER JOIN SUPPLIER as s 
                                                           ON s.SUPPLIER_ID = c.Supp_ID
                                                           WHERE c.STATUS = 'OUT' AND c.VIN_No like '{searchBox.Text}%'", RedundantData.con);

                        SqlDataAdapter viewInOutAdapter = new SqlDataAdapter(viewInOutCmd);
                        DataSet inOutData = new DataSet();
                        viewInOutAdapter.Fill(inOutData);
                        viewTransitData.DataSource = inOutData.Tables[0];
                        view.Visible = false;
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
        private void searchByIn()
        {
            try
            {
                if (statusBox.Visible == true)
                {
                    if (searchBox.Text == "")
                    {
                        viewTransitData.DataSource = null;
                        RedundantData.con.Open();
                        SqlCommand viewInOutCmd = new SqlCommand(@"SELECT c.VIN_No as 'VIN #',c.Name,c.STATUS,s.NAME as 'Supplier'
                                                                   FROM CAR as c
                                                                   INNER JOIN SUPPLIER as s 
                                                                   ON s.SUPPLIER_ID = c.Supp_ID
                                                                   WHERE c.STATUS = 'IN'", RedundantData.con);

                        SqlDataAdapter viewInOutAdapter = new SqlDataAdapter(viewInOutCmd);
                        DataSet inOutData = new DataSet();
                        viewInOutAdapter.Fill(inOutData);
                        viewTransitData.DataSource = inOutData.Tables[0];
                        view.Visible = false;
                    }
                    else
                    {
                        viewTransitData.DataSource = null;
                        RedundantData.con.Open();
                        SqlCommand viewInOutCmd = new SqlCommand($@"SELECT c.VIN_No as 'VIN #',c.Name,c.STATUS,s.NAME as 'Supplier'
                                                           FROM CAR as c
                                                           INNER JOIN SUPPLIER as s 
                                                           ON s.SUPPLIER_ID = c.Supp_ID
                                                           WHERE c.STATUS = 'IN' AND c.VIN_No like '{searchBox.Text}%'", RedundantData.con);

                        SqlDataAdapter viewInOutAdapter = new SqlDataAdapter(viewInOutCmd);
                        DataSet inOutData = new DataSet();
                        viewInOutAdapter.Fill(inOutData);
                        viewTransitData.DataSource = inOutData.Tables[0];
                        view.Visible = false;
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
        private void inOutDataFill()
        {
            try
            {
                viewTransitData.DataSource = null; 
                RedundantData.con.Open();
                SqlCommand viewInOutCmd = new SqlCommand(@"SELECT c.VIN_No as 'VIN #',c.Name,c.STATUS,s.NAME as 'Supplier'
                                                           FROM CAR as c
                                                           INNER JOIN SUPPLIER as s 
                                                           ON s.SUPPLIER_ID = c.Supp_ID
                                                           WHERE c.STATUS = 'IN' OR c.STATUS = 'OUT'", RedundantData.con);

                SqlDataAdapter viewInOutAdapter = new SqlDataAdapter(viewInOutCmd);
                DataSet inOutData = new DataSet();
                viewInOutAdapter.Fill(inOutData);
                viewTransitData.DataSource = inOutData.Tables[0];
                view.Visible = false;
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
        private void gridFill()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewSalesCmd = new SqlCommand(@"SELECT ct.CNIC,ct.NAME,ct.CONTACT,c.NAME as 'Car Name',c.MODEL,
                                                           ch.Paid_Price as Paid,(ch.Paid_Price - c.SELL_PRICE) as Debt,ct.ID,c.VIN_No
                                                           FROM CUSTOMER_HAS as ch
                                                           INNER JOIN CAR as c ON c.VIN_No = ch.CAR_ID
                                                           INNER JOIN CUSTOMER as ct ON ct.ID = ch.CUSTOMER_ID", RedundantData.con);

                SqlDataAdapter viewSalesAdapter = new SqlDataAdapter(viewSalesCmd);
                DataSet salesData = new DataSet();
                viewSalesAdapter.Fill(salesData);
                viewCarGrid.Rows.Clear();
                for (int i = 0; i < (salesData.Tables[0].Rows.Count); i++)
                {
                    string cnic = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[0]);
                    string ctName = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[1]);
                    string ctContact = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[2]);
                    string cName = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[3]);
                    string cModel = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[4]);
                    string ctPaid = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[5]);
                    string ctDebt = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[6]);
                    string ctid= Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[7]);
                    string vin = Convert.ToString(salesData.Tables[0].Rows[i].ItemArray[8]);
                    DataGridViewRow pushData = new DataGridViewRow();
                    pushData.CreateCells(viewCarGrid);
                    pushData.Cells[0].Value = cnic;
                    pushData.Cells[1].Value = ctName;
                    pushData.Cells[2].Value = ctContact;
                    pushData.Cells[3].Value = cName;
                    pushData.Cells[4].Value = cModel;
                    pushData.Cells[5].Value = string.Format("{0:#}", Convert.ToDecimal(ctPaid));
                    pushData.Cells[6].Value = (ctDebt == "") ? "0" : string.Format("{0:#}", Convert.ToDecimal(ctDebt));
                    pushData.Cells[7].Value = ctid;
                    pushData.Cells[8].Value = vin;
                    viewCarGrid.Rows.Add(pushData);
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

        private void showTotalCarsByStatus(string status="IN")
        {
            lbltotaltext.Visible = true;
            lblTotalCars.Visible = true;
            try
            {
                RedundantData.con.Open();
                SqlCommand viewtotalAvailableCmd = new SqlCommand($@"SELECT COUNT(*) FROM CAR WHERE STATUS='{status}'", RedundantData.con);
                int total = Convert.ToInt32(viewtotalAvailableCmd.ExecuteScalar());
                lblTotalCars.Text = total.ToString();
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
        private void showTotalCars()
        {
            lbltotaltext.Visible = true;
            lblTotalCars.Visible = true;
            try
            {
                RedundantData.con.Open();
                SqlCommand viewtotalAvailableCmd = new SqlCommand($@"SELECT COUNT(*) FROM CAR", RedundantData.con);
                int total = Convert.ToInt32(viewtotalAvailableCmd.ExecuteScalar());
                lblTotalCars.Text = total.ToString();
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
            new frmMain().Show();
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.White;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            gridFill();

        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            transitDataFill();
            viewCarGrid.Visible = false;
            viewTransitData.Visible = true;
            searchBox.Visible = false;
            searchButton.Visible = false;
            statusBox.Visible = false;
            lbltotaltext.Visible = false;
            lblTotalCars.Visible = false;
        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            viewCarGrid.Visible = true;
            viewTransitData.Visible = false;
            searchBox.Visible = true;
            searchButton.Visible = true;
            statusBox.Visible = false;
            lbltotaltext.Visible = false;
            lblTotalCars.Visible = false;
        }

        private void inOutNav_MouseClick(object sender, MouseEventArgs e)
        {
            inOutDataFill();
            viewCarGrid.Visible = false;
            viewTransitData.Visible = true;
            searchBox.Visible = true;
            searchButton.Visible = true;
            statusBox.Visible = true;
            showTotalCars();
        }
        private void ExportToExcel()
        {
            if (viewCarGrid.Visible == true)
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
            else
            {
                if (viewTransitData.Rows.Count > 0)
                {
                    MsExcel.Application excapp = new Microsoft.Office.Interop.Excel.Application();
                    excapp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < viewTransitData.Columns.Count + 1; i++)
                    {
                        excapp.Cells[1, i] = viewTransitData.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < viewTransitData.Rows.Count; i++)
                    {
                        for (int j = 0; j < viewTransitData.Columns.Count; j++)
                        {
                            excapp.Cells[i + 2, j + 1] = viewTransitData.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    excapp.Columns.AutoFit();
                    excapp.Visible = true;
                }
            }
        }
        private void exportToExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToExcel();
        }

        private void viewTransitData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (viewTransitData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "view cars")
                    {
                        string id = viewTransitData.SelectedRows[0].Cells[5].Value.ToString();
                        this.Hide();
                        new frmViewCars(id).Show();
                    }   
            }
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (statusBox.Text)
            {
                case "IN":
                    searchByIn();
                    showTotalCarsByStatus("IN");
                    break;
                case "OUT":
                    searchByOut();
                    showTotalCarsByStatus("OUT");
                    break;
                default:
                    break;
            }
            searchForCustomerName();
        }

        private void viewCarGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                frmUpdatePaid.carID = viewCarGrid.SelectedRows[0].Cells[8].Value.ToString();
                if (frmUpdatePaid.Show() == DialogResult.OK)
                {
                    gridFill();
                }
            }
        }
    }
}
