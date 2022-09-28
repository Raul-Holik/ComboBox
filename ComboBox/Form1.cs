using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBx_TextChanged(object sender, EventArgs e)
        {
            txtBx.AppendText("Odabrali ste : " + txtBx.Text);
        }
    }
}
