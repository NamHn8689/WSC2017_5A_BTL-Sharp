namespace WSC2017_5A
{
    partial class form
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
            this.txtBookRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPassport = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCabinClass = new System.Windows.Forms.Label();
            this.grbAmenities = new System.Windows.Forms.GroupBox();
            this.chkbLA = new System.Windows.Forms.CheckBox();
            this.chkbTR = new System.Windows.Forms.CheckBox();
            this.chkbEBlanket = new System.Windows.Forms.CheckBox();
            this.chkbWF250 = new System.Windows.Forms.CheckBox();
            this.chkb2NSF = new System.Windows.Forms.CheckBox();
            this.chkbPHR = new System.Windows.Forms.CheckBox();
            this.chkbFCL = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.chkbNSF = new System.Windows.Forms.CheckBox();
            this.chkbLR = new System.Windows.Forms.CheckBox();
            this.chkbEBag = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbFee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSelected = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPaid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.txtFlNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbAmenities.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookRef
            // 
            this.txtBookRef.Location = new System.Drawing.Point(257, 20);
            this.txtBookRef.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookRef.Name = "txtBookRef";
            this.txtBookRef.Size = new System.Drawing.Size(407, 27);
            this.txtBookRef.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking referencce";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(875, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fight list";
            // 
            // cbx
            // 
            this.cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(236, 46);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(411, 28);
            this.cbx.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(696, 36);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 46);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Amenities";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose your flight";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(672, 16);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 36);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full name:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(127, 196);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 20);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "XXXXXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Passport number:";
            // 
            // lbPassport
            // 
            this.lbPassport.AutoSize = true;
            this.lbPassport.Location = new System.Drawing.Point(610, 196);
            this.lbPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassport.Name = "lbPassport";
            this.lbPassport.Size = new System.Drawing.Size(75, 20);
            this.lbPassport.TabIndex = 7;
            this.lbPassport.Text = "XXXXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Your cabin class is:";
            // 
            // lbCabinClass
            // 
            this.lbCabinClass.AutoSize = true;
            this.lbCabinClass.Location = new System.Drawing.Point(195, 238);
            this.lbCabinClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCabinClass.Name = "lbCabinClass";
            this.lbCabinClass.Size = new System.Drawing.Size(75, 20);
            this.lbCabinClass.TabIndex = 9;
            this.lbCabinClass.Text = "XXXXXX";
            // 
            // grbAmenities
            // 
            this.grbAmenities.Controls.Add(this.chkbLA);
            this.grbAmenities.Controls.Add(this.chkbTR);
            this.grbAmenities.Controls.Add(this.chkbEBlanket);
            this.grbAmenities.Controls.Add(this.chkbWF250);
            this.grbAmenities.Controls.Add(this.chkb2NSF);
            this.grbAmenities.Controls.Add(this.chkbPHR);
            this.grbAmenities.Controls.Add(this.chkbFCL);
            this.grbAmenities.Controls.Add(this.checkBox6);
            this.grbAmenities.Controls.Add(this.chkbNSF);
            this.grbAmenities.Controls.Add(this.chkbLR);
            this.grbAmenities.Controls.Add(this.chkbEBag);
            this.grbAmenities.Controls.Add(this.checkBox1);
            this.grbAmenities.Location = new System.Drawing.Point(24, 276);
            this.grbAmenities.Margin = new System.Windows.Forms.Padding(4);
            this.grbAmenities.Name = "grbAmenities";
            this.grbAmenities.Padding = new System.Windows.Forms.Padding(4);
            this.grbAmenities.Size = new System.Drawing.Size(874, 200);
            this.grbAmenities.TabIndex = 10;
            this.grbAmenities.TabStop = false;
            this.grbAmenities.Text = "AMONIC Airlines Amenities";
            // 
            // chkbLA
            // 
            this.chkbLA.AutoSize = true;
            this.chkbLA.Location = new System.Drawing.Point(572, 83);
            this.chkbLA.Name = "chkbLA";
            this.chkbLA.Size = new System.Drawing.Size(191, 24);
            this.chkbLA.TabIndex = 18;
            this.chkbLA.Text = "Lounge Access ($25)";
            this.chkbLA.UseVisualStyleBackColor = true;
            this.chkbLA.CheckedChanged += new System.EventHandler(this.chkbLA_CheckedChanged);
            // 
            // chkbTR
            // 
            this.chkbTR.AutoSize = true;
            this.chkbTR.Location = new System.Drawing.Point(341, 83);
            this.chkbTR.Name = "chkbTR";
            this.chkbTR.Size = new System.Drawing.Size(174, 24);
            this.chkbTR.TabIndex = 17;
            this.chkbTR.Text = "Tablet Rental ($12)";
            this.chkbTR.UseVisualStyleBackColor = true;
            this.chkbTR.CheckedChanged += new System.EventHandler(this.chkbTR_CheckedChanged);
            // 
            // chkbEBlanket
            // 
            this.chkbEBlanket.AutoSize = true;
            this.chkbEBlanket.Location = new System.Drawing.Point(35, 156);
            this.chkbEBlanket.Name = "chkbEBlanket";
            this.chkbEBlanket.Size = new System.Drawing.Size(175, 24);
            this.chkbEBlanket.TabIndex = 16;
            this.chkbEBlanket.Text = "Extra Blanket ($10)";
            this.chkbEBlanket.UseVisualStyleBackColor = true;
            this.chkbEBlanket.CheckedChanged += new System.EventHandler(this.chkbEBlanket_CheckedChanged);
            // 
            // chkbWF250
            // 
            this.chkbWF250.AutoSize = true;
            this.chkbWF250.Location = new System.Drawing.Point(572, 48);
            this.chkbWF250.Name = "chkbWF250";
            this.chkbWF250.Size = new System.Drawing.Size(175, 24);
            this.chkbWF250.TabIndex = 15;
            this.chkbWF250.Text = "Wi-Fi 250 mb ($25)";
            this.chkbWF250.UseVisualStyleBackColor = true;
            this.chkbWF250.CheckedChanged += new System.EventHandler(this.chkbWF250_CheckedChanged);
            // 
            // chkb2NSF
            // 
            this.chkb2NSF.AutoSize = true;
            this.chkb2NSF.Location = new System.Drawing.Point(572, 156);
            this.chkb2NSF.Name = "chkb2NSF";
            this.chkb2NSF.Size = new System.Drawing.Size(287, 24);
            this.chkb2NSF.TabIndex = 13;
            this.chkb2NSF.Text = "Two Neighboring Seats Free ($35)";
            this.chkb2NSF.UseVisualStyleBackColor = true;
            this.chkb2NSF.CheckedChanged += new System.EventHandler(this.chkb2NSF_CheckedChanged);
            // 
            // chkbPHR
            // 
            this.chkbPHR.AutoSize = true;
            this.chkbPHR.Location = new System.Drawing.Point(35, 120);
            this.chkbPHR.Name = "chkbPHR";
            this.chkbPHR.Size = new System.Drawing.Size(285, 24);
            this.chkbPHR.TabIndex = 12;
            this.chkbPHR.Text = "Premium Headphones Rental ($5)";
            this.chkbPHR.UseVisualStyleBackColor = true;
            this.chkbPHR.CheckedChanged += new System.EventHandler(this.chkbPHR_CheckedChanged);
            // 
            // chkbFCL
            // 
            this.chkbFCL.AutoSize = true;
            this.chkbFCL.Location = new System.Drawing.Point(341, 48);
            this.chkbFCL.Name = "chkbFCL";
            this.chkbFCL.Size = new System.Drawing.Size(215, 24);
            this.chkbFCL.TabIndex = 11;
            this.chkbFCL.Text = "Fast Checkin Lane ($10)";
            this.chkbFCL.UseVisualStyleBackColor = true;
            this.chkbFCL.CheckedChanged += new System.EventHandler(this.chkbFCL_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(37, 83);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(173, 24);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "Wi-Fi 50 mb (Free)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // chkbNSF
            // 
            this.chkbNSF.AutoSize = true;
            this.chkbNSF.Location = new System.Drawing.Point(572, 120);
            this.chkbNSF.Name = "chkbNSF";
            this.chkbNSF.Size = new System.Drawing.Size(187, 24);
            this.chkbNSF.TabIndex = 9;
            this.chkbNSF.Text = "Next Seat Free ($30)";
            this.chkbNSF.UseVisualStyleBackColor = true;
            this.chkbNSF.CheckedChanged += new System.EventHandler(this.chkbNSF_CheckedChanged);
            // 
            // chkbLR
            // 
            this.chkbLR.AutoSize = true;
            this.chkbLR.Location = new System.Drawing.Point(341, 120);
            this.chkbLR.Name = "chkbLR";
            this.chkbLR.Size = new System.Drawing.Size(179, 24);
            this.chkbLR.TabIndex = 7;
            this.chkbLR.Text = "Laptop Rental ($15)";
            this.chkbLR.UseVisualStyleBackColor = true;
            this.chkbLR.CheckedChanged += new System.EventHandler(this.chkbLR_CheckedChanged);
            // 
            // chkbEBag
            // 
            this.chkbEBag.AutoSize = true;
            this.chkbEBag.Location = new System.Drawing.Point(341, 156);
            this.chkbEBag.Name = "chkbEBag";
            this.chkbEBag.Size = new System.Drawing.Size(149, 24);
            this.chkbEBag.TabIndex = 6;
            this.chkbEBag.Text = "Extra Bag ($15)";
            this.chkbEBag.UseVisualStyleBackColor = true;
            this.chkbEBag.CheckedChanged += new System.EventHandler(this.chkbEBag_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(37, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Soft Drinks (Free)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Location = new System.Drawing.Point(338, 571);
            this.lbFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(18, 20);
            this.lbFee.TabIndex = 14;
            this.lbFee.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 571);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Duties and texes";
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Location = new System.Drawing.Point(338, 533);
            this.lbSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(18, 20);
            this.lbSelected.TabIndex = 12;
            this.lbSelected.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(155, 533);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Items selected";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 965);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Total payable:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(563, 579);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 45);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 511);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 45);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save and Confirm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 704);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.lbPaid);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lbTotal);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtBookRef);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnOK);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbFee);
            this.tabPage1.Controls.Add(this.lbName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lbSelected);
            this.tabPage1.Controls.Add(this.lbPassport);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.grbAmenities);
            this.tabPage1.Controls.Add(this.lbCabinClass);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CheckInformation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(319, 607);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(319, 571);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 533);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 496);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "$";
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.Location = new System.Drawing.Point(338, 496);
            this.lbPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(18, 20);
            this.lbPaid.TabIndex = 22;
            this.lbPaid.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 496);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 607);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total payable ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTotal.Location = new System.Drawing.Point(338, 607);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(18, 20);
            this.lbTotal.TabIndex = 19;
            this.lbTotal.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dgvReport);
            this.tabPage2.Controls.Add(this.btnGetReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amenities Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(755, 582);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "49,\'2018/09/04\',\'2018/11/04\'";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Controls.Add(this.txtFlNumber);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(56, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Flight Number";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(468, 76);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerTo.TabIndex = 13;
            // 
            // txtFlNumber
            // 
            this.txtFlNumber.Location = new System.Drawing.Point(231, 20);
            this.txtFlNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlNumber.Name = "txtFlNumber";
            this.txtFlNumber.Size = new System.Drawing.Size(437, 27);
            this.txtFlNumber.TabIndex = 6;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(231, 76);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.RightToLeftLayout = true;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerFrom.TabIndex = 12;
            this.dateTimePickerFrom.Value = new System.DateTime(2020, 8, 13, 14, 53, 15, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "to";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(17, 236);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(916, 188);
            this.dgvReport.TabIndex = 11;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(391, 167);
            this.btnGetReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(137, 46);
            this.btnGetReport.TabIndex = 4;
            this.btnGetReport.Text = "Make Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 701);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form";
            this.Text = "Purchase Amenities";
            this.Load += new System.EventHandler(this.form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbAmenities.ResumeLayout(false);
            this.grbAmenities.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPassport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCabinClass;
        private System.Windows.Forms.GroupBox grbAmenities;
        private System.Windows.Forms.CheckBox chkbFCL;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox chkbNSF;
        private System.Windows.Forms.CheckBox chkbLR;
        private System.Windows.Forms.CheckBox chkbEBag;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSelected;
        private System.Windows.Forms.Label label12;
       
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.CheckBox chkbEBlanket;
        private System.Windows.Forms.CheckBox chkbWF250;
        private System.Windows.Forms.CheckBox chkb2NSF;
        private System.Windows.Forms.CheckBox chkbPHR;
        private System.Windows.Forms.CheckBox chkbTR;
        private System.Windows.Forms.CheckBox chkbLA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFlNumber;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
    }
}

