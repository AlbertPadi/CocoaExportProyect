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
