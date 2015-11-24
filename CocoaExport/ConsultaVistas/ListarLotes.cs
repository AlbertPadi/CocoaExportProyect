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
    public partial class ListarLotes : Form
    {
        Lotes lotes = new Lotes();
        public ListarLotes()
        {
            InitializeComponent();
        }

        private void Listarbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DatoscomboBox.DataSource = lotes.Listar("LoteId, CodigoLote, Total, CertificacionId, Fecha", "1=1", "");
            DatoscomboBox.DisplayMember = "LoteId";
            DatoscomboBox.ValueMember = "CodigoLote";

            string Filtro = "1=1";
            if (DatoscomboBox.SelectedIndex == 0)
            {
                if (ListatextBox.Text.Trim().Length == 0)
                {
                    Filtro = "1=1";
                }
                else
                {
                    Filtro = "LoteId = " + ListatextBox.Text;
                }

                dt = lotes.Listar("LoteId, CodigoLote, Total, CertificacionId, Fecha", Filtro, "");
                ListadataGridView.DataSource = dt;
            }
        }

        private void ListarLotes_Load(object sender, EventArgs e)
        {

        }
    }
}
