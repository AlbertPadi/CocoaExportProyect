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
    public partial class DestinosExportes : Form
    {
    
        int IdBuscado;
        int CodigoPost;
        int DestinoId;
        ErrorProvider error = new ErrorProvider();
        BLL.DestinosExportes destino = new BLL.DestinosExportes();
        public DestinosExportes()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (DestinoIdtextBox.Text.Length == 0)
            {
                Utilities.Utilitarios.Validacion(PaistextBox, error, "No puede haver campos en blanco");
                destino.Pais = PaistextBox.Text;
                destino.CodigoDestino = CodigoDesttextBox.Text;
                Utilities.Utilitarios.Validacion(NombreDesttextBox, error, "No puede haver campos en blanco");
                destino.NombreDestino = NombreDesttextBox.Text;
                Utilities.Utilitarios.Validacion(DireccionDesttextBox, error, "No puede haver campos en blanco");
                destino.Direccion = DireccionDesttextBox.Text;
                Utilities.Utilitarios.Validacion(CodigoPosttextBox, error, "No puede haver campos en blanco");
                int.TryParse(CodigoPosttextBox.Text, out CodigoPost);
                destino.CodigoPostal = CodigoPost;


                if (destino.Insertar())
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
                int.TryParse(DestinoIdtextBox.Text, out DestinoId);
                Utilities.Utilitarios.Validacion(PaistextBox, error, "No puede haver campos en blanco");
                destino.Pais = PaistextBox.Text;
                destino.CodigoDestino = CodigoDesttextBox.Text;
                Utilities.Utilitarios.Validacion(NombreDesttextBox, error, "No puede haver campos en blanco");
                destino.NombreDestino = NombreDesttextBox.Text;
                Utilities.Utilitarios.Validacion(DireccionDesttextBox, error, "No puede haver campos en blanco");
                destino.Direccion = DireccionDesttextBox.Text;
                Utilities.Utilitarios.Validacion(CodigoPosttextBox, error, "No puede haver campos en blanco");
                int.TryParse(CodigoPosttextBox.Text, out CodigoPost);
                destino.CodigoPostal = CodigoPost;


                if (destino.Editar())
                {
                    MessageBox.Show("Se actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han actualizado los datos!");
                }
            }
            

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int.TryParse(DestinoIdtextBox.Text, out DestinoId);
            destino.DestinoId = DestinoId;
            if (destino.Eliminar())
            {
                MessageBox.Show("Se han borrado los datos");
            }
            else
            {
                MessageBox.Show("Error al borrar los datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idBus;
            int.TryParse(DestinoIdtextBox.Text, out idBus);
            IdBuscado = idBus;

            if (destino.Buscar(IdBuscado))
            {
                destino.DestinoId = IdBuscado;
                PaistextBox.Text = destino.Pais;
                CodigoDesttextBox.Text = destino.CodigoDestino;
                NombreDesttextBox.Text = destino.NombreDestino;
                DireccionDesttextBox.Text = destino.Direccion;
                CodigoPosttextBox.Text = destino.CodigoPostal.ToString();
                
            }
        }

        private void DestinosExportes_Load(object sender, EventArgs e)
        {
            

        }

        private void DireccionDesttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CodigoDesttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CodigoPosttextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(CodigoPosttextBox, "Este campo solo acepta numeros");
            }
        }

        private void DestinoIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(DestinoIdtextBox, "Este campo solo acepta numeros");
            }
        }

        private void NombreDesttextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(NombreDesttextBox, "Este campo no acepta numeros ni caracteres especiales");
            }
        }

        private void PaistextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(PaistextBox, "Este campo no acepta numeros ni caracteres especiales");
            }
        }

        private void PaistextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            PaistextBox.Clear();
            CodigoDesttextBox.Clear();
            NombreDesttextBox.Clear();
            DireccionDesttextBox.Clear();
            CodigoDesttextBox.Clear();
        }
    }
}
