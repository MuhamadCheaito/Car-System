
namespace KassemCars
{
    partial class frmCarCostsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarCostsData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchByBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewCostsGrid = new System.Windows.Forms.DataGridView();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spray = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCostsGrid)).BeginInit();
            this.SuspendLayout();
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
            this.exitBtn.Location = new System.Drawing.Point(754, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 62);
            this.label8.TabIndex = 40;
            this.label8.Text = "Car Costs Data View";
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
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 99;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(233, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.searchByBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.currBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 82);
            this.panel2.TabIndex = 100;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(323, 18);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(217, 30);
            this.searchBox.TabIndex = 138;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchByBox
            // 
            this.searchByBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.searchByBox.FormattingEnabled = true;
            this.searchByBox.Items.AddRange(new object[] {
            "VIN #",
            "Car Name"});
            this.searchByBox.Location = new System.Drawing.Point(181, 17);
            this.searchByBox.Name = "searchByBox";
            this.searchByBox.Size = new System.Drawing.Size(136, 31);
            this.searchByBox.TabIndex = 137;
            this.searchByBox.SelectedIndexChanged += new System.EventHandler(this.searchByBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 136;
            this.label1.Text = "By:";
            // 
            // currBox
            // 
            this.currBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currBox.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.currBox.FormattingEnabled = true;
            this.currBox.Items.AddRange(new object[] {
            "USD($)",
            "NAIRA(₦)"});
            this.currBox.Location = new System.Drawing.Point(656, 17);
            this.currBox.Name = "currBox";
            this.currBox.Size = new System.Drawing.Size(129, 31);
            this.currBox.TabIndex = 134;
            this.currBox.SelectedIndexChanged += new System.EventHandler(this.currBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(546, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 135;
            this.label10.Text = "Currency:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewCostsGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 289);
            this.panel3.TabIndex = 101;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // viewCostsGrid
            // 
            this.viewCostsGrid.AllowUserToAddRows = false;
            this.viewCostsGrid.AllowUserToDeleteRows = false;
            this.viewCostsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewCostsGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewCostsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewCostsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCostsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewCostsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCostsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vin,
            this.carName,
            this.carModel,
            this.carCompany,
            this.duty,
            this.lights,
            this.tiers,
            this.engine,
            this.battery,
            this.spray,
            this.fur,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCostsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewCostsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCostsGrid.EnableHeadersVisualStyles = false;
            this.viewCostsGrid.GridColor = System.Drawing.Color.White;
            this.viewCostsGrid.Location = new System.Drawing.Point(0, 0);
            this.viewCostsGrid.Name = "viewCostsGrid";
            this.viewCostsGrid.ReadOnly = true;
            this.viewCostsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewCostsGrid.RowHeadersVisible = false;
            this.viewCostsGrid.RowHeadersWidth = 102;
            this.viewCostsGrid.RowTemplate.Height = 80;
            this.viewCostsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewCostsGrid.Size = new System.Drawing.Size(800, 289);
            this.viewCostsGrid.TabIndex = 133;
            this.viewCostsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCostsGrid_CellContentClick);
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
            // duty
            // 
            this.duty.HeaderText = "Duty Costs";
            this.duty.Name = "duty";
            this.duty.ReadOnly = true;
            this.duty.Width = 123;
            // 
            // lights
            // 
            this.lights.HeaderText = "Lights";
            this.lights.Name = "lights";
            this.lights.ReadOnly = true;
            this.lights.Width = 84;
            // 
            // tiers
            // 
            this.tiers.HeaderText = "Tires";
            this.tiers.Name = "tiers";
            this.tiers.ReadOnly = true;
            this.tiers.Width = 74;
            // 
            // engine
            // 
            this.engine.HeaderText = "Engine";
            this.engine.Name = "engine";
            this.engine.ReadOnly = true;
            this.engine.Width = 92;
            // 
            // battery
            // 
            this.battery.HeaderText = "Battery";
            this.battery.Name = "battery";
            this.battery.ReadOnly = true;
            this.battery.Width = 93;
            // 
            // spray
            // 
            this.spray.HeaderText = "Spray";
            this.spray.Name = "spray";
            this.spray.ReadOnly = true;
            this.spray.Width = 81;
            // 
            // fur
            // 
            this.fur.HeaderText = "Seats";
            this.fur.Name = "fur";
            this.fur.ReadOnly = true;
            this.fur.Width = 78;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.LinkColor = System.Drawing.Color.Red;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.Width = 88;
            // 
            // frmCarCostsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarCostsData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCarCostsData_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewCostsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox searchByBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView viewCostsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn carName;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lights;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiers;
        private System.Windows.Forms.DataGridViewTextBoxColumn engine;
        private System.Windows.Forms.DataGridViewTextBoxColumn battery;
        private System.Windows.Forms.DataGridViewTextBoxColumn spray;
        private System.Windows.Forms.DataGridViewTextBoxColumn fur;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}