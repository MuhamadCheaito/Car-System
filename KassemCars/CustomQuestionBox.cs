using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassemCars
{
    public partial class CustomQuestionBox : Form
    {
        public CustomQuestionBox()
        {
            InitializeComponent();
        }
        static CustomQuestionBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text)
        {
            MsgBox = new CustomQuestionBox();
            MsgBox.label1.Text = Text;
            MsgBox.ShowDialog();
            return result;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(77, 74, 82);
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(77, 74, 82);
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            result = DialogResult.No; MsgBox.Close();
        }
    }
}
