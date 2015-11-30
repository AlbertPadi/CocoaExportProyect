namespace CocoaExport.Vistas
{
    partial class ExportacionesReporte
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
            this.ExpcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ExpcrystalReportViewer
            // 
            this.ExpcrystalReportViewer.ActiveViewIndex = -1;
            this.ExpcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ExpcrystalReportViewer.Name = "ExpcrystalReportViewer";
            this.ExpcrystalReportViewer.Size = new System.Drawing.Size(604, 470);
            this.ExpcrystalReportViewer.TabIndex = 0;
            // 
            // ExportacionesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 470);
            this.Controls.Add(this.ExpcrystalReportViewer);
            this.Name = "ExportacionesReporte";
            this.Text = "ExportacionesReporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ExpcrystalReportViewer;
    }
}