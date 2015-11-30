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
    public partial class ListarUsuarios : Form
    {
        Usuarios usuario = new Usuarios();
        public ListarUsuarios()
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
                    Condicion = "UsuarioId = " + ListatextBox.Text;
                }

                dt = usuario.Listar("UsuarioId, Nombres, Apellidos, Direccion, NombreUsuario, Contrasena, Contrasena1", Condicion, "");
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

                    Condicion = String.Format("Nombres  like '{0}%' ", ListatextBox.Text);
                }

                dt = usuario.Listar("UsuarioId, Nombres, Apellidos, Direccion, NombreUsuario, Contrasena, Contrasena1", Condicion, "");
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

                    Condicion = String.Format("Apellidos  like '{0}%' ", ListatextBox.Text);
                }

                dt = usuario.Listar("UsuarioId, Nombres, Apellidos, Direccion, NombreUsuario, Contrasena, Contrasena1", Condicion, "");
                ListadataGridView.DataSource = dt;
            }
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
    }
