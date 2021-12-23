
namespace CapaPresentacion
{
    partial class FrmReporteAsistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboAsistenciaCurso = new System.Windows.Forms.ComboBox();
            this.dgvAsistenciaReporte = new System.Windows.Forms.DataGridView();
            this.Asistencia = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por :";
            // 
            // cboAsistenciaCurso
            // 
            this.cboAsistenciaCurso.FormattingEnabled = true;
            this.cboAsistenciaCurso.Location = new System.Drawing.Point(210, 33);
            this.cboAsistenciaCurso.Name = "cboAsistenciaCurso";
            this.cboAsistenciaCurso.Size = new System.Drawing.Size(343, 24);
            this.cboAsistenciaCurso.TabIndex = 1;
            this.cboAsistenciaCurso.SelectedIndexChanged += new System.EventHandler(this.cboAsistenciaCurso_SelectedIndexChanged);
            this.cboAsistenciaCurso.Click += new System.EventHandler(this.cboAsistenciaCurso_Click);
            // 
            // dgvAsistenciaReporte
            // 
            this.dgvAsistenciaReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia});
            this.dgvAsistenciaReporte.Location = new System.Drawing.Point(43, 89);
            this.dgvAsistenciaReporte.Name = "dgvAsistenciaReporte";
            this.dgvAsistenciaReporte.RowHeadersWidth = 51;
            this.dgvAsistenciaReporte.RowTemplate.Height = 24;
            this.dgvAsistenciaReporte.Size = new System.Drawing.Size(641, 554);
            this.dgvAsistenciaReporte.TabIndex = 2;
            this.dgvAsistenciaReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistenciaReporte_CellContentClick);
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.Image = global::CapaPresentacion.Properties.Resources.pdf_24px;
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Asistencia.Width = 125;
            // 
            // FrmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 694);
            this.Controls.Add(this.dgvAsistenciaReporte);
            this.Controls.Add(this.cboAsistenciaCurso);
            this.Controls.Add(this.label1);
            this.Name = "FrmReporteAsistencia";
            this.Text = "FrmReporteAsistencia";
            this.Load += new System.EventHandler(this.FrmReporteAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAsistenciaCurso;
        private System.Windows.Forms.DataGridView dgvAsistenciaReporte;
        private System.Windows.Forms.DataGridViewImageColumn Asistencia;
    }
}