﻿namespace CocoaExport.Vistas
{
    partial class RegistroExportacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroExportacion));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResumenrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExportacionIdtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DestinosIdcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LoteIdcomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AgregarLotebutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.LotesdataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LotesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resumen";
            // 
            // ResumenrichTextBox
            // 
            this.ResumenrichTextBox.Location = new System.Drawing.Point(436, 116);
            this.ResumenrichTextBox.Name = "ResumenrichTextBox";
            this.ResumenrichTextBox.Size = new System.Drawing.Size(335, 121);
            this.ResumenrichTextBox.TabIndex = 4;
            this.ResumenrichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exportacion Id";
            // 
            // ExportacionIdtextBox
            // 
            this.ExportacionIdtextBox.Location = new System.Drawing.Point(550, 17);
            this.ExportacionIdtextBox.Name = "ExportacionIdtextBox";
            this.ExportacionIdtextBox.Size = new System.Drawing.Size(103, 20);
            this.ExportacionIdtextBox.TabIndex = 9;
            this.ExportacionIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExportacionIdtextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Destinos";
            // 
            // DestinosIdcomboBox
            // 
            this.DestinosIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinosIdcomboBox.FormattingEnabled = true;
            this.DestinosIdcomboBox.Items.AddRange(new object[] {
            ""});
            this.DestinosIdcomboBox.Location = new System.Drawing.Point(550, 68);
            this.DestinosIdcomboBox.Name = "DestinosIdcomboBox";
            this.DestinosIdcomboBox.Size = new System.Drawing.Size(221, 21);
            this.DestinosIdcomboBox.TabIndex = 3;
            this.DestinosIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.DestinosIdcomboBox_SelectedIndexChanged);
            // 
            // Buscarlabel
            // 
            this.Buscarlabel.AutoSize = true;
            this.Buscarlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarlabel.Location = new System.Drawing.Point(694, 49);
            this.Buscarlabel.Name = "Buscarlabel";
            this.Buscarlabel.Size = new System.Drawing.Size(56, 16);
            this.Buscarlabel.TabIndex = 25;
            this.Buscarlabel.Text = "Buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Eliminar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nuevo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(567, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Guardar";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(127, 21);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(221, 20);
            this.FechadateTimePicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lotes";
            // 
            // LoteIdcomboBox
            // 
            this.LoteIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoteIdcomboBox.FormattingEnabled = true;
            this.LoteIdcomboBox.Items.AddRange(new object[] {
            ""});
            this.LoteIdcomboBox.Location = new System.Drawing.Point(127, 115);
            this.LoteIdcomboBox.Name = "LoteIdcomboBox";
            this.LoteIdcomboBox.Size = new System.Drawing.Size(221, 21);
            this.LoteIdcomboBox.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(354, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Añadir";
            // 
            // AgregarLotebutton
            // 
            this.AgregarLotebutton.Image = global::CocoaExport.Properties.Resources.plus_32;
            this.AgregarLotebutton.Location = new System.Drawing.Point(350, 113);
            this.AgregarLotebutton.Name = "AgregarLotebutton";
            this.AgregarLotebutton.Size = new System.Drawing.Size(57, 24);
            this.AgregarLotebutton.TabIndex = 2;
            this.AgregarLotebutton.UseVisualStyleBackColor = true;
            this.AgregarLotebutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::CocoaExport.Properties.Resources.Inspection_128;
            this.Buscarbutton.Location = new System.Drawing.Point(676, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 34);
            this.Buscarbutton.TabIndex = 24;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // button2
            // 
            this.button2.Image = global::CocoaExport.Properties.Resources.trash_circle_red_32;
            this.button2.Location = new System.Drawing.Point(674, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CocoaExport.Properties.Resources.plus_32;
            this.button1.Location = new System.Drawing.Point(434, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::CocoaExport.Properties.Resources._1441773161_save;
            this.Guardarbutton.Location = new System.Drawing.Point(552, 258);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(95, 34);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // LotesdataGridView
            // 
            this.LotesdataGridView.AllowUserToAddRows = false;
            this.LotesdataGridView.AllowUserToDeleteRows = false;
            this.LotesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LotesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoLote,
            this.Cantidad});
            this.LotesdataGridView.Location = new System.Drawing.Point(127, 155);
            this.LotesdataGridView.Name = "LotesdataGridView";
            this.LotesdataGridView.ReadOnly = true;
            this.LotesdataGridView.Size = new System.Drawing.Size(228, 121);
            this.LotesdataGridView.TabIndex = 34;
            // 
            // CodigoLote
            // 
            this.CodigoLote.HeaderText = "Codigo Lote";
            this.CodigoLote.Name = "CodigoLote";
            this.CodigoLote.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(127, 282);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(228, 20);
            this.TotaltextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Total";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(127, 69);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(228, 20);
            this.PreciotextBox.TabIndex = 37;
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Precio Quintal";
            // 
            // RegistroExportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(826, 330);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.LotesdataGridView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AgregarLotebutton);
            this.Controls.Add(this.LoteIdcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Buscarlabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.DestinosIdcomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExportacionIdtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResumenrichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroExportacion";
            this.Text = "Registro Exportacion";
            this.Load += new System.EventHandler(this.RegistroExportacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LotesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ResumenrichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExportacionIdtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DestinosIdcomboBox;
        private System.Windows.Forms.Label Buscarlabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LoteIdcomboBox;
        private System.Windows.Forms.Button AgregarLotebutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView LotesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label6;
    }
}