namespace CocoaExport.Vistas
{
    partial class ReporteRecepcion
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
            this.RecepcioncrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RecepcioncrystalReportViewer
            // 
            this.RecepcioncrystalReportViewer.ActiveViewIndex = -1;
            this.RecepcioncrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecepcioncrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.RecepcioncrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecepcioncrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.RecepcioncrystalReportViewer.Name = "RecepcioncrystalReportViewer";
            this.RecepcioncrystalReportViewer.Size = new System.Drawing.Size(609, 502);
            this.RecepcioncrystalReportViewer.TabIndex = 0;
            // 
            // ReporteRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 502);
            this.Controls.Add(this.RecepcioncrystalReportViewer);
            this.Name = "ReporteRecepcion";
            this.Text = "ReporteRecepcion";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer RecepcioncrystalReportViewer;
    }
}