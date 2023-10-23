using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_listbox_meyve_sebze_aktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                if (listBox1.Items[i].ToString() == "Elma" ||
                    listBox1.Items[i].ToString() == "Karpuz" ||
                    listBox1.Items[i].ToString() == "Erik")
                {
                    lslMeyve.Items.Add(listBox1.Items[i]);
                }
                else
                    lslSebze.Items.Add(listBox1.Items[i]);
            }

            
        }
    }
}
