﻿namespace prySerafiniGiorgi_Biblioteca_nuevo
{
    partial class frmConsultaLibros
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
            this.cmdAvanzar = new System.Windows.Forms.Button();
            this.cmdRetroceso = new System.Windows.Forms.Button();
            this.txtCodigoDistri = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtCodigoEdito = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAvanzar
            // 
            this.cmdAvanzar.Location = new System.Drawing.Point(260, 316);
            this.cmdAvanzar.Name = "cmdAvanzar";
            this.cmdAvanzar.Size = new System.Drawing.Size(81, 33);
            this.cmdAvanzar.TabIndex = 25;
            this.cmdAvanzar.Text = "AVANZAR";
            this.cmdAvanzar.UseVisualStyleBackColor = true;
            this.cmdAvanzar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdRetroceso
            // 
            this.cmdRetroceso.Location = new System.Drawing.Point(12, 316);
            this.cmdRetroceso.Name = "cmdRetroceso";
            this.cmdRetroceso.Size = new System.Drawing.Size(92, 33);
            this.cmdRetroceso.TabIndex = 24;
            this.cmdRetroceso.Text = "RETROCEDER";
            this.cmdRetroceso.UseVisualStyleBackColor = true;
            this.cmdRetroceso.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodigoDistri
            // 
            this.txtCodigoDistri.Location = new System.Drawing.Point(167, 268);
            this.txtCodigoDistri.Name = "txtCodigoDistri";
            this.txtCodigoDistri.Size = new System.Drawing.Size(174, 20);
            this.txtCodigoDistri.TabIndex = 23;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Location = new System.Drawing.Point(167, 231);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.Size = new System.Drawing.Size(174, 20);
            this.txtCodigoAutor.TabIndex = 22;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(167, 108);
            this.txtNombreLibro.Multiline = true;
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(174, 69);
            this.txtNombreLibro.TabIndex = 21;
            // 
            // txtCodigoEdito
            // 
            this.txtCodigoEdito.Location = new System.Drawing.Point(167, 194);
            this.txtCodigoEdito.Name = "txtCodigoEdito";
            this.txtCodigoEdito.Size = new System.Drawing.Size(174, 20);
            this.txtCodigoEdito.TabIndex = 20;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(167, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 20);
            this.txtCodigo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "CODIGO DISTRUIDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "CODIGO AUTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "NOMBRE DEL LIBRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "CODIGO EDITORIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "CONSULTE POR SU LIBRO";
            // 
            // frmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 374);
            this.Controls.Add(this.cmdAvanzar);
            this.Controls.Add(this.cmdRetroceso);
            this.Controls.Add(this.txtCodigoDistri);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.txtCodigoEdito);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaLibros";
            this.Text = "frmConsultaLibros";
            this.Load += new System.EventHandler(this.frmConsultaLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAvanzar;
        private System.Windows.Forms.Button cmdRetroceso;
        private System.Windows.Forms.TextBox txtCodigoDistri;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtCodigoEdito;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}