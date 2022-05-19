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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void txtSueldoBruto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblAFPDeduccion.Text = "";
            lblISRDeduccion.Text = "";
            lblSFSDeduccion.Text = "";
            lblSueldoNeto.Text = "";
            lblDivisa.Text = "";
               
        }

        private void RD_Click(object sender, EventArgs e)
        {
            lblDivisa.Text = "RD$";
            lblAFP.Text = (Class1.vAFPEdit*100).ToString() + "%";
            lblSFS.Text = (Class1.vSFSEdit*100).ToString() + "%";
            lblISR.Text = "0% - 25%";
        }


       
        private void US_Click(object sender, EventArgs e)
        {
            lblDivisa.Text = "US$";
            lblAFP.Text = (Class1.vAFPEdit * 100).ToString() + "%";
            lblSFS.Text = (Class1.vSFSEdit * 100).ToString() + "%";
            lblISR.Text = "0% - 25%";
            

        }

        private void EUR_Click(object sender, EventArgs e)
        {
            lblDivisa.Text = "EUR€";
            lblAFP.Text = (Class1.vAFPEdit * 100).ToString() + "%";
            lblSFS.Text = (Class1.vSFSEdit * 100).ToString() + "%";
            lblISR.Text = "0% - 25%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deducciones();
        }

        public void Deducciones()
        {
            float vSueldoBruto, vSueldoNeto, vAFP, vSFS, vSueldoDescontado, vSueldoAnual,vConversion, vISR;
            string vDivisa = lblDivisa.Text;

            vSueldoBruto = float.Parse(txtSueldoBruto.Text);

            
            vAFP = vSueldoBruto * Class1.vAFPEdit;
            vSFS = vSueldoBruto * Class1.vSFSEdit;
            lblAFPDeduccion.Text = vAFP.ToString() + vDivisa;
            lblSFSDeduccion.Text = vSFS.ToString() + vDivisa;

            vSueldoDescontado = vSueldoBruto - (vAFP + vSFS);

            if (lblDivisa.Text == "RD$")
            {
                
                vConversion = 1;
                vSueldoAnual = vSueldoDescontado * 12;
            }

            else
            {
                if (lblDivisa.Text == "US$")
                {
                     
                    vConversion = 55;
                    vSueldoAnual = (vSueldoDescontado * 12) * vConversion;
                }
                else
                {
                    if (lblDivisa.Text == "EUR€")
                    {
                        vConversion = 57.56f;
                        vSueldoAnual = (vSueldoDescontado * 12) * vConversion;
                    }
                    else
                    {
                        vConversion = 0;
                        vSueldoAnual = 0;
                    }
                    
                }
            }

            
            
            if (vSueldoAnual <= 466220.00f)
            {
                vSueldoNeto = vSueldoDescontado;
                vISR = 0;
                
                lblISR.Text = "0%";
                lblISRDeduccion.Text = vISR.ToString() + vDivisa;
                lblSueldoNeto.Text = vSueldoNeto.ToString() + vDivisa;

            }

            else
            {
                if (vSueldoAnual >= 466220.01f && vSueldoAnual <= 624329.00f)
                {
                    vISR = (vSueldoAnual - 466220.01f) * 0.15f;
                    vISR = (vISR / 12)/vConversion;
                    vSueldoNeto = vSueldoDescontado - vISR;
                    
                    lblISR.Text = "15%";
                    lblISRDeduccion.Text = vISR.ToString() + vDivisa;
                    lblSueldoNeto.Text = vSueldoNeto.ToString() + vDivisa;


                }

                else
                {
                    if (vSueldoAnual >= 624329.01f && vSueldoAnual <= 867123.00f)
                    {
                        vISR = ((vSueldoAnual - 624329.01f) * 0.2f) + 31216;
                        vISR = (vISR / 12) / vConversion;
                        vSueldoNeto = vSueldoDescontado - vISR;
                        
                        lblISR.Text = "20%";
                        lblISRDeduccion.Text = vISR.ToString() + vDivisa;
                        lblSueldoNeto.Text = vSueldoNeto.ToString() + vDivisa;
                    }

                    else
                    {
                        vISR = ((vSueldoAnual - 867123.01f) * 0.25f) + 79776;
                        vISR = (vISR / 12) / vConversion;
                        vSueldoNeto = vSueldoDescontado - vISR;
                        
                        lblISR.Text = "25%";
                        lblISRDeduccion.Text = vISR.ToString() + vDivisa;
                        lblSueldoNeto.Text = vSueldoNeto.ToString() + vDivisa;

                    }
                }
            }

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form vTasasEdit = new TasasEdit();
            vTasasEdit.ShowDialog();
        }

        private void lblAFP_Click(object sender, EventArgs e)
        {

        }

        public static void EditTasas()
        {
            
        }
    }
    
}
