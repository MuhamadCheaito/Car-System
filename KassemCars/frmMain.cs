using CSM_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
            exitBtn.ForeColor = Color.White;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }

        private void empCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            empCtrlPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void empCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            empCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void carCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            carCtrlPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void carCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            carCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void salesCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            salesCtrlPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void salesCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            salesCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void accountCtrlPanel_MouseEnter(object sender, EventArgs e)
        {
            accountCtrlPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void accountCtrlPanel_MouseLeave(object sender, EventArgs e)
        {
            accountCtrlPanel.BackColor = Color.FromArgb(77, 74, 82);
        }

        private void empCtrlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new frmCarMaintenance().Show();
            this.Hide();
        }

        private void carCtrlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new frmSMMenu().Show();
            this.Hide();
        }

        private void salesCtrlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new frmSales().Show();
            this.Hide();
        }

        private void accountCtrlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new frmAccountMangement().Show();
            this.Hide();
        }

        private void nairaExchangeRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(frmUpdateExchangeRate.Show() == DialogResult.OK)
            {
                nairaExchangeRate.Text = frmUpdateExchangeRate.newRate+ " ₦";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if(RedundantData.con.State == ConnectionState.Open)
                {
                    RedundantData.con.Close();
                }
                RedundantData.con.Open();
                SqlCommand nairaCmd = new SqlCommand("SELECT TOP 1 * FROM NAIRA_CUR ORDER BY ID DESC", RedundantData.con);
                SqlDataReader reader = nairaCmd.ExecuteReader();
                while (reader.Read())
                {
                    nairaExchangeRate.Text = decimal.Parse(reader["NIARA_PRICE"].ToString(),NumberStyles.Currency).ToString("#.##") + " ₦";
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
    }
}
