using System;
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
    public partial class ReporteExpaciones : Form
    {
        public ReporteExpaciones()
        {
            InitializeComponent();
        }

        private void ReporteExpaciones_Load(object sender, EventArgs e)
        {
            ReporteExpaciones reportes = new ReporteExpaciones();
            ExportacionReporte expReporte = new ExportacionReporte();
            reportes.ExportacionesCrystalReportViewer.ReportSource = expReporte;

        }
    }
}
