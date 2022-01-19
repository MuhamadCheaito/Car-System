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
    public partial class frmChangeSettings : Form
    {
        public frmChangeSettings()
        {
            InitializeComponent();
            LblVanish();
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            userImage.Image = RedundantData.ReplaceColor((Image)userImage.Image.Clone(), Color.FromArgb(102, 102, 102), Color.White);
            lockImage.Image = RedundantData.ReplaceColor((Image)lockImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (nameBox.Text == "Username")
            {
                nameBox.Text = "";
            }
            namePnl.BorderStyle = BorderStyle.FixedSingle;
            namePnl.BackColor = Color.FromArgb(34, 36, 49);
            nameBox.BackColor = Color.FromArgb(34, 36, 49);
            nameBox.ForeColor = Color.White;
            userImage.BackColor = Color.FromArgb(34, 36, 49);
            lockImage.BackColor = Color.White;
            LblVanish();
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            userImage.Image = RedundantData.ReplaceColor((Image)userImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (nameBox.Text == "")
            {
                nameBox.Text = "Username";
            }
            namePnl.BackColor = Color.White;
            nameBox.BackColor = Color.White;
            nameBox.ForeColor = Color.Black;
            userImage.BackColor = Color.White;

        }
        private void LblVisible()
        {
            pinErrorIcon.Visible = true;
            confirmErrorIcon.Visible = true;
            lockImage.BackColor = Color.Red;
            openLockImage.BackColor = Color.Red;
            CustomMsgBox.Show("Passwords Don't Match", "OK");
        }
        private void LblVanish()
        {
            pinErrorIcon.Visible = false;
            confirmErrorIcon.Visible = false;
        }
        private void pinBox_Enter(object sender, EventArgs e)
        {
            lockImage.Image = RedundantData.ReplaceColor((Image)lockImage.Image.Clone(), Color.Silver, Color.White);
            userImage.Image = RedundantData.ReplaceColor((Image)userImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (pinBox.Text == "Password")
            {
                pinBox.Text = "";
                pinBox.PasswordChar = '*';
            }
            pinPnl.BorderStyle = BorderStyle.FixedSingle;
            pinPnl.BackColor = Color.FromArgb(34, 36, 49);
            pinBox.BackColor = Color.FromArgb(34, 36, 49);
            pinBox.ForeColor = Color.White;
            lockImage.BackColor = Color.FromArgb(34, 36, 49);
            userImage.BackColor = Color.White;
            LblVanish();
        }

        private void pinBox_Leave(object sender, EventArgs e)
        {
            lockImage.Image = RedundantData.ReplaceColor((Image)lockImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));
            if (pinBox.Text == "")
            {
                pinBox.Text = "Password";
                pinBox.PasswordChar = '\0';
            }
            pinPnl.BackColor = Color.White;
            pinBox.BackColor = Color.White;
            pinBox.ForeColor = Color.Black;
            lockImage.BackColor = Color.White;
        }

        private void confirmBox_Enter(object sender, EventArgs e)
        {
            openLockImage.Image = RedundantData.ReplaceColor((Image)openLockImage.Image.Clone(), Color.Silver, Color.White);
            userImage.Image = RedundantData.ReplaceColor((Image)userImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (confirmBox.Text == "Confirm Password")
            {
                confirmBox.Text = "";
                confirmBox.PasswordChar = '*';
            }
            confirmPnl.BorderStyle = BorderStyle.FixedSingle;
            confirmPnl.BackColor = Color.FromArgb(34, 36, 49);
            confirmBox.BackColor = Color.FromArgb(34, 36, 49);
            confirmBox.ForeColor = Color.White;
            openLockImage.BackColor = Color.FromArgb(34, 36, 49);
            userImage.BackColor = Color.White;
            LblVanish();
        }

        private void confirmBox_Leave(object sender, EventArgs e)
        {
            openLockImage.Image = RedundantData.ReplaceColor((Image)openLockImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));
            if (confirmBox.Text == "")
            {
                confirmBox.Text = "Confirm Password";
                confirmBox.PasswordChar = '\0';
            }
            confirmPnl.BackColor = Color.White;
            confirmBox.BackColor = Color.White;
            confirmBox.ForeColor = Color.Black;
            openLockImage.BackColor = Color.White;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if(pinBox.Text != confirmBox.Text)
            {
                openLockImage.Image = RedundantData.ReplaceColor((Image)openLockImage.Image.Clone(), Color.FromArgb(102, 102, 102), Color.White);
                lockImage.Image = RedundantData.ReplaceColor((Image)lockImage.Image.Clone(), Color.FromArgb(102, 102, 102), Color.White);
                LblVisible();
                if (pinBox.Text != "Password")
                    pinBox.Text = "";
                if (confirmBox.Text != "Confirm Password")
                    confirmBox.Text = "";
            }
            else
            {

                try
                {
                    RedundantData.con.Open();
                    string empUpdateQuery = @"UPDATE EMPLOYEE
                                             SET EMPLOYEE_NAME=@name,EMPLOYEE_PASSWORD=@pass WHERE EMPLOYEE_ID=2";
                    SqlCommand empUpdateCMD = new SqlCommand(empUpdateQuery, RedundantData.con);
                    empUpdateCMD.Parameters.AddWithValue("@name", nameBox.Text);
                    empUpdateCMD.Parameters.AddWithValue("@pass", pinBox.Text);
                    empUpdateCMD.ExecuteNonQuery();
                    this.Hide();
                    new frmMain().Show();
                }
                catch(Exception ex)
                {
                    CustomMsgBox.Show(ex.Message, "OK");
                }
                finally
                {
                    CustomSuccessBox.Show("Username & Password changed successfully.");
                    RedundantData.con.Close();
                }
            }
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
    }
}
