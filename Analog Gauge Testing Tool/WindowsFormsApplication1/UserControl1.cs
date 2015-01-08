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
    public partial class UserControl1 : UserControl
    {
        DxpSimpleAPI.DxpSimpleClass opc;
        int SVMin = Properties.Settings.Default.SVMinimum;
        int SVMax = Properties.Settings.Default.SVMaximum;
        int PVMin = Properties.Settings.Default.PVMinimum;
        int PVMax = Properties.Settings.Default.PVMaximum;
        int MVMin = Properties.Settings.Default.MVMimimum;
        int MVMax = Properties.Settings.Default.MVMaximum;
        public List<string[]> var=new List<string[]>();
        public UserControl1(DxpSimpleAPI.DxpSimpleClass opc)
        {
            this.opc = opc;
            InitializeComponent();
        }

        public int _controlNum;
        public int controlNum
        {
            get
            {
                return _controlNum;
            }
            set
            {
                _controlNum = value;
            }
        }
        public string tagText
        {
            get
            {
                return this.txtTag.Text;
            }
            set
            {
                txtTag.Text = value;
            }
        }

        public string str1Text
        {
            get
            {
                return this.txtStr1.Text;
            }
            set
            {
                txtStr1.Text = value;
            }
        }

        public string str2Text
        {
            get
            {
                return this.txtStr2.Text;
            }
            set
            {
                txtStr2.Text = value;
            }
        }

        public string tuning
        {
            get
            {
                return this.btnTuning.Tag.ToString();
            }
            set
            {
                this.btnTuning.Tag = value;
            }
        }
        public string AMAdrsText
        {
            get
            {
                return this.txtAmAdrs.Text;
            }
            set
            {
                txtAmAdrs.Text = value;
            }
        }

        public string AMStat
        {
            get
            {
                return btnAMStatus.Text;
            }
            set
            {
                btnAMStatus.Text = value;
            }
        }
        public string OPAdrsText
        {
            get
            {
                return this.txtOPAdrs.Text;
            }
            set
            {
                txtOPAdrs.Text = value;
            }
        }


        public string OPStat
        {
            get
            {
                return txtOPStatus.Text;
            }
            set
            {
                txtOPStatus.Text = value;
            }
        }
        public string CLAdrsText
        {
            get
            {
                return this.txtCLAdrs.Text;
            }
            set
            {
                txtCLAdrs.Text = value;
            }
        }


        public string CLStat
        {
            get
            {
                return btnCLStatus.Text;
            }
            set
            {
                btnCLStatus.Text = value;
            }
        }
        public string SVAdrsText
        {
            get
            {
                return this.txtSVAdrs.Text;
            }
            set
            {
                txtSVAdrs.Text = value;
            }
        }

        public string SVVal
        {
            get
            {
                return txtSVValue.Text;
            }
            set
            {
                txtSVValue.Text = value;
            }
        }
        public string PVAdrsText
        {
            get
            {
                return this.txtPVAdrs.Text;
            }
            set
            {
                txtPVAdrs.Text = value;
            }
        }

        public string PVVal
        {
            get
            {
                return txtPVValue.Text;
            }
            set
            {
                txtPVValue.Text = value;
            }
        }
        public string MVAdrsText
        {
            get
            {
                return this.txtMVAdrs.Text;
            }
            set
            {
                txtMVAdrs.Text = value;
            }
        }

        public string MVVal
        {
            get
            {
                return txtMVValue.Text;
            }
            set
            {
                txtMVValue.Text = value;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnSVZero_Click(object sender, EventArgs e)
        {
            valueWrite(0, txtSVAdrs.Text, "SV");
        }
        public void valueWrite(int value, string targetReg, string sender)
        {
            string[] target = new string[] { targetReg };
            object[] val = new object[] { value };
            int[] error;
            if (opc.Write(target, val, out error))
            {
                if (sender == "SV") 
                {
                    txtSVValue.Text = value.ToString();
                }
                else if (sender == "PV")
                {
                    txtPVValue.Text = value.ToString();
                }
                else if (sender == "MV")
                {
                    txtMVValue.Text = value.ToString();
                }
            }
        }

        private void btnPVZero_Click(object sender, EventArgs e)
        {
            valueWrite(0, txtPVAdrs.Text, "PV");
        }

        private void txtMVZero_Click(object sender, EventArgs e)
        {
            valueWrite(0, txtMVAdrs.Text, "MV");
        }

        private void btnSVFive_Click(object sender, EventArgs e)
        {
            valueWrite(5000, txtSVAdrs.Text, "SV");
        }

        private void btnPVFive_Click(object sender, EventArgs e)
        {
            valueWrite(5000, txtPVAdrs.Text, "PV");

        }

        private void btnMVFive_Click(object sender, EventArgs e)
        {

            valueWrite(5000, txtMVAdrs.Text, "MV");
        }

        private void btnSVOne_Click(object sender, EventArgs e)
        {

            valueWrite(10000, txtSVAdrs.Text, "SV");
        }

        private void btnPVOne_Click(object sender, EventArgs e)
        {
            valueWrite(10000, txtPVAdrs.Text, "PV");
        }

        private void btnMVOne_Click(object sender, EventArgs e)
        {
            valueWrite(10000, txtMVAdrs.Text, "MV");
        }

        private void btnSVSet_Click(object sender, EventArgs e)
        {
            sv();
            
        }

        private void sv()
        {
            int val;
            if (Int32.TryParse(txtSVBlank.Text, out val))
            {
                if (val >= SVMin && val <= SVMax)
                {
                    valueWrite(Convert.ToInt32(txtSVBlank.Text), txtSVAdrs.Text, "SV");
                    errorProvider1.SetError(txtSVBlank, "");
                }
                else
                {
                    errorProvider1.SetError(txtSVBlank, "Limit is " + SVMin + " to " + SVMax);
                }
            }
            else if (txtSVBlank.Text == "")
            {
                errorProvider1.SetError(txtSVBlank, "");
            }
            else
            {
                errorProvider1.SetError(txtSVBlank, "Limit is " + SVMin + " to " + SVMax);
            }
        }

        private void txtPVSet_Click(object sender, EventArgs e)
        {
            pv();
        }

        private void pv()
        {
            int val;
            if (Int32.TryParse(txtPVBlank.Text, out val))
            {
                if (val >= PVMin && val <= PVMax)
                {
                    valueWrite(Convert.ToInt32(txtPVBlank.Text), txtPVAdrs.Text, "PV");
                    errorProvider1.SetError(txtPVBlank, "");
                }
                else
                {

                    errorProvider1.SetError(txtPVBlank, "Limit is " + PVMin + " to " + PVMax);
                }
            }
            else if (txtPVBlank.Text == "")
            {
                errorProvider1.SetError(txtPVBlank, "");
            }
            else
            {

                errorProvider1.SetError(txtPVBlank, "Limit is " + PVMin + " to " + PVMax);
            }
        }

        private void txtMVSet_Click(object sender, EventArgs e)
        {
            mv();
        }

        private void mv()
        {
            int val;
            if (Int32.TryParse(txtMVBlank.Text, out val))
            {
                if (val >= MVMin && val <= MVMax)
                {
                    valueWrite(Convert.ToInt32(txtMVBlank.Text), txtMVAdrs.Text, "MV");
                    errorProvider1.SetError(txtMVBlank, "");
                }
                else
                {
                    errorProvider1.SetError(txtMVBlank, "Limit is " + MVMin + " to " + MVMax);
                }
            }
            else if (txtMVBlank.Text == "")
            {
                errorProvider1.SetError(txtMVBlank, "");
            }
            else
            {
                errorProvider1.SetError(txtMVBlank, "Limit is " + MVMin + " to " + MVMax);
            }
        }

        private void btnOPSet_Click(object sender, EventArgs e)
        {
            opSet();
        }

        private void opSet()
        {
            int value;
            if ((txtOPStatus.Text == "0") || (txtOPStatus.Text.ToLower() == "none"))
            {
                value = 0;
            }
            else if ((txtOPStatus.Text == "1") || (txtOPStatus.Text.ToLower() == "prohibition"))
            {
                value = 1;
            }
            else if ((txtOPStatus.Text == "2") || (txtOPStatus.Text.ToLower() == "maintenance"))
            {
                value = 2;
            }
            else if ((txtOPStatus.Text == "3") || (txtOPStatus.Text.ToLower() == "broke"))
            {
                value = 3;
            }
            else
            {
                errorProvider1.SetError(txtOPStatus, "Value must be from 0-3 only");
                return;
            }
            errorProvider1.SetError(txtOPStatus, "");
            OpcOnOff(txtOPAdrs.Text, value, btnOPSet);
        }
        public void OpcOnOff(string addr, int value, Button btn)
        {
            string[] target = new string[] { addr };
            object[] val = new object[] { value };
            int[] error;
            if (opc.Write(target, val, out error))
            {
                Debug.WriteLine("Write succeed");
                object[] valueRead;
                short[] quality;
                FILETIME[] filetime;

                if (opc.Read(target, out valueRead, out quality, out filetime, out error))
                {
                    string op = ReadVal(valueRead[0], error[0]);
                    if (btn == btnOPSet)
                    {
                        if (op == "0")
                        {
                            txtOPStatus.Text = "None";
                        }
                        else if (op == "1")
                        {
                            txtOPStatus.Text = "Prohibition";
                        }
                        else if (op == "2")
                        {
                            txtOPStatus.Text = "Maintenance";
                        }
                        else if (op == "3")
                        {
                            txtOPStatus.Text = "Broke";
                        }
                    }
                    else if (btn == btnCLStatus)
                    {
                        if (op == "False")
                        {
                            btn.Text = "Off";
                        }
                        else
                        {
                            btn.Text = "On";
                        }
                    }
                    else if (btn == btnAMStatus)
                    {
                        if (op == "False")
                        {
                            btn.Text = "Off";
                        }
                        else
                        {
                            btn.Text = "On";
                        }
                    }
                }
            }
        }

        private void btnCLStatus_Click(object sender, EventArgs e)
        {
            int value;
            if (btnCLStatus.Text == "On")
            {
                value = 0;
            }
            else
            {
                value = -1;
            }
            OpcOnOff(txtCLAdrs.Text, value, btnCLStatus);
        }

        private void btnAMStatus_Click(object sender, EventArgs e)
        {
            int value;
            if (btnAMStatus.Text == "On")
            {
                value = 0;
            }
            else
            {
                value = -1;
            }
            OpcOnOff(txtAmAdrs.Text, value, btnAMStatus);
        }

        private void btnTuning_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(opc, this.var);
            f2.ShowDialog();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private string ReadVal(object val, int err)
        {
            if (err != 0)
            {
                return "Read Error";
            }
            return val.ToString();
        }

        private void txtSVBlank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sv();
            }
        }

        private void txtPVBlank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pv();
            }
        }

        private void txtMVBlank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mv();
            }
        }

        private void txtSVBlank_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOPStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                opSet();
            }
        }
    }
}
