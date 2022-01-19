
namespace KassemCars
{
    partial class frmSellCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sellBtn = new System.Windows.Forms.Button();
            this.sellPriceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkAdd = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.customersBox = new System.Windows.Forms.ComboBox();
            this.sellValidIcon = new System.Windows.Forms.PictureBox();
            this.sellErrorIcon = new System.Windows.Forms.PictureBox();
            this.paidValidIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpaidPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSellDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.paidErrorIcon = new System.Windows.Forms.PictureBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellValidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidValidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 79);
            this.panel1.TabIndex = 59;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick_1);
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
            this.exitBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(581, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(61, 79);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sell Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(239, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.sellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellBtn.FlatAppearance.BorderSize = 0;
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.Color.White;
            this.sellBtn.Location = new System.Drawing.Point(276, 421);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(100, 43);
            this.sellBtn.TabIndex = 4;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            this.sellBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sellBtn_MouseClick);
            this.sellBtn.MouseEnter += new System.EventHandler(this.sellBtn_MouseEnter);
            this.sellBtn.MouseLeave += new System.EventHandler(this.sellBtn_MouseLeave);
            // 
            // sellPriceBox
            // 
            this.sellPriceBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.sellPriceBox.ForeColor = System.Drawing.Color.Gray;
            this.sellPriceBox.Location = new System.Drawing.Point(330, 293);
            this.sellPriceBox.MaxLength = 50;
            this.sellPriceBox.Multiline = true;
            this.sellPriceBox.Name = "sellPriceBox";
            this.sellPriceBox.Size = new System.Drawing.Size(300, 28);
            this.sellPriceBox.TabIndex = 2;
            this.sellPriceBox.TextChanged += new System.EventHandler(this.sellPriceBox_TextChanged);
            this.sellPriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sellPriceBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "Sell Price";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label21.Location = new System.Drawing.Point(537, 324);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 14);
            this.label21.TabIndex = 118;
            this.label21.Text = "e.g. 2453000";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(250, 275);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(44, 13);
            this.linkLabel2.TabIndex = 134;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Delete";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(216, 275);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 13);
            this.linkLabel1.TabIndex = 133;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Edit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkAdd
            // 
            this.linkAdd.AutoSize = true;
            this.linkAdd.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.linkAdd.Location = new System.Drawing.Point(130, 275);
            this.linkAdd.Name = "linkAdd";
            this.linkAdd.Size = new System.Drawing.Size(54, 13);
            this.linkAdd.TabIndex = 132;
            this.linkAdd.TabStop = true;
            this.linkAdd.Text = "New (+)";
            this.linkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdd_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 131;
            this.label2.Text = "Customer";
            // 
            // customersBox
            // 
            this.customersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.customersBox.FormattingEnabled = true;
            this.customersBox.Location = new System.Drawing.Point(27, 293);
            this.customersBox.Name = "customersBox";
            this.customersBox.Size = new System.Drawing.Size(267, 31);
            this.customersBox.TabIndex = 1;
            // 
            // sellValidIcon
            // 
            this.sellValidIcon.BackColor = System.Drawing.Color.Transparent;
            this.sellValidIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sellValidIcon.BackgroundImage")));
            this.sellValidIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sellValidIcon.Location = new System.Drawing.Point(606, 295);
            this.sellValidIcon.Name = "sellValidIcon";
            this.sellValidIcon.Size = new System.Drawing.Size(21, 23);
            this.sellValidIcon.TabIndex = 155;
            this.sellValidIcon.TabStop = false;
            this.sellValidIcon.Visible = false;
            // 
            // sellErrorIcon
            // 
            this.sellErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.sellErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sellErrorIcon.BackgroundImage")));
            this.sellErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sellErrorIcon.Location = new System.Drawing.Point(607, 295);
            this.sellErrorIcon.Name = "sellErrorIcon";
            this.sellErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.sellErrorIcon.TabIndex = 70;
            this.sellErrorIcon.TabStop = false;
            // 
            // paidValidIcon
            // 
            this.paidValidIcon.BackColor = System.Drawing.Color.Transparent;
            this.paidValidIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paidValidIcon.BackgroundImage")));
            this.paidValidIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paidValidIcon.Location = new System.Drawing.Point(272, 368);
            this.paidValidIcon.Name = "paidValidIcon";
            this.paidValidIcon.Size = new System.Drawing.Size(21, 23);
            this.paidValidIcon.TabIndex = 159;
            this.paidValidIcon.TabStop = false;
            this.paidValidIcon.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(205, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 158;
            this.label1.Text = "e.g. 2453000";
            // 
            // txtpaidPrice
            // 
            this.txtpaidPrice.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.txtpaidPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtpaidPrice.Location = new System.Drawing.Point(21, 366);
            this.txtpaidPrice.MaxLength = 40;
            this.txtpaidPrice.Multiline = true;
            this.txtpaidPrice.Name = "txtpaidPrice";
            this.txtpaidPrice.Size = new System.Drawing.Size(273, 28);
            this.txtpaidPrice.TabIndex = 3;
            this.txtpaidPrice.TextChanged += new System.EventHandler(this.txtpaidPrice_TextChanged);
            this.txtpaidPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaidPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 25);
            this.label3.TabIndex = 157;
            this.label3.Text = "Price Paid By Customer";
            // 
            // dtpSellDate
            // 
            this.dtpSellDate.CustomFormat = "dd-MM-yyyy";
            this.dtpSellDate.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpSellDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSellDate.Location = new System.Drawing.Point(332, 368);
            this.dtpSellDate.Name = "dtpSellDate";
            this.dtpSellDate.ShowUpDown = true;
            this.dtpSellDate.Size = new System.Drawing.Size(298, 27);
            this.dtpSellDate.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 160;
            this.label4.Text = "Sell Date";
            // 
            // paidErrorIcon
            // 
            this.paidErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.paidErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paidErrorIcon.BackgroundImage")));
            this.paidErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paidErrorIcon.Location = new System.Drawing.Point(272, 368);
            this.paidErrorIcon.Name = "paidErrorIcon";
            this.paidErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.paidErrorIcon.TabIndex = 162;
            this.paidErrorIcon.TabStop = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCompany.Location = new System.Drawing.Point(118, 211);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(0, 23);
            this.lblCompany.TabIndex = 171;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 170;
            this.label10.Text = "Car Price:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.Olive;
            this.lblModel.Location = new System.Drawing.Point(120, 176);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 23);
            this.lblModel.TabIndex = 169;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 168;
            this.label8.Text = "Car Model:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblname.Location = new System.Drawing.Point(120, 143);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 23);
            this.lblname.TabIndex = 167;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 166;
            this.label6.Text = "Car Name:";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVin.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblVin.Location = new System.Drawing.Point(101, 109);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(0, 23);
            this.lblVin.TabIndex = 165;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 164;
            this.label9.Text = "Car Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 23);
            this.label11.TabIndex = 163;
            this.label11.Text = "VIN No.:";
            // 
            // frmSellCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 495);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.paidErrorIcon);
            this.Controls.Add(this.dtpSellDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paidValidIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpaidPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellValidIcon);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customersBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.sellErrorIcon);
            this.Controls.Add(this.sellPriceBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sellBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSellCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSellCar";
            this.Load += new System.EventHandler(this.frmSellCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellValidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidValidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.PictureBox sellErrorIcon;
        private System.Windows.Forms.TextBox sellPriceBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customersBox;
        private System.Windows.Forms.PictureBox sellValidIcon;
        private System.Windows.Forms.PictureBox paidValidIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpaidPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSellDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox paidErrorIcon;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}