using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpcRcw.Da;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class ucTuning : UserControl
    {
        DxpSimpleAPI.DxpSimpleClass opc;
        int tuningMax = Properties.Settings.Default.tuningMaximum;
        int tuningMin = Properties.Settings.Default.tuningMinimum;
        public ucTuning(DxpSimpleAPI.DxpSimpleClass opc)
        {
            InitializeComponent();
            this.opc = opc;
        }
        public string initial
        {
            get
            {
                return this.lblInitial.Text;
            }
            set
            {
                lblInitial.Text = value;
            }
        }

        public string reg
        {
            get
            {
                return txtTag.Text;
            }
            set
            {
                txtTag.Text = value;
            }
        }

        public string val
        {
            get
            {
                return txtReadVal.Text;
            }
            set
            {
                txtReadVal.Text = value;
            }
        }
        private void ucTuning_Load(object sender, EventArgs e)
        {

        }

        private void btnSVZero_Click(object sender, EventArgs e)
        {
            Analog(0);
        }
        public void Analog(int value)
        {
            string[] target=new string[]{txtTag.Text};
            object[] val=new object[]{value};
            int[] error;
            try { 
                if (opc.Write(target, val, out error))
                {
                    object[] valRead;
                    short[] quality;
                    FILETIME[] ft; 
                    Debug.WriteLine("Succeed writing " + txtTag.Text + " to OPC Server");
                    if (opc.Read(target, out valRead, out quality, out ft, out error))
                    {
                        txtReadVal.Text = valRead[0].ToString();
                        Debug.WriteLine("Succeed reading " + txtTag.Text + " to OPC Server");
                    }
                }
                else
                {
                    Debug.WriteLine("Error writing " + txtTag.Text + " to OPC Server");
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Error writing/ reading " + txtTag.Text + " to OPC Server");
            }
        }

        private void btnSVFive_Click(object sender, EventArgs e)
        {
            Analog(5000);
        }

        private void btnSVOne_Click(object sender, EventArgs e)
        {
            Analog(10000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tuning();
        }

        private void tuning()
        {
            int a;
            if (Int32.TryParse(txtVal.Text, out a))
            {
                if (a >= tuningMin && a <= tuningMax)
                {
                    Analog(a);
                    errorProvider1.SetError(txtVal, "");
                }
                else
                {
                    errorProvider1.SetError(txtVal, "Limit is " + tuningMin + " to " + tuningMax);
                }
            }
            else if (txtVal.Text == "")
            {
                errorProvider1.SetError(txtVal, "");
            }
            else
            {
                errorProvider1.SetError(txtVal, "Limit is " + tuningMin + " to " + tuningMax);
            }
        }

        private void txtVal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tuning();
            }
        }
    }
}
