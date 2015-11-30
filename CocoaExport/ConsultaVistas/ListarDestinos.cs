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
namespace CocoaExport.ConsultaVistas
{
    public partial class ListarDestinos : Form
    {
        DestinosExportes destinos = new DestinosExportes();
        public ListarDestinos()
        {
            InitializeComponent();
        }

        private void Listarbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string Condicion = "1=1";
            if (DatoscomboBox.SelectedIndex == 0)
            {
                if (ListatextBox.Text.Trim().Length == 0)
                {
                    Condicion = "1=1";
                }
                else
                {
                    Condicion = "DestinoId = " + ListatextBox.Text;
                }

                dt = destinos.Listar("DestinoId, Pais, CodigoDestino, NombreDestino, Direccion, CodigoPostal", Condicion, "");
                ListadataGridView.DataSource = dt;
            }

            if (DatoscomboBox.SelectedIndex == 1)
            {
                if (ListatextBox.Text.Trim().Length == 1)
                {
                    Condicion = "2=2";
                }
                else
                {
                    Condicion = String.Format("Pais  like '{0}%' ", ListatextBox.Text);
                }

                dt = destinos.Listar("DestinoId, Pais, CodigoDestino, NombreDestino, Direccion, CodigoPostal", Condicion, "");
                ListadataGridView.DataSource = dt;
            }

            if (DatoscomboBox.SelectedIndex == 2)
            {
                if (ListatextBox.Text.Trim().Length == 2)
                {
                    Condicion = "3=3";
                }
                else
                {
                    Condicion = String.Format("NombreDestino  like '{0}%' ", ListatextBox.Text);
                }

                dt = destinos.Listar("DestinoId, Pais, CodigoDestino, NombreDestino, Direccion, CodigoPostal", Condicion, "");
                ListadataGridView.DataSource = dt;
            }
        }
    }
}
