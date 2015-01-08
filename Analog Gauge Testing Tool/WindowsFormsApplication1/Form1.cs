using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpcRcw.Da;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DxpSimpleAPI.DxpSimpleClass opc = new DxpSimpleAPI.DxpSimpleClass();
        List<string[]> list = new List<string[]>();
        public Dictionary<string, GAddress> gAdrs = new Dictionary<string, GAddress>();
        List<string> tag = new List<string> { };
        List<string> str1 = new List<string> { };
        List<string> str2 = new List<string> { };
        List<string> amAdrs = new List<string> { };
        List<string> opAdrs = new List<string> { };
        List<string> clAdrs = new List<string> { };
        List<string> svAdrs = new List<string> { };
        List<string> pvAdrs = new List<string> { };
        List<string> mvAdrs = new List<string> { };
        List<string> listSearch = new List<string> { };
        public Form1()
        {
            InitializeComponent();
        }
        public string _userNo;
        public string userNo
        {
            get
            {
                return txtSearch.Text;
            }
            set
            {
                txtSearch.Text = value;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnListRefresh_Click(object sender, EventArgs e)
        {
            cmbServerList.Items.Clear();
            string[] ServerNameArray;
            opc.EnumServerList(txtNode.Text, out ServerNameArray);

            for (int a = 0; a < ServerNameArray.Count<string>(); a++)
            {
                cmbServerList.Items.Add(ServerNameArray[a]);
            }
            cmbServerList.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0) { 
                if (opc.Connect(txtNode.Text, cmbServerList.Text))
                {
                    Debug.WriteLine("Connected");
                    btnDisconnect.Enabled = true;
                    btnConnect.Enabled = false;
                    btnListRefresh.Enabled = false;

                    loadValues();
                }
            }
        }

        private void loadValues()
        {
            for (int a = 0; a < panel1.Controls.Count; a++)
            {
                UserControl1 uc = panel1.Controls[a] as UserControl1;
                string[] target = new string[]{uc.AMAdrsText, uc.OPAdrsText, 
                                               uc.CLAdrsText, uc.SVAdrsText, 
                                               uc.PVAdrsText, uc.MVAdrsText};
                object[] val;
                short[] quality;
                FILETIME[] ft;
                int[] error;
                if (opc.Read(target, out val, out quality, out ft, out error))
                {
                    string readValAM = ReadVal(val[0], error[0]);
                    string readValOP = ReadVal(val[1], error[1]);
                    string readValCL = ReadVal(val[2], error[2]);

                    uc.SVVal = ReadVal(val[3], error[3]);
                    uc.PVVal = ReadVal(val[4], error[4]);
                    uc.MVVal = ReadVal(val[5], error[5]);
                    if (readValAM == "False")
                    {
                        uc.AMStat = "Off";
                    }
                    else
                    {
                        uc.AMStat = "On";
                    }
                    if (readValCL == "False")
                    {
                        uc.CLStat = "Off";
                    }
                    else
                    {
                        uc.CLStat = "On";
                    }
                    if (readValOP == "0")
                    {
                        uc.OPStat = "None";
                    }
                    else if (readValOP == "1")
                    {
                        uc.OPStat = "Prohibition";
                    }
                    else if (readValOP == "2")
                    {
                        uc.OPStat = "Maintenance";
                    }
                    else if (readValOP == "3")
                    {
                        uc.OPStat = "Broke";
                    }
                }
            }
        }

        private string ReadVal(object val, int err)
        {
            if (err != 0)
            {
                return "Read Error";
            }
            return val.ToString();
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (opc.Disconnect())
            {
                Debug.WriteLine("Disconnected");
                btnConnect.Enabled = true;
                btnListRefresh.Enabled = true;
                btnDisconnect.Enabled = false;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                panel1.Controls.Clear();
                list.Clear();
                using (TextFieldParser parser = new TextFieldParser(openFileDialog1.FileName))
                {
                    parser.Delimiters = new string[] { "," };
                    //bool st = false;
                    while (true)
                    {
                        string[] parts = parser.ReadFields();
                        if (parts == null)
                        {
                            break;
                        }
                        try 
                        { 
                            if (parts[95] == "0")
                            {
                                list.Add(parts);
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    if(list.Count > 0)
                    {
                        gAdrs.Clear();
                        progressBar1.Visible = true;
                        progressBar1.Maximum = list.Count;
                        for(int a = 0; a < list.Count; a++)
                        {
                            try 
                            { 
                                using (TextFieldParser tfp = new TextFieldParser(Path.GetDirectoryName(openFileDialog1.FileName) + "\\GAddress.csv"))
                                {
                                    tfp.Delimiters = new string[] { "," };
                                    Regex reg = new Regex(@"\(" + list[a][0].ToString() + @"\)");
                                    while (true) { 
                                        string[] part = tfp.ReadFields();
                                        if (part == null)
                                        {
                                            break;
                                        }
                                        Match m=reg.Match(part[0].ToString());
                                        if (m.Success)
                                        {
                                            gAdrs.Add(part[0], new GAddress
                                            {
                                                value1 = part,
                                            });
                                        }
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Cannot locate GAddress.csv");
                                break;
                            }
                            progressBar1.Value = a + 1;
                        }
                    }
                    tag.Clear();
                    str1.Clear();
                    str2.Clear();
                    amAdrs.Clear();
                    clAdrs.Clear();
                    opAdrs.Clear();
                    svAdrs.Clear();
                    pvAdrs.Clear();
                    mvAdrs.Clear();
                    if (list.Count > 0 && gAdrs.Count > 0)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            List<string[]> var = new List<string[]>();
                            
                            UserControl1 uc = new UserControl1(opc);
                            uc.Location = new Point(0, 147 * (j));

                            panel1.Controls.Add(uc);
                            uc.tagText = list[j][0]; tag.Add(list[j][0]);
                            uc.str1Text = list[j][1]; str1.Add(list[j][1]);
                            uc.str2Text = list[j][2]; str2.Add(list[j][2]);
                            uc.OPAdrsText = list[j][119]; opAdrs.Add(list[j][119]);
                            progressBar1.Value = j + 1;
                            if (gAdrs.ContainsKey("AM(" + list[j][0] + ")"))
                            {
                                uc.AMAdrsText = gAdrs["AM(" + list[j][0] + ")"].value1[1]; amAdrs.Add(gAdrs["AM(" + list[j][0] + ")"].value1[1]);
                            }
                            if (gAdrs.ContainsKey("CL(" + list[j][0] + ")"))
                            {
                                uc.CLAdrsText = gAdrs["CL(" + list[j][0] + ")"].value1[1]; clAdrs.Add(gAdrs["CL(" + list[j][0] + ")"].value1[1]);
                            }
                            if (gAdrs.ContainsKey("SV(" + list[j][0] + ")"))
                            {
                                uc.SVAdrsText = gAdrs["SV(" + list[j][0] + ")"].value1[1]; svAdrs.Add(gAdrs["SV(" + list[j][0] + ")"].value1[1]);
                            }
                            if (gAdrs.ContainsKey("PV(" + list[j][0] + ")"))
                            {
                                uc.PVAdrsText = gAdrs["PV(" + list[j][0] + ")"].value1[1]; pvAdrs.Add(gAdrs["PV(" + list[j][0] + ")"].value1[1]);
                            }
                            if (gAdrs.ContainsKey("MV(" + list[j][0] + ")"))
                            {
                                uc.MVAdrsText = gAdrs["MV(" + list[j][0] + ")"].value1[1]; mvAdrs.Add(gAdrs["MV(" + list[j][0] + ")"].value1[1]);
                            }
                            string[] initials = new string[] { "P", "I", "D", "MH", "ML", "PH", "PL", "T", "ST", "K0", 
                                                               "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "KA", 
                                                               "KB", "KC", "KD", "KE", "KF"};
                            uc.var.Clear();
                            for (int a = 0; a < initials.Length; a++)
                            {
                                if (gAdrs.ContainsKey(initials[a] + "(" + list[j][0] + ")"))
                                {
                                    uc.var.Add(gAdrs[initials[a] + "(" + list[j][0] + ")"].value1);
                                }
                                else
                                {
                                    uc.var.Add(new string[] { "0" });
                                }
                            }
                            
                        }
                        txtSearch.Enabled = true;
                        btnSearch.Enabled = true;
                    }
                    else
                    {
                        Label lbl = new Label();
                        lbl.Location = new Point(0,20);
                        lbl.Width = 200;
                        lbl.Text = "There are no items on the list";
                        panel1.Controls.Add(lbl);
                        txtSearch.Enabled = false;
                        btnSearch.Enabled = false;
                    }
                    progressBar1.Visible = false;
                }
             }
        }

        public void showUserControl(string tagText)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(txtSearch.Text.Replace(@"\",@"\\")
                                                .Replace("(", "\\(")
                                                .Replace("$", "\\$")
                                                .Replace("|", "\\|")
                                                .Replace("^", "\\^")
                                                .Replace("[", "\\[")
                                                .Replace(")", "\\)")
                                                .Replace("*", "\\*"), RegexOptions.IgnoreCase);
            listSearch.Clear();
            for (int c = 0; c < list.Count; c++)
            {
                UserControl1 uc = panel1.Controls[c] as UserControl1;
                uc.txtTag.BackColor = SystemColors.Control;
                uc.txtStr1.BackColor = SystemColors.Control;
                uc.txtStr2.BackColor = SystemColors.Control;
                uc.txtAmAdrs.BackColor = SystemColors.Control;
                uc.txtOPAdrs.BackColor = SystemColors.Control;
                uc.txtCLAdrs.BackColor = SystemColors.Control;
                uc.txtSVAdrs.BackColor = SystemColors.Control;
                uc.txtPVAdrs.BackColor = SystemColors.Control;
                uc.txtMVAdrs.BackColor = SystemColors.Control;
            }
            if (txtSearch.Text != "")
            {
                for (int c = 0; c < list.Count; c++)
                {
                    UserControl1 uc = panel1.Controls[c] as UserControl1;
                    Match tags = reg.Match(tag[c]);
                    if (tags.Success)
                    {
                        uc.txtTag.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match insOne = reg.Match(str1[c]);
                    if (insOne.Success)
                    {
                        uc.txtStr1.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match insTwo = reg.Match(str2[c]);
                    if (insTwo.Success)
                    {
                        uc.txtStr2.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match am = reg.Match(amAdrs[c]);
                    if (am.Success)
                    {
                        uc.txtAmAdrs.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match op = reg.Match(opAdrs[c]);
                    if (op.Success)
                    {
                        uc.txtOPAdrs.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match cl = reg.Match(clAdrs[c]);
                    if (cl.Success)
                    {
                        uc.txtCLAdrs.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match sv = reg.Match(svAdrs[c]);
                    if (sv.Success)
                    {
                        uc.txtSVAdrs.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match pv = reg.Match(pvAdrs[c]);
                    if (pv.Success)
                    {
                        uc.txtPVAdrs.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                    Match mv = reg.Match(mvAdrs[c]);
                    if (mv.Success)
                    {
                        uc.txtMVAdrs.BackColor = Color.Pink;
                        listSearch.Add(c.ToString());
                    }
                }

                if (listSearch.Count > 0)
                {
                    panel1.VerticalScroll.Value = (Convert.ToInt32(listSearch[0]) * 147);
                    lblResult.Text = "There are " + listSearch.Count + " results on " + txtSearch.Text;
                }
                else
                {
                    lblResult.Text = "There are no results for " + txtSearch.Text + " !!!";
                }
            }
        }
    }

    public class GAddress
    {
        public string[] value1 { get; set; }
    }

}
