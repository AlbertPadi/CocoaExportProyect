using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace CocoaExport.Vistas
{
    public partial class Recepcion : Form
    {
        int IdBuscado;
        BLL.Recepcion Registro = new BLL.Recepcion();

        public Recepcion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recepcion_Load(object sender, EventArgs e)
        {
            Socios socio = new Socios();
            SocioIdcomboBox.DataSource = socio.Listar("SocioId, Nombre", "1=1", "");
            SocioIdcomboBox.DisplayMember = "Nombre";
            SocioIdcomboBox.ValueMember = "SocioId";


            BLL.Certificaciones Cert = new BLL.Certificaciones();
            CertificacionIdcomboBox.DataSource = Cert.Listar("CertificacionId, Descripcion", "1=1", "");
            CertificacionIdcomboBox.DisplayMember = "Descripcion";
            CertificacionIdcomboBox.ValueMember = "CertificacionId";

            Lotes lotes = new Lotes();
            LoteIdcomboBox.DataSource = lotes.Listar("*", "1=1", "");
            LoteIdcomboBox.DisplayMember = "CodigoLote";
            LoteIdcomboBox.ValueMember = "LoteId";

            BLL.TipoCacao TipoC = new BLL.TipoCacao();
            TipoCacaoIdcomboBox.DataSource = TipoC.Listar("TipoCacaoId, Descripcion", "1=1", "");
            TipoCacaoIdcomboBox.DisplayMember = "Descripcion";
            TipoCacaoIdcomboBox.ValueMember = "TipoCacaoId";
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Registro.RecepcionId = Convert.ToInt32(RecepcionIdtextBox.Text);
            Registro.Eliminar();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            RecepcionIdtextBox.Clear();
            CantPtextBox.Clear();
            ObservacionrichTextBox.Clear();
            RecibidoPortextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            IdBuscado = Convert.ToInt32(RecepcionIdtextBox.Text);
            if (Registro.Buscar(IdBuscado))
            {
                Registro.RecepcionId = IdBuscado;
                FechadateTimePicker.Text = Registro.Fecha;
                CantPtextBox.Text = Registro.CantidadPesada.ToString();
                ObservacionrichTextBox.Text = Registro.Observacion;
                RecibidoPortextBox.Text = Registro.RecibidoPor;
            }
            }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (RecepcionIdtextBox.Text.Length == 0)
            {
                Registro.CantidadPesada = Convert.ToInt32(CantPtextBox.Text);
                Registro.Observacion = ObservacionrichTextBox.Text;
                Utilities.Utilitarios.Validacion(RecibidoPortextBox, error, "No puede quedar este campo en blanco");
                Registro.RecibidoPor = RecibidoPortextBox.Text;
                Registro.CodigoLote = LoteIdcomboBox.SelectedValue.ToString();
                Registro.SocioId = (int)SocioIdcomboBox.SelectedValue;
                Registro.TipoCacaoId = (int)TipoCacaoIdcomboBox.SelectedValue;

                if (Registro.Insertar())
                {
                    MessageBox.Show("Se guardaron los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }

            }
            else
            {
                Registro.TipoCacaoId = Convert.ToInt32(RecepcionIdtextBox.Text);
                Registro.CantidadPesada = Convert.ToInt32(CantPtextBox.Text);
                Registro.Observacion = ObservacionrichTextBox.Text;
                Registro.RecibidoPor = RecibidoPortextBox.Text;
                Registro.SocioId = (int)SocioIdcomboBox.SelectedValue;
                Registro.CodigoLote = LoteIdcomboBox.SelectedValue.ToString();
                Registro.TipoCacaoId = (int)TipoCacaoIdcomboBox.SelectedValue;
                Registro.Editar();

                if (Registro.Editar())
                {
                    MessageBox.Show("Se han actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }
            }
        }
    }
}
