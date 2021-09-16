
namespace WinFormsApp1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbNombreOk = new System.Windows.Forms.ComboBox();
            this.ckbHabilitar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(45, 88);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(238, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textNombre.Location = new System.Drawing.Point(45, 36);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(238, 29);
            this.textNombre.TabIndex = 1;
            this.textNombre.Text = " ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbNombreOk
            // 
            this.cmbNombreOk.FormattingEnabled = true;
            this.cmbNombreOk.Location = new System.Drawing.Point(344, 36);
            this.cmbNombreOk.Name = "cmbNombreOk";
            this.cmbNombreOk.Size = new System.Drawing.Size(238, 23);
            this.cmbNombreOk.TabIndex = 3;
            // 
            // ckbHabilitar
            // 
            this.ckbHabilitar.AutoSize = true;
            this.ckbHabilitar.Checked = true;
            this.ckbHabilitar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHabilitar.Location = new System.Drawing.Point(344, 88);
            this.ckbHabilitar.Name = "ckbHabilitar";
            this.ckbHabilitar.Size = new System.Drawing.Size(106, 19);
            this.ckbHabilitar.TabIndex = 4;
            this.ckbHabilitar.Text = "Habilitar botón";
            this.ckbHabilitar.UseVisualStyleBackColor = true;
            this.ckbHabilitar.CheckedChanged += new System.EventHandler(this.ckbHabilitar_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckbHabilitar);
            this.Controls.Add(this.cmbNombreOk);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form de pruebas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbNombreOk;
        private System.Windows.Forms.CheckBox ckbHabilitar;
        private System.Windows.Forms.Button button1;
    }
}

