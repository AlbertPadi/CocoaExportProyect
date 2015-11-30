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
    public partial class Listar : Form
    {
        Socios socios = new Socios();
        DataTable dt = new DataTable();
        public Listar()
        {
            InitializeComponent();
        }

        private void Listarbutton_Click(object sender, EventArgs e)
        {
            

            string Condicion = "1=1";
            if (DatoscomboBox.SelectedIndex == 0)
            {
                if (ListatextBox.Text.Trim().Length == 0)
                {
                    Condicion = "1=1";
                }
                else
                {
                    Condicion = "SocioId = " + ListatextBox.Text;
                }

                dt = socios.Listar("SocioId, Nombre, Apellido, Direccion, Cedula, CertificacionId, CantidadTerreno", Condicion, "");
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
                    
                    Condicion = String.Format("Nombre  like '{0}%' ", ListatextBox.Text);
                }

                dt = socios.Listar("SocioId, Nombre, Apellido, Direccion, Cedula, CertificacionId, CantidadTerreno", Condicion, "");
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

                    Condicion = String.Format("Apellido  like '{0}%' ", ListatextBox.Text);
                }

                dt = socios.Listar("SocioId, Nombre, Apellido, Direccion, Cedula, CertificacionId, CantidadTerreno", Condicion, "");
                ListadataGridView.DataSource = dt;
            }
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Listar_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ListatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
