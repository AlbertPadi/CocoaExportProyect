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
        double monto;
        double precio;
        double cantidad;
        double cantidad2;
        int tipo;
        int recepcion;
        ErrorProvider error = new ErrorProvider();
        BLL.Recepcion Registro = new BLL.Recepcion();

        public Recepcion()
        {
            InitializeComponent();
            this.monto = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecepcionIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
                error.SetError(RecepcionIdtextBox, "Este campo solo acepta numeros");
            }
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
            Registro.RecepcionId = recepcion;
            if (Registro.Eliminar())
            {
                MessageBox.Show("Se han eliminado los datos!");
            }
            else
            {
                MessageBox.Show("no se han eliminado los datos!");
            }
            limpiar();
        }


        void limpiar()
        {
            RecepcionIdtextBox.Clear();
            CantPtextBox.Clear();
            ObservacionrichTextBox.Clear();
            RecibidoPortextBox.Clear();
            MontotextBox.Clear();
            PreciotextBox.Clear();
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();    
        }
        
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            IdBuscado = Convert.ToInt32(RecepcionIdtextBox.Text);
            if (Registro.Buscar(IdBuscado))
            {
                Registro.CantidadAnterior = Registro.CantidadPesada;
                Registro.RecepcionId = IdBuscado;
                FechadateTimePicker.Text = Registro.Fecha;
                SocioIdcomboBox.SelectedValue = Registro.SocioId;
                CantPtextBox.Text = Registro.CantidadPesada.ToString();
                ObservacionrichTextBox.Text = Registro.Observacion;
                RecibidoPortextBox.Text = Registro.RecibidoPor;
                MontotextBox.Text = Registro.Monto.ToString();
            }
            }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (RecepcionIdtextBox.Text.Length == 0)
            {
                double resultado;
                double.TryParse(CantPtextBox.Text, out cantidad);
                Registro.CantidadPesada = cantidad;
                Registro.Observacion = ObservacionrichTextBox.Text;
                Utilities.Utilitarios.Validacion(RecibidoPortextBox, error, "No puede quedar este campo en blanco");
                Registro.RecibidoPor = RecibidoPortextBox.Text;
                Registro.LoteId = (int)LoteIdcomboBox.SelectedValue;
                Registro.SocioId = (int)SocioIdcomboBox.SelectedValue;
                Registro.TipoCacaoId = (int)TipoCacaoIdcomboBox.SelectedValue;
                Registro.Fecha = FechadateTimePicker.Text;

                double.TryParse(CantPtextBox.Text, out cantidad);
                double.TryParse(PreciotextBox.Text, out precio);
                PreciotextBox.Text = precio.ToString();
                resultado = precio * cantidad;
                MontotextBox.Text = resultado.ToString();
                Registro.Monto = resultado;

                if (Registro.Insertar())
                {
                    MessageBox.Show("Se guardaron los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }
                limpiar();
            }
            else if (RecepcionIdtextBox.Text.Length > 0)
            {
                int.TryParse(RecepcionIdtextBox.Text, out recepcion);
                double.TryParse(CantPtextBox.Text, out cantidad);
                Registro.RecepcionId = recepcion;
                Registro.CantidadPesada = cantidad;
                Registro.Observacion = ObservacionrichTextBox.Text;
                Registro.RecibidoPor = RecibidoPortextBox.Text;
                Registro.SocioId = (int)SocioIdcomboBox.SelectedValue;
                Registro.LoteId = (int)LoteIdcomboBox.SelectedValue;
                Registro.TipoCacaoId = (int)TipoCacaoIdcomboBox.SelectedValue;
                Registro.Fecha = FechadateTimePicker.Text;

                if (Registro.Editar())
                {
                    MessageBox.Show("Se han actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han actualizado los datos!");
                }
            }
        }
        private void RecibidoPortextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                error.SetError(RecibidoPortextBox, "Este campo no acepta numeros ni caracteres especiales");

            }
        }
    }
    
}
