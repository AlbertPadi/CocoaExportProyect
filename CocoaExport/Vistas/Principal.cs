﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CocoaExport.Vistas;

namespace CocoaExport
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void RegistrarSbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void CentrosAcpbutton_Click(object sender, EventArgs e)
        {

        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios re = new RegistroUsuarios();
            re.Show();
        }

        private void RegistrarSbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void Registrarbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void registroSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroSocios registro = new RegistroSocios();
            registro.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void registroCertificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Certificaciones registro = new Certificaciones();
            registro.Show();
        }

        private void controlDeLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestinosExportes destinos = new DestinosExportes();
            destinos.Show();
        }

        private void registroInspeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InspeccionesRegistro Inspecciones = new InspeccionesRegistro();
            Inspecciones.Show();
        }

        private void exportacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroExportacion registro = new RegistroExportacion();
            registro.Show();
        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegistroLote control = new RegistroLote();
            control.Show();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
                Login login = new Login();
                this.Close();
                login.Show();
            
        }

        private void controlLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar();
            listar.Show();
        }

        private void inspeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
