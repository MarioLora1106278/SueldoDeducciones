namespace Sueldo_Deducciones
{
    partial class TasasEdit
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
            this.lblEditAFP = new System.Windows.Forms.Label();
            this.lblEditSFS = new System.Windows.Forms.Label();
            this.txtEditAFP = new System.Windows.Forms.TextBox();
            this.txtEditSFS = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditAFP
            // 
            this.lblEditAFP.AutoSize = true;
            this.lblEditAFP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAFP.Location = new System.Drawing.Point(43, 59);
            this.lblEditAFP.Name = "lblEditAFP";
            this.lblEditAFP.Size = new System.Drawing.Size(52, 24);
            this.lblEditAFP.TabIndex = 0;
            this.lblEditAFP.Text = "AFP";
            // 
            // lblEditSFS
            // 
            this.lblEditSFS.AutoSize = true;
            this.lblEditSFS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSFS.Location = new System.Drawing.Point(43, 121);
            this.lblEditSFS.Name = "lblEditSFS";
            this.lblEditSFS.Size = new System.Drawing.Size(51, 24);
            this.lblEditSFS.TabIndex = 1;
            this.lblEditSFS.Text = "SFS";
            // 
            // txtEditAFP
            // 
            this.txtEditAFP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAFP.Location = new System.Drawing.Point(101, 58);
            this.txtEditAFP.Name = "txtEditAFP";
            this.txtEditAFP.Size = new System.Drawing.Size(39, 29);
            this.txtEditAFP.TabIndex = 2;
            this.txtEditAFP.TextChanged += new System.EventHandler(this.txtEditAFP_TextChanged);
            // 
            // txtEditSFS
            // 
            this.txtEditSFS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSFS.Location = new System.Drawing.Point(101, 120);
            this.txtEditSFS.Name = "txtEditSFS";
            this.txtEditSFS.Size = new System.Drawing.Size(39, 29);
            this.txtEditSFS.TabIndex = 3;
            this.txtEditSFS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(349, 34);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "EDITOR DE TASAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "%";
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(219, 58);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(142, 100);
            this.btGuardar.TabIndex = 7;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // TasasEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtEditSFS);
            this.Controls.Add(this.txtEditAFP);
            this.Controls.Add(this.lblEditSFS);
            this.Controls.Add(this.lblEditAFP);
            this.Name = "TasasEdit";
            this.Text = "TasasEdit";
            this.Load += new System.EventHandler(this.TasasEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditAFP;
        private System.Windows.Forms.Label lblEditSFS;
        private System.Windows.Forms.TextBox txtEditAFP;
        private System.Windows.Forms.TextBox txtEditSFS;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGuardar;
    }
}