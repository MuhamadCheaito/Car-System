
namespace KassemCars
{
    partial class frmAddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSupplier));
            this.contactBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.suppLocationBoxValid = new System.Windows.Forms.PictureBox();
            this.suppContactBoxValid = new System.Windows.Forms.PictureBox();
            this.suppNameBoxValid = new System.Windows.Forms.PictureBox();
            this.suppLocationErrorIcon = new System.Windows.Forms.PictureBox();
            this.suppContactErrorIcon = new System.Windows.Forms.PictureBox();
            this.suppNameErrorIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppLocationBoxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppContactBoxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppNameBoxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppLocationErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppContactErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppNameErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // contactBox
            // 
            this.contactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactBox.Location = new System.Drawing.Point(346, 123);
            this.contactBox.MaxLength = 100;
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(300, 28);
            this.contactBox.TabIndex = 93;
            this.contactBox.TextChanged += new System.EventHandler(this.contactBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(30, 123);
            this.nameBox.MaxLength = 100;
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 28);
            this.nameBox.TabIndex = 92;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 95;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 94;
            this.label2.Text = "Name";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(223, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 62);
            this.label8.TabIndex = 40;
            this.label8.Text = "Supplier Information";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 79);
            this.panel1.TabIndex = 98;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(87, 79);
            this.backBtn.TabIndex = 41;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(612, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(160, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // locationBox
            // 
            this.locationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.Location = new System.Drawing.Point(30, 218);
            this.locationBox.MaxLength = 100;
            this.locationBox.Multiline = true;
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(300, 28);
            this.locationBox.TabIndex = 99;
            this.locationBox.TextChanged += new System.EventHandler(this.locationBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 100;
            this.label4.Text = "Location";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(435, 209);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 43);
            this.addBtn.TabIndex = 101;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            this.addBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label18.Location = new System.Drawing.Point(266, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 14);
            this.label18.TabIndex = 104;
            this.label18.Text = "e.g.  USA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label16.Location = new System.Drawing.Point(530, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 14);
            this.label16.TabIndex = 103;
            this.label16.Text = "e.g. +176902010";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label15.Location = new System.Drawing.Point(234, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 14);
            this.label15.TabIndex = 102;
            this.label15.Text = "e.g. Ali Ahmad";
            // 
            // suppLocationBoxValid
            // 
            this.suppLocationBoxValid.BackColor = System.Drawing.Color.Transparent;
            this.suppLocationBoxValid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suppLocationBoxValid.BackgroundImage")));
            this.suppLocationBoxValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.suppLocationBoxValid.Location = new System.Drawing.Point(310, 220);
            this.suppLocationBoxValid.Name = "suppLocationBoxValid";
            this.suppLocationBoxValid.Size = new System.Drawing.Size(18, 23);
            this.suppLocationBoxValid.TabIndex = 135;
            this.suppLocationBoxValid.TabStop = false;
            this.suppLocationBoxValid.Visible = false;
            // 
            // suppContactBoxValid
            // 
            this.suppContactBoxValid.BackColor = System.Drawing.Color.Transparent;
            this.suppContactBoxValid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suppContactBoxValid.BackgroundImage")));
            this.suppContactBoxValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.suppContactBoxValid.Location = new System.Drawing.Point(628, 126);
            this.suppContactBoxValid.Name = "suppContactBoxValid";
            this.suppContactBoxValid.Size = new System.Drawing.Size(18, 23);
            this.suppContactBoxValid.TabIndex = 134;
            this.suppContactBoxValid.TabStop = false;
            this.suppContactBoxValid.Visible = false;
            // 
            // suppNameBoxValid
            // 
            this.suppNameBoxValid.BackColor = System.Drawing.Color.Transparent;
            this.suppNameBoxValid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suppNameBoxValid.BackgroundImage")));
            this.suppNameBoxValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.suppNameBoxValid.Location = new System.Drawing.Point(310, 126);
            this.suppNameBoxValid.Name = "suppNameBoxValid";
            this.suppNameBoxValid.Size = new System.Drawing.Size(18, 23);
            this.suppNameBoxValid.TabIndex = 133;
            this.suppNameBoxValid.TabStop = false;
            this.suppNameBoxValid.Visible = false;
            // 
            // suppLocationErrorIcon
            // 
            this.suppLocationErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.suppLocationErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suppLocationErrorIcon.BackgroundImage")));
            this.suppLocationErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.suppLocationErrorIcon.Location = new System.Drawing.Point(310, 220);
            this.suppLocationErrorIcon.Name = "suppLocationErrorIcon";
            this.suppLocationErrorIcon.Size = new System.Drawing.Size(18, 23);
            this.suppLocationErrorIcon.TabIndex = 107;
            this.suppLocationErrorIcon.TabStop = false;
            // 
            // suppContactErrorIcon
            // 
            this.suppContactErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.suppContactErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suppContactErrorIcon.BackgroundImage")));
            this.suppContactErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.suppContactErrorIcon.Location = new System.Drawing.Point(628, 126);
            this.suppContactErrorIcon.Name = "suppContactErrorIcon";
            this.suppContactErrorIcon.Size = new System.Drawing.Size(18, 23);
            this.suppContactErrorIcon.TabIndex = 106;
            this.suppContactErrorIcon.TabStop = false;
            // 
            // suppNameErrorIcon
            // 
            this.suppNameErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.suppNameErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suppNameErrorIcon.BackgroundImage")));
            this.suppNameErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.suppNameErrorIcon.Location = new System.Drawing.Point(310, 126);
            this.suppNameErrorIcon.Name = "suppNameErrorIcon";
            this.suppNameErrorIcon.Size = new System.Drawing.Size(18, 23);
            this.suppNameErrorIcon.TabIndex = 105;
            this.suppNameErrorIcon.TabStop = false;
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 282);
            this.Controls.Add(this.suppLocationBoxValid);
            this.Controls.Add(this.suppContactBoxValid);
            this.Controls.Add(this.suppNameBoxValid);
            this.Controls.Add(this.suppLocationErrorIcon);
            this.Controls.Add(this.suppContactErrorIcon);
            this.Controls.Add(this.suppNameErrorIcon);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddSupplier";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppLocationBoxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppContactBoxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppNameBoxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppLocationErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppContactErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppNameErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox suppNameErrorIcon;
        private System.Windows.Forms.PictureBox suppContactErrorIcon;
        private System.Windows.Forms.PictureBox suppLocationErrorIcon;
        private System.Windows.Forms.PictureBox suppLocationBoxValid;
        private System.Windows.Forms.PictureBox suppContactBoxValid;
        private System.Windows.Forms.PictureBox suppNameBoxValid;
    }
}