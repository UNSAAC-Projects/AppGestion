
namespace CapaPresentacion
{
    partial class ReporteAsistenciasAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteAsistenciasAlumnos));
            this.dgvReporteAsistencia = new System.Windows.Forms.DataGridView();
            this.comboBoxCursosReporte = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizarFrmReporte = new System.Windows.Forms.PictureBox();
            this.btnCancelarFrmReporte = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarFrmReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarFrmReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteAsistencia
            // 
            this.dgvReporteAsistencia.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvReporteAsistencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReporteAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReporteAsistencia.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReporteAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvReporteAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteAsistencia.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvReporteAsistencia.Location = new System.Drawing.Point(57, 244);
            this.dgvReporteAsistencia.Name = "dgvReporteAsistencia";
            this.dgvReporteAsistencia.RowHeadersVisible = false;
            this.dgvReporteAsistencia.RowHeadersWidth = 51;
            this.dgvReporteAsistencia.RowTemplate.Height = 24;
            this.dgvReporteAsistencia.Size = new System.Drawing.Size(1041, 603);
            this.dgvReporteAsistencia.TabIndex = 1;
            this.dgvReporteAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBoxCursosReporte
            // 
            this.comboBoxCursosReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCursosReporte.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursosReporte.FormattingEnabled = true;
            this.comboBoxCursosReporte.Location = new System.Drawing.Point(172, 108);
            this.comboBoxCursosReporte.Name = "comboBoxCursosReporte";
            this.comboBoxCursosReporte.Size = new System.Drawing.Size(478, 29);
            this.comboBoxCursosReporte.TabIndex = 2;
            this.comboBoxCursosReporte.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurso_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnMinimizarFrmReporte);
            this.panel1.Controls.Add(this.btnCancelarFrmReporte);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnMinimizarFrmReporte
            // 
            this.btnMinimizarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarFrmReporte.Image")));
            this.btnMinimizarFrmReporte.Location = new System.Drawing.Point(1062, 5);
            this.btnMinimizarFrmReporte.Name = "btnMinimizarFrmReporte";
            this.btnMinimizarFrmReporte.Size = new System.Drawing.Size(46, 46);
            this.btnMinimizarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarFrmReporte.TabIndex = 59;
            this.btnMinimizarFrmReporte.TabStop = false;
            this.btnMinimizarFrmReporte.Click += new System.EventHandler(this.btnMinimizarFrmReporte_Click);
            // 
            // btnCancelarFrmReporte
            // 
            this.btnCancelarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFrmReporte.Image")));
            this.btnCancelarFrmReporte.Location = new System.Drawing.Point(1114, 5);
            this.btnCancelarFrmReporte.Name = "btnCancelarFrmReporte";
            this.btnCancelarFrmReporte.Size = new System.Drawing.Size(46, 46);
            this.btnCancelarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarFrmReporte.TabIndex = 58;
            this.btnCancelarFrmReporte.TabStop = false;
            this.btnCancelarFrmReporte.Click += new System.EventHandler(this.btnCancelarFrmReporte_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(42, 45);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 57;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 30);
            this.label11.TabIndex = 34;
            this.label11.Text = "REPORTE DE ASISTENCIAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(51, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CURSO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(159, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 1);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(200, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
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
            this.label3.Location = new System.Drawing.Point(618, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "FECHA SUPERIOR: ";
            // 
            // dtpFechaInferior
            // 
            this.dtpFechaInferior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInferior.Location = new System.Drawing.Point(388, 191);
            this.dtpFechaInferior.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.Name = "dtpFechaInferior";
            this.dtpFechaInferior.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaInferior.TabIndex = 27;
            this.dtpFechaInferior.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.ValueChanged += new System.EventHandler(this.dtpFechaInferior_ValueChanged);
            // 
            // dtpFechaSuperior
            // 
            this.dtpFechaSuperior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSuperior.Location = new System.Drawing.Point(817, 191);
            this.dtpFechaSuperior.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.Name = "dtpFechaSuperior";
            this.dtpFechaSuperior.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaSuperior.TabIndex = 28;
            this.dtpFechaSuperior.Value = new System.DateTime(2022, 1, 18, 17, 15, 0, 0);
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
            this.buttonExportar.Location = new System.Drawing.Point(834, 108);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(264, 51);
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
            this.cbGrupo.Size = new System.Drawing.Size(121, 28);
            this.cbGrupo.TabIndex = 30;
            this.cbGrupo.Visible = false;
            // 
            // cbNombreCurso
            // 
            this.cbNombreCurso.FormattingEnabled = true;
            this.cbNombreCurso.Location = new System.Drawing.Point(172, 162);
            this.cbNombreCurso.Name = "cbNombreCurso";
            this.cbNombreCurso.Size = new System.Drawing.Size(121, 28);
            this.cbNombreCurso.TabIndex = 31;
            this.cbNombreCurso.Visible = false;
            // 
            // ReporteAsistenciasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1164, 928);
            this.Controls.Add(this.cbNombreCurso);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.dtpFechaSuperior);
            this.Controls.Add(this.dtpFechaInferior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCursosReporte);
            this.Controls.Add(this.dgvReporteAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteAsistenciasAlumnos";
            this.Text = "ReporteAsistenciasAlumnos";
            this.Load += new System.EventHandler(this.ReporteAsistenciasAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarFrmReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarFrmReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteAsistencia;
        private System.Windows.Forms.ComboBox comboBoxCursosReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCancelarFrmReporte;
        private System.Windows.Forms.PictureBox btnMinimizarFrmReporte;
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