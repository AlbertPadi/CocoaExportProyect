﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocoaExport.Vistas
{
    public partial class ReporteExportaciones : Form
    {
        public ReporteExportaciones()
        {
            InitializeComponent();
        }

        private void ReporteExpaciones_Load(object sender, EventArgs e)
        {
            ReporteExportaciones reportes = new ReporteExportaciones();
           // ExportacionReporte expReporte = new ExportacionReporte();
           ExportacionesCrystalReportViewer.ReportSource = reportes;

        }
    }
}
