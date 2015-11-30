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
    public partial class ListarTipoCacao : Form
    {
        TipoCacao tipo = new TipoCacao();
        public ListarTipoCacao()
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
                    Condicion = "TipoCacaoId = " + ListatextBox.Text;
                }

                dt = tipo.Listar("TipoCacaoId, Descripcion", Condicion, "");
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
                    Condicion = String.Format("Descripcion  like '{0}%' ", ListatextBox.Text);
                }

                dt = tipo.Listar("TipoCacaoId, Descripcion", Condicion, "");
                ListadataGridView.DataSource = dt;
            }
        }
    }
}
