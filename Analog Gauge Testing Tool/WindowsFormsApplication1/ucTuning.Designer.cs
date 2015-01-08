namespace WindowsFormsApplication1
{
    partial class ucTuning
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
            this.txtReadVal = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnSVOne = new System.Windows.Forms.Button();
            this.btnSVFive = new System.Windows.Forms.Button();
            this.btnSVZero = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblInitial = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReadVal
            // 
            this.txtReadVal.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtReadVal.Location = new System.Drawing.Point(132, 4);
            this.txtReadVal.Name = "txtReadVal";
            this.txtReadVal.ReadOnly = true;
            this.txtReadVal.Size = new System.Drawing.Size(83, 20);
            this.txtReadVal.TabIndex = 249;
            // 
            // txtVal
            // 
            this.txtVal.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtVal.Location = new System.Drawing.Point(404, 4);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(65, 20);
            this.txtVal.TabIndex = 248;
            this.txtVal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVal_KeyDown);
            // 
            // btnSVOne
            // 
            this.btnSVOne.Location = new System.Drawing.Point(343, 2);
            this.btnSVOne.Name = "btnSVOne";
            this.btnSVOne.Size = new System.Drawing.Size(55, 23);
            this.btnSVOne.TabIndex = 247;
            this.btnSVOne.Text = "10000";
            this.btnSVOne.UseVisualStyleBackColor = true;
            this.btnSVOne.Click += new System.EventHandler(this.btnSVOne_Click);
            // 
            // btnSVFive
            // 
            this.btnSVFive.Location = new System.Drawing.Point(282, 2);
            this.btnSVFive.Name = "btnSVFive";
            this.btnSVFive.Size = new System.Drawing.Size(55, 23);
            this.btnSVFive.TabIndex = 246;
            this.btnSVFive.Text = "5000";
            this.btnSVFive.UseVisualStyleBackColor = true;
            this.btnSVFive.Click += new System.EventHandler(this.btnSVFive_Click);
            // 
            // btnSVZero
            // 
            this.btnSVZero.Location = new System.Drawing.Point(221, 2);
            this.btnSVZero.Name = "btnSVZero";
            this.btnSVZero.Size = new System.Drawing.Size(55, 23);
            this.btnSVZero.TabIndex = 245;
            this.btnSVZero.Text = "0";
            this.btnSVZero.UseVisualStyleBackColor = true;
            this.btnSVZero.Click += new System.EventHandler(this.btnSVZero_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(475, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 244;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(26, 5);
            this.txtTag.Name = "txtTag";
            this.txtTag.ReadOnly = true;
            this.txtTag.Size = new System.Drawing.Size(100, 19);
            this.txtTag.TabIndex = 243;
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(4, 8);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(12, 12);
            this.lblInitial.TabIndex = 250;
            this.lblInitial.Text = "P";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucTuning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.txtReadVal);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.btnSVOne);
            this.Controls.Add(this.btnSVFive);
            this.Controls.Add(this.btnSVZero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTag);
            this.Name = "ucTuning";
            this.Size = new System.Drawing.Size(554, 29);
            this.Load += new System.EventHandler(this.ucTuning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReadVal;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnSVOne;
        private System.Windows.Forms.Button btnSVFive;
        private System.Windows.Forms.Button btnSVZero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
