namespace Sueldo_Deducciones
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RD = new System.Windows.Forms.ToolStripMenuItem();
            this.US = new System.Windows.Forms.ToolStripMenuItem();
            this.EUR = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblSFS = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAFPDeduccion = new System.Windows.Forms.Label();
            this.lblSFSDeduccion = new System.Windows.Forms.Label();
            this.lblISRDeduccion = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.lblDivisa = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(734, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 20);
            this.toolStripMenuItem1.Text = "Edicion de Tasas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RD,
            this.US,
            this.EUR});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem2.Text = "Divisa";
            // 
            // RD
            // 
            this.RD.Name = "RD";
            this.RD.Size = new System.Drawing.Size(109, 22);
            this.RD.Text = "RD($)";
            this.RD.Click += new System.EventHandler(this.RD_Click);
            // 
            // US
            // 
            this.US.Name = "US";
            this.US.Size = new System.Drawing.Size(109, 22);
            this.US.Text = "US($)";
            this.US.Click += new System.EventHandler(this.US_Click);
            // 
            // EUR
            // 
            this.EUR.Name = "EUR";
            this.EUR.Size = new System.Drawing.Size(109, 22);
            this.EUR.Text = "EUR(€)";
            this.EUR.Click += new System.EventHandler(this.EUR_Click);
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBruto.Location = new System.Drawing.Point(157, 143);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(100, 25);
            this.txtSueldoBruto.TabIndex = 2;
            this.txtSueldoBruto.TextChanged += new System.EventHandler(this.txtSueldoBruto_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(499, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 79);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(101, 208);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(31, 23);
            this.lblAFP.TabIndex = 14;
            this.lblAFP.Text = "0%";
            this.lblAFP.Click += new System.EventHandler(this.lblAFP_Click);
            // 
            // lblSFS
            // 
            this.lblSFS.AutoSize = true;
            this.lblSFS.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFS.Location = new System.Drawing.Point(242, 208);
            this.lblSFS.Name = "lblSFS";
            this.lblSFS.Size = new System.Drawing.Size(31, 23);
            this.lblSFS.TabIndex = 15;
            this.lblSFS.Text = "0%";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(388, 208);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(31, 23);
            this.lblISR.TabIndex = 16;
            this.lblISR.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 17;
            // 
            // lblAFPDeduccion
            // 
            this.lblAFPDeduccion.AutoSize = true;
            this.lblAFPDeduccion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFPDeduccion.Location = new System.Drawing.Point(69, 277);
            this.lblAFPDeduccion.Name = "lblAFPDeduccion";
            this.lblAFPDeduccion.Size = new System.Drawing.Size(52, 23);
            this.lblAFPDeduccion.TabIndex = 18;
            this.lblAFPDeduccion.Text = "label5";
            // 
            // lblSFSDeduccion
            // 
            this.lblSFSDeduccion.AutoSize = true;
            this.lblSFSDeduccion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFSDeduccion.Location = new System.Drawing.Point(205, 277);
            this.lblSFSDeduccion.Name = "lblSFSDeduccion";
            this.lblSFSDeduccion.Size = new System.Drawing.Size(52, 23);
            this.lblSFSDeduccion.TabIndex = 19;
            this.lblSFSDeduccion.Text = "label6";
            // 
            // lblISRDeduccion
            // 
            this.lblISRDeduccion.AutoSize = true;
            this.lblISRDeduccion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISRDeduccion.Location = new System.Drawing.Point(343, 277);
            this.lblISRDeduccion.Name = "lblISRDeduccion";
            this.lblISRDeduccion.Size = new System.Drawing.Size(52, 23);
            this.lblISRDeduccion.TabIndex = 20;
            this.lblISRDeduccion.Text = "label7";
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.Location = new System.Drawing.Point(205, 342);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(52, 23);
            this.lblSueldoNeto.TabIndex = 21;
            this.lblSueldoNeto.Text = "label8";
            // 
            // lblDivisa
            // 
            this.lblDivisa.AutoSize = true;
            this.lblDivisa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDivisa.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisa.Location = new System.Drawing.Point(554, 153);
            this.lblDivisa.Name = "lblDivisa";
            this.lblDivisa.Size = new System.Drawing.Size(76, 31);
            this.lblDivisa.TabIndex = 22;
            this.lblDivisa.Text = "label9";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sueldo_Deducciones.Properties.Resources.SDpaint1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(738, 395);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(734, 422);
            this.Controls.Add(this.lblDivisa);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblISRDeduccion);
            this.Controls.Add(this.lblSFSDeduccion);
            this.Controls.Add(this.lblAFPDeduccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.lblSFS);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSueldoBruto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edicionDeTasasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sRSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eURToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem RD;
        private System.Windows.Forms.ToolStripMenuItem US;
        private System.Windows.Forms.ToolStripMenuItem EUR;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAFPDeduccion;
        private System.Windows.Forms.Label lblSFSDeduccion;
        private System.Windows.Forms.Label lblISRDeduccion;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Label lblDivisa;
        public System.Windows.Forms.Label lblAFP;
        public System.Windows.Forms.Label lblSFS;
    }
}

