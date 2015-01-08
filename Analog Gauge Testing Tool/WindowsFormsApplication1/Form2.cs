using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpcRcw.Da;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        DxpSimpleAPI.DxpSimpleClass opc;
        List<string[]> var = new List<string[]>();
        public Form2(DxpSimpleAPI.DxpSimpleClass opc,  List<string[]> variable)
        {
            InitializeComponent();
            this.opc = opc;
            this.var = variable;
            string[] initials = new string[] { "P", "I", "D", "MH", "ML", "PH", "PL", "T", "ST",
                                               "K0", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K8", 
                                               "K9", "KA", "KB", "KC", "KD", "KE", "KF"};
            int b=0;
            for (int a = 0; a < initials.Length; a++)
            {
                if (var[a][0] != "0")
                {
                    ucTuning uc = new ucTuning(opc);
                    uc.Location = new Point(0, 29 * b);
                    uc.reg = var[a][1];
                    uc.initial = initials[a];
                    panel1.Controls.Add(uc);
                    b++;
                }
            }
            
            for (int a = 0; a < panel1.Controls.Count; a++)
            {
                ucTuning uc = panel1.Controls[a] as ucTuning;

                string[] target = new string[] { uc.reg };
                object[] val;
                short[] quality;
                FILETIME[] ft;
                int[] error;
                if (opc.Read(target, out val, out quality, out ft, out error))
                {
                    if (error[0] != 0) { return; }
                    uc.val = val[0].ToString();
                }
            }
        }
    }

}
