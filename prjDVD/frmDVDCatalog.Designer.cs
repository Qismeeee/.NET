namespace prjDVD
{
    partial class frmDVDCatalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeading = new Label();
            lblDVDCodeNo = new Label();
            lblTitle = new Label();
            lblLang = new Label();
            lblPrice = new Label();
            grpSubTitles = new GroupBox();
            radNo = new RadioButton();
            radYes = new RadioButton();
            cboLang = new ComboBox();
            updPrice = new NumericUpDown();
            txtNo = new TextBox();
            txtTitle = new TextBox();
            btnAdd = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            grpSubTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updPrice).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(308, 25);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(160, 32);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "DVD Catalog";
            // 
            // lblDVDCodeNo
            // 
            lblDVDCodeNo.AutoSize = true;
            lblDVDCodeNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDVDCodeNo.Location = new Point(82, 82);
            lblDVDCodeNo.Name = "lblDVDCodeNo";
            lblDVDCodeNo.Size = new Size(124, 25);
            lblDVDCodeNo.TabIndex = 1;
            lblDVDCodeNo.Text = "DVD Number";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(82, 145);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(93, 25);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "DVD Title";
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLang.Location = new Point(82, 210);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(95, 25);
            lblLang.TabIndex = 3;
            lblLang.Text = "Language";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(82, 269);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // grpSubTitles
            // 
            grpSubTitles.Controls.Add(radNo);
            grpSubTitles.Controls.Add(radYes);
            grpSubTitles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSubTitles.Location = new Point(177, 332);
            grpSubTitles.Name = "grpSubTitles";
            grpSubTitles.Size = new Size(300, 111);
            grpSubTitles.TabIndex = 6;
            grpSubTitles.TabStop = false;
            grpSubTitles.Text = "Subtitles";
            // 
            // radNo
            // 
            radNo.AutoSize = true;
            radNo.Location = new Point(174, 45);
            radNo.Name = "radNo";
            radNo.Size = new Size(62, 29);
            radNo.TabIndex = 1;
            radNo.Text = "No";
            radNo.UseVisualStyleBackColor = true;
            radNo.CheckedChanged += radNo_CheckedChanged;
            // 
            // radYes
            // 
            radYes.AutoSize = true;
            radYes.Checked = true;
            radYes.Location = new Point(48, 45);
            radYes.Name = "radYes";
            radYes.Size = new Size(64, 29);
            radYes.TabIndex = 0;
            radYes.TabStop = true;
            radYes.Text = "Yes";
            radYes.UseVisualStyleBackColor = true;
            radYes.CheckedChanged += radYes_CheckedChanged;
            // 
            // cboLang
            // 
            cboLang.FormattingEnabled = true;
            cboLang.Items.AddRange(new object[] { "English", "Spanish", "French", "Chinese", "Russian" });
            cboLang.Location = new Point(235, 207);
            cboLang.Name = "cboLang";
            cboLang.Size = new Size(262, 33);
            cboLang.TabIndex = 7;
            cboLang.SelectedIndexChanged += cboLang_SelectedIndexChanged;
            // 
            // updPrice
            // 
            updPrice.Location = new Point(235, 267);
            updPrice.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            updPrice.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            updPrice.Name = "updPrice";
            updPrice.Size = new Size(262, 31);
            updPrice.TabIndex = 8;
            updPrice.Value = new decimal(new int[] { 5, 0, 0, 0 });
            updPrice.ValueChanged += updPrice_ValueChanged;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(239, 88);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(258, 31);
            txtNo.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(239, 144);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(413, 31);
            txtTitle.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(114, 478);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 45);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(271, 478);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 45);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(431, 478);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 45);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmDVDCatalog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 567);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Controls.Add(txtNo);
            Controls.Add(updPrice);
            Controls.Add(cboLang);
            Controls.Add(grpSubTitles);
            Controls.Add(lblPrice);
            Controls.Add(lblLang);
            Controls.Add(lblTitle);
            Controls.Add(lblDVDCodeNo);
            Controls.Add(lblHeading);
            Name = "frmDVDCatalog";
            Text = "DVD Library";
            grpSubTitles.ResumeLayout(false);
            grpSubTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblDVDCodeNo;
        private Label lblTitle;
        private Label lblLang;
        private Label lblPrice;
        private GroupBox grpSubTitles;
        private RadioButton radNo;
        private RadioButton radYes;
        private ComboBox cboLang;
        private NumericUpDown updPrice;
        private TextBox txtNo;
        private TextBox txtTitle;
        private Button btnAdd;
        private Button btnSave;
        private Button btnCancel;
    }
}
