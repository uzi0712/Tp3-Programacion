
namespace Tp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtCarg = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.BtLimp = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtCarg
            // 
            this.BtCarg.Location = new System.Drawing.Point(206, 68);
            this.BtCarg.Name = "BtCarg";
            this.BtCarg.Size = new System.Drawing.Size(75, 23);
            this.BtCarg.TabIndex = 0;
            this.BtCarg.Text = "Cargar";
            this.BtCarg.UseVisualStyleBackColor = true;
            this.BtCarg.Click += new System.EventHandler(this.BtCarg_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(22, 54);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(100, 13);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "Numero a potenciar";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(22, 128);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(90, 13);
            this.lblP.TabIndex = 8;
            this.lblP.Text = "Potencia a elevar";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(22, 9);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(87, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Calcula Potencia";
            this.lbl3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 342);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtLimp
            // 
            this.BtLimp.Location = new System.Drawing.Point(287, 68);
            this.BtLimp.Name = "BtLimp";
            this.BtLimp.Size = new System.Drawing.Size(75, 23);
            this.BtLimp.TabIndex = 11;
            this.BtLimp.Text = "Limpiar";
            this.BtLimp.UseVisualStyleBackColor = true;
            this.BtLimp.Click += new System.EventHandler(this.BtLimp_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(25, 144);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(162, 20);
            this.txtP.TabIndex = 12;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(25, 70);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(162, 20);
            this.txtN.TabIndex = 13;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(227, 151);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 255);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.BtLimp);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.BtCarg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCarg;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button BtLimp;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lbl1;
    }
}

