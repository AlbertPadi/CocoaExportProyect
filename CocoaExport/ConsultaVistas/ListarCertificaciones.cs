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
    public partial class ListarCertificaciones : Form
    {
        public ListarCertificaciones()
        {
            InitializeComponent();
        }

        private void Listarbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BLL.Certificaciones registroc = new BLL.Certificaciones();
            DatoscomboBox.DataSource = registroc.Listar("CertificacionId,Descripcion", "1=1", "");
            DatoscomboBox.DisplayMember = "CertificacionId";
            DatoscomboBox.ValueMember = "Descripcion";

            string Filtro = "1=1";
            if (DatoscomboBox.SelectedIndex == 0)
            {
                if (ListatextBox.Text.Trim().Length == 0)
                {
                    Filtro = "1=1";
                }
                else
                {
                    Filtro = "CertificacionId = " + ListatextBox.Text;
                }

                dt = registroc.Listar("CertificacionId, Descripcion", Filtro, "");
                ListadataGridView.DataSource = dt;
            }
        }


        private void ListarCertificaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
    
