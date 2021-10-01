using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mendoza.Javier._2C;

namespace FormMendoza.Javier._2C_
{
    public partial class Form1 : Form
    {
        EjercitoImperial ejercitoImperial;
        TrooperAsalto trooperAsalto;

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            this.ejercitoImperial = new EjercitoImperial(10);
            this.trooperAsalto = new TrooperAsalto(Blaster.EC17);
            InitializeComponent();
        }

        /// <summary>
        /// Metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Arena");
            cmbTipo.Items.Add("Asalto");
            cmbTipo.Items.Add("Explorador");
        }

        /// <summary>
        /// Metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.Text == "Arena")
            {
                foreach (Trooper troAux in ejercitoImperial.Troopers)
                {
                    if (troAux is TrooperArena)
                    {
                        lstEjercito.Items.Add(troAux.Tipo);
                    }
                }
            }
            else if(cmbTipo.Text == "Asalto")
            {
                foreach (Trooper troAux in ejercitoImperial.Troopers)
                {
                    if (troAux is TrooperAsalto)
                    {
                        lstEjercito.Items.Add(troAux.Tipo);
                    }
                }
            }
            else
            {
                foreach (Trooper troAux in ejercitoImperial.Troopers)
                {
                    if (troAux is TrooperExplorador)
                    {
                        lstEjercito.Items.Add(troAux.Tipo);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo
        /// </summary>
        private void RefrescarEjercito()
        {
            lstEjercito.ClearSelected();

            foreach (Trooper troAux in ejercitoImperial.Troopers)
            {                
                if(troAux is TrooperAsalto)
                {
                    lstEjercito.Items.Add(troAux.Tipo);                    
                }
                else if (troAux is TrooperArena)
                {
                    lstEjercito.Items.Add(troAux.Tipo);
                }
                else
                {
                    lstEjercito.Items.Add(troAux.Tipo);
                }
            }
        }

        /// <summary>
        /// Metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbTipo.Text != " ")
            {
                if(cmbTipo.Text == "Arena")
                {
                    TrooperArena trooperArena = new TrooperArena(Blaster.EC17);
                    ejercitoImperial.Troopers.Add(trooperArena);
                    this.RefrescarEjercito();
                }
                else if(cmbTipo.Text == "Asalto")
                {
                    TrooperAsalto trooperAsalto = new TrooperAsalto(Blaster.E11);
                    ejercitoImperial.Troopers.Add(trooperAsalto);
                    this.RefrescarEjercito();
                }
                else
                {
                    TrooperExplorador trooperExplorador = new TrooperExplorador("Moto");
                    ejercitoImperial.Troopers.Add(trooperExplorador);
                    this.RefrescarEjercito();
                }
            }
        }

        /// <summary>
        /// Metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(cmbTipo.Text != " ")
            {
                if(cmbTipo.Text == "Arena")
                {
                    TrooperArena trooperArena = new TrooperArena(Blaster.EC17);
                    ejercitoImperial.Troopers.Remove(trooperArena);
                    this.RefrescarEjercito();
                }
                else if(cmbTipo.Text == "Asalto")
                {
                    TrooperAsalto trooperAsalto = new TrooperAsalto(Blaster.E11);
                    ejercitoImperial.Troopers.Remove(trooperAsalto);
                    this.RefrescarEjercito();
                }
                else
                {
                    TrooperExplorador trooperExplorador = new TrooperExplorador("Moto");
                    ejercitoImperial.Troopers.Remove(trooperExplorador);
                    this.RefrescarEjercito();
                }
            }
        }

        /// <summary>
        /// Metodo de seleccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbClon_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbClon.Checked)
            {
                cmbBlaster.Items.Add("Es Clon");
                cmbBlaster.Items.Add("No es Clon");
            }
        }
    }
}
