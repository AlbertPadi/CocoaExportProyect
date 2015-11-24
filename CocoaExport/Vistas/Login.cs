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
    public partial class Login : Form
    {
        ErrorProvider error = new ErrorProvider();
        Usuarios registro = new Usuarios();
        Principal principal = new Principal();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {
            Utilities.Utilitarios.Validacion(NombretextBox, error, "No puede haver campos en blanco");
            registro.NombreUsuario = NombretextBox.Text;
            Utilities.Utilitarios.Validacion(ContrasenatextBox, error, "No puede haver campos en blanco");
            registro.Contrasena = ContrasenatextBox.Text;

            if (registro.Login())
            {
                if (NombretextBox.Text == registro.NombreUsuario && ContrasenatextBox.Text == registro.Contrasena)
                {

                    
                    principal.Show();
                    this.Visible = false;
                }
                
            }
            else 
            {
                
                error.SetError(NombretextBox, "Usuario Incorrecto");
                error.SetError(ContrasenatextBox, "Contrasena Incorrecta");


            }
 

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            ContrasenatextBox.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ContrasenatextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ContrasenatextBox_KeyDown(object sender, KeyPressEventArgs e)
        {
            
            }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void imagenpictureBox_Click(object sender, EventArgs e)
        {
            Utilities.Utilitarios.Validacion(NombretextBox, error, "No puede haver campos en blanco");
            registro.NombreUsuario = NombretextBox.Text;
            Utilities.Utilitarios.Validacion(ContrasenatextBox, error, "No puede haver campos en blanco");
            registro.Contrasena = ContrasenatextBox.Text;

            if (registro.Login())
            {
                if (NombretextBox.Text == registro.NombreUsuario && ContrasenatextBox.Text == registro.Contrasena)
                {

                    
                    principal.Show();
                    this.Visible = false;
                }

            }
            else
            {

                error.SetError(NombretextBox, "Usuario Incorrecto");
                error.SetError(ContrasenatextBox, "Contrasena Incorrecta");


            }
        }
    }
}
