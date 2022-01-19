using CSM_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class frmUpdateDate : Form
    {
        public static int year, month;
        public frmUpdateDate()
        {
            InitializeComponent();
        }
        static frmUpdateDate updateDate; static DialogResult result = DialogResult.Cancel;
        private void frmUpdateDate_Load(object sender, EventArgs e)
        {
            var currentYear = DateTime.UtcNow.Year;
            for (int i = 2017; i <= currentYear; i++)
            {
                var item = i;
                yearBox.Items.Add(item);
            }
        }
        public static DialogResult Show()
        {
            updateDate = new frmUpdateDate();
            updateDate.ShowDialog();
            return result;
        }

        private void OkButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(yearBox.Text != "" && monthBox.Text != "")
            {
                result = DialogResult.OK;
                year = int.Parse(yearBox.Text);
                month = int.Parse(monthBox.Text);
                updateDate.Close();
            }
            else
            {
                CustomMsgBox.Show("Enter a valid date", "OK");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel; updateDate.Close();
        }
    }
}
