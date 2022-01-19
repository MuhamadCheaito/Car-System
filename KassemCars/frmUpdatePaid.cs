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
    public partial class frmUpdatePaid : Form
    {
        public static string carID;
        static frmUpdatePaid updatePaid; static DialogResult result = DialogResult.Cancel;
        public frmUpdatePaid()
        {
            InitializeComponent();
        }
        public frmUpdatePaid(string carId)
        {
            carID = carId;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            try
            {
                RedundantData.con.Open();
                string carAddQuery = $@"UPDATE CUSTOMER_HAS
                                       SET Paid_Price=@paid WHERE CAR_ID='{carID}'";
                SqlCommand carAddCMD = new SqlCommand(carAddQuery, RedundantData.con);
                carAddCMD.Parameters.AddWithValue("@paid", Convert.ToDecimal(priceBox.Text));
                carAddCMD.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                updatePaid.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel; updatePaid.Close();
        }
        public static DialogResult Show()
        {
            updatePaid = new frmUpdatePaid();
            updatePaid.ShowDialog();
            return result;
        }
    }
}
