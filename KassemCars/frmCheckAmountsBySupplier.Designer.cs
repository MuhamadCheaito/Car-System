
namespace KassemCars
{
    partial class frmCheckAmountsBySupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckAmountsBySupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalCars = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalRecent = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPassDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.supplierListView = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRemain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalPay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.amountGrid = new System.Windows.Forms.DataGridView();
            this.amountid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.viewSuppGrid = new System.Windows.Forms.DataGridView();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountGrid)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSuppGrid)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(343, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(1016, 79);
            this.panel1.TabIndex = 117;
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
            this.exitBtn.Location = new System.Drawing.Point(970, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(423, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 62);
            this.label8.TabIndex = 40;
            this.label8.Text = "Supplier Account Data View";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblTotalCars);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTotalRecent);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpPassDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.amountBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 94);
            this.panel2.TabIndex = 118;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(196, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 23);
            this.lblDate.TabIndex = 155;
            // 
            // lblTotalCars
            // 
            this.lblTotalCars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCars.AutoSize = true;
            this.lblTotalCars.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCars.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalCars.Location = new System.Drawing.Point(769, 3);
            this.lblTotalCars.Name = "lblTotalCars";
            this.lblTotalCars.Size = new System.Drawing.Size(22, 23);
            this.lblTotalCars.TabIndex = 154;
            this.lblTotalCars.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 153;
            this.label6.Text = "Total Cars:";
            // 
            // lblTotalRecent
            // 
            this.lblTotalRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRecent.AutoSize = true;
            this.lblTotalRecent.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecent.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalRecent.Location = new System.Drawing.Point(873, 31);
            this.lblTotalRecent.Name = "lblTotalRecent";
            this.lblTotalRecent.Size = new System.Drawing.Size(34, 23);
            this.lblTotalRecent.TabIndex = 152;
            this.lblTotalRecent.Text = "0$";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(472, 28);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 28);
            this.addButton.TabIndex = 129;
            this.addButton.Text = "Add Amount";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addButton_MouseClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 23);
            this.label5.TabIndex = 151;
            this.label5.Text = "Total Recent Amount:";
            // 
            // dtpPassDate
            // 
            this.dtpPassDate.CustomFormat = "dd-MM-yyyy";
            this.dtpPassDate.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpPassDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassDate.Location = new System.Drawing.Point(249, 29);
            this.dtpPassDate.Name = "dtpPassDate";
            this.dtpPassDate.ShowUpDown = true;
            this.dtpPassDate.Size = new System.Drawing.Size(217, 27);
            this.dtpPassDate.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 127;
            this.label3.Text = "Pass Date";
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.Location = new System.Drawing.Point(16, 29);
            this.amountBox.Multiline = true;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(217, 28);
            this.amountBox.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 125;
            this.label7.Text = "Amount ($)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.supplierListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 332);
            this.panel3.TabIndex = 122;
            // 
            // supplierListView
            // 
            this.supplierListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierListView.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierListView.HideSelection = false;
            this.supplierListView.Location = new System.Drawing.Point(0, 0);
            this.supplierListView.MultiSelect = false;
            this.supplierListView.Name = "supplierListView";
            this.supplierListView.Size = new System.Drawing.Size(200, 332);
            this.supplierListView.TabIndex = 0;
            this.supplierListView.UseCompatibleStateImageBehavior = false;
            this.supplierListView.View = System.Windows.Forms.View.List;
            this.supplierListView.SelectedIndexChanged += new System.EventHandler(this.supplierListView_SelectedIndexChanged);
            this.supplierListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.supplierListView_MouseClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblRemain);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbltotalPay);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 505);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 59);
            this.panel4.TabIndex = 121;
            // 
            // lblRemain
            // 
            this.lblRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemain.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRemain.Location = new System.Drawing.Point(584, 18);
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
            this.label2.Location = new System.Drawing.Point(416, 18);
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
            this.lbltotalPay.Location = new System.Drawing.Point(873, 18);
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
            this.label4.Location = new System.Drawing.Point(762, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 147;
            this.label4.Text = "Total Cost:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.amountGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(686, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 332);
            this.panel5.TabIndex = 123;
            // 
            // amountGrid
            // 
            this.amountGrid.AllowUserToAddRows = false;
            this.amountGrid.AllowUserToDeleteRows = false;
            this.amountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.amountGrid.BackgroundColor = System.Drawing.Color.White;
            this.amountGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.amountGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.amountGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.amountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountid,
            this.amount,
            this.Passdate,
            this.delete});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.amountGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.amountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountGrid.EnableHeadersVisualStyles = false;
            this.amountGrid.GridColor = System.Drawing.Color.White;
            this.amountGrid.Location = new System.Drawing.Point(0, 0);
            this.amountGrid.Name = "amountGrid";
            this.amountGrid.ReadOnly = true;
            this.amountGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.amountGrid.RowHeadersVisible = false;
            this.amountGrid.RowHeadersWidth = 102;
            this.amountGrid.RowTemplate.Height = 80;
            this.amountGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.amountGrid.Size = new System.Drawing.Size(330, 332);
            this.amountGrid.TabIndex = 125;
            this.amountGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.amountGrid_CellContentClick);
            // 
            // amountid
            // 
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Red;
            this.amountid.DefaultCellStyle = dataGridViewCellStyle12;
            this.amountid.HeaderText = "Amount Id";
            this.amountid.Name = "amountid";
            this.amountid.ReadOnly = true;
            this.amountid.Visible = false;
            this.amountid.Width = 103;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 101;
            // 
            // Passdate
            // 
            this.Passdate.HeaderText = "Pass Date";
            this.Passdate.Name = "Passdate";
            this.Passdate.ReadOnly = true;
            this.Passdate.Width = 115;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.LinkColor = System.Drawing.Color.Red;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForLinkValue = true;
            this.delete.Width = 88;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.viewSuppGrid);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(200, 173);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(486, 332);
            this.panel6.TabIndex = 124;
            // 
            // viewSuppGrid
            // 
            this.viewSuppGrid.AllowUserToAddRows = false;
            this.viewSuppGrid.AllowUserToDeleteRows = false;
            this.viewSuppGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewSuppGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewSuppGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewSuppGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewSuppGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.viewSuppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSuppGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vin,
            this.carName,
            this.carModel,
            this.carCompany,
            this.price,
            this.PurchaseDate});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewSuppGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.viewSuppGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSuppGrid.EnableHeadersVisualStyles = false;
            this.viewSuppGrid.GridColor = System.Drawing.Color.White;
            this.viewSuppGrid.Location = new System.Drawing.Point(0, 0);
            this.viewSuppGrid.Name = "viewSuppGrid";
            this.viewSuppGrid.ReadOnly = true;
            this.viewSuppGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewSuppGrid.RowHeadersVisible = false;
            this.viewSuppGrid.RowHeadersWidth = 102;
            this.viewSuppGrid.RowTemplate.Height = 80;
            this.viewSuppGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewSuppGrid.Size = new System.Drawing.Size(486, 332);
            this.viewSuppGrid.TabIndex = 124;
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
            // frmCheckAmountsBySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 564);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckAmountsBySupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheckAmountsBySupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountGrid)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSuppGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView supplierListView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbltotalPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpPassDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label lblTotalRecent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView amountGrid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView viewSuppGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn carName;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.Label lblTotalCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountid;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passdate;
        private System.Windows.Forms.DataGridViewLinkColumn delete;
    }
}