﻿using System;
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


                for (int i = 0; i < LoteslistBox.Items.Count; i++)
                 {
                     Lotes lotes = new Lotes();
                    lotes.LoteId = (int)LoteIdcomboBox.SelectedValue;
                    exportacion.AgregarLotes(lotes.LoteId,LoteslistBox.Items[i].ToString());
                 }
                 if (exportacion.Insertar())
                 {
                     MessageBox.Show("Se guardaron los datos!");
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
    }
}
