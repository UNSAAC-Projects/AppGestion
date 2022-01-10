namespace CapaPresentacion
{
    partial class frmReportesSesiones
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
            this.dgvReporteSesiones = new System.Windows.Forms.DataGridView();
            this.labelReporteAsistencia = new System.Windows.Forms.Label();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonCerrrar = new System.Windows.Forms.Button();
            this.comboBoxAsignaturas = new System.Windows.Forms.ComboBox();
            this.labelAsignatura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteSesiones
            // 
            this.dgvReporteSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteSesiones.Location = new System.Drawing.Point(36, 95);
            this.dgvReporteSesiones.Name = "dgvReporteSesiones";
            this.dgvReporteSesiones.Size = new System.Drawing.Size(734, 294);
            this.dgvReporteSesiones.TabIndex = 0;
            // 
            // labelReporteAsistencia
            // 
            this.labelReporteAsistencia.AutoSize = true;
            this.labelReporteAsistencia.Location = new System.Drawing.Point(12, 18);
            this.labelReporteAsistencia.Name = "labelReporteAsistencia";
            this.labelReporteAsistencia.Size = new System.Drawing.Size(123, 13);
            this.labelReporteAsistencia.TabIndex = 1;
            this.labelReporteAsistencia.Text = "REPORTE DE AVANCE";
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(497, 405);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(142, 33);
            this.buttonExportar.TabIndex = 2;
            this.buttonExportar.Text = "Exportar Excel";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // buttonCerrrar
            // 
            this.buttonCerrrar.Location = new System.Drawing.Point(666, 405);
            this.buttonCerrrar.Name = "buttonCerrrar";
            this.buttonCerrrar.Size = new System.Drawing.Size(104, 33);
            this.buttonCerrrar.TabIndex = 3;
            this.buttonCerrrar.Text = "Cerrar";
            this.buttonCerrrar.UseVisualStyleBackColor = true;
            this.buttonCerrrar.Click += new System.EventHandler(this.buttonCerrrar_Click);
            // 
            // comboBoxAsignaturas
            // 
            this.comboBoxAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAsignaturas.FormattingEnabled = true;
            this.comboBoxAsignaturas.Location = new System.Drawing.Point(285, 46);
            this.comboBoxAsignaturas.Name = "comboBoxAsignaturas";
            this.comboBoxAsignaturas.Size = new System.Drawing.Size(216, 21);
            this.comboBoxAsignaturas.TabIndex = 4;
            this.comboBoxAsignaturas.SelectedIndexChanged += new System.EventHandler(this.comboBoxAsignaturas_SelectedIndexChanged);
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.Location = new System.Drawing.Point(216, 49);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(63, 13);
            this.labelAsignatura.TabIndex = 5;
            this.labelAsignatura.Text = "Asignatura: ";
            // 
            // frmReportesSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAsignatura);
            this.Controls.Add(this.comboBoxAsignaturas);
            this.Controls.Add(this.buttonCerrrar);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.labelReporteAsistencia);
            this.Controls.Add(this.dgvReporteSesiones);
            this.Name = "frmReportesSesiones";
            this.Text = "frmReportesSesiones";
            this.Load += new System.EventHandler(this.frmReportesSesiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteSesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteSesiones;
        private System.Windows.Forms.Label labelReporteAsistencia;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonCerrrar;
        private System.Windows.Forms.ComboBox comboBoxAsignaturas;
        private System.Windows.Forms.Label labelAsignatura;
    }
}