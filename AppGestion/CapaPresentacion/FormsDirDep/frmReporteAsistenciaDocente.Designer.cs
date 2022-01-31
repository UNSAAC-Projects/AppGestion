
namespace CapaPresentacion
{
    partial class frmReporteAsistenciaDocente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReporteAsistenciaDocentes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInferior = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaSuperior = new System.Windows.Forms.DateTimePicker();
            this.buttonExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistenciaDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteAsistenciaDocentes
            // 
            this.dgvReporteAsistenciaDocentes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvReporteAsistenciaDocentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteAsistenciaDocentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteAsistenciaDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteAsistenciaDocentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReporteAsistenciaDocentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteAsistenciaDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteAsistenciaDocentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReporteAsistenciaDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteAsistenciaDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteAsistenciaDocentes.ColumnHeadersHeight = 30;
            this.dgvReporteAsistenciaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteAsistenciaDocentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteAsistenciaDocentes.EnableHeadersVisualStyles = false;
            this.dgvReporteAsistenciaDocentes.Location = new System.Drawing.Point(20, 115);
            this.dgvReporteAsistenciaDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReporteAsistenciaDocentes.Name = "dgvReporteAsistenciaDocentes";
            this.dgvReporteAsistenciaDocentes.RowHeadersVisible = false;
            this.dgvReporteAsistenciaDocentes.RowHeadersWidth = 51;
            this.dgvReporteAsistenciaDocentes.RowTemplate.Height = 24;
            this.dgvReporteAsistenciaDocentes.Size = new System.Drawing.Size(992, 358);
            this.dgvReporteAsistenciaDocentes.TabIndex = 2;
            this.dgvReporteAsistenciaDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteAsistenciaDocentes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(87, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "FECHA INFERIOR:";
            // 
            // dtpFechaInferior
            // 
            this.dtpFechaInferior.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInferior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInferior.Location = new System.Drawing.Point(327, 36);
            this.dtpFechaInferior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInferior.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.Name = "dtpFechaInferior";
            this.dtpFechaInferior.Size = new System.Drawing.Size(178, 23);
            this.dtpFechaInferior.TabIndex = 28;
            this.dtpFechaInferior.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.ValueChanged += new System.EventHandler(this.dtpFechaInferior_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(87, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "FECHA SUPERIOR: ";
            // 
            // dtpFechaSuperior
            // 
            this.dtpFechaSuperior.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSuperior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSuperior.Location = new System.Drawing.Point(327, 69);
            this.dtpFechaSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaSuperior.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.Name = "dtpFechaSuperior";
            this.dtpFechaSuperior.Size = new System.Drawing.Size(178, 23);
            this.dtpFechaSuperior.TabIndex = 30;
            this.dtpFechaSuperior.Value = new System.DateTime(2022, 1, 26, 19, 35, 44, 0);
            this.dtpFechaSuperior.ValueChanged += new System.EventHandler(this.dtpFechaSuperior_ValueChanged);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.Transparent;
            this.buttonExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.FlatAppearance.BorderSize = 3;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.Location = new System.Drawing.Point(721, 48);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(235, 41);
            this.buttonExportar.TabIndex = 31;
            this.buttonExportar.Text = "Exportar Excel";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // frmReporteAsistenciaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1023, 482);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.dtpFechaSuperior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInferior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReporteAsistenciaDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReporteAsistenciaDocente";
            this.Text = "frmReporteAsistenciaDocente";
            this.Load += new System.EventHandler(this.frmReporteAsistenciaDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistenciaDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteAsistenciaDocentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInferior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaSuperior;
        private System.Windows.Forms.Button buttonExportar;
    }
}