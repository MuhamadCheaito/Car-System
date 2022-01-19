
namespace KassemCars
{
    partial class frmViewCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCars));
            this.exportToExcel = new System.Windows.Forms.LinkLabel();
            this.viewCarGrid = new System.Windows.Forms.DataGridView();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toYearBox = new System.Windows.Forms.ComboBox();
            this.toMonthBox = new System.Windows.Forms.ComboBox();
            this.fromYearBox = new System.Windows.Forms.ComboBox();
            this.fromMonthBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exportToExcel
            // 
            this.exportToExcel.AutoSize = true;
            this.exportToExcel.Location = new System.Drawing.Point(489, 110);
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(78, 13);
            this.exportToExcel.TabIndex = 121;
            this.exportToExcel.TabStop = true;
            this.exportToExcel.Text = "Export to Excel";
            this.exportToExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exportToExcel_LinkClicked);
            // 
            // viewCarGrid
            // 
            this.viewCarGrid.AllowUserToAddRows = false;
            this.viewCarGrid.AllowUserToDeleteRows = false;
            this.viewCarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewCarGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewCarGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewCarGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vin,
            this.carName,
            this.carModel,
            this.carCompany,
            this.shippedby,
            this.ShipmentDate,
            this.supplier});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCarGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewCarGrid.EnableHeadersVisualStyles = false;
            this.viewCarGrid.GridColor = System.Drawing.Color.White;
            this.viewCarGrid.Location = new System.Drawing.Point(0, 152);
            this.viewCarGrid.Name = "viewCarGrid";
            this.viewCarGrid.ReadOnly = true;
            this.viewCarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewCarGrid.RowHeadersVisible = false;
            this.viewCarGrid.RowHeadersWidth = 102;
            this.viewCarGrid.RowTemplate.Height = 80;
            this.viewCarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewCarGrid.Size = new System.Drawing.Size(800, 299);
            this.viewCarGrid.TabIndex = 118;
            // 
            // vin
            // 
            this.vin.HeaderText = "VIN #";
            this.vin.MinimumWidth = 12;
            this.vin.Name = "vin";
            this.vin.ReadOnly = true;
            this.vin.Width = 81;
            // 
            // carName
            // 
            this.carName.HeaderText = "Name";
            this.carName.MinimumWidth = 12;
            this.carName.Name = "carName";
            this.carName.ReadOnly = true;
            this.carName.Width = 84;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "Model";
            this.carModel.MinimumWidth = 12;
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
            this.carModel.Width = 88;
            // 
            // carCompany
            // 
            this.carCompany.HeaderText = "Company";
            this.carCompany.MinimumWidth = 12;
            this.carCompany.Name = "carCompany";
            this.carCompany.ReadOnly = true;
            this.carCompany.Width = 114;
            // 
            // shippedby
            // 
            this.shippedby.HeaderText = "Shipped By";
            this.shippedby.MinimumWidth = 12;
            this.shippedby.Name = "shippedby";
            this.shippedby.ReadOnly = true;
            this.shippedby.Width = 128;
            // 
            // ShipmentDate
            // 
            this.ShipmentDate.HeaderText = "Shipment Date";
            this.ShipmentDate.MinimumWidth = 12;
            this.ShipmentDate.Name = "ShipmentDate";
            this.ShipmentDate.ReadOnly = true;
            this.ShipmentDate.Width = 158;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.MinimumWidth = 12;
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            this.supplier.Width = 104;
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
            this.panel1.Size = new System.Drawing.Size(798, 79);
            this.panel1.TabIndex = 117;
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
            this.exitBtn.Location = new System.Drawing.Point(752, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 62);
            this.label8.TabIndex = 40;
            this.label8.Text = "Shipped Car Data View";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(233, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // toYearBox
            // 
            this.toYearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toYearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toYearBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toYearBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.toYearBox.FormattingEnabled = true;
            this.toYearBox.Location = new System.Drawing.Point(464, 99);
            this.toYearBox.Name = "toYearBox";
            this.toYearBox.Size = new System.Drawing.Size(107, 31);
            this.toYearBox.TabIndex = 133;
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
            this.toMonthBox.Location = new System.Drawing.Point(351, 99);
            this.toMonthBox.Name = "toMonthBox";
            this.toMonthBox.Size = new System.Drawing.Size(107, 31);
            this.toMonthBox.TabIndex = 132;
            // 
            // fromYearBox
            // 
            this.fromYearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromYearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromYearBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromYearBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.fromYearBox.FormattingEnabled = true;
            this.fromYearBox.Location = new System.Drawing.Point(189, 99);
            this.fromYearBox.Name = "fromYearBox";
            this.fromYearBox.Size = new System.Drawing.Size(107, 31);
            this.fromYearBox.TabIndex = 135;
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
            this.fromMonthBox.Location = new System.Drawing.Point(79, 99);
            this.fromMonthBox.Name = "fromMonthBox";
            this.fromMonthBox.Size = new System.Drawing.Size(107, 31);
            this.fromMonthBox.TabIndex = 134;
            this.fromMonthBox.SelectedIndexChanged += new System.EventHandler(this.fromMonthBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 136;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 137;
            this.label2.Text = "To:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(577, 99);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 28);
            this.searchButton.TabIndex = 138;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // frmViewCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 452);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromYearBox);
            this.Controls.Add(this.fromMonthBox);
            this.Controls.Add(this.toYearBox);
            this.Controls.Add(this.toMonthBox);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.viewCarGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewCars";
            this.Load += new System.EventHandler(this.frmViewCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel exportToExcel;
        private System.Windows.Forms.DataGridView viewCarGrid;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn carName;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentDate;
        private System.Windows.Forms.ComboBox toYearBox;
        private System.Windows.Forms.ComboBox toMonthBox;
        private System.Windows.Forms.ComboBox fromYearBox;
        private System.Windows.Forms.ComboBox fromMonthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
    }
}