﻿
namespace FrmTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(309, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Location = new System.Drawing.Point(15, 253);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(309, 23);
            this.btnVerInforme.TabIndex = 1;
            this.btnVerInforme.Text = "Ver Informe";
            this.btnVerInforme.UseVisualStyleBackColor = true;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(15, 224);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(309, 23);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 15;
            this.lstStock.Location = new System.Drawing.Point(15, 12);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(309, 199);
            this.lstStock.TabIndex = 3;
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(370, 12);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(270, 268);
            this.rtbInforme.TabIndex = 4;
            this.rtbInforme.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 317);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnVerInforme);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester App de Javier Mendoza 2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.RichTextBox rtbInforme;
    }
}

