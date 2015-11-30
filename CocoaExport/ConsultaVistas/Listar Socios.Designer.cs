namespace CocoaExport.Vistas
{
    partial class Listar
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
            this.ListadataGridView = new System.Windows.Forms.DataGridView();
            this.DatoscomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Listarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadataGridView
            // 
            this.ListadataGridView.AllowUserToAddRows = false;
            this.ListadataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadataGridView.Location = new System.Drawing.Point(12, 77);
            this.ListadataGridView.Name = "ListadataGridView";
            this.ListadataGridView.Size = new System.Drawing.Size(770, 235);
            this.ListadataGridView.TabIndex = 1;
            // 
            // DatoscomboBox
            // 
            this.DatoscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatoscomboBox.FormattingEnabled = true;
            this.DatoscomboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Apellido"});
            this.DatoscomboBox.Location = new System.Drawing.Point(92, 30);
            this.DatoscomboBox.Name = "DatoscomboBox";
            this.DatoscomboBox.Size = new System.Drawing.Size(191, 21);
            this.DatoscomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listar Por";
            // 
            // ListatextBox
            // 
            this.ListatextBox.Location = new System.Drawing.Point(299, 31);
            this.ListatextBox.Name = "ListatextBox";
            this.ListatextBox.Size = new System.Drawing.Size(366, 20);
            this.ListatextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Listarbutton
            // 
            this.Listarbutton.Image = global::CocoaExport.Properties.Resources._1443814210_fine_print;
            this.Listarbutton.Location = new System.Drawing.Point(671, 30);
            this.Listarbutton.Name = "Listarbutton";
            this.Listarbutton.Size = new System.Drawing.Size(111, 33);
            this.Listarbutton.TabIndex = 5;
            this.Listarbutton.UseVisualStyleBackColor = true;
            this.Listarbutton.Click += new System.EventHandler(this.Listarbutton_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(803, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Listarbutton);
            this.Controls.Add(this.ListatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatoscomboBox);
            this.Controls.Add(this.ListadataGridView);
            this.Name = "Listar";
            this.Text = "Listar Socios";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ListadataGridView;
        private System.Windows.Forms.ComboBox DatoscomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ListatextBox;
        private System.Windows.Forms.Button Listarbutton;
        private System.Windows.Forms.Label label2;
    }
}