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
       

        double toneladas;
        int exportacionId;
        string addlotes;
        int idbuscado;
        public RegistroExportacion()
        {
            InitializeComponent();
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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            BLL.Exportacion exportacion = new BLL.Exportacion();

            if (ExportacionIdtextBox.Text.Length == 0)
            {
                double.TryParse(CantidadtextBox.Text, out toneladas);
                exportacion.CantidadToneladas = toneladas;
                exportacion.Fecha = FechadateTimePicker.Text;
                exportacion.DestinoId = (int)DestinosIdcomboBox.SelectedValue;
                exportacion.Resumen = ResumenrichTextBox.Text;

                if (toneladas < 25000 || toneladas > 25999)
                {
                    ErrorProvider error = new ErrorProvider();
                    error.SetError(CantidadtextBox, "Asegurese de que la cantidad sea >24999 o <25999");
                }
                else
                {

                    for (int i = 0; i < LoteslistBox.Items.Count; i++)
                    {
                        Lotes lotes = new Lotes();
                        lotes.LoteId = (int)LoteIdcomboBox.SelectedValue;
                        exportacion.AgregarLotes(lotes.LoteId, LoteslistBox.Items[i].ToString());
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
             

            }
            else
            {
                int.TryParse(ExportacionIdtextBox.Text, out exportacionId);
                exportacion.ExportacionId = exportacionId;

                double.TryParse(CantidadtextBox.Text, out toneladas);
                exportacion.CantidadToneladas = toneladas;
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

        private void button3_Click(object sender, EventArgs e)
        {
            LoteslistBox.Items.Add(LoteIdcomboBox.Text);
        }

        private void LotescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DestinosIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CantidadtextBox.Clear();
            ResumenrichTextBox.Clear();
            LoteslistBox.ClearSelected();
            ExportacionIdtextBox.Clear();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Lotes lote = new Lotes();
            Exportacion exportacion = new Exportacion();
            int.TryParse(ExportacionIdtextBox.Text, out idbuscado);
            lote.ExportacionId = idbuscado;
            lote.Buscar(idbuscado);
            
                exportacion.CantidadToneladas = toneladas;
                exportacion.Fecha = FechadateTimePicker.Text;

                foreach (var item in exportacion.Lotes)
                {
                    LoteslistBox.Items.Add(item.CodigoLote);
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
