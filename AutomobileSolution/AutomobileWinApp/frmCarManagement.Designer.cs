namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            ReleaseYear = new Label();
            txtCarID = new TextBox();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            txtCarName = new TextBox();
            btnClose = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            txtManufacturer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(73, 66);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(36, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "CarID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(73, 114);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(57, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "CarName";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(62, 169);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(461, 66);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // ReleaseYear
            // 
            ReleaseYear.AutoSize = true;
            ReleaseYear.Location = new Point(439, 119);
            ReleaseYear.Name = "ReleaseYear";
            ReleaseYear.Size = new Size(68, 15);
            ReleaseYear.TabIndex = 4;
            ReleaseYear.Text = "ReleaseYear";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(147, 68);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(195, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(523, 114);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(189, 23);
            txtReleaseYear.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(523, 66);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(189, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(147, 111);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(195, 23);
            txtCarName.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(342, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(180, 214);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(342, 214);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(505, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 243);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(776, 166);
            dgvCarList.TabIndex = 14;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(147, 166);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(195, 23);
            txtManufacturer.TabIndex = 15;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtManufacturer);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(txtCarName);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarID);
            Controls.Add(ReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label ReleaseYear;
        private TextBox txtCarID;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private TextBox txtCarName;
        private Button btnClose;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private TextBox txtManufacturer;
    }
}