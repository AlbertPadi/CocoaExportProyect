using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CocoaExport.Vistas;
using CocoaExport.ConsultaVistas;

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
            
        }

        private void registroInspeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exportacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void inspeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void certificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarLotes listarlotes = new ListarLotes();
            listarlotes.Show();
        }

        private void registroTipoCacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoCacaoRegistro Registro = new TipoCacaoRegistro();
            Registro.Show();
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteExportaciones reporte = new ReporteExportaciones();
            reporte.Show();
        }

        private void registroInspeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroInspecciones Inspecciones = new RegistroInspecciones();
            Inspecciones.Show();
        }

        private void recepcionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Recepcion recepcion = new Recepcion();
            recepcion.Show();
        }

        private void controlLotesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroLote control = new RegistroLote();
            control.Show();
        }

        private void destinoExporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestinosExportes destinos = new DestinosExportes();
            destinos.Show();
        }

        private void exportacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroExportacion registro = new RegistroExportacion();
            registro.Show();
        }

        private void sociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar();
            listar.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarUsuarios usuarios = new ListarUsuarios();
            usuarios.Show();
        }

        private void certificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCertificaciones listarcer = new ListarCertificaciones();
            listarcer.Show();
        }

        private void lotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarLotes lotes = new ListarLotes();
            lotes.Show();
        }

        private void tipoCacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarTipoCacao tipo = new ListarTipoCacao();
            tipo.Show();
        }

        private void inspeccionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListarInspecciones inspecciones = new ListarInspecciones();
            inspecciones.Show();

        }

        private void recepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarRecepciones recepcion = new ListarRecepciones();
            recepcion.Show();
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarDestinos destinos = new ListarDestinos();
            destinos.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extras.Ayuda ayuda = new Extras.Ayuda();
            ayuda.Show();
        }

        private void exportacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarExportaciones exportacion = new ListarExportaciones();
            exportacion.Show();
        }
    }
}
