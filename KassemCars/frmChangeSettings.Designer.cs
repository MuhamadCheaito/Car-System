
namespace KassemCars
{
    partial class frmChangeSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeSettings));
            this.exitBtn = new System.Windows.Forms.Button();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.confirmErrorIcon = new System.Windows.Forms.PictureBox();
            this.openLockImage = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.namePnl = new System.Windows.Forms.Panel();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.pinPnl = new System.Windows.Forms.Panel();
            this.pinErrorIcon = new System.Windows.Forms.PictureBox();
            this.lockImage = new System.Windows.Forms.PictureBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLockImage)).BeginInit();
            this.namePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.pinPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(408, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 54;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // confirmBox
            // 
            this.confirmBox.BackColor = System.Drawing.Color.White;
            this.confirmBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBox.ForeColor = System.Drawing.Color.Black;
            this.confirmBox.Location = new System.Drawing.Point(58, 11);
            this.confirmBox.Multiline = true;
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(229, 26);
            this.confirmBox.TabIndex = 6;
            this.confirmBox.Text = "Confirm Password";
            this.confirmBox.Enter += new System.EventHandler(this.confirmBox_Enter);
            this.confirmBox.Leave += new System.EventHandler(this.confirmBox_Leave);
            // 
            // confirmPnl
            // 
            this.confirmPnl.BackColor = System.Drawing.Color.White;
            this.confirmPnl.Controls.Add(this.confirmErrorIcon);
            this.confirmPnl.Controls.Add(this.openLockImage);
            this.confirmPnl.Controls.Add(this.confirmBox);
            this.confirmPnl.Location = new System.Drawing.Point(110, 293);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Size = new System.Drawing.Size(290, 48);
            this.confirmPnl.TabIndex = 5;
            // 
            // confirmErrorIcon
            // 
            this.confirmErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.confirmErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmErrorIcon.BackgroundImage")));
            this.confirmErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmErrorIcon.Location = new System.Drawing.Point(263, 10);
            this.confirmErrorIcon.Name = "confirmErrorIcon";
            this.confirmErrorIcon.Size = new System.Drawing.Size(19, 29);
            this.confirmErrorIcon.TabIndex = 42;
            this.confirmErrorIcon.TabStop = false;
            // 
            // openLockImage
            // 
            this.openLockImage.BackColor = System.Drawing.Color.White;
            this.openLockImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openLockImage.Image = global::KassemCars.Properties.Resources._495_4950485_confirm_new_password_comments_confirm_password_icon_png1;
            this.openLockImage.Location = new System.Drawing.Point(0, 0);
            this.openLockImage.Name = "openLockImage";
            this.openLockImage.Size = new System.Drawing.Size(52, 48);
            this.openLockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openLockImage.TabIndex = 24;
            this.openLockImage.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(58, 11);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(229, 26);
            this.nameBox.TabIndex = 2;
            this.nameBox.Text = "Username";
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // namePnl
            // 
            this.namePnl.BackColor = System.Drawing.Color.White;
            this.namePnl.Controls.Add(this.userImage);
            this.namePnl.Controls.Add(this.nameBox);
            this.namePnl.Location = new System.Drawing.Point(110, 137);
            this.namePnl.Name = "namePnl";
            this.namePnl.Size = new System.Drawing.Size(290, 48);
            this.namePnl.TabIndex = 1;
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(0, 0);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(52, 48);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 24;
            this.userImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 32);
            this.label3.TabIndex = 60;
            this.label3.Text = "Edit Username && Password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ebrima", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 51);
            this.label1.TabIndex = 59;
            this.label1.Text = "KASSEM  AUTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.White;
            this.doneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.Black;
            this.doneBtn.Location = new System.Drawing.Point(211, 377);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(89, 40);
            this.doneBtn.TabIndex = 7;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // pinPnl
            // 
            this.pinPnl.BackColor = System.Drawing.Color.White;
            this.pinPnl.Controls.Add(this.pinErrorIcon);
            this.pinPnl.Controls.Add(this.lockImage);
            this.pinPnl.Controls.Add(this.pinBox);
            this.pinPnl.Location = new System.Drawing.Point(110, 213);
            this.pinPnl.Name = "pinPnl";
            this.pinPnl.Size = new System.Drawing.Size(290, 48);
            this.pinPnl.TabIndex = 3;
            // 
            // pinErrorIcon
            // 
            this.pinErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.pinErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinErrorIcon.BackgroundImage")));
            this.pinErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pinErrorIcon.Location = new System.Drawing.Point(263, 10);
            this.pinErrorIcon.Name = "pinErrorIcon";
            this.pinErrorIcon.Size = new System.Drawing.Size(19, 29);
            this.pinErrorIcon.TabIndex = 42;
            this.pinErrorIcon.TabStop = false;
            // 
            // lockImage
            // 
            this.lockImage.BackColor = System.Drawing.Color.White;
            this.lockImage.Image = ((System.Drawing.Image)(resources.GetObject("lockImage.Image")));
            this.lockImage.Location = new System.Drawing.Point(0, 0);
            this.lockImage.Name = "lockImage";
            this.lockImage.Size = new System.Drawing.Size(52, 48);
            this.lockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockImage.TabIndex = 24;
            this.lockImage.TabStop = false;
            // 
            // pinBox
            // 
            this.pinBox.BackColor = System.Drawing.Color.White;
            this.pinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBox.ForeColor = System.Drawing.Color.Black;
            this.pinBox.Location = new System.Drawing.Point(58, 11);
            this.pinBox.Multiline = true;
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(229, 26);
            this.pinBox.TabIndex = 4;
            this.pinBox.Text = "Password";
            this.pinBox.Enter += new System.EventHandler(this.pinBox_Enter);
            this.pinBox.Leave += new System.EventHandler(this.pinBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 60);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // frmChangeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(461, 471);
            this.Controls.Add(this.pinPnl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.confirmPnl);
            this.Controls.Add(this.namePnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangeSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmchangeSettings";
            this.confirmPnl.ResumeLayout(false);
            this.confirmPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLockImage)).EndInit();
            this.namePnl.ResumeLayout(false);
            this.namePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.pinPnl.ResumeLayout(false);
            this.pinPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.PictureBox confirmErrorIcon;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel namePnl;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox openLockImage;
        private System.Windows.Forms.Panel pinPnl;
        private System.Windows.Forms.PictureBox pinErrorIcon;
        private System.Windows.Forms.PictureBox lockImage;
        private System.Windows.Forms.TextBox pinBox;
    }
}