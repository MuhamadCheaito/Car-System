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

namespace KassemCars
{
    public partial class frmConfirmPassword : Form
    {
        public frmConfirmPassword()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                RedundantData.con.Open();
                string empPin;
                empPin = pinBox.Text;

                string logQuery = "select * from employee where EMPLOYEE_PASSWORD = @pin AND EMPLOYEE_ID=2";

                SqlCommand logCmd = new SqlCommand(logQuery, RedundantData.con);
                logCmd.Parameters.AddWithValue("@pin", empPin);

                SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
                DataSet LogSet = new DataSet();
                LogAdpater.Fill(LogSet);

                if ((LogSet.Tables[0].Rows.Count) > 0)
                {
                    new frmChangeSettings().Show();
                    this.Hide();
                }
                else
                {
                    CustomMsgBox.Show("You entered a wrong password", "OK");
                }


            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }
            finally
            {
                RedundantData.con.Close();
                Form f = Application.OpenForms["frmLogin"];
                f.Hide();
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmConfirmPassword_Load(object sender, EventArgs e)
        {
            pinBox.PasswordChar = '*';
        }
    }
}
