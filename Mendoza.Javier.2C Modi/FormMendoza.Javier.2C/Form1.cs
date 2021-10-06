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
            this.ejercitoImperial = new EjercitoImperial(4);
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

            cmbBlaster.Items.Add(Blaster.DLT19);
            cmbBlaster.Items.Add(Blaster.E11);
            cmbBlaster.Items.Add(Blaster.EC17);
        }

        /// <summary>
        /// Metodo
        /// </summary>
        private void RefrescarEjercito()
        {
            lstEjercito.Items.Clear();
            foreach (Trooper troAux in ejercitoImperial.Troopers)
            {
                if (troAux is TrooperAsalto)
                {
                    lstEjercito.Items.Add(troAux.InfoTrooper());
                }
                else if (troAux is TrooperArena)
                {
                    lstEjercito.Items.Add(troAux.InfoTrooper());
                }
                else
                {
                    lstEjercito.Items.Add(troAux.InfoTrooper());
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
            if (cmbTipo.SelectedIndex != -1 && cmbBlaster.SelectedIndex != -1)
            {
                if (cmbTipo.Text == "Arena")
                {
                    TrooperArena trooperArena = new TrooperArena((Blaster)this.cmbBlaster.SelectedItem);
                    if (ckbClon.Checked)
                    {
                        trooperArena.EsClon = true;
                    }
                    ejercitoImperial = ejercitoImperial + trooperArena;
                    this.RefrescarEjercito();
                }
                else if (cmbTipo.Text == "Asalto")
                {
                    TrooperAsalto trooperAsalto = new TrooperAsalto((Blaster)this.cmbBlaster.SelectedItem);
                    if (ckbClon.Checked)
                    {
                        trooperAsalto.EsClon = true;
                    }
                    ejercitoImperial = ejercitoImperial + trooperAsalto;
                    this.RefrescarEjercito();
                }
                else
                {
                    TrooperExplorador trooperExplorador = new TrooperExplorador("Moto");
                    if (ckbClon.Checked)
                    {
                        trooperExplorador.EsClon = true;
                    }
                    ejercitoImperial = ejercitoImperial + trooperExplorador;
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
            if (cmbTipo.SelectedIndex != -1)
            {
                if (cmbTipo.Text == "Arena")
                {
                    TrooperArena trooperArena = new TrooperArena(Blaster.EC17);
                    ejercitoImperial = ejercitoImperial - trooperArena;
                    this.RefrescarEjercito();
                }
                else if (cmbTipo.Text == "Asalto")
                {
                    TrooperAsalto trooperAsalto = new TrooperAsalto(Blaster.E11);
                    ejercitoImperial = ejercitoImperial - trooperAsalto;
                    this.RefrescarEjercito();
                }
                else
                {
                    TrooperExplorador trooperExplorador = new TrooperExplorador("Moto");
                    ejercitoImperial = ejercitoImperial - trooperExplorador;
                    this.RefrescarEjercito();
                }
            }
        }

    }    
}
