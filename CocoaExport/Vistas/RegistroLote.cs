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
    public partial class RegistroLote : Form
    {
        Lotes lotes = new Lotes();
        ErrorProvider error = new ErrorProvider();
        BLL.Certificaciones registroc = new BLL.Certificaciones();
        double total;
        int loteId;
        int IdBuscado;
        public RegistroLote()
        {
            InitializeComponent();
        }

        private void RegistroLote_Load(object sender, EventArgs e)
        {
            CertificaionIdcomboBox.DataSource = registroc.Listar("CertificacionId,Descripcion", "1=1", "");
            CertificaionIdcomboBox.DisplayMember = "Descripcion";
            CertificaionIdcomboBox.ValueMember = "CertificacionId";
        }

        private void CodigoLotetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TotaltextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(LoteIdtextBox, "Este campo solo acepta numeros");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (LoteIdtextBox.Text.Length == 0)
            {
                double.TryParse(TotaltextBox.Text, out total);
                lotes.Total = total;
                
                {
                    lotes.CodigoLote = CodigoLotetextBox.Text;
                    lotes.CertificacionId = (int)CertificaionIdcomboBox.SelectedValue;
                    lotes.Fecha = FechadateTimePicker.Text;

                    if (lotes.Insertar())
                    {
                        MessageBox.Show("Se han insertado los datos!");
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar los datos!");
                    }
                }
                
            }
            else
            {
                int.TryParse(LoteIdtextBox.Text, out loteId);
                lotes.LoteId = loteId;

                double.TryParse(TotaltextBox.Text, out total);
                lotes.Total = total;
                lotes.CodigoLote = CodigoLotetextBox.Text;
                lotes.CertificacionId = (int)CertificaionIdcomboBox.SelectedValue;
                lotes.Fecha = FechadateTimePicker.Text;

                lotes.Total = total;
                
                {
                    if (lotes.Insertar())
                    {
                        MessageBox.Show("Se han modificado los datos!");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar los datos!");
                    }
                }
                    
            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(LoteIdtextBox.Text, out loteId);
            lotes.LoteId = loteId;
            if (lotes.Eliminar())
            {
                MessageBox.Show("Se han eliminado los datos!");
            }
            else
            {
                MessageBox.Show("No se han eliminado los datos!");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int.TryParse(LoteIdtextBox.Text, out loteId);
            IdBuscado = loteId;
            if (lotes.Buscar(IdBuscado))
            {

                TotaltextBox.Text = lotes.Total.ToString();
                CodigoLotetextBox.Text = lotes.CodigoLote;
                FechadateTimePicker.Text = lotes.Fecha;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Buscarlabel_Click(object sender, EventArgs e)
        {

        }

        private void LoteIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                error.SetError(LoteIdtextBox, "Este campo solo acepta numeros");
            }
        }
    }
}
