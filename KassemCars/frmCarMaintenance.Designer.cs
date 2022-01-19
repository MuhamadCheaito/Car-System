
namespace KassemCars
{
    partial class frmCarMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarMaintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lightDescBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.carIdBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.rdYesLight = new System.Windows.Forms.RadioButton();
            this.rdNoLight = new System.Windows.Forms.RadioButton();
            this.lightPriceBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpLight = new System.Windows.Forms.GroupBox();
            this.grpTier = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tierPriceBox = new System.Windows.Forms.TextBox();
            this.rdNoTier = new System.Windows.Forms.RadioButton();
            this.rdYesTier = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tierDescBox = new System.Windows.Forms.TextBox();
            this.grpEngine = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.enginePriceBox = new System.Windows.Forms.TextBox();
            this.rdNoEngine = new System.Windows.Forms.RadioButton();
            this.rdYesEngine = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.engineDescBox = new System.Windows.Forms.TextBox();
            this.grpBattery = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.batteryPriceBox = new System.Windows.Forms.TextBox();
            this.rdNoBattery = new System.Windows.Forms.RadioButton();
            this.rdYesBattery = new System.Windows.Forms.RadioButton();
            this.lblBattery = new System.Windows.Forms.Label();
            this.batteryDescBox = new System.Windows.Forms.TextBox();
            this.grpSpray = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sprayPriceBox = new System.Windows.Forms.TextBox();
            this.rdNoSpray = new System.Windows.Forms.RadioButton();
            this.rdYesSpray = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.sprayDescBox = new System.Windows.Forms.TextBox();
            this.grpFur = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.furPriceBox = new System.Windows.Forms.TextBox();
            this.rdNoFur = new System.Windows.Forms.RadioButton();
            this.rdYesFur = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.furDescBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.dutyBox = new System.Windows.Forms.TextBox();
            this.paidBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLight.SuspendLayout();
            this.grpTier.SuspendLayout();
            this.grpEngine.SuspendLayout();
            this.grpBattery.SuspendLayout();
            this.grpSpray.SuspendLayout();
            this.grpFur.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1033, 79);
            this.panel1.TabIndex = 140;
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
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.exitBtn.Location = new System.Drawing.Point(987, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(336, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 62);
            this.label8.TabIndex = 40;
            this.label8.Text = "Car Costs Information";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(273, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lightDescBox
            // 
            this.lightDescBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightDescBox.Enabled = false;
            this.lightDescBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightDescBox.Location = new System.Drawing.Point(12, 33);
            this.lightDescBox.MaxLength = 300;
            this.lightDescBox.Multiline = true;
            this.lightDescBox.Name = "lightDescBox";
            this.lightDescBox.Size = new System.Drawing.Size(300, 89);
            this.lightDescBox.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 133;
            this.label2.Text = "Lights";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(27, 507);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 52);
            this.addBtn.TabIndex = 132;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // carIdBox
            // 
            this.carIdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carIdBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carIdBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.carIdBox.FormattingEnabled = true;
            this.carIdBox.Location = new System.Drawing.Point(22, 270);
            this.carIdBox.Name = "carIdBox";
            this.carIdBox.Size = new System.Drawing.Size(222, 31);
            this.carIdBox.TabIndex = 143;
            this.carIdBox.SelectedIndexChanged += new System.EventHandler(this.carIdBox_SelectedIndexChanged);
            this.carIdBox.SelectedValueChanged += new System.EventHandler(this.carIdBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 144;
            this.label1.Text = "Choose a car:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 145;
            this.label4.Text = "Car:";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCarName.Location = new System.Drawing.Point(69, 323);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(0, 23);
            this.lblCarName.TabIndex = 146;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.Green;
            this.lblModel.Location = new System.Drawing.Point(91, 360);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 23);
            this.lblModel.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 147;
            this.label6.Text = "Model:";
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.FlatAppearance.BorderSize = 0;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(183, 507);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(134, 52);
            this.viewBtn.TabIndex = 157;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // rdYesLight
            // 
            this.rdYesLight.AutoSize = true;
            this.rdYesLight.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdYesLight.Location = new System.Drawing.Point(101, 8);
            this.rdYesLight.Name = "rdYesLight";
            this.rdYesLight.Size = new System.Drawing.Size(44, 17);
            this.rdYesLight.TabIndex = 158;
            this.rdYesLight.Text = "Yes";
            this.rdYesLight.UseVisualStyleBackColor = true;
            // 
            // rdNoLight
            // 
            this.rdNoLight.AutoSize = true;
            this.rdNoLight.Checked = true;
            this.rdNoLight.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdNoLight.Location = new System.Drawing.Point(151, 8);
            this.rdNoLight.Name = "rdNoLight";
            this.rdNoLight.Size = new System.Drawing.Size(40, 17);
            this.rdNoLight.TabIndex = 159;
            this.rdNoLight.TabStop = true;
            this.rdNoLight.Text = "No";
            this.rdNoLight.UseVisualStyleBackColor = true;
            this.rdNoLight.CheckedChanged += new System.EventHandler(this.rdNoLight_CheckedChanged);
            // 
            // lightPriceBox
            // 
            this.lightPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lightPriceBox.Enabled = false;
            this.lightPriceBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightPriceBox.Location = new System.Drawing.Point(223, 4);
            this.lightPriceBox.MaxLength = 25;
            this.lightPriceBox.Name = "lightPriceBox";
            this.lightPriceBox.Size = new System.Drawing.Size(102, 24);
            this.lightPriceBox.TabIndex = 160;
            this.lightPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F);
            this.label11.Location = new System.Drawing.Point(197, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 18);
            this.label11.TabIndex = 181;
            this.label11.Text = "₦";
            // 
            // grpLight
            // 
            this.grpLight.Controls.Add(this.label11);
            this.grpLight.Controls.Add(this.lightPriceBox);
            this.grpLight.Controls.Add(this.rdNoLight);
            this.grpLight.Controls.Add(this.rdYesLight);
            this.grpLight.Controls.Add(this.label2);
            this.grpLight.Controls.Add(this.lightDescBox);
            this.grpLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLight.Location = new System.Drawing.Point(350, 86);
            this.grpLight.Name = "grpLight";
            this.grpLight.Size = new System.Drawing.Size(325, 134);
            this.grpLight.TabIndex = 186;
            this.grpLight.TabStop = false;
            // 
            // grpTier
            // 
            this.grpTier.Controls.Add(this.label3);
            this.grpTier.Controls.Add(this.tierPriceBox);
            this.grpTier.Controls.Add(this.rdNoTier);
            this.grpTier.Controls.Add(this.rdYesTier);
            this.grpTier.Controls.Add(this.label5);
            this.grpTier.Controls.Add(this.tierDescBox);
            this.grpTier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTier.Location = new System.Drawing.Point(350, 226);
            this.grpTier.Name = "grpTier";
            this.grpTier.Size = new System.Drawing.Size(325, 134);
            this.grpTier.TabIndex = 187;
            this.grpTier.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(197, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 181;
            this.label3.Text = "₦";
            // 
            // tierPriceBox
            // 
            this.tierPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tierPriceBox.Enabled = false;
            this.tierPriceBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tierPriceBox.Location = new System.Drawing.Point(223, 4);
            this.tierPriceBox.MaxLength = 25;
            this.tierPriceBox.Name = "tierPriceBox";
            this.tierPriceBox.Size = new System.Drawing.Size(102, 24);
            this.tierPriceBox.TabIndex = 160;
            this.tierPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdNoTier
            // 
            this.rdNoTier.AutoSize = true;
            this.rdNoTier.Checked = true;
            this.rdNoTier.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdNoTier.Location = new System.Drawing.Point(151, 8);
            this.rdNoTier.Name = "rdNoTier";
            this.rdNoTier.Size = new System.Drawing.Size(40, 17);
            this.rdNoTier.TabIndex = 159;
            this.rdNoTier.TabStop = true;
            this.rdNoTier.Text = "No";
            this.rdNoTier.UseVisualStyleBackColor = true;
            this.rdNoTier.CheckedChanged += new System.EventHandler(this.rdNoTier_CheckedChanged);
            // 
            // rdYesTier
            // 
            this.rdYesTier.AutoSize = true;
            this.rdYesTier.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdYesTier.Location = new System.Drawing.Point(101, 8);
            this.rdYesTier.Name = "rdYesTier";
            this.rdYesTier.Size = new System.Drawing.Size(44, 17);
            this.rdYesTier.TabIndex = 158;
            this.rdYesTier.Text = "Yes";
            this.rdYesTier.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 133;
            this.label5.Text = "Tires";
            // 
            // tierDescBox
            // 
            this.tierDescBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tierDescBox.Enabled = false;
            this.tierDescBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tierDescBox.Location = new System.Drawing.Point(12, 33);
            this.tierDescBox.MaxLength = 300;
            this.tierDescBox.Multiline = true;
            this.tierDescBox.Name = "tierDescBox";
            this.tierDescBox.Size = new System.Drawing.Size(300, 89);
            this.tierDescBox.TabIndex = 121;
            // 
            // grpEngine
            // 
            this.grpEngine.Controls.Add(this.label7);
            this.grpEngine.Controls.Add(this.enginePriceBox);
            this.grpEngine.Controls.Add(this.rdNoEngine);
            this.grpEngine.Controls.Add(this.rdYesEngine);
            this.grpEngine.Controls.Add(this.label9);
            this.grpEngine.Controls.Add(this.engineDescBox);
            this.grpEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpEngine.Location = new System.Drawing.Point(350, 366);
            this.grpEngine.Name = "grpEngine";
            this.grpEngine.Size = new System.Drawing.Size(325, 134);
            this.grpEngine.TabIndex = 188;
            this.grpEngine.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(197, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 18);
            this.label7.TabIndex = 181;
            this.label7.Text = "₦";
            // 
            // enginePriceBox
            // 
            this.enginePriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enginePriceBox.Enabled = false;
            this.enginePriceBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enginePriceBox.Location = new System.Drawing.Point(223, 4);
            this.enginePriceBox.MaxLength = 25;
            this.enginePriceBox.Name = "enginePriceBox";
            this.enginePriceBox.Size = new System.Drawing.Size(102, 24);
            this.enginePriceBox.TabIndex = 160;
            this.enginePriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdNoEngine
            // 
            this.rdNoEngine.AutoSize = true;
            this.rdNoEngine.Checked = true;
            this.rdNoEngine.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdNoEngine.Location = new System.Drawing.Point(151, 8);
            this.rdNoEngine.Name = "rdNoEngine";
            this.rdNoEngine.Size = new System.Drawing.Size(40, 17);
            this.rdNoEngine.TabIndex = 159;
            this.rdNoEngine.TabStop = true;
            this.rdNoEngine.Text = "No";
            this.rdNoEngine.UseVisualStyleBackColor = true;
            this.rdNoEngine.CheckedChanged += new System.EventHandler(this.rdNoEngine_CheckedChanged);
            // 
            // rdYesEngine
            // 
            this.rdYesEngine.AutoSize = true;
            this.rdYesEngine.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdYesEngine.Location = new System.Drawing.Point(101, 8);
            this.rdYesEngine.Name = "rdYesEngine";
            this.rdYesEngine.Size = new System.Drawing.Size(44, 17);
            this.rdYesEngine.TabIndex = 158;
            this.rdYesEngine.Text = "Yes";
            this.rdYesEngine.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 133;
            this.label9.Text = "Engine";
            // 
            // engineDescBox
            // 
            this.engineDescBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.engineDescBox.Enabled = false;
            this.engineDescBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineDescBox.Location = new System.Drawing.Point(12, 33);
            this.engineDescBox.MaxLength = 300;
            this.engineDescBox.Multiline = true;
            this.engineDescBox.Name = "engineDescBox";
            this.engineDescBox.Size = new System.Drawing.Size(300, 89);
            this.engineDescBox.TabIndex = 121;
            // 
            // grpBattery
            // 
            this.grpBattery.Controls.Add(this.label10);
            this.grpBattery.Controls.Add(this.batteryPriceBox);
            this.grpBattery.Controls.Add(this.rdNoBattery);
            this.grpBattery.Controls.Add(this.rdYesBattery);
            this.grpBattery.Controls.Add(this.lblBattery);
            this.grpBattery.Controls.Add(this.batteryDescBox);
            this.grpBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBattery.Location = new System.Drawing.Point(681, 86);
            this.grpBattery.Name = "grpBattery";
            this.grpBattery.Size = new System.Drawing.Size(325, 134);
            this.grpBattery.TabIndex = 187;
            this.grpBattery.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F);
            this.label10.Location = new System.Drawing.Point(198, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 18);
            this.label10.TabIndex = 181;
            this.label10.Text = "₦";
            // 
            // batteryPriceBox
            // 
            this.batteryPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batteryPriceBox.Enabled = false;
            this.batteryPriceBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryPriceBox.Location = new System.Drawing.Point(224, 4);
            this.batteryPriceBox.MaxLength = 25;
            this.batteryPriceBox.Name = "batteryPriceBox";
            this.batteryPriceBox.Size = new System.Drawing.Size(101, 24);
            this.batteryPriceBox.TabIndex = 160;
            this.batteryPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdNoBattery
            // 
            this.rdNoBattery.AutoSize = true;
            this.rdNoBattery.Checked = true;
            this.rdNoBattery.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdNoBattery.Location = new System.Drawing.Point(161, 8);
            this.rdNoBattery.Name = "rdNoBattery";
            this.rdNoBattery.Size = new System.Drawing.Size(40, 17);
            this.rdNoBattery.TabIndex = 159;
            this.rdNoBattery.TabStop = true;
            this.rdNoBattery.Text = "No";
            this.rdNoBattery.UseVisualStyleBackColor = true;
            this.rdNoBattery.CheckedChanged += new System.EventHandler(this.rdNoBattery_CheckedChanged);
            // 
            // rdYesBattery
            // 
            this.rdYesBattery.AutoSize = true;
            this.rdYesBattery.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdYesBattery.Location = new System.Drawing.Point(111, 8);
            this.rdYesBattery.Name = "rdYesBattery";
            this.rdYesBattery.Size = new System.Drawing.Size(44, 17);
            this.rdYesBattery.TabIndex = 158;
            this.rdYesBattery.Text = "Yes";
            this.rdYesBattery.UseVisualStyleBackColor = true;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery.Location = new System.Drawing.Point(8, 3);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(78, 23);
            this.lblBattery.TabIndex = 133;
            this.lblBattery.Text = "Battery";
            // 
            // batteryDescBox
            // 
            this.batteryDescBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batteryDescBox.Enabled = false;
            this.batteryDescBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryDescBox.Location = new System.Drawing.Point(12, 33);
            this.batteryDescBox.MaxLength = 300;
            this.batteryDescBox.Multiline = true;
            this.batteryDescBox.Name = "batteryDescBox";
            this.batteryDescBox.Size = new System.Drawing.Size(300, 89);
            this.batteryDescBox.TabIndex = 121;
            // 
            // grpSpray
            // 
            this.grpSpray.Controls.Add(this.label13);
            this.grpSpray.Controls.Add(this.sprayPriceBox);
            this.grpSpray.Controls.Add(this.rdNoSpray);
            this.grpSpray.Controls.Add(this.rdYesSpray);
            this.grpSpray.Controls.Add(this.label14);
            this.grpSpray.Controls.Add(this.sprayDescBox);
            this.grpSpray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSpray.Location = new System.Drawing.Point(681, 226);
            this.grpSpray.Name = "grpSpray";
            this.grpSpray.Size = new System.Drawing.Size(325, 134);
            this.grpSpray.TabIndex = 188;
            this.grpSpray.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F);
            this.label13.Location = new System.Drawing.Point(198, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 18);
            this.label13.TabIndex = 181;
            this.label13.Text = "₦";
            // 
            // sprayPriceBox
            // 
            this.sprayPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sprayPriceBox.Enabled = false;
            this.sprayPriceBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprayPriceBox.Location = new System.Drawing.Point(224, 4);
            this.sprayPriceBox.MaxLength = 25;
            this.sprayPriceBox.Name = "sprayPriceBox";
            this.sprayPriceBox.Size = new System.Drawing.Size(101, 24);
            this.sprayPriceBox.TabIndex = 160;
            this.sprayPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdNoSpray
            // 
            this.rdNoSpray.AutoSize = true;
            this.rdNoSpray.Checked = true;
            this.rdNoSpray.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdNoSpray.Location = new System.Drawing.Point(161, 7);
            this.rdNoSpray.Name = "rdNoSpray";
            this.rdNoSpray.Size = new System.Drawing.Size(40, 17);
            this.rdNoSpray.TabIndex = 159;
            this.rdNoSpray.TabStop = true;
            this.rdNoSpray.Text = "No";
            this.rdNoSpray.UseVisualStyleBackColor = true;
            this.rdNoSpray.CheckedChanged += new System.EventHandler(this.rdNoSpray_CheckedChanged);
            // 
            // rdYesSpray
            // 
            this.rdYesSpray.AutoSize = true;
            this.rdYesSpray.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdYesSpray.Location = new System.Drawing.Point(111, 7);
            this.rdYesSpray.Name = "rdYesSpray";
            this.rdYesSpray.Size = new System.Drawing.Size(44, 17);
            this.rdYesSpray.TabIndex = 158;
            this.rdYesSpray.Text = "Yes";
            this.rdYesSpray.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 23);
            this.label14.TabIndex = 133;
            this.label14.Text = "Spray";
            // 
            // sprayDescBox
            // 
            this.sprayDescBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sprayDescBox.Enabled = false;
            this.sprayDescBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprayDescBox.Location = new System.Drawing.Point(12, 33);
            this.sprayDescBox.MaxLength = 300;
            this.sprayDescBox.Multiline = true;
            this.sprayDescBox.Name = "sprayDescBox";
            this.sprayDescBox.Size = new System.Drawing.Size(300, 89);
            this.sprayDescBox.TabIndex = 121;
            // 
            // grpFur
            // 
            this.grpFur.Controls.Add(this.label15);
            this.grpFur.Controls.Add(this.furPriceBox);
            this.grpFur.Controls.Add(this.rdNoFur);
            this.grpFur.Controls.Add(this.rdYesFur);
            this.grpFur.Controls.Add(this.label16);
            this.grpFur.Controls.Add(this.furDescBox);
            this.grpFur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFur.Location = new System.Drawing.Point(681, 366);
            this.grpFur.Name = "grpFur";
            this.grpFur.Size = new System.Drawing.Size(325, 134);
            this.grpFur.TabIndex = 189;
            this.grpFur.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F);
            this.label15.Location = new System.Drawing.Point(198, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 18);
            this.label15.TabIndex = 181;
            this.label15.Text = "₦";
            // 
            // furPriceBox
            // 
            this.furPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.furPriceBox.Enabled = false;
            this.furPriceBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furPriceBox.Location = new System.Drawing.Point(224, 4);
            this.furPriceBox.MaxLength = 25;
            this.furPriceBox.Name = "furPriceBox";
            this.furPriceBox.Size = new System.Drawing.Size(101, 24);
            this.furPriceBox.TabIndex = 160;
            this.furPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdNoFur
            // 
            this.rdNoFur.AutoSize = true;
            this.rdNoFur.Checked = true;
            this.rdNoFur.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdNoFur.Location = new System.Drawing.Point(161, 8);
            this.rdNoFur.Name = "rdNoFur";
            this.rdNoFur.Size = new System.Drawing.Size(40, 17);
            this.rdNoFur.TabIndex = 159;
            this.rdNoFur.TabStop = true;
            this.rdNoFur.Text = "No";
            this.rdNoFur.UseVisualStyleBackColor = true;
            this.rdNoFur.CheckedChanged += new System.EventHandler(this.rdNoFur_CheckedChanged);
            // 
            // rdYesFur
            // 
            this.rdYesFur.AutoSize = true;
            this.rdYesFur.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdYesFur.Location = new System.Drawing.Point(111, 8);
            this.rdYesFur.Name = "rdYesFur";
            this.rdYesFur.Size = new System.Drawing.Size(44, 17);
            this.rdYesFur.TabIndex = 158;
            this.rdYesFur.Text = "Yes";
            this.rdYesFur.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 133;
            this.label16.Text = "Seats";
            // 
            // furDescBox
            // 
            this.furDescBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.furDescBox.Enabled = false;
            this.furDescBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furDescBox.Location = new System.Drawing.Point(12, 33);
            this.furDescBox.MaxLength = 300;
            this.furDescBox.Multiline = true;
            this.furDescBox.Name = "furDescBox";
            this.furDescBox.Size = new System.Drawing.Size(300, 89);
            this.furDescBox.TabIndex = 121;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 23);
            this.label12.TabIndex = 191;
            this.label12.Text = "Choose a supplier:";
            // 
            // supplierBox
            // 
            this.supplierBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(26, 112);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(222, 31);
            this.supplierBox.TabIndex = 190;
            this.supplierBox.SelectedIndexChanged += new System.EventHandler(this.supplierBox_SelectedIndexChanged);
            // 
            // dutyBox
            // 
            this.dutyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dutyBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.dutyBox.Location = new System.Drawing.Point(185, 461);
            this.dutyBox.MaxLength = 300;
            this.dutyBox.Name = "dutyBox";
            this.dutyBox.Size = new System.Drawing.Size(141, 27);
            this.dutyBox.TabIndex = 192;
            // 
            // paidBox
            // 
            this.paidBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paidBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.paidBox.Location = new System.Drawing.Point(22, 461);
            this.paidBox.MaxLength = 300;
            this.paidBox.Name = "paidBox";
            this.paidBox.Size = new System.Drawing.Size(139, 27);
            this.paidBox.TabIndex = 193;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 435);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 194;
            this.label17.Text = "Paid($)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(179, 435);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 23);
            this.label18.TabIndex = 195;
            this.label18.Text = "Duty(₦)";
            // 
            // yearBox
            // 
            this.yearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.yearBox.Location = new System.Drawing.Point(138, 189);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(110, 31);
            this.yearBox.TabIndex = 215;
            this.yearBox.SelectedIndexChanged += new System.EventHandler(this.yearBox_SelectedIndexChanged);
            // 
            // monthBox
            // 
            this.monthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthBox.Location = new System.Drawing.Point(22, 189);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(102, 31);
            this.monthBox.TabIndex = 214;
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.monthBox_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 14F);
            this.label19.Location = new System.Drawing.Point(19, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 23);
            this.label19.TabIndex = 213;
            this.label19.Text = "Enter The Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(92, 399);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 23);
            this.lblPrice.TabIndex = 217;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 399);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 23);
            this.label21.TabIndex = 216;
            this.label21.Text = "Price:";
            // 
            // frmCarMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 597);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.paidBox);
            this.Controls.Add(this.dutyBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.supplierBox);
            this.Controls.Add(this.grpFur);
            this.Controls.Add(this.grpSpray);
            this.Controls.Add(this.grpBattery);
            this.Controls.Add(this.grpEngine);
            this.Controls.Add(this.grpTier);
            this.Controls.Add(this.grpLight);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carIdBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarMaintenance";
            this.Load += new System.EventHandler(this.frmCarMaintenance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLight.ResumeLayout(false);
            this.grpLight.PerformLayout();
            this.grpTier.ResumeLayout(false);
            this.grpTier.PerformLayout();
            this.grpEngine.ResumeLayout(false);
            this.grpEngine.PerformLayout();
            this.grpBattery.ResumeLayout(false);
            this.grpBattery.PerformLayout();
            this.grpSpray.ResumeLayout(false);
            this.grpSpray.PerformLayout();
            this.grpFur.ResumeLayout(false);
            this.grpFur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lightDescBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox carIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.RadioButton rdYesLight;
        private System.Windows.Forms.RadioButton rdNoLight;
        private System.Windows.Forms.TextBox lightPriceBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpLight;
        private System.Windows.Forms.GroupBox grpTier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tierPriceBox;
        private System.Windows.Forms.RadioButton rdNoTier;
        private System.Windows.Forms.RadioButton rdYesTier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tierDescBox;
        private System.Windows.Forms.GroupBox grpEngine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox enginePriceBox;
        private System.Windows.Forms.RadioButton rdNoEngine;
        private System.Windows.Forms.RadioButton rdYesEngine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox engineDescBox;
        private System.Windows.Forms.GroupBox grpBattery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox batteryPriceBox;
        private System.Windows.Forms.RadioButton rdNoBattery;
        private System.Windows.Forms.RadioButton rdYesBattery;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.TextBox batteryDescBox;
        private System.Windows.Forms.GroupBox grpSpray;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sprayPriceBox;
        private System.Windows.Forms.RadioButton rdNoSpray;
        private System.Windows.Forms.RadioButton rdYesSpray;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sprayDescBox;
        private System.Windows.Forms.GroupBox grpFur;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox furPriceBox;
        private System.Windows.Forms.RadioButton rdNoFur;
        private System.Windows.Forms.RadioButton rdYesFur;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox furDescBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.TextBox dutyBox;
        private System.Windows.Forms.TextBox paidBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label21;
    }
}