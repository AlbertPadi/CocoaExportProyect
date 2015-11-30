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
    public partial class Certificaciones : Form
    {
        int IdBuscado;
        int certificacionId;
        ErrorProvider error = new ErrorProvider();
        BLL.Certificaciones registro = new BLL.Certificaciones();

        public Certificaciones()
        {
            InitializeComponent();
        }

        private void Certificaciones_Load(object sender, EventArgs e)
        {
            
        }

        private void IDtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(IDtextBox, "Este campo solo acepta numeros");
            }
        }

        private void DescripciontextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(DescripciontextBox, "Este campo no acepta numeros ni caracteres especiales");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text.Length == 0)
            {
                ErrorProvider error = new ErrorProvider();
                Utilities.Utilitarios.Validacion(DescripciontextBox, error, "No puede haver campos en blanco");
                registro.Descripcion = DescripciontextBox.Text;

                if (registro.Insertar())
                {
                    MessageBox.Show("Se guardaron los datos!");
                }
                else
                { 
                    MessageBox.Show("No se han guardado los datos!");
                }

            }
            else if(IDtextBox.Text.Length > 0)
            {
                int.TryParse(IDtextBox.Text, out certificacionId);
                registro.CertificacionID = certificacionId;

                registro.Descripcion = DescripciontextBox.Text;
     
                if (registro.Editar())
                {
                    MessageBox.Show("Se han actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(IDtextBox.Text, out certificacionId);
            registro.CertificacionID = certificacionId;
            if (registro.Eliminar())
            {
                MessageBox.Show("Se han eliminado los datos!");
            }
            else
            {
                MessageBox.Show("No se han eliminado los datos!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDtextBox.Text, out id);
            IdBuscado = id;
            if (registro.Buscar(IdBuscado))
            {
                registro.CertificacionID = IdBuscado;
                DescripciontextBox.Text = registro.Descripcion;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
