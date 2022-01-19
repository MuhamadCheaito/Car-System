using CSM_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmSMMenu : Form
    {
        decimal exchange;
        string C_VIN = "";
        string C_Status = "";
        string C_SOLD = "";
        public frmSMMenu()
        {
            InitializeComponent();
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sellCarPanel_MouseEnter(object sender, EventArgs e)
        {
            sellCarPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void sellCarPanel_MouseLeave(object sender, EventArgs e)
        {
            sellCarPanel.BackColor = Color.Transparent;
        }

        private void buyCarPanel_MouseEnter(object sender, EventArgs e)
        {
            buyCarPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void buyCarPanel_MouseLeave(object sender, EventArgs e)
        {
            buyCarPanel.BackColor = Color.Transparent;
        }

        private void viewSoldPanel_MouseEnter(object sender, EventArgs e)
        {
            viewSoldPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void viewSoldPanel_MouseLeave(object sender, EventArgs e)
        {
            viewSoldPanel.BackColor = Color.Transparent;
        }

        private void viewAvailPanel_MouseEnter(object sender, EventArgs e)
        {
            viewAvailPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void viewAvailPanel_MouseLeave(object sender, EventArgs e)
        {
            viewAvailPanel.BackColor = Color.Transparent;
        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            SellCar();
        }

        private void SellCar()
        {
            if (viewCarGrid.Rows.Count > 0)
            {
                C_SOLD = viewCarGrid.SelectedRows[0].Cells[12].Value.ToString();
                C_VIN = viewCarGrid.SelectedRows[0].Cells[1].Value.ToString();
                C_Status = viewCarGrid.SelectedRows[0].Cells[10].Value.ToString();
            }
                string sold,status;
                sold = C_SOLD;
                status = C_Status;
                if (sold == "" || status == "")
                {
                    CustomMsgBox.Show("No Stock Remaining.\nContact Higher Authority.", "OK");
                }
                else if (status.ToLower() == "out" || status.ToLower() == "shipped")
                {
                    CustomMsgBox.Show("This Car Is Not Available", "OK");
                }
                else if (sold.ToLower() == "no")
                {
                    new frmSellCar(C_VIN).Show();
                    this.Hide();
                }
                else if (sold.ToLower() == "yes")
                {
                    CustomMsgBox.Show("This Car has already been Sold.\nSelect Another.", "OK");
                }
        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            BuyCar();
        }

        private void BuyCar()
        {
            new frmBuyCar().Show();
            this.Hide();
        }
        private void loadViewData(SqlCommand cmd)
        {
            string SoldDate;
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(cmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Vin = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);
                string carColor = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[6]);
                string Kilometers = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[7]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[8]);
                string SellPrice = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[9]);
                string Status = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[10]);
                string purshaseDate = Convert.ToDateTime(carData.Tables[0].Rows[i].ItemArray[12]).ToString("dd-MM-yyyy");
                string Sold = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[11]);
                if(!Convert.IsDBNull(carData.Tables[0].Rows[i].ItemArray[13]))
                    SoldDate = Convert.ToDateTime(carData.Tables[0].Rows[i].ItemArray[13]).ToString("dd-MM-yyyy");
                else
                    SoldDate = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[13]);
                string supplier = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[16]);
                string transitor = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[17]);
                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = ID;
                pushData.Cells[1].Value = Vin;
                pushData.Cells[2].Value = Name;
                pushData.Cells[3].Value = Model;
                pushData.Cells[4].Value = Company;
                pushData.Cells[5].Value = carColor;
                pushData.Cells[5].Style.ForeColor = Color.FromName(carColor);
                pushData.Cells[5].Style.BackColor = (carColor == "") ? Color.White : Color.FromName(carColor);
                pushData.Cells[6].Value = Kilometers;
                pushData.Cells[7].Value = (Price == "") ? 0 : Convert.ToDecimal(Price);
                pushData.Cells[8].Value = (SellPrice == "") ? "0" : string.Format("{0:#}", Convert.ToDecimal(SellPrice));
                pushData.Cells[9].Value = supplier;
                pushData.Cells[10].Value = Status;
                pushData.Cells[11].Value = purshaseDate;
                pushData.Cells[12].Value = (Sold == "False") ? "No" : "Yes";
                pushData.Cells[13].Value = SoldDate;
                pushData.Cells[14].Value = transitor;
                viewCarGrid.Rows.Add(pushData);

            }

        }
        private void gridFill()
        {
            viewCarGrid.SuspendLayout();
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                        INNER JOIN SUPPLIER 
                                                        ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                        LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                        LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID", RedundantData.con);
                loadViewData(viewCarCmd);
            }
            catch (Exception ex)
            {

                CustomMsgBox.Show(ex.Message,"OK");
            }
            finally
            {
                RedundantData.con.Close();
            }
            viewCarGrid.ResumeLayout();
        }
        private void gridFillByID(string vin)
        {
                try
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand($@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                              INNER JOIN SUPPLIER 
                                                              ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                              LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                              LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID
                                                              where VIN_No like '{vin}%'", RedundantData.con);
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
        private void gridFillByName(string name)
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                        INNER JOIN SUPPLIER 
                                                        ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                        LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                        LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID where CAR.Name like '" + name + "%'", RedundantData.con);
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
        private void gridFillByModel(string model)
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                        INNER JOIN SUPPLIER 
                                                        ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                        LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                        LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID where MODEL like '" + model + "%'", RedundantData.con);
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
        private void gridFillByStatus(string status)
        {
            if (searchBox.Text != "" && searchBox.Visible == true)
            {
                try
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                             INNER JOIN SUPPLIER 
                                                             ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                             LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                             LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID where STATUS like '"+status+"%'", RedundantData.con);
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
        }
        private void gridFillBySold(int sold)
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                        INNER JOIN SUPPLIER 
                                                        ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                        LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                        LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID WHERE SOLD=" + sold + " AND STATUS='SOLD'", RedundantData.con);
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
            private void gridFillByNotSoldSold(int sold)
            {
                try
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                             INNER JOIN SUPPLIER 
                                                             ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                             LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                             LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID WHERE SOLD=" + sold + " AND STATUS='IN'", RedundantData.con);
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
            private void gridFillByYear(int year)
        {
            if (year != 0)
            {
                try
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                            INNER JOIN SUPPLIER 
                                                            ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                            LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                            LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID WHERE YEAR(PurchaseDate) = " + year, RedundantData.con);
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
        }
        private void gridFillByMonth(int month,int year)
        {
            if (month != 0 && year != 0)
            {
                try
                {
                    RedundantData.con.Open();
                    SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                            INNER JOIN SUPPLIER 
                                                            ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                            LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                            LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID WHERE MONTH(PurchaseDate)=" + month + " AND YEAR(PurchaseDate) = " + year, RedundantData.con);
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
        }
        private void viewCarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
                {
                    string vin = viewCarGrid.SelectedRows[0].Cells[1].Value.ToString();
                    this.Hide();
                    new frmUpdateCar(vin).Show();
                }
                if (viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Change")
                {
                    string vin = viewCarGrid.SelectedRows[0].Cells[1].Value.ToString();
                    this.Hide();
                    new frmTransitShipment(vin,1).Show();
                }
                if (viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
                {
                    C_VIN = viewCarGrid.SelectedRows[0].Cells[1].Value.ToString();
                  
                    if (CustomQuestionBox.Show("Are You Sure You Wanna Delete This Car?") == DialogResult.Yes)
                    {
                        try
                        {
                            RedundantData.con.Open();
                            string carAddQuery = $@"DELETE FROM Car WHERE VIN_No='{C_VIN}'";
                            SqlCommand carAddCMD = new SqlCommand(carAddQuery, RedundantData.con);
                            carAddCMD.ExecuteNonQuery();
                            viewCarGrid.Rows.RemoveAt(e.RowIndex);
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
                if (viewCarGrid.Rows.Count != 0)
                {
                    if (e.ColumnIndex == 15)
                    {
                        if (viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "ship this car")
                        {
                            if (viewCarGrid.SelectedRows[0].Cells[10].Value.Equals("SHIPPED"))
                            {
                                CustomMsgBox.Show("This car is already shipped", "OK");
                            }
                            else if (viewCarGrid.SelectedRows[0].Cells[11].Value.ToString().ToLower().Equals("yes"))
                            {
                                CustomMsgBox.Show("You can't ship this car it is already sold", "OK");
                            }
                            else
                            {
                                C_VIN = viewCarGrid.SelectedRows[0].Cells[1].Value.ToString();
                                this.Hide();
                                new frmTransitShipment(C_VIN,0).Show();
                            }
                        }

                        if (viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "available?")
                        {
                            if (CustomQuestionBox.Show("Are You Sure This Car Is Now Available?") == DialogResult.Yes)
                            {
                                C_VIN = viewCarGrid.SelectedRows[0].Cells[1].Value.ToString();
                                try
                                {
                                    RedundantData.con.Open();
                                   
                                    string carUpdateQuery = $@"UPDATE CAR SET STATUS = 'IN',SOLD=0,SoldDate=NULL WHERE VIN_No='{C_VIN}'";
                                    SqlCommand carUpdateCMD = new SqlCommand(carUpdateQuery, RedundantData.con);
                                    string sellDeleteQuery = $@"DELETE FROM CUSTOMER_HAS WHERE CAR_ID='{C_VIN}'";
                                    SqlCommand sellDeleteCMD = new SqlCommand(sellDeleteQuery, RedundantData.con);
                                    string accountDeleteQuery = $@"DELETE FROM ACCOUNT WHERE CAR_ID='{C_VIN}'";
                                    SqlCommand accountDeleteCMD = new SqlCommand(accountDeleteQuery, RedundantData.con);
                                    carUpdateCMD.ExecuteNonQuery();
                                    sellDeleteCMD.ExecuteNonQuery();
                                    accountDeleteCMD.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {

                                    CustomMsgBox.Show(ex.Message, "OK");
                                }
                                finally
                                {
                                    RedundantData.con.Close();
                                    gridFill();
                                }
                            }
                        }
                    }
                }

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSMMenu_Load(object sender, EventArgs e)
        {
            gridFill();
            var currentYear = DateTime.UtcNow.Year;
            for (int i = 2017; i <= currentYear; i++)
            {
                var item = i;
                yearBox.Items.Add(item);
            }
        }

        private void viewCarGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewSoldPanel_MouseClick(object sender, MouseEventArgs e)
        {
            gridFillBySold(1);
        }

        private void viewAvailPanel_MouseClick(object sender, MouseEventArgs e)
        {
            gridFillByNotSoldSold(0);
            
        }

        private void gridFillBySupplier(string supplier)
        {
            try
            {
                RedundantData.con.Open();
                SqlCommand viewCarCmd = new SqlCommand(@"select CAR.*,SUPPLIER.NAME,Transit.NAME from CAR 
                                                        INNER JOIN SUPPLIER 
                                                        ON SUPPLIER.SUPPLIER_ID = CAR.Supp_ID
                                                        LEFT JOIN Shipped_To ON Shipped_To.CAR_ID = CAR.VIN_No
                                                        LEFT JOIN Transit ON Shipped_To.Transit_ID = Transit.ID where SUPPLIER.NAME like '" + supplier + "%'", RedundantData.con);
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
        private void cIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchBox.Text == "")
            {
                currBox.SelectedIndex = 0;
                gridFill();
            }
            switch (seachByBox.Text)
            {
                case "VIN #":
                    gridFillByID(searchBox.Text);
                    currBox.SelectedIndex = 0;
                    break;
                case "Name":
                    gridFillByName(searchBox.Text);
                    currBox.SelectedIndex = 0;
                    break;
                case "Model":
                    gridFillByModel(searchBox.Text);
                    currBox.SelectedIndex = 0;
                    break;
                case "Status":
                    gridFillByStatus(searchBox.Text);
                    currBox.SelectedIndex = 0;
                    break;
                case "Year":
                    int year = (yearBox.Text == "") ? 0 : int.Parse(yearBox.Text);
                    gridFillByYear(year);
                    currBox.SelectedIndex = 0;
                    break;
                case "Month":
                    year = (yearBox.Text == "") ? 0 : int.Parse(yearBox.Text);
                    int month = (monthBox.Text == "") ? 0 : int.Parse(monthBox.Text);
                    gridFillByMonth(month, year);
                    currBox.SelectedIndex = 0;
                    break;
                case "Supplier":
                    gridFillBySupplier(searchBox.Text);
                    currBox.SelectedIndex = 0;
                    break;
                default:
                    CustomMsgBox.Show("Please Choose a valid type to search for", "OK");
                    break;
            }
        }
        private void updateStatus(string value)
        {
            try
            {
                int stock_no = int.Parse(viewCarGrid.SelectedRows[0].Cells[0].Value.ToString());
                RedundantData.con.Open();
                string carUpdateQuery = @"UPDATE CAR
                                          SET STATUS='" + value + "' WHERE Stock_No=" + stock_no;
                SqlCommand carStatusCmd = new SqlCommand(carUpdateQuery, RedundantData.con);
                carStatusCmd.ExecuteNonQuery();
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

        private void viewCarGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                switch (row)
                {
                    case "IN":
                        row = viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =  "OUT";
                        deleteTransit(viewCarGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                        updateStatus(row.ToString());
                        viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value = "";
                        break;
                    case "OUT":
                        row = viewCarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "IN";
                        updateStatus(row.ToString());
                        break;
                }
            }
        }

        private void seachByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seachByBox.Text.ToLower() == "year")
            {
                searchBox.Visible = false;
                monthBox.Visible = false;
                yearBox.Visible = true;
            }
            else if (seachByBox.Text.ToLower() == "month")
            {
                searchBox.Visible = false;
                monthBox.Visible = true;
                yearBox.Visible = true;
            }
            else
            {
                searchBox.Visible = true;
                monthBox.Visible = false;
                yearBox.Visible = false;

            }
        }
        private void deleteTransit(string cId)
        {
            try
            {
                RedundantData.con.Open();
                string shipDeleteQuery = $@"DELETE FROM Shipped_TO WHERE CAR_ID='{cId}'";
                SqlCommand shipDeleteCMD = new SqlCommand(shipDeleteQuery, RedundantData.con);
                shipDeleteCMD.ExecuteNonQuery();
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
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void currBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void viewCarGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            foreach (DataGridViewRow row in viewCarGrid.Rows)
            {
                if (row.Cells[4].Value.ToString().ToLower().Trim() == "old")
                {
                    row.Cells[4].Style.ForeColor = Color.Red;
                }
                else if (row.Cells[4].Value.ToString().ToLower().Trim() == "new")
                {
                    row.Cells[4].Style.ForeColor = Color.Green;
                }

                if (row.Cells[10].Value.ToString() == "IN")
                {
                    row.Cells[10].Style.ForeColor = Color.DarkGreen;
                    row.Cells[15].Value = "";
                    row.Cells[18].Value = "Change";
                }
                else if (row.Cells[10].Value.ToString() == "OUT")
                {
                    row.Cells[10].Style.ForeColor = Color.DarkRed;
                    row.Cells[15].Value = "Ship this car";
                    row.Cells[18].Value = "";
                }
                else if (row.Cells[10].Value.ToString() == "SOLD")
                {
                    row.Cells[10].Style.ForeColor = Color.DeepSkyBlue;
                    row.Cells[15].Value = "Available?";
                }
                else
                {
                    row.Cells[10].Style.ForeColor = Color.DarkMagenta;
                    row.Cells[15].Value = "Available?";
                    row.Cells[18].Value = "Change";
                }
            }

        }

        private void currBox_TextChanged(object sender, EventArgs e)
        {
            if (currBox.Text == "USD($)")
            {
                if (seachByBox.Text == "" || searchBox.Text == "")
                    gridFill();
                else if (seachByBox.Text == "VIN #")
                {
                    gridFillByID(searchBox.Text);
                }
                else if (seachByBox.Text == "Name")
                {
                    gridFillByName(searchBox.Text);
                }
                else if (seachByBox.Text == "Model")
                {
                    gridFillByModel(searchBox.Text);
                }
                else if (seachByBox.Text == "Status")
                {
                    gridFillByStatus(searchBox.Text);
                }
                else if (seachByBox.Text == "Year")
                {
                    int year = (yearBox.Text == "") ? 0 : int.Parse(yearBox.Text);
                    gridFillByYear(year);
                }
                else if (seachByBox.Text == "Month")
                {
                    int year = (yearBox.Text == "") ? 0 : int.Parse(yearBox.Text);
                    int month = (monthBox.Text == "") ? 0 : int.Parse(monthBox.Text);
                    gridFillByMonth(month, year);
                }
                else if (seachByBox.Text == "Supplier")
                {
                    gridFillBySupplier(searchBox.Text);
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
                        row.Cells[7].Value = (decimal.Parse(row.Cells[7].Value.ToString()) * exchange).ToString("#.##");
                        row.Cells[8].Value = (decimal.Parse(row.Cells[8].Value.ToString()) * exchange).ToString("#.##");
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
