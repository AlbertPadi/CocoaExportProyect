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
            DatoscomboBox.DataSource = usuario.Listar("UsuarioId, Nombres, Apellidos, Direccion, NombreUsuario, Contrasena, Contrasena1", "1=1", "");
            DatoscomboBox.DisplayMember = "Nombres";
            DatoscomboBox.ValueMember = "UsuarioId";

            string Filtro = "1=1";
            if (DatoscomboBox.SelectedIndex == 0)
            {
                if (ListatextBox.Text.Trim().Length == 0)
                {
                    Filtro = "1=1";
                }
                else
                {
                    Filtro = "UsuarioId = " + ListatextBox.Text;
                }

                dt = usuario.Listar("Nombres, Apellidos, Direccion, NombreUsuario, Contrasena, Contrasena1", Filtro, "");
                ListadataGridView.DataSource = dt;
            }
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
    }
