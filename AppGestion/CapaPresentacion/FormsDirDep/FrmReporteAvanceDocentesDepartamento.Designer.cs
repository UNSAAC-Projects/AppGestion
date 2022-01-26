
namespace CapaPresentacion.FormsDirDep
{
    partial class FrmReporteAvanceDocentesDepartamento
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
            this.dgvAvanceDocentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvanceDocentes
            // 
            this.dgvAvanceDocentes.AllowUserToAddRows = false;
            this.dgvAvanceDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvanceDocentes.Location = new System.Drawing.Point(60, 65);
            this.dgvAvanceDocentes.Name = "dgvAvanceDocentes";
            this.dgvAvanceDocentes.ReadOnly = true;
            this.dgvAvanceDocentes.RowHeadersWidth = 51;
            this.dgvAvanceDocentes.RowTemplate.Height = 24;
            this.dgvAvanceDocentes.Size = new System.Drawing.Size(959, 454);
            this.dgvAvanceDocentes.TabIndex = 0;
            // 
            // FrmReporteAvanceDocentesDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 531);
            this.Controls.Add(this.dgvAvanceDocentes);
            this.Name = "FrmReporteAvanceDocentesDepartamento";
            this.Text = "FrmReporteAvanceDocentesDepartamento";
            this.Load += new System.EventHandler(this.FrmReporteAvanceDocentesDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvanceDocentes;
    }
}