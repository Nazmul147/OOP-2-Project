namespace FinalProject
{
    partial class FormData
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.billingSystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingSystemDataSet1 = new FinalProject.BillingSystemDataSet1();
            this.billingSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingSystemDataSet = new FinalProject.BillingSystemDataSet();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtPAtientAge = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.billingSystemDataSet2 = new FinalProject.BillingSystemDataSet();
            this.billingSystemDataSet3 = new FinalProject.BillingSystemDataSet();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTest = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.dtpDATE = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.PatientAge,
            this.Reference,
            this.Date,
            this.Gender,
            this.Test,
            this.Payment});
            this.dataGridView.Location = new System.Drawing.Point(4, 406);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1214, 316);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.UseWaitCursor = true;
            this.dataGridView.VirtualMode = true;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // billingSystemDataSet1BindingSource
            // 
            this.billingSystemDataSet1BindingSource.DataSource = this.billingSystemDataSet1;
            this.billingSystemDataSet1BindingSource.Position = 0;
            // 
            // billingSystemDataSet1
            // 
            this.billingSystemDataSet1.DataSetName = "BillingSystemDataSet1";
            this.billingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingSystemDataSetBindingSource
            // 
            this.billingSystemDataSetBindingSource.DataSource = this.billingSystemDataSet;
            this.billingSystemDataSetBindingSource.Position = 0;
            // 
            // billingSystemDataSet
            // 
            this.billingSystemDataSet.DataSetName = "BillingSystemDataSet";
            this.billingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(27, 31);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(126, 29);
            this.lblPatientID.TabIndex = 1;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(27, 78);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(170, 29);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(27, 180);
            this.lblRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(134, 29);
            this.lblRef.TabIndex = 3;
            this.lblRef.Text = "Reference";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(27, 225);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 29);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(27, 132);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(147, 29);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Patient Age";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(27, 318);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(113, 29);
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = "Payment";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(29, 273);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(65, 29);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "Test";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(213, 31);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(231, 26);
            this.txtPatientID.TabIndex = 8;
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(213, 186);
            this.txtRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(231, 26);
            this.txtRef.TabIndex = 10;
            this.txtRef.Text = "Dr.";
            // 
            // txtPAtientAge
            // 
            this.txtPAtientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAtientAge.Location = new System.Drawing.Point(213, 138);
            this.txtPAtientAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPAtientAge.Name = "txtPAtientAge";
            this.txtPAtientAge.Size = new System.Drawing.Size(231, 26);
            this.txtPAtientAge.TabIndex = 11;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(213, 84);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(231, 26);
            this.txtPatientName.TabIndex = 12;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(213, 324);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(231, 26);
            this.txtPayment.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.Location = new System.Drawing.Point(517, 15);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(308, 64);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(517, 180);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(308, 64);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSearch.Location = new System.Drawing.Point(757, 368);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(232, 32);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(517, 368);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 30);
            this.txtSearch.TabIndex = 19;
            // 
            // billingSystemDataSet2
            // 
            this.billingSystemDataSet2.DataSetName = "BillingSystemDataSet";
            this.billingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingSystemDataSet3
            // 
            this.billingSystemDataSet3.DataSetName = "BillingSystemDataSet";
            this.billingSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnShowDetails.Location = new System.Drawing.Point(517, 277);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(308, 64);
            this.btnShowDetails.TabIndex = 20;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(513, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search by Patient ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gender";
            // 
            // cbxTest
            // 
            this.cbxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTest.FormattingEnabled = true;
            this.cbxTest.Items.AddRange(new object[] {
            "Blood",
            "Suger ",
            "MRI",
            "CT Scan"});
            this.cbxTest.Location = new System.Drawing.Point(213, 276);
            this.cbxTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTest.Name = "cbxTest";
            this.cbxTest.Size = new System.Drawing.Size(231, 28);
            this.cbxTest.TabIndex = 24;
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(213, 363);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(231, 28);
            this.cbxGender.TabIndex = 25;
            // 
            // dtpDATE
            // 
            this.dtpDATE.CustomFormat = "dd-MM-yyyy";
            this.dtpDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDATE.Location = new System.Drawing.Point(209, 236);
            this.dtpDATE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDATE.Name = "dtpDATE";
            this.dtpDATE.Size = new System.Drawing.Size(233, 30);
            this.dtpDATE.TabIndex = 26;
            this.dtpDATE.UseWaitCursor = true;
            this.dtpDATE.ValueChanged += new System.EventHandler(this.dtpDATE_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDelete.Location = new System.Drawing.Point(517, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(308, 64);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "id";
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 125;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "name";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 125;
            // 
            // PatientAge
            // 
            this.PatientAge.DataPropertyName = "age";
            this.PatientAge.HeaderText = "Patient Age";
            this.PatientAge.MinimumWidth = 6;
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.ReadOnly = true;
            this.PatientAge.Width = 125;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "ref";
            this.Reference.HeaderText = "Reference";
            this.Reference.MinimumWidth = 6;
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // Test
            // 
            this.Test.DataPropertyName = "test";
            this.Test.HeaderText = "Test";
            this.Test.MinimumWidth = 6;
            this.Test.Name = "Test";
            this.Test.ReadOnly = true;
            this.Test.Width = 125;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "payment";
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 125;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1231, 737);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtpDATE);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.cbxTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtPAtientAge);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormData";
            this.Text = "FormData";
            this.Load += new System.EventHandler(this.FormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource billingSystemDataSetBindingSource;
        private BillingSystemDataSet billingSystemDataSet;
        private BillingSystemDataSet1 billingSystemDataSet1;
        private System.Windows.Forms.BindingSource billingSystemDataSet1BindingSource;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtPAtientAge;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private BillingSystemDataSet billingSystemDataSet2;
        private BillingSystemDataSet billingSystemDataSet3;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTest;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.DateTimePicker dtpDATE;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
    }
}