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
    public partial class RegistroUsuarios : Form
    {
        Usuarios Registro = new Usuarios();
        ErrorProvider error = new ErrorProvider();
        int usuarioId;
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void UsuarioIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(UsuarioIdtextBox, "Este campo solo acepta numeros");
            }
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(ApellidotextBox, "Este campo no acepta numeros ni caracteres especiales");
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(NombretextBox, "Este campo no acepta numeros ni caracteres especiales");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            
            int.TryParse(UsuarioIdtextBox.Text, out usuarioId);
            
            if (UsuarioIdtextBox.Text.Length == 0)
            {
                Utilities.Utilitarios.Validacion(NombretextBox, errorProvider, "No puede haver campos en blanco");
                Registro.Nombre = NombretextBox.Text;
                Utilities.Utilitarios.Validacion(ApellidotextBox, errorProvider, "No puede haver campos en blanco");
                Registro.Apellido = ApellidotextBox.Text;
                Utilities.Utilitarios.Validacion(DirecciontextBox, errorProvider, "No puede haver campos en blanco");
                Registro.Direccion = DirecciontextBox.Text;
                Utilities.Utilitarios.Validacion(NomUsuariotextBox, errorProvider, "No puede haver campos en blanco");
                Registro.NombreUsuario = NomUsuariotextBox.Text;
                Utilities.Utilitarios.Validacion(ContraseñatextBox, errorProvider, "No puede haver campos en blanco");
                Registro.Contrasena = ContraseñatextBox.Text;
                Utilities.Utilitarios.Validacion(Contrasena1textBox, errorProvider, "No puede haver campos en blanco");
                Registro.Contrasena1 = Contrasena1textBox.Text;

                if (ContraseñatextBox.Text.Trim() != Contrasena1textBox.Text.Trim())
                {
                    errorProvider.SetError(ContraseñatextBox, "Las contraseña no son identicas");
                    errorProvider.SetError(Contrasena1textBox, "Las contraseña no son identicas");
                    Contrasena1textBox.Clear();
                }
               
                else
                {
                    if (Registro.Insertar())
                    {
                        MessageBox.Show("Se insertaron los datos correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("No se han podido guardar los datos!");
                    }
                }
                
            }
            else if(UsuarioIdtextBox.Text.Length > 0)
            {
                Registro.UsuarioId = usuarioId;

                Registro.Nombre = NombretextBox.Text;
                Registro.Apellido = ApellidotextBox.Text;
                Registro.Direccion = DirecciontextBox.Text;
                Registro.NombreUsuario = NomUsuariotextBox.Text;
                Registro.Contrasena = ContraseñatextBox.Text;
                Registro.Contrasena1 = Contrasena1textBox.Text;

                if (ContraseñatextBox.Text.Trim() != Contrasena1textBox.Text.Trim())
                {
                    errorProvider.SetError(ContraseñatextBox, "Las contraseña no son identicas");
                    errorProvider.SetError(Contrasena1textBox, "Las contraseña no son identicas");
                    Contrasena1textBox.Clear();
                }
                else
                {
                    if (Registro.Editar())
                    {
                        MessageBox.Show("Se han actualizado los datos correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("No se han actualizado podido guardar los datos!");
                    }
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            NomUsuariotextBox.Clear();
            ContraseñatextBox.Clear();
            Contrasena1textBox.Clear();
            UsuarioIdtextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(UsuarioIdtextBox.Text, out usuarioId);
            Registro.UsuarioId = usuarioId;
            if (Registro.Eliminar())
            {
                MessageBox.Show("Se eliminaron los datos!");
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos!");
            }
             
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int.TryParse(UsuarioIdtextBox.Text, out usuarioId);
            int IdBuscado;
            IdBuscado = usuarioId;
            if (Registro.Buscar(IdBuscado))
            {
                NombretextBox.Text = Registro.Nombre;
                ApellidotextBox.Text = Registro.Apellido;
                DirecciontextBox.Text = Registro.Direccion;
                ContraseñatextBox.Text = Registro.Contrasena;
                NomUsuariotextBox.Text = Registro.NombreUsuario;
                Contrasena1textBox.Text = Registro.Contrasena1;
            }
        }

        private void ApellidotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
