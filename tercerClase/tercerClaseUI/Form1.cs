﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio1;

namespace tercerClaseUI
{
    public partial class Form1 : Form
    {
        private Carrera _miCarrera;
        private Auto _autoUno;

        public Form1()
        {
            InitializeComponent();

            foreach (EFabricante item in Enum.GetValues(typeof(EFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }

            this.cmbFabricante.SelectedIndex = 0;
            this.txtNombreCarrera.Text = "Chingolo Speedway";
            this.txtFechaCarrera.Text = "13/9/16";
            this.txtLugarCarrera.Text = "Monte Chingolo";
            this.cmbTipoCarrera.SelectedIndex = 0;
            //_miCarrera = new Carrera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _miCarrera = new Carrera(this.txtNombreCarrera.Text, this.txtFechaCarrera.Text, this.txtLugarCarrera.Text);
            gpbCarrera.Enabled = false;
            gpbAutos.Enabled = true;

            this.txtNombrePiloto.Text = "";
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            _autoUno = new Auto(this.txtNombrePiloto.Text, (EFabricante)this.cmbFabricante.SelectedItem);
            _miCarrera = _miCarrera + _autoUno;
            gpbListado.Enabled = true;
            gpbResultado.Enabled = true;
            this.txtNombrePiloto.Text = "";

            mostrarListado();
        }

        private void mostrarListado()
        {
            this.lsbAutos.Items.Clear();

            foreach (Auto item in this._miCarrera.listaDeAutos)
            {
                this.lsbAutos.Items.Add(item.datosEnString);
            }
        }

        private void btnCorrerCarrera_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoCarrera.Text == "Tiempo")
            {
                this.txtCorrerCarrera.Text = this._miCarrera.correrCarreraPorTiempo(10);
            }
            else
            {
                this.txtCorrerCarrera.Text = this._miCarrera.correrCarreraPorKilometros(100);
            }

            this._miCarrera.listaDeAutos.Clear();
            this.txtNombrePiloto.Clear();

            this.gpbResultado.Enabled = false;
            this.gpbListado.Enabled = false;
            this.gpbAutos.Enabled = false;
            this.gpbCarrera.Enabled = true;
        }

        private void txtCorrerCarrera_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
