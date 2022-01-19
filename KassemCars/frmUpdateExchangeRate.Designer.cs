
namespace KassemCars
{
    partial class frmUpdateExchangeRate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateExchangeRate));
            this.label12 = new System.Windows.Forms.Label();
            this.exchangeRateBox = new System.Windows.Forms.TextBox();
            this.rateValidIcon = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rateErrorIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rateValidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F);
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 18);
            this.label12.TabIndex = 192;
            this.label12.Text = "Exchange Rate";
            // 
            // exchangeRateBox
            // 
            this.exchangeRateBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.exchangeRateBox.ForeColor = System.Drawing.Color.Gray;
            this.exchangeRateBox.Location = new System.Drawing.Point(14, 41);
            this.exchangeRateBox.MaxLength = 11;
            this.exchangeRateBox.Multiline = true;
            this.exchangeRateBox.Name = "exchangeRateBox";
            this.exchangeRateBox.Size = new System.Drawing.Size(121, 28);
            this.exchangeRateBox.TabIndex = 193;
            this.exchangeRateBox.TextChanged += new System.EventHandler(this.exchangeRateBox_TextChanged);
            // 
            // rateValidIcon
            // 
            this.rateValidIcon.BackColor = System.Drawing.Color.Transparent;
            this.rateValidIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rateValidIcon.BackgroundImage")));
            this.rateValidIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rateValidIcon.Location = new System.Drawing.Point(114, 43);
            this.rateValidIcon.Name = "rateValidIcon";
            this.rateValidIcon.Size = new System.Drawing.Size(21, 23);
            this.rateValidIcon.TabIndex = 194;
            this.rateValidIcon.TabStop = false;
            this.rateValidIcon.Visible = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(7, 78);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(53, 28);
            this.OkButton.TabIndex = 195;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(66, 78);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 28);
            this.cancelButton.TabIndex = 196;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rateErrorIcon
            // 
            this.rateErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.rateErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rateErrorIcon.BackgroundImage")));
            this.rateErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rateErrorIcon.Location = new System.Drawing.Point(114, 43);
            this.rateErrorIcon.Name = "rateErrorIcon";
            this.rateErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.rateErrorIcon.TabIndex = 197;
            this.rateErrorIcon.TabStop = false;
            // 
            // frmUpdateExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 118);
            this.Controls.Add(this.rateErrorIcon);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.rateValidIcon);
            this.Controls.Add(this.exchangeRateBox);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateExchangeRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateExchangeRate";
            ((System.ComponentModel.ISupportInitialize)(this.rateValidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox rateValidIcon;
        private System.Windows.Forms.TextBox exchangeRateBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox rateErrorIcon;
    }
}