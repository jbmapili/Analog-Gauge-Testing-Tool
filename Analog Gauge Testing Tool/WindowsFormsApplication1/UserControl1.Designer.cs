namespace WindowsFormsApplication1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtStr1 = new System.Windows.Forms.TextBox();
            this.btnSVOne = new System.Windows.Forms.Button();
            this.txtSVBlank = new System.Windows.Forms.TextBox();
            this.gbSV = new System.Windows.Forms.GroupBox();
            this.btnSVFive = new System.Windows.Forms.Button();
            this.btnSVZero = new System.Windows.Forms.Button();
            this.btnSVSet = new System.Windows.Forms.Button();
            this.txtSVValue = new System.Windows.Forms.TextBox();
            this.txtSVAdrs = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbPV = new System.Windows.Forms.GroupBox();
            this.txtPVBlank = new System.Windows.Forms.TextBox();
            this.btnPVOne = new System.Windows.Forms.Button();
            this.btnPVFive = new System.Windows.Forms.Button();
            this.btnPVZero = new System.Windows.Forms.Button();
            this.txtPVSet = new System.Windows.Forms.Button();
            this.txtPVValue = new System.Windows.Forms.TextBox();
            this.txtPVAdrs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMVAdrs = new System.Windows.Forms.TextBox();
            this.txtMVValue = new System.Windows.Forms.TextBox();
            this.txtMVSet = new System.Windows.Forms.Button();
            this.txtMVZero = new System.Windows.Forms.Button();
            this.btnMVFive = new System.Windows.Forms.Button();
            this.btnMVOne = new System.Windows.Forms.Button();
            this.txtMVBlank = new System.Windows.Forms.TextBox();
            this.gbMV = new System.Windows.Forms.GroupBox();
            this.txtOPStatus = new System.Windows.Forms.TextBox();
            this.btnOPSet = new System.Windows.Forms.Button();
            this.txtCLAdrs = new System.Windows.Forms.TextBox();
            this.btnCLStatus = new System.Windows.Forms.Button();
            this.btnTuning = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtAmAdrs = new System.Windows.Forms.TextBox();
            this.btnAMStatus = new System.Windows.Forms.Button();
            this.txtOPAdrs = new System.Windows.Forms.TextBox();
            this.txtStr2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSV.SuspendLayout();
            this.gbPV.SuspendLayout();
            this.gbMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStr1
            // 
            this.txtStr1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtStr1.Location = new System.Drawing.Point(90, 6);
            this.txtStr1.Name = "txtStr1";
            this.txtStr1.ReadOnly = true;
            this.txtStr1.Size = new System.Drawing.Size(93, 20);
            this.txtStr1.TabIndex = 240;
            // 
            // btnSVOne
            // 
            this.btnSVOne.Location = new System.Drawing.Point(129, 67);
            this.btnSVOne.Name = "btnSVOne";
            this.btnSVOne.Size = new System.Drawing.Size(55, 23);
            this.btnSVOne.TabIndex = 236;
            this.btnSVOne.Text = "10000";
            this.btnSVOne.UseVisualStyleBackColor = true;
            this.btnSVOne.Click += new System.EventHandler(this.btnSVOne_Click);
            // 
            // txtSVBlank
            // 
            this.txtSVBlank.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSVBlank.Location = new System.Drawing.Point(191, 69);
            this.txtSVBlank.Name = "txtSVBlank";
            this.txtSVBlank.Size = new System.Drawing.Size(65, 20);
            this.txtSVBlank.TabIndex = 237;
            this.txtSVBlank.TextChanged += new System.EventHandler(this.txtSVBlank_TextChanged);
            this.txtSVBlank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSVBlank_KeyDown);
            // 
            // gbSV
            // 
            this.gbSV.Controls.Add(this.txtSVBlank);
            this.gbSV.Controls.Add(this.btnSVOne);
            this.gbSV.Controls.Add(this.btnSVFive);
            this.gbSV.Controls.Add(this.btnSVZero);
            this.gbSV.Controls.Add(this.btnSVSet);
            this.gbSV.Controls.Add(this.txtSVValue);
            this.gbSV.Controls.Add(this.txtSVAdrs);
            this.gbSV.Controls.Add(this.label21);
            this.gbSV.Controls.Add(this.label19);
            this.gbSV.Controls.Add(this.label12);
            this.gbSV.Location = new System.Drawing.Point(54, 41);
            this.gbSV.Name = "gbSV";
            this.gbSV.Size = new System.Drawing.Size(280, 100);
            this.gbSV.TabIndex = 250;
            this.gbSV.TabStop = false;
            this.gbSV.Text = "SV";
            // 
            // btnSVFive
            // 
            this.btnSVFive.Location = new System.Drawing.Point(68, 68);
            this.btnSVFive.Name = "btnSVFive";
            this.btnSVFive.Size = new System.Drawing.Size(55, 23);
            this.btnSVFive.TabIndex = 235;
            this.btnSVFive.Text = "5000";
            this.btnSVFive.UseVisualStyleBackColor = true;
            this.btnSVFive.Click += new System.EventHandler(this.btnSVFive_Click);
            // 
            // btnSVZero
            // 
            this.btnSVZero.Location = new System.Drawing.Point(7, 67);
            this.btnSVZero.Name = "btnSVZero";
            this.btnSVZero.Size = new System.Drawing.Size(55, 23);
            this.btnSVZero.TabIndex = 234;
            this.btnSVZero.Text = "0";
            this.btnSVZero.UseVisualStyleBackColor = true;
            this.btnSVZero.Click += new System.EventHandler(this.btnSVZero_Click);
            // 
            // btnSVSet
            // 
            this.btnSVSet.Location = new System.Drawing.Point(201, 42);
            this.btnSVSet.Name = "btnSVSet";
            this.btnSVSet.Size = new System.Drawing.Size(55, 23);
            this.btnSVSet.TabIndex = 233;
            this.btnSVSet.Text = "Set";
            this.btnSVSet.UseVisualStyleBackColor = true;
            this.btnSVSet.Click += new System.EventHandler(this.btnSVSet_Click);
            // 
            // txtSVValue
            // 
            this.txtSVValue.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSVValue.Location = new System.Drawing.Point(112, 43);
            this.txtSVValue.Name = "txtSVValue";
            this.txtSVValue.ReadOnly = true;
            this.txtSVValue.Size = new System.Drawing.Size(83, 20);
            this.txtSVValue.TabIndex = 232;
            // 
            // txtSVAdrs
            // 
            this.txtSVAdrs.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSVAdrs.Location = new System.Drawing.Point(7, 43);
            this.txtSVAdrs.Name = "txtSVAdrs";
            this.txtSVAdrs.ReadOnly = true;
            this.txtSVAdrs.Size = new System.Drawing.Size(99, 20);
            this.txtSVAdrs.TabIndex = 231;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(131, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 17);
            this.label21.TabIndex = 230;
            this.label21.Text = "Value";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(28, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 229;
            this.label19.Text = "SV Adrs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 228;
            this.label12.Text = "SV Set";
            // 
            // gbPV
            // 
            this.gbPV.Controls.Add(this.txtPVBlank);
            this.gbPV.Controls.Add(this.btnPVOne);
            this.gbPV.Controls.Add(this.btnPVFive);
            this.gbPV.Controls.Add(this.btnPVZero);
            this.gbPV.Controls.Add(this.txtPVSet);
            this.gbPV.Controls.Add(this.txtPVValue);
            this.gbPV.Controls.Add(this.txtPVAdrs);
            this.gbPV.Controls.Add(this.label10);
            this.gbPV.Controls.Add(this.label11);
            this.gbPV.Controls.Add(this.label13);
            this.gbPV.Location = new System.Drawing.Point(351, 41);
            this.gbPV.Name = "gbPV";
            this.gbPV.Size = new System.Drawing.Size(278, 100);
            this.gbPV.TabIndex = 251;
            this.gbPV.TabStop = false;
            this.gbPV.Text = "PV";
            // 
            // txtPVBlank
            // 
            this.txtPVBlank.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPVBlank.Location = new System.Drawing.Point(191, 69);
            this.txtPVBlank.Name = "txtPVBlank";
            this.txtPVBlank.Size = new System.Drawing.Size(65, 20);
            this.txtPVBlank.TabIndex = 237;
            this.txtPVBlank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPVBlank_KeyDown);
            // 
            // btnPVOne
            // 
            this.btnPVOne.Location = new System.Drawing.Point(129, 67);
            this.btnPVOne.Name = "btnPVOne";
            this.btnPVOne.Size = new System.Drawing.Size(55, 23);
            this.btnPVOne.TabIndex = 236;
            this.btnPVOne.Text = "10000";
            this.btnPVOne.UseVisualStyleBackColor = true;
            this.btnPVOne.Click += new System.EventHandler(this.btnPVOne_Click);
            // 
            // btnPVFive
            // 
            this.btnPVFive.Location = new System.Drawing.Point(68, 68);
            this.btnPVFive.Name = "btnPVFive";
            this.btnPVFive.Size = new System.Drawing.Size(55, 23);
            this.btnPVFive.TabIndex = 235;
            this.btnPVFive.Text = "5000";
            this.btnPVFive.UseVisualStyleBackColor = true;
            this.btnPVFive.Click += new System.EventHandler(this.btnPVFive_Click);
            // 
            // btnPVZero
            // 
            this.btnPVZero.Location = new System.Drawing.Point(7, 67);
            this.btnPVZero.Name = "btnPVZero";
            this.btnPVZero.Size = new System.Drawing.Size(55, 23);
            this.btnPVZero.TabIndex = 234;
            this.btnPVZero.Text = "0";
            this.btnPVZero.UseVisualStyleBackColor = true;
            this.btnPVZero.Click += new System.EventHandler(this.btnPVZero_Click);
            // 
            // txtPVSet
            // 
            this.txtPVSet.Location = new System.Drawing.Point(201, 42);
            this.txtPVSet.Name = "txtPVSet";
            this.txtPVSet.Size = new System.Drawing.Size(55, 23);
            this.txtPVSet.TabIndex = 233;
            this.txtPVSet.Text = "Set";
            this.txtPVSet.UseVisualStyleBackColor = true;
            this.txtPVSet.Click += new System.EventHandler(this.txtPVSet_Click);
            // 
            // txtPVValue
            // 
            this.txtPVValue.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPVValue.Location = new System.Drawing.Point(112, 43);
            this.txtPVValue.Name = "txtPVValue";
            this.txtPVValue.ReadOnly = true;
            this.txtPVValue.Size = new System.Drawing.Size(83, 20);
            this.txtPVValue.TabIndex = 232;
            // 
            // txtPVAdrs
            // 
            this.txtPVAdrs.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPVAdrs.Location = new System.Drawing.Point(7, 43);
            this.txtPVAdrs.Name = "txtPVAdrs";
            this.txtPVAdrs.ReadOnly = true;
            this.txtPVAdrs.Size = new System.Drawing.Size(99, 20);
            this.txtPVAdrs.TabIndex = 231;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 230;
            this.label10.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 229;
            this.label11.Text = "PV Adrs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(203, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 228;
            this.label13.Text = "PV Set";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(203, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 17);
            this.label20.TabIndex = 228;
            this.label20.Text = "MV Set";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 229;
            this.label15.Text = "MV Adrs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(131, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 230;
            this.label14.Text = "Value";
            // 
            // txtMVAdrs
            // 
            this.txtMVAdrs.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMVAdrs.Location = new System.Drawing.Point(7, 43);
            this.txtMVAdrs.Name = "txtMVAdrs";
            this.txtMVAdrs.ReadOnly = true;
            this.txtMVAdrs.Size = new System.Drawing.Size(99, 20);
            this.txtMVAdrs.TabIndex = 231;
            // 
            // txtMVValue
            // 
            this.txtMVValue.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMVValue.Location = new System.Drawing.Point(112, 43);
            this.txtMVValue.Name = "txtMVValue";
            this.txtMVValue.ReadOnly = true;
            this.txtMVValue.Size = new System.Drawing.Size(83, 20);
            this.txtMVValue.TabIndex = 232;
            // 
            // txtMVSet
            // 
            this.txtMVSet.Location = new System.Drawing.Point(201, 42);
            this.txtMVSet.Name = "txtMVSet";
            this.txtMVSet.Size = new System.Drawing.Size(55, 23);
            this.txtMVSet.TabIndex = 233;
            this.txtMVSet.Text = "Set";
            this.txtMVSet.UseVisualStyleBackColor = true;
            this.txtMVSet.Click += new System.EventHandler(this.txtMVSet_Click);
            // 
            // txtMVZero
            // 
            this.txtMVZero.Location = new System.Drawing.Point(7, 67);
            this.txtMVZero.Name = "txtMVZero";
            this.txtMVZero.Size = new System.Drawing.Size(55, 23);
            this.txtMVZero.TabIndex = 234;
            this.txtMVZero.Text = "0";
            this.txtMVZero.UseVisualStyleBackColor = true;
            this.txtMVZero.Click += new System.EventHandler(this.txtMVZero_Click);
            // 
            // btnMVFive
            // 
            this.btnMVFive.Location = new System.Drawing.Point(68, 68);
            this.btnMVFive.Name = "btnMVFive";
            this.btnMVFive.Size = new System.Drawing.Size(55, 23);
            this.btnMVFive.TabIndex = 235;
            this.btnMVFive.Text = "5000";
            this.btnMVFive.UseVisualStyleBackColor = true;
            this.btnMVFive.Click += new System.EventHandler(this.btnMVFive_Click);
            // 
            // btnMVOne
            // 
            this.btnMVOne.Location = new System.Drawing.Point(129, 67);
            this.btnMVOne.Name = "btnMVOne";
            this.btnMVOne.Size = new System.Drawing.Size(55, 23);
            this.btnMVOne.TabIndex = 236;
            this.btnMVOne.Text = "10000";
            this.btnMVOne.UseVisualStyleBackColor = true;
            this.btnMVOne.Click += new System.EventHandler(this.btnMVOne_Click);
            // 
            // txtMVBlank
            // 
            this.txtMVBlank.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMVBlank.Location = new System.Drawing.Point(191, 69);
            this.txtMVBlank.Name = "txtMVBlank";
            this.txtMVBlank.Size = new System.Drawing.Size(65, 20);
            this.txtMVBlank.TabIndex = 237;
            this.txtMVBlank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMVBlank_KeyDown);
            // 
            // gbMV
            // 
            this.gbMV.Controls.Add(this.txtMVBlank);
            this.gbMV.Controls.Add(this.btnMVOne);
            this.gbMV.Controls.Add(this.btnMVFive);
            this.gbMV.Controls.Add(this.txtMVZero);
            this.gbMV.Controls.Add(this.txtMVSet);
            this.gbMV.Controls.Add(this.txtMVValue);
            this.gbMV.Controls.Add(this.txtMVAdrs);
            this.gbMV.Controls.Add(this.label14);
            this.gbMV.Controls.Add(this.label15);
            this.gbMV.Controls.Add(this.label20);
            this.gbMV.Location = new System.Drawing.Point(647, 41);
            this.gbMV.Name = "gbMV";
            this.gbMV.Size = new System.Drawing.Size(281, 100);
            this.gbMV.TabIndex = 252;
            this.gbMV.TabStop = false;
            this.gbMV.Text = "MV";
            // 
            // txtOPStatus
            // 
            this.txtOPStatus.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtOPStatus.Location = new System.Drawing.Point(592, 6);
            this.txtOPStatus.Name = "txtOPStatus";
            this.txtOPStatus.Size = new System.Drawing.Size(79, 20);
            this.txtOPStatus.TabIndex = 244;
            this.txtOPStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOPStatus_KeyDown);
            // 
            // btnOPSet
            // 
            this.btnOPSet.Location = new System.Drawing.Point(677, 5);
            this.btnOPSet.Name = "btnOPSet";
            this.btnOPSet.Size = new System.Drawing.Size(55, 23);
            this.btnOPSet.TabIndex = 245;
            this.btnOPSet.Text = "OP Set";
            this.btnOPSet.UseVisualStyleBackColor = true;
            this.btnOPSet.Click += new System.EventHandler(this.btnOPSet_Click);
            // 
            // txtCLAdrs
            // 
            this.txtCLAdrs.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCLAdrs.Location = new System.Drawing.Point(738, 6);
            this.txtCLAdrs.Name = "txtCLAdrs";
            this.txtCLAdrs.ReadOnly = true;
            this.txtCLAdrs.Size = new System.Drawing.Size(102, 20);
            this.txtCLAdrs.TabIndex = 246;
            // 
            // btnCLStatus
            // 
            this.btnCLStatus.Location = new System.Drawing.Point(846, 5);
            this.btnCLStatus.Name = "btnCLStatus";
            this.btnCLStatus.Size = new System.Drawing.Size(55, 23);
            this.btnCLStatus.TabIndex = 247;
            this.btnCLStatus.Text = "On/ Off";
            this.btnCLStatus.UseVisualStyleBackColor = true;
            this.btnCLStatus.Click += new System.EventHandler(this.btnCLStatus_Click);
            // 
            // btnTuning
            // 
            this.btnTuning.Location = new System.Drawing.Point(930, 5);
            this.btnTuning.Name = "btnTuning";
            this.btnTuning.Size = new System.Drawing.Size(55, 23);
            this.btnTuning.TabIndex = 248;
            this.btnTuning.Text = "Tuning";
            this.btnTuning.UseVisualStyleBackColor = true;
            this.btnTuning.Click += new System.EventHandler(this.btnTuning_Click);
            // 
            // txtTag
            // 
            this.txtTag.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTag.Location = new System.Drawing.Point(5, 6);
            this.txtTag.Name = "txtTag";
            this.txtTag.ReadOnly = true;
            this.txtTag.Size = new System.Drawing.Size(79, 20);
            this.txtTag.TabIndex = 239;
            // 
            // txtAmAdrs
            // 
            this.txtAmAdrs.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAmAdrs.Location = new System.Drawing.Point(300, 6);
            this.txtAmAdrs.Name = "txtAmAdrs";
            this.txtAmAdrs.ReadOnly = true;
            this.txtAmAdrs.Size = new System.Drawing.Size(117, 20);
            this.txtAmAdrs.TabIndex = 241;
            // 
            // btnAMStatus
            // 
            this.btnAMStatus.Location = new System.Drawing.Point(423, 5);
            this.btnAMStatus.Name = "btnAMStatus";
            this.btnAMStatus.Size = new System.Drawing.Size(55, 23);
            this.btnAMStatus.TabIndex = 242;
            this.btnAMStatus.Text = "On/ Off";
            this.btnAMStatus.UseVisualStyleBackColor = true;
            this.btnAMStatus.Click += new System.EventHandler(this.btnAMStatus_Click);
            // 
            // txtOPAdrs
            // 
            this.txtOPAdrs.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtOPAdrs.Location = new System.Drawing.Point(484, 6);
            this.txtOPAdrs.Name = "txtOPAdrs";
            this.txtOPAdrs.ReadOnly = true;
            this.txtOPAdrs.Size = new System.Drawing.Size(102, 20);
            this.txtOPAdrs.TabIndex = 243;
            // 
            // txtStr2
            // 
            this.txtStr2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtStr2.Location = new System.Drawing.Point(189, 6);
            this.txtStr2.Name = "txtStr2";
            this.txtStr2.ReadOnly = true;
            this.txtStr2.Size = new System.Drawing.Size(105, 20);
            this.txtStr2.TabIndex = 249;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMV);
            this.Controls.Add(this.gbPV);
            this.Controls.Add(this.gbSV);
            this.Controls.Add(this.txtStr2);
            this.Controls.Add(this.btnTuning);
            this.Controls.Add(this.btnCLStatus);
            this.Controls.Add(this.txtCLAdrs);
            this.Controls.Add(this.btnOPSet);
            this.Controls.Add(this.txtOPStatus);
            this.Controls.Add(this.txtOPAdrs);
            this.Controls.Add(this.btnAMStatus);
            this.Controls.Add(this.txtAmAdrs);
            this.Controls.Add(this.txtStr1);
            this.Controls.Add(this.txtTag);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(988, 147);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.gbSV.ResumeLayout(false);
            this.gbSV.PerformLayout();
            this.gbPV.ResumeLayout(false);
            this.gbPV.PerformLayout();
            this.gbMV.ResumeLayout(false);
            this.gbMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtStr1;
        private System.Windows.Forms.Button btnSVOne;
        private System.Windows.Forms.TextBox txtSVBlank;
        private System.Windows.Forms.GroupBox gbSV;
        private System.Windows.Forms.Button btnSVFive;
        private System.Windows.Forms.Button btnSVZero;
        private System.Windows.Forms.Button btnSVSet;
        private System.Windows.Forms.TextBox txtSVValue;
        public System.Windows.Forms.TextBox txtSVAdrs;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbPV;
        private System.Windows.Forms.TextBox txtPVBlank;
        private System.Windows.Forms.Button btnPVOne;
        private System.Windows.Forms.Button btnPVFive;
        private System.Windows.Forms.Button btnPVZero;
        private System.Windows.Forms.Button txtPVSet;
        private System.Windows.Forms.TextBox txtPVValue;
        public System.Windows.Forms.TextBox txtPVAdrs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtMVAdrs;
        private System.Windows.Forms.TextBox txtMVValue;
        private System.Windows.Forms.Button txtMVSet;
        private System.Windows.Forms.Button txtMVZero;
        private System.Windows.Forms.Button btnMVFive;
        private System.Windows.Forms.Button btnMVOne;
        private System.Windows.Forms.TextBox txtMVBlank;
        private System.Windows.Forms.GroupBox gbMV;
        private System.Windows.Forms.TextBox txtOPStatus;
        private System.Windows.Forms.Button btnOPSet;
        public System.Windows.Forms.TextBox txtCLAdrs;
        private System.Windows.Forms.Button btnCLStatus;
        private System.Windows.Forms.Button btnTuning;
        public System.Windows.Forms.TextBox txtTag;
        public System.Windows.Forms.TextBox txtAmAdrs;
        private System.Windows.Forms.Button btnAMStatus;
        public System.Windows.Forms.TextBox txtOPAdrs;
        public System.Windows.Forms.TextBox txtStr2;
        private System.Windows.Forms.ErrorProvider errorProvider1;


    }
}
