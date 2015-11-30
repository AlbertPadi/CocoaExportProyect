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
    public partial class ListarInspecciones : Form
    {
        Inspeciones inspeccion = new Inspeciones();
        public ListarInspecciones()
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
                    Condicion = "InspeccionId = " + ListatextBox.Text;
                }

                dt = inspeccion.Listar("InspeccionId, SocioId, Fecha, Fertilizantes, MaterialSiembra, CrianzaAnimales, ControlPlagas, ResumenInspeccion", Condicion, "");
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
                    int id;
                    int.TryParse(ListatextBox.Text, out id);
                    Condicion = " SocioId = " + id.ToString();
                }

                dt = inspeccion.Listar("InspeccionId, SocioId, Fecha, Fertilizantes, MaterialSiembra, CrianzaAnimales, ControlPlagas, ResumenInspeccion", Condicion, "");
                ListadataGridView.DataSource = dt;
            }
        }

        private void ListarInspecciones_Load(object sender, EventArgs e)
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
