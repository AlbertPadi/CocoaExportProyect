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
    public partial class RegistroSocios : Form
    {
        double CantTerreno;
        int IdBuscado;
        int socioId;
        ErrorProvider error = new ErrorProvider();
        BLL.Socios registro = new BLL.Socios();

        public RegistroSocios()
        {
            
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();

            BLL.Certificaciones registrocer = new BLL.Certificaciones();
            if (SocioIdtextBox.Text.Length == 0)
            {
                Utilities.Utilitarios.Validacion(NombretextBox, error, "No puede haver campos en blanco");
                registro.Nombre = NombretextBox.Text;
                Utilities.Utilitarios.Validacion(ApellidotextBox, error, "No puede haver campos en blanco");
                registro.Apellido = ApellidotextBox.Text;
                Utilities.Utilitarios.Validacion(DirecciontextBox, error, "No puede haver campos en blanco");
                registro.Direccion = DirecciontextBox.Text;
                Utilities.Utilitarios.Validacion(CedulatextBox, error, "No puede haver campos en blanco");
                registro.Cedula = CedulatextBox.Text;
                registro.CertificacionId = (int)CertificacioncomboBox.SelectedValue;


                double.TryParse(TerrenotextBox.Text, out CantTerreno);

                registro.CantidadTerreno = CantTerreno;
                
                if (registro.Insertar())
                {
                    MessageBox.Show("Se guardaron los datos!");
                }
                else
                { 
                    MessageBox.Show("No se han guardado los datos!");
                }

            }
            else if(SocioIdtextBox.Text.Length > 0)
            {
                int.TryParse(SocioIdtextBox.Text, out socioId);
                registro.SocioId = socioId;

                Utilities.Utilitarios.Validacion(NombretextBox, error, "No puede haver campos en blanco");
                registro.Nombre = NombretextBox.Text;
                Utilities.Utilitarios.Validacion(ApellidotextBox, error, "No puede haver campos en blanco");
                registro.Apellido = ApellidotextBox.Text;
                Utilities.Utilitarios.Validacion(DirecciontextBox, error, "No puede haver campos en blanco");
                registro.Direccion = DirecciontextBox.Text;
                Utilities.Utilitarios.Validacion(CedulatextBox, error, "No puede haver campos en blanco");
                registro.Cedula = CedulatextBox.Text;
                double.TryParse(TerrenotextBox.Text, out CantTerreno);

                registro.CantidadTerreno = CantTerreno;


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
            int.TryParse(SocioIdtextBox.Text, out socioId);
            registro.SocioId = socioId;
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
            int vari;
            int.TryParse(SocioIdtextBox.Text, out vari);
            IdBuscado = vari;
            if (registro.Buscar(IdBuscado))
            {
                registro.SocioId = IdBuscado;
                NombretextBox.Text = registro.Nombre;
                ApellidotextBox.Text = registro.Apellido;
                DirecciontextBox.Text = registro.Direccion;
                CedulatextBox.Text = registro.Cedula.ToString();
                CertificacioncomboBox.SelectedItem = registro.CertificacionId;
                TerrenotextBox.Text = registro.CantidadTerreno.ToString();

            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            CedulatextBox.Clear();
            SocioIdtextBox.Clear();
            TerrenotextBox.Clear();

           

        }
        DataTable table = new DataTable();
        DateTime date = DateTime.Now;

        private void RegistroSocios_Load(object sender, EventArgs e)
        {
            BLL.Certificaciones registroc = new BLL.Certificaciones();
            CertificacioncomboBox.DataSource = registroc.Listar("CertificacionId,Descripcion","1=1","");
            CertificacioncomboBox.DisplayMember = "Descripcion";
            CertificacioncomboBox.ValueMember = "CertificacionId";
            Socios socios = new Socios(); 
            

        }

        private void CedulatextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(SocioIdtextBox, "Este campo solo acepta numeros");
            }
        }

        private void TerrenotextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(SocioIdtextBox, "Este campo solo acepta numeros");
            }
        }

        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
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
                error.SetError(ApellidotextBox, "Este Campo no acepta numeros ni caracteres especiales");
            }
        }

        private void SocioIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(SocioIdtextBox, "Este campo solo acepta numeros");
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
                error.SetError(NombretextBox, "Este Campo no acepta numeros ni caracteres especiales");
               
                }
            }

        private void CertificacioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApellidotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
