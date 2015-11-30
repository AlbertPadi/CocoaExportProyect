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
    public partial class RegistroExportacion : Form
    {
        BLL.Certificaciones certificacion = new BLL.Certificaciones();
        BLL.DestinosExportes destinos = new BLL.DestinosExportes();
        ErrorProvider error = new ErrorProvider();
        
        int exportacionId;
        string addlotes;
        int idbuscado;
        double precio;
        double total;
        double Monto;
        public RegistroExportacion()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //LotesdataGridView.Items.Add(LoteIdcomboBox.Text);
            Lotes lotes = new Lotes();
            DataTable dt = new DataTable();

            lotes.Buscar((int)LoteIdcomboBox.SelectedValue);
            this.LotesdataGridView.Rows.Add(LoteIdcomboBox.SelectedValue.ToString(), lotes.Total.ToString());

            double.TryParse(PreciotextBox.Text, out precio);
            total += lotes.Total * precio;

            TotaltextBox.Text = total.ToString();

            total = Monto;

        }

        private void RegistroExportacion_Load(object sender, EventArgs e)
        {
            Lotes lotes = new Lotes();
            LoteIdcomboBox.DataSource = lotes.Listar("*","1=1","");
            LoteIdcomboBox.DisplayMember = "CodigoLote";
            LoteIdcomboBox.ValueMember = "LoteId";
            addlotes = LoteIdcomboBox.Text;
            

            DestinosIdcomboBox.DataSource = destinos.Listar("DestinoId, NombreDestino", "1=1", "");
            DestinosIdcomboBox.DisplayMember = "NombreDestino";
            DestinosIdcomboBox.ValueMember = "DestinoId";
        }

        private void ExportacionIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(ExportacionIdtextBox, "Este campo solo acepta numeros");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            BLL.Exportacion exportacion = new BLL.Exportacion();

            if (ExportacionIdtextBox.Text.Length == 0)
            {

                exportacion.Fecha = FechadateTimePicker.Text;
                exportacion.DestinoId = (int)DestinosIdcomboBox.SelectedValue;
                exportacion.Resumen = ResumenrichTextBox.Text;
                double.TryParse(TotaltextBox.Text, out Monto);
                exportacion.Monto = Monto;
                

                    for (int i = 0; i < LotesdataGridView.Rows.Count; i++)
                    {
                        Lotes lotes = new Lotes();
                        lotes.LoteId = (int)LoteIdcomboBox.SelectedValue;
                        exportacion.AgregarLotes(lotes.LoteId, LotesdataGridView.Rows[i].ToString());
                    }
                    if (exportacion.Insertar())
                    {
                        MessageBox.Show("El producto esta listo para exportarce");
                    }
                    else
                    {
                        MessageBox.Show("No se han guardado los datos!");
                    }

            }
            else
            {
                int.TryParse(ExportacionIdtextBox.Text, out exportacionId);
                exportacion.ExportacionId = exportacionId;
                exportacion.Fecha = FechadateTimePicker.Text;
                exportacion.ExportacionId = (int)DestinosIdcomboBox.SelectedValue;
                exportacion.Resumen = ResumenrichTextBox.Text;


                if (exportacion.Editar())
                {
                    MessageBox.Show("Se han actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }
            }
        }

        

        private void LotescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DestinosIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResumenrichTextBox.Clear();
            
            ExportacionIdtextBox.Clear();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Lotes lote = new Lotes();
            Exportacion exportacion = new Exportacion();
            int.TryParse(ExportacionIdtextBox.Text, out idbuscado);
            lote.ExportacionId = idbuscado;
            lote.Buscar(idbuscado);
            
                exportacion.Fecha = FechadateTimePicker.Text;

                foreach (var item in exportacion.Lotes)
                {
                LotesdataGridView.Rows.Add(item.CodigoLote);
                }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(ExportacionIdtextBox.Text, out id);
            Exportacion exportacion = new Exportacion();
            exportacion.ExportacionId = id;

            if (exportacion.Eliminar())
            {
                MessageBox.Show("Eliminado con exito!");
            }
        }
    }
    }
