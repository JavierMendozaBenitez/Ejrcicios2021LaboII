
namespace FormMendoza.Javier._2C_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lstEjercito = new System.Windows.Forms.ListBox();
            this.picStormtrooperHelmet = new System.Windows.Forms.PictureBox();
            this.cmbBlaster = new System.Windows.Forms.ComboBox();
            this.ckbClon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(28, 43);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 13);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(28, 307);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lstEjercito
            // 
            this.lstEjercito.FormattingEnabled = true;
            this.lstEjercito.ItemHeight = 15;
            this.lstEjercito.Location = new System.Drawing.Point(261, 13);
            this.lstEjercito.Name = "lstEjercito";
            this.lstEjercito.Size = new System.Drawing.Size(623, 334);
            this.lstEjercito.TabIndex = 4;
            // 
            // picStormtrooperHelmet
            // 
            this.picStormtrooperHelmet.Image = global::FormMendoza.Javier._2C_.Properties.Resources.stormtrooper;
            this.picStormtrooperHelmet.Location = new System.Drawing.Point(28, 72);
            this.picStormtrooperHelmet.Name = "picStormtrooperHelmet";
            this.picStormtrooperHelmet.Size = new System.Drawing.Size(185, 165);
            this.picStormtrooperHelmet.TabIndex = 5;
            this.picStormtrooperHelmet.TabStop = false;
            // 
            // cmbBlaster
            // 
            this.cmbBlaster.FormattingEnabled = true;
            this.cmbBlaster.Location = new System.Drawing.Point(121, 254);
            this.cmbBlaster.Name = "cmbBlaster";
            this.cmbBlaster.Size = new System.Drawing.Size(121, 23);
            this.cmbBlaster.TabIndex = 6;
            // 
            // ckbClon
            // 
            this.ckbClon.AutoSize = true;
            this.ckbClon.Location = new System.Drawing.Point(121, 307);
            this.ckbClon.Name = "ckbClon";
            this.ckbClon.Size = new System.Drawing.Size(83, 19);
            this.ckbClon.TabIndex = 7;
            this.ckbClon.Text = "checkBox1";
            this.ckbClon.UseVisualStyleBackColor = true;
            this.ckbClon.CheckedChanged += new System.EventHandler(this.ckbClon_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 352);
            this.Controls.Add(this.ckbClon);
            this.Controls.Add(this.cmbBlaster);
            this.Controls.Add(this.picStormtrooperHelmet);
            this.Controls.Add(this.lstEjercito);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a la fábrica de troopers del Lado Oscuro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox lstEjercito;
        private System.Windows.Forms.PictureBox picStormtrooperHelmet;
        private System.Windows.Forms.ComboBox cmbBlaster;
        private System.Windows.Forms.CheckBox ckbClon;
    }
}

