
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
            this.txtBuscarAvanceDocente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvanceDocentes
            // 
            this.dgvAvanceDocentes.AllowUserToAddRows = false;
            this.dgvAvanceDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvanceDocentes.Location = new System.Drawing.Point(61, 92);
            this.dgvAvanceDocentes.Name = "dgvAvanceDocentes";
            this.dgvAvanceDocentes.ReadOnly = true;
            this.dgvAvanceDocentes.RowHeadersWidth = 51;
            this.dgvAvanceDocentes.RowTemplate.Height = 24;
            this.dgvAvanceDocentes.Size = new System.Drawing.Size(959, 454);
            this.dgvAvanceDocentes.TabIndex = 0;
            // 
            // txtBuscarAvanceDocente
            // 
            this.txtBuscarAvanceDocente.Location = new System.Drawing.Point(146, 27);
            this.txtBuscarAvanceDocente.Name = "txtBuscarAvanceDocente";
            this.txtBuscarAvanceDocente.Size = new System.Drawing.Size(514, 22);
            this.txtBuscarAvanceDocente.TabIndex = 1;
            this.txtBuscarAvanceDocente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // FrmReporteAvanceDocentesDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarAvanceDocente);
            this.Controls.Add(this.dgvAvanceDocentes);
            this.Name = "FrmReporteAvanceDocentesDepartamento";
            this.Text = "FrmReporteAvanceDocentesDepartamento";
            this.Load += new System.EventHandler(this.FrmReporteAvanceDocentesDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvanceDocentes;
        private System.Windows.Forms.TextBox txtBuscarAvanceDocente;
        private System.Windows.Forms.Label label1;
    }
}