
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAvanceDocentes = new System.Windows.Forms.DataGridView();
            this.txtBuscarAvanceDocente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvanceDocentes
            // 
            this.dgvAvanceDocentes.AllowUserToAddRows = false;
            this.dgvAvanceDocentes.AllowUserToDeleteRows = false;
            this.dgvAvanceDocentes.AllowUserToOrderColumns = true;
            this.dgvAvanceDocentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvAvanceDocentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAvanceDocentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvanceDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvanceDocentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAvanceDocentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvanceDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvanceDocentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAvanceDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvanceDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAvanceDocentes.ColumnHeadersHeight = 32;
            this.dgvAvanceDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvanceDocentes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAvanceDocentes.EnableHeadersVisualStyles = false;
            this.dgvAvanceDocentes.Location = new System.Drawing.Point(61, 92);
            this.dgvAvanceDocentes.Name = "dgvAvanceDocentes";
            this.dgvAvanceDocentes.RowHeadersVisible = false;
            this.dgvAvanceDocentes.RowHeadersWidth = 51;
            this.dgvAvanceDocentes.RowTemplate.Height = 24;
            this.dgvAvanceDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAvanceDocentes.Size = new System.Drawing.Size(959, 454);
            this.dgvAvanceDocentes.TabIndex = 0;
            // 
            // txtBuscarAvanceDocente
            // 
            this.txtBuscarAvanceDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarAvanceDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAvanceDocente.Location = new System.Drawing.Point(171, 52);
            this.txtBuscarAvanceDocente.Name = "txtBuscarAvanceDocente";
            this.txtBuscarAvanceDocente.Size = new System.Drawing.Size(514, 23);
            this.txtBuscarAvanceDocente.TabIndex = 1;
            this.txtBuscarAvanceDocente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(171, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 1);
            this.panel2.TabIndex = 3;
            // 
            // FrmReporteAvanceDocentesDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1099, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarAvanceDocente);
            this.Controls.Add(this.dgvAvanceDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Panel panel2;
    }
}