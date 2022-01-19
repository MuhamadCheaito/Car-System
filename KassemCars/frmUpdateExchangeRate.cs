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
    public partial class frmUpdateExchangeRate : Form
    {
        public frmUpdateExchangeRate()
        {
            InitializeComponent();
        }
        public static decimal newRate;
        static frmUpdateExchangeRate updateRate; static DialogResult result = DialogResult.Cancel;
        private void validateBox(TextBox text, PictureBox errorIcon, PictureBox validIcon)
        {
            if (text.Text != "")
            {
                validIcon.Visible = true;
                errorIcon.Visible = false;
            }
            else
            {
                validIcon.Visible = false;
                errorIcon.Visible = true;
            }
        }
        public static DialogResult Show()
        {
            updateRate = new frmUpdateExchangeRate();
            updateRate.ShowDialog();
            return result;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel; updateRate.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            try
            {
                RedundantData.con.Open();
                string rateAddQuery = @"INSERT INTO NAIRA_CUR(NIARA_PRICE)
                                            VALUES(@NAIRA)";
                SqlCommand rateAddCMD = new SqlCommand(rateAddQuery, RedundantData.con);
                rateAddCMD.Parameters.AddWithValue("@NAIRA", decimal.Parse(exchangeRateBox.Text,NumberStyles.Currency));
                rateAddCMD.ExecuteNonQuery();
                newRate = decimal.Parse(exchangeRateBox.Text);
            }
            catch (Exception ex)
            {

                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                updateRate.Close();
            }
        }

        private void exchangeRateBox_TextChanged(object sender, EventArgs e)
        {
            validateBox(exchangeRateBox, rateErrorIcon, rateValidIcon);
        }
    }
}
