using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo_Deducciones
{
    public partial class TasasEdit : Form
    {
        public TasasEdit()
        {
            InitializeComponent();
        }

        private void TasasEdit_Load(object sender, EventArgs e)
        {

        }

        private void txtEditAFP_TextChanged(object sender, EventArgs e)
        {
            Class1.vAFPEdit = float.Parse(txtEditAFP.Text)/100;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.vSFSEdit = float.Parse(txtEditSFS.Text)/100;
            
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.lblAFP.Text = Class1.vAFPEdit.ToString();
            f.lblSFS.Text = Class1.vSFSEdit.ToString();
            this.Close();
        }
    }
}
