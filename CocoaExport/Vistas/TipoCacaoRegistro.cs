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
    public partial class TipoCacaoRegistro : Form
    {
        int IdBuscado;
        TipoCacao registro = new TipoCacao();

        public TipoCacaoRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id;
            int.TryParse(IdTipoCacaotextBox.Text, out id);
            IdBuscado = id;
            if (registro.Buscar(IdBuscado))
            {
                registro.TipoCacaoId = IdBuscado;
                DescripcionTipotextBox.Text = registro.Descripcion;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (IdTipoCacaotextBox.Text.Length == 0)
            {
                registro.Descripcion = DescripcionTipotextBox.Text;

                if (registro.Insertar())
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
                registro.TipoCacaoId = Convert.ToInt32(IdTipoCacaotextBox.Text);

                registro.Descripcion = DescripcionTipotextBox.Text;

                registro.Editar();

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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            registro.TipoCacaoId = Convert.ToInt32(IdTipoCacaotextBox.Text);
            registro.Eliminar();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdTipoCacaotextBox.Clear();
            DescripcionTipotextBox.Clear();
        }
    }
}
