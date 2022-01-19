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
using MsExcel = Microsoft.Office.Interop.Excel;

namespace KassemCars
{
    public partial class frmViewCars : Form
    {
        string transit_id;
        public frmViewCars()
        {
            InitializeComponent();
        }
        public frmViewCars(string id)
        {
            transit_id = id;
            InitializeComponent();
        }
        private void loadViewData(SqlCommand cmd)
        {
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(cmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);
            string shippedDate;
            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string vin = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string shippedBy = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                if(!Convert.IsDBNull(carData.Tables[0].Rows[i].ItemArray[5]))
                 shippedDate = Convert.ToDateTime(carData.Tables[0].Rows[i].ItemArray[5]).ToString("dd-MM-yyyy");
                else
                    shippedDate = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);
                string supplier = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[6]);
                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = vin;
                pushData.Cells[1].Value = Name;
                pushData.Cells[2].Value = Model;
                pushData.Cells[3].Value = Company;
                pushData.Cells[4].Value = shippedBy;
                pushData.Cells[5].Value = shippedDate;
                pushData.Cells[6].Value = supplier;
                viewCarGrid.Rows.Add(pushData);
            }

        }
        private void gridFillByToMonthYear()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.Name,c.Model,c.Company,t.NAME,Shipped_To.ShipDate,s.NAME
                                                         from CAR as c INNER JOIN Shipped_To ON c.VIN_No = Shipped_To.CAR_ID
                                                         INNER JOIN Transit as t ON Shipped_To.Transit_ID = t.ID
                                                         INNER JOIN SUPPLIER as s 
                                                         ON s.SUPPLIER_ID = c.Supp_ID
                                                         WHERE t.ID={int.Parse(transit_id)} 
                                                         AND c.STATUS='SHIPPED'
                                                         AND (Month(Shipped_To.ShipDate) >= {int.Parse(fromMonthBox.Text)}
                                                         AND Year(Shipped_To.ShipDate) >= {int.Parse(fromMonthBox.Text)})
                                                         AND (Month(Shipped_To.ShipDate) <= {int.Parse(toMonthBox.Text)}
                                                         AND Year(Shipped_To.ShipDate) <= {int.Parse(toYearBox.Text)})", RedundantData.con);
                loadViewData(viewCarCmd);
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
        private void gridFillByFromMonthYear()
        {

        }
        private void gridFill()
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand($@"select c.VIN_No,c.Name,c.Model,c.Company,t.NAME,Shipped_To.ShipDate,s.NAME
                                                         from CAR as c INNER JOIN Shipped_To ON c.VIN_No = Shipped_To.CAR_ID
                                                         INNER JOIN Transit as t ON Shipped_To.Transit_ID = t.ID
                                                         INNER JOIN SUPPLIER as s 
                                                         ON s.SUPPLIER_ID = c.Supp_ID
                                                         WHERE t.ID={int.Parse(transit_id)}
                                                         AND c.STATUS='SHIPPED'", RedundantData.con);
                loadViewData(viewCarCmd);
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
            new frmSales().Show();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
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
        private void frmViewCars_Load(object sender, EventArgs e)
        {
            gridFill();
            fillYears(toYearBox, fromYearBox);
        }

        private void exportToExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToExcel();
        }

        private void fromMonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillYears(ComboBox box1,ComboBox box2)
        {
            var currentYear = DateTime.UtcNow.Year;
            for (int i = 2017; i <= currentYear; i++)
            {
                var item = i;
                box1.Items.Add(item);
                box2.Items.Add(item);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(fromYearBox.Text == "" || toYearBox.Text == "" || fromMonthBox.Text == "" || toMonthBox.Text == "")
            {
                gridFill();
            }
            else if (int.Parse(fromYearBox.Text) > int.Parse(toYearBox.Text))
            {
                gridFill();
                CustomMsgBox.Show("Enter Valid Years!!", "OK");
            }
            else if(int.Parse(fromYearBox.Text) == int.Parse(toYearBox.Text) && int.Parse(fromMonthBox.Text) > int.Parse(toMonthBox.Text))
            {
                gridFill();
                CustomMsgBox.Show("Enter Valid Months!!", "OK");
            }
            else
            {
                gridFillByToMonthYear();
            }
        }
    }
}
