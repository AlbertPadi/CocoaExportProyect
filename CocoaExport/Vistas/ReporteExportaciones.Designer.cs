namespace CocoaExport.Vistas
{
    partial class ReporteExportaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExportacionesCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ExportacionesCrystalReportViewer
            // 
            this.ExportacionesCrystalReportViewer.ActiveViewIndex = -1;
            this.ExportacionesCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExportacionesCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportacionesCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportacionesCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ExportacionesCrystalReportViewer.Name = "ExportacionesCrystalReportViewer";
            this.ExportacionesCrystalReportViewer.Size = new System.Drawing.Size(828, 509);
            this.ExportacionesCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteExpaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 509);
            this.Controls.Add(this.ExportacionesCrystalReportViewer);
            this.Name = "ReporteExpaciones";
            this.Text = "ReporteExpaciones";
            this.Load += new System.EventHandler(this.ReporteExpaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ExportacionesCrystalReportViewer;
    }
}