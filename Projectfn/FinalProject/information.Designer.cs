namespace FinalProject
{
    partial class frmPatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnRefrash = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.cbxSugerTest = new System.Windows.Forms.CheckBox();
            this.cbxMRI = new System.Windows.Forms.CheckBox();
            this.cbxCTscan = new System.Windows.Forms.CheckBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.dtpDOT = new System.Windows.Forms.DateTimePicker();
            this.cbxBlood = new System.Windows.Forms.CheckBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTestMRI = new System.Windows.Forms.Label();
            this.lblTestSuger = new System.Windows.Forms.Label();
            this.LblTestCT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitile = new System.Windows.Forms.Label();
            this.lblTestBlood = new System.Windows.Forms.Label();
            this.lblPayment2 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblRef2 = new System.Windows.Forms.Label();
            this.lblGender2 = new System.Windows.Forms.Label();
            this.lblAge2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.DOT = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl32 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowData);
            this.panel1.Controls.Add(this.btnRefrash);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.cbxSugerTest);
            this.panel1.Controls.Add(this.cbxMRI);
            this.panel1.Controls.Add(this.cbxCTscan);
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Controls.Add(this.dtpDOT);
            this.panel1.Controls.Add(this.cbxBlood);
            this.panel1.Controls.Add(this.txtRef);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblRef);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 534);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnShowData
            // 
            this.btnShowData.BackColor = System.Drawing.SystemColors.Info;
            this.btnShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnShowData.Location = new System.Drawing.Point(70, 440);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(312, 58);
            this.btnShowData.TabIndex = 38;
            this.btnShowData.Text = "Show Database";
            this.btnShowData.UseVisualStyleBackColor = false;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnRefrash
            // 
            this.btnRefrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrash.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRefrash.Location = new System.Drawing.Point(252, 371);
            this.btnRefrash.Name = "btnRefrash";
            this.btnRefrash.Size = new System.Drawing.Size(130, 34);
            this.btnRefrash.TabIndex = 37;
            this.btnRefrash.Text = "Refrash";
            this.btnRefrash.UseVisualStyleBackColor = true;
            this.btnRefrash.Click += new System.EventHandler(this.btnRefrash_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSubmit.Location = new System.Drawing.Point(70, 371);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 34);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(107, 217);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(208, 29);
            this.txtPayment.TabIndex = 35;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // cbxSugerTest
            // 
            this.cbxSugerTest.AutoSize = true;
            this.cbxSugerTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSugerTest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxSugerTest.Location = new System.Drawing.Point(358, 166);
            this.cbxSugerTest.Name = "cbxSugerTest";
            this.cbxSugerTest.Size = new System.Drawing.Size(121, 28);
            this.cbxSugerTest.TabIndex = 34;
            this.cbxSugerTest.Text = "Suger Test";
            this.cbxSugerTest.UseVisualStyleBackColor = true;
            this.cbxSugerTest.CheckedChanged += new System.EventHandler(this.cbxSugerTest_CheckedChanged);
            // 
            // cbxMRI
            // 
            this.cbxMRI.AutoSize = true;
            this.cbxMRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMRI.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxMRI.Location = new System.Drawing.Point(358, 124);
            this.cbxMRI.Name = "cbxMRI";
            this.cbxMRI.Size = new System.Drawing.Size(62, 28);
            this.cbxMRI.TabIndex = 33;
            this.cbxMRI.Text = "MRI";
            this.cbxMRI.UseVisualStyleBackColor = true;
            this.cbxMRI.CheckedChanged += new System.EventHandler(this.cbxMRI_CheckedChanged);
            // 
            // cbxCTscan
            // 
            this.cbxCTscan.AutoSize = true;
            this.cbxCTscan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCTscan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxCTscan.Location = new System.Drawing.Point(358, 217);
            this.cbxCTscan.Name = "cbxCTscan";
            this.cbxCTscan.Size = new System.Drawing.Size(102, 28);
            this.cbxCTscan.TabIndex = 32;
            this.cbxCTscan.Text = "CT Scan";
            this.cbxCTscan.UseVisualStyleBackColor = true;
            this.cbxCTscan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTest.Location = new System.Drawing.Point(355, 26);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(78, 29);
            this.lblTest.TabIndex = 31;
            this.lblTest.Text = "Tests";
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // dtpDOT
            // 
            this.dtpDOT.CustomFormat = "dd-MM-yyyy";
            this.dtpDOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOT.Location = new System.Drawing.Point(107, 273);
            this.dtpDOT.Name = "dtpDOT";
            this.dtpDOT.Size = new System.Drawing.Size(117, 29);
            this.dtpDOT.TabIndex = 30;
            this.dtpDOT.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // cbxBlood
            // 
            this.cbxBlood.AutoSize = true;
            this.cbxBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBlood.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxBlood.Location = new System.Drawing.Point(358, 75);
            this.cbxBlood.Name = "cbxBlood";
            this.cbxBlood.Size = new System.Drawing.Size(119, 28);
            this.cbxBlood.TabIndex = 29;
            this.cbxBlood.Text = "Blood Test";
            this.cbxBlood.UseVisualStyleBackColor = true;
            this.cbxBlood.CheckedChanged += new System.EventHandler(this.cbxBlood_CheckedChanged);
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(107, 172);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(208, 29);
            this.txtRef.TabIndex = 26;
            this.txtRef.TextChanged += new System.EventHandler(this.txtRef_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(107, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(208, 29);
            this.txtAge.TabIndex = 25;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(107, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 29);
            this.txtName.TabIndex = 24;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(115, 127);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 22);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(234, 127);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 22);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 274);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(3, 215);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(83, 20);
            this.lblPayment.TabIndex = 20;
            this.lblPayment.Text = "Payment ";
            this.lblPayment.Click += new System.EventHandler(this.lblPayment_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(-4, 127);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(2, 174);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(108, 20);
            this.lblRef.TabIndex = 18;
            this.lblRef.Text = "Refernence ";
            this.lblRef.Click += new System.EventHandler(this.lblRef_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(3, 75);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 20);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(-1, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(83, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIGITAL DIAGNOSTIC CENTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblTestMRI);
            this.panel2.Controls.Add(this.lblTestSuger);
            this.panel2.Controls.Add(this.LblTestCT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTitile);
            this.panel2.Controls.Add(this.lblTestBlood);
            this.panel2.Controls.Add(this.lblPayment2);
            this.panel2.Controls.Add(this.lblDate2);
            this.panel2.Controls.Add(this.lblRef2);
            this.panel2.Controls.Add(this.lblGender2);
            this.panel2.Controls.Add(this.lblAge2);
            this.panel2.Controls.Add(this.lblName2);
            this.panel2.Controls.Add(this.lbls);
            this.panel2.Controls.Add(this.DOT);
            this.panel2.Controls.Add(this.lbl7);
            this.panel2.Controls.Add(this.lbl5);
            this.panel2.Controls.Add(this.lbl4);
            this.panel2.Controls.Add(this.lbl32);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Location = new System.Drawing.Point(512, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 536);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Info;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrint.Location = new System.Drawing.Point(257, 469);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(151, 47);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // lblTestMRI
            // 
            this.lblTestMRI.AutoSize = true;
            this.lblTestMRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestMRI.Location = new System.Drawing.Point(161, 416);
            this.lblTestMRI.Name = "lblTestMRI";
            this.lblTestMRI.Size = new System.Drawing.Size(57, 20);
            this.lblTestMRI.TabIndex = 39;
            this.lblTestMRI.Text = "--------";
            // 
            // lblTestSuger
            // 
            this.lblTestSuger.AutoSize = true;
            this.lblTestSuger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestSuger.Location = new System.Drawing.Point(161, 449);
            this.lblTestSuger.Name = "lblTestSuger";
            this.lblTestSuger.Size = new System.Drawing.Size(57, 20);
            this.lblTestSuger.TabIndex = 38;
            this.lblTestSuger.Text = "--------";
            // 
            // LblTestCT
            // 
            this.LblTestCT.AutoSize = true;
            this.LblTestCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestCT.Location = new System.Drawing.Point(161, 481);
            this.LblTestCT.Name = "LblTestCT";
            this.LblTestCT.Size = new System.Drawing.Size(57, 20);
            this.LblTestCT.TabIndex = 37;
            this.LblTestCT.Text = "--------";
            this.LblTestCT.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Test 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Test 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Test 3";
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitile.Location = new System.Drawing.Point(147, 12);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(131, 20);
            this.lblTitile.TabIndex = 33;
            this.lblTitile.Text = "INFORMATION";
            this.lblTitile.Click += new System.EventHandler(this.lblTitile_Click);
            // 
            // lblTestBlood
            // 
            this.lblTestBlood.AutoSize = true;
            this.lblTestBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestBlood.Location = new System.Drawing.Point(161, 383);
            this.lblTestBlood.Name = "lblTestBlood";
            this.lblTestBlood.Size = new System.Drawing.Size(57, 20);
            this.lblTestBlood.TabIndex = 32;
            this.lblTestBlood.Text = "--------";
            // 
            // lblPayment2
            // 
            this.lblPayment2.AutoSize = true;
            this.lblPayment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment2.Location = new System.Drawing.Point(161, 329);
            this.lblPayment2.Name = "lblPayment2";
            this.lblPayment2.Size = new System.Drawing.Size(57, 20);
            this.lblPayment2.TabIndex = 31;
            this.lblPayment2.Text = "--------";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.Location = new System.Drawing.Point(161, 281);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(57, 20);
            this.lblDate2.TabIndex = 30;
            this.lblDate2.Text = "--------";
            // 
            // lblRef2
            // 
            this.lblRef2.AutoSize = true;
            this.lblRef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef2.Location = new System.Drawing.Point(161, 222);
            this.lblRef2.Name = "lblRef2";
            this.lblRef2.Size = new System.Drawing.Size(57, 20);
            this.lblRef2.TabIndex = 29;
            this.lblRef2.Text = "--------";
            // 
            // lblGender2
            // 
            this.lblGender2.AutoSize = true;
            this.lblGender2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender2.Location = new System.Drawing.Point(161, 179);
            this.lblGender2.Name = "lblGender2";
            this.lblGender2.Size = new System.Drawing.Size(57, 20);
            this.lblGender2.TabIndex = 28;
            this.lblGender2.Text = "--------";
            // 
            // lblAge2
            // 
            this.lblAge2.AutoSize = true;
            this.lblAge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge2.Location = new System.Drawing.Point(161, 130);
            this.lblAge2.Name = "lblAge2";
            this.lblAge2.Size = new System.Drawing.Size(57, 20);
            this.lblAge2.TabIndex = 27;
            this.lblAge2.Text = "--------";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(161, 80);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(57, 20);
            this.lblName2.TabIndex = 26;
            this.lblName2.Text = "--------";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(186, 45);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(0, 20);
            this.lbls.TabIndex = 25;
            this.lbls.Click += new System.EventHandler(this.lbls_Click);
            // 
            // DOT
            // 
            this.DOT.AutoSize = true;
            this.DOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOT.Location = new System.Drawing.Point(9, 276);
            this.DOT.Name = "DOT";
            this.DOT.Size = new System.Drawing.Size(48, 20);
            this.DOT.TabIndex = 24;
            this.DOT.Text = "Date";
            this.DOT.Click += new System.EventHandler(this.DOT_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(9, 383);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(64, 20);
            this.lbl7.TabIndex = 23;
            this.lbl7.Text = "Test 1 ";
            this.lbl7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(2, 329);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(83, 20);
            this.lbl5.TabIndex = 22;
            this.lbl5.Text = "Payment ";
            this.lbl5.Click += new System.EventHandler(this.lblPayment2_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(9, 224);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(108, 20);
            this.lbl4.TabIndex = 21;
            this.lbl4.Text = "Refernence ";
            this.lbl4.Click += new System.EventHandler(this.lblRef2_Click);
            // 
            // lbl32
            // 
            this.lbl32.AutoSize = true;
            this.lbl32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl32.Location = new System.Drawing.Point(9, 175);
            this.lbl32.Name = "lbl32";
            this.lbl32.Size = new System.Drawing.Size(69, 20);
            this.lbl32.TabIndex = 20;
            this.lbl32.Text = "Gender";
            this.lbl32.Click += new System.EventHandler(this.lblGender2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(13, 127);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(41, 20);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "Age";
            this.lbl2.Click += new System.EventHandler(this.lblAge2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 20);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Name ";
            this.lbl1.Click += new System.EventHandler(this.lblName2_Click);
            // 
            // frmPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(947, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPatientInfo";
            this.Text = "Patient Information ";
            this.Load += new System.EventHandler(this.frmPatientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxBlood;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpDOT;
        private System.Windows.Forms.CheckBox cbxSugerTest;
        private System.Windows.Forms.CheckBox cbxMRI;
        private System.Windows.Forms.CheckBox cbxCTscan;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRefrash;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl32;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label DOT;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lblTestBlood;
        private System.Windows.Forms.Label lblPayment2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblRef2;
        private System.Windows.Forms.Label lblGender2;
        private System.Windows.Forms.Label lblAge2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.Label lblTestMRI;
        private System.Windows.Forms.Label lblTestSuger;
        private System.Windows.Forms.Label LblTestCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShowData;
    }
}

