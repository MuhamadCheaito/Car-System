
namespace KassemCars
{
    partial class frmCheckAmountByMonths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckAmountByMonths));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalRecent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalPay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromYearBox = new System.Windows.Forms.ComboBox();
            this.fromMonthBox = new System.Windows.Forms.ComboBox();
            this.toYearBox = new System.Windows.Forms.ComboBox();
            this.toMonthBox = new System.Windows.Forms.ComboBox();
            this.lblTotalCars = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.supplierListView = new System.Windows.Forms.ListView();
            this.viewSuppGrid = new System.Windows.Forms.DataGridView();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSuppGrid)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(966, 79);
            this.panel1.TabIndex = 118;
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
            this.exitBtn.Location = new System.Drawing.Point(920, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(398, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 62);
            this.label8.TabIndex = 40;
            this.label8.Text = "Total Amount Data View";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(318, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTotalRecent);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblRemain);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbltotalPay);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 471);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 59);
            this.panel4.TabIndex = 122;
            // 
            // lblTotalRecent
            // 
            this.lblTotalRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRecent.AutoSize = true;
            this.lblTotalRecent.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecent.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalRecent.Location = new System.Drawing.Point(227, 18);
            this.lblTotalRecent.Name = "lblTotalRecent";
            this.lblTotalRecent.Size = new System.Drawing.Size(34, 23);
            this.lblTotalRecent.TabIndex = 154;
            this.lblTotalRecent.Text = "0$";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 23);
            this.label5.TabIndex = 153;
            this.label5.Text = "Total Recent Amount:";
            // 
            // lblRemain
            // 
            this.lblRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemain.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRemain.Location = new System.Drawing.Point(567, 18);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(34, 23);
            this.lblRemain.TabIndex = 150;
            this.lblRemain.Text = "0$";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 149;
            this.label2.Text = "Total Remaining:";
            // 
            // lbltotalPay
            // 
            this.lbltotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalPay.AutoSize = true;
            this.lbltotalPay.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalPay.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbltotalPay.Location = new System.Drawing.Point(843, 18);
            this.lbltotalPay.Name = "lbltotalPay";
            this.lbltotalPay.Size = new System.Drawing.Size(34, 23);
            this.lbltotalPay.TabIndex = 148;
            this.lbltotalPay.Text = "0$";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 147;
            this.label4.Text = "Total Cost:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.fromYearBox);
            this.panel2.Controls.Add(this.fromMonthBox);
            this.panel2.Controls.Add(this.toYearBox);
            this.panel2.Controls.Add(this.toMonthBox);
            this.panel2.Controls.Add(this.lblTotalCars);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 67);
            this.panel2.TabIndex = 123;
            // 
            // viewButton
            // 
            this.viewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.viewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Location = new System.Drawing.Point(584, 12);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(74, 28);
            this.viewButton.TabIndex = 166;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewButton_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 165;
            this.label1.Text = "To:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 164;
            this.label3.Text = "From:";
            // 
            // fromYearBox
            // 
            this.fromYearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromYearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromYearBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromYearBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.fromYearBox.FormattingEnabled = true;
            this.fromYearBox.Location = new System.Drawing.Point(196, 12);
            this.fromYearBox.Name = "fromYearBox";
            this.fromYearBox.Size = new System.Drawing.Size(107, 31);
            this.fromYearBox.TabIndex = 163;
            // 
            // fromMonthBox
            // 
            this.fromMonthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromMonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromMonthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromMonthBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.fromMonthBox.FormattingEnabled = true;
            this.fromMonthBox.Items.AddRange(new object[] {
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
            this.fromMonthBox.Location = new System.Drawing.Point(86, 12);
            this.fromMonthBox.Name = "fromMonthBox";
            this.fromMonthBox.Size = new System.Drawing.Size(107, 31);
            this.fromMonthBox.TabIndex = 162;
            // 
            // toYearBox
            // 
            this.toYearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toYearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toYearBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toYearBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.toYearBox.FormattingEnabled = true;
            this.toYearBox.Location = new System.Drawing.Point(471, 12);
            this.toYearBox.Name = "toYearBox";
            this.toYearBox.Size = new System.Drawing.Size(107, 31);
            this.toYearBox.TabIndex = 161;
            // 
            // toMonthBox
            // 
            this.toMonthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toMonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toMonthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toMonthBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.toMonthBox.FormattingEnabled = true;
            this.toMonthBox.Items.AddRange(new object[] {
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
            this.toMonthBox.Location = new System.Drawing.Point(358, 12);
            this.toMonthBox.Name = "toMonthBox";
            this.toMonthBox.Size = new System.Drawing.Size(107, 31);
            this.toMonthBox.TabIndex = 160;
            // 
            // lblTotalCars
            // 
            this.lblTotalCars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCars.AutoSize = true;
            this.lblTotalCars.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCars.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalCars.Location = new System.Drawing.Point(911, 15);
            this.lblTotalCars.Name = "lblTotalCars";
            this.lblTotalCars.Size = new System.Drawing.Size(22, 23);
            this.lblTotalCars.TabIndex = 158;
            this.lblTotalCars.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(800, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 157;
            this.label6.Text = "Total Cars:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.supplierListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 325);
            this.panel3.TabIndex = 124;
            // 
            // supplierListView
            // 
            this.supplierListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierListView.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierListView.HideSelection = false;
            this.supplierListView.Location = new System.Drawing.Point(0, 0);
            this.supplierListView.MultiSelect = false;
            this.supplierListView.Name = "supplierListView";
            this.supplierListView.Size = new System.Drawing.Size(200, 325);
            this.supplierListView.TabIndex = 0;
            this.supplierListView.UseCompatibleStateImageBehavior = false;
            this.supplierListView.View = System.Windows.Forms.View.List;
            // 
            // viewSuppGrid
            // 
            this.viewSuppGrid.AllowUserToAddRows = false;
            this.viewSuppGrid.AllowUserToDeleteRows = false;
            this.viewSuppGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewSuppGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewSuppGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewSuppGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewSuppGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewSuppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSuppGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vin,
            this.carName,
            this.carModel,
            this.carCompany,
            this.price,
            this.PurchaseDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewSuppGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewSuppGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSuppGrid.EnableHeadersVisualStyles = false;
            this.viewSuppGrid.GridColor = System.Drawing.Color.White;
            this.viewSuppGrid.Location = new System.Drawing.Point(200, 146);
            this.viewSuppGrid.Name = "viewSuppGrid";
            this.viewSuppGrid.ReadOnly = true;
            this.viewSuppGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewSuppGrid.RowHeadersVisible = false;
            this.viewSuppGrid.RowHeadersWidth = 102;
            this.viewSuppGrid.RowTemplate.Height = 80;
            this.viewSuppGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewSuppGrid.Size = new System.Drawing.Size(766, 325);
            this.viewSuppGrid.TabIndex = 125;
            this.viewSuppGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.viewSuppGrid_CellFormatting);
            // 
            // vin
            // 
            this.vin.HeaderText = "VIN #";
            this.vin.Name = "vin";
            this.vin.ReadOnly = true;
            this.vin.Width = 81;
            // 
            // carName
            // 
            this.carName.HeaderText = "Name";
            this.carName.Name = "carName";
            this.carName.ReadOnly = true;
            this.carName.Width = 84;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "Model";
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
            this.carModel.Width = 88;
            // 
            // carCompany
            // 
            this.carCompany.HeaderText = "Account";
            this.carCompany.Name = "carCompany";
            this.carCompany.ReadOnly = true;
            this.carCompany.Width = 103;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 76;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 155;
            // 
            // frmCheckAmountByMonths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 530);
            this.Controls.Add(this.viewSuppGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckAmountByMonths";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckAmountByMonthcs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheckAmountByMonthcs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSuppGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalRecent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView supplierListView;
        private System.Windows.Forms.DataGridView viewSuppGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn carName;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.Label lblTotalCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fromYearBox;
        private System.Windows.Forms.ComboBox fromMonthBox;
        private System.Windows.Forms.ComboBox toYearBox;
        private System.Windows.Forms.ComboBox toMonthBox;
    }
}