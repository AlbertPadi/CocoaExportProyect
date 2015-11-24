namespace CocoaExport.Vistas
{
    partial class ExportacionReporte
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
            this.ReportedataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportedataGridView
            // 
            this.ReportedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportedataGridView.Location = new System.Drawing.Point(12, 49);
            this.ReportedataGridView.Name = "ReportedataGridView";
            this.ReportedataGridView.Size = new System.Drawing.Size(875, 201);
            this.ReportedataGridView.TabIndex = 0;
            // 
            // ExportacionReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(899, 262);
            this.Controls.Add(this.ReportedataGridView);
            this.Name = "ExportacionReporte";
            this.Text = "ExportacionReporte";
            this.Load += new System.EventHandler(this.ExportacionReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportedataGridView;
    }
}