
namespace CapaPresentacion
{
    partial class frmReporteAsistenciasAlumnos
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
            this.dgvReporteAsistencia = new System.Windows.Forms.DataGridView();
            this.comboBoxCursosReporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInferior = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSuperior = new System.Windows.Forms.DateTimePicker();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.cbNombreCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteAsistencia
            // 
            this.dgvReporteAsistencia.AllowUserToAddRows = false;
            this.dgvReporteAsistencia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvReporteAsistencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReporteAsistencia.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReporteAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteAsistencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteAsistencia.EnableHeadersVisualStyles = false;
            this.dgvReporteAsistencia.Location = new System.Drawing.Point(28, 163);
            this.dgvReporteAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReporteAsistencia.Name = "dgvReporteAsistencia";
            this.dgvReporteAsistencia.RowHeadersVisible = false;
            this.dgvReporteAsistencia.RowHeadersWidth = 51;
            this.dgvReporteAsistencia.RowTemplate.Height = 24;
            this.dgvReporteAsistencia.Size = new System.Drawing.Size(1049, 478);
            this.dgvReporteAsistencia.TabIndex = 1;
            this.dgvReporteAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBoxCursosReporte
            // 
            this.comboBoxCursosReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCursosReporte.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursosReporte.FormattingEnabled = true;
            this.comboBoxCursosReporte.Location = new System.Drawing.Point(157, 48);
            this.comboBoxCursosReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCursosReporte.Name = "comboBoxCursosReporte";
            this.comboBoxCursosReporte.Size = new System.Drawing.Size(425, 25);
            this.comboBoxCursosReporte.TabIndex = 2;
            this.comboBoxCursosReporte.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "CURSO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(145, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 2);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(182, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "FECHA INFERIOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(553, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "FECHA SUPERIOR: ";
            // 
            // dtpFechaInferior
            // 
            this.dtpFechaInferior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInferior.Location = new System.Drawing.Point(349, 115);
            this.dtpFechaInferior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInferior.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.Name = "dtpFechaInferior";
            this.dtpFechaInferior.Size = new System.Drawing.Size(178, 22);
            this.dtpFechaInferior.TabIndex = 27;
            this.dtpFechaInferior.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.ValueChanged += new System.EventHandler(this.dtpFechaInferior_ValueChanged);
            // 
            // dtpFechaSuperior
            // 
            this.dtpFechaSuperior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSuperior.Location = new System.Drawing.Point(730, 115);
            this.dtpFechaSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaSuperior.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.Name = "dtpFechaSuperior";
            this.dtpFechaSuperior.Size = new System.Drawing.Size(178, 22);
            this.dtpFechaSuperior.TabIndex = 28;
            this.dtpFechaSuperior.Value = new System.DateTime(2022, 1, 26, 0, 0, 0, 0);
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
            this.buttonExportar.Location = new System.Drawing.Point(745, 48);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(235, 41);
            this.buttonExportar.TabIndex = 29;
            this.buttonExportar.Text = "Exportar Excel";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(35, 163);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(121, 25);
            this.cbGrupo.TabIndex = 30;
            this.cbGrupo.Visible = false;
            // 
            // cbNombreCurso
            // 
            this.cbNombreCurso.FormattingEnabled = true;
            this.cbNombreCurso.Location = new System.Drawing.Point(172, 162);
            this.cbNombreCurso.Name = "cbNombreCurso";
            this.cbNombreCurso.Size = new System.Drawing.Size(121, 25);
            this.cbNombreCurso.TabIndex = 31;
            this.cbNombreCurso.Visible = false;
            // 
            // frmReporteAsistenciasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 694);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.dtpFechaSuperior);
            this.Controls.Add(this.dtpFechaInferior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCursosReporte);
            this.Controls.Add(this.dgvReporteAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReporteAsistenciasAlumnos";
            this.Text = "ReporteAsistenciasAlumnos";
            this.Load += new System.EventHandler(this.ReporteAsistenciasAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteAsistencia;
        private System.Windows.Forms.ComboBox comboBoxCursosReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInferior;
        private System.Windows.Forms.DateTimePicker dtpFechaSuperior;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.ComboBox cbNombreCurso;
    }
}