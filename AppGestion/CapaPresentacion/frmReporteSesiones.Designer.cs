﻿namespace CapaPresentacion
{
    partial class frmReporteSesiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteSesiones));
            this.dgvReporteSesiones = new System.Windows.Forms.DataGridView();
            this.labelReporteAsistencia = new System.Windows.Forms.Label();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonCerrrar = new System.Windows.Forms.Button();
            this.comboBoxAsignaturas = new System.Windows.Forms.ComboBox();
            this.labelAsignatura = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTiemposCursos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteSesiones
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvReporteSesiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvReporteSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReporteSesiones.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteSesiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteSesiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReporteSesiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteSesiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvReporteSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteSesiones.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvReporteSesiones.Location = new System.Drawing.Point(28, 151);
            this.dgvReporteSesiones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReporteSesiones.Name = "dgvReporteSesiones";
            this.dgvReporteSesiones.RowHeadersVisible = false;
            this.dgvReporteSesiones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvReporteSesiones.Size = new System.Drawing.Size(995, 361);
            this.dgvReporteSesiones.TabIndex = 0;
            // 
            // labelReporteAsistencia
            // 
            this.labelReporteAsistencia.AutoSize = true;
            this.labelReporteAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.labelReporteAsistencia.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReporteAsistencia.ForeColor = System.Drawing.Color.LightCoral;
            this.labelReporteAsistencia.Location = new System.Drawing.Point(383, 34);
            this.labelReporteAsistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReporteAsistencia.Name = "labelReporteAsistencia";
            this.labelReporteAsistencia.Size = new System.Drawing.Size(242, 25);
            this.labelReporteAsistencia.TabIndex = 1;
            this.labelReporteAsistencia.Text = "REPORTE DE AVANCE";
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.Transparent;
            this.buttonExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.FlatAppearance.BorderSize = 3;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.Location = new System.Drawing.Point(546, 533);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(235, 41);
            this.buttonExportar.TabIndex = 2;
            this.buttonExportar.Text = "Exportar Excel";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // buttonCerrrar
            // 
            this.buttonCerrrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrrar.FlatAppearance.BorderSize = 3;
            this.buttonCerrrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrrar.Location = new System.Drawing.Point(762, 533);
            this.buttonCerrrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCerrrar.Name = "buttonCerrrar";
            this.buttonCerrrar.Size = new System.Drawing.Size(236, 41);
            this.buttonCerrrar.TabIndex = 3;
            this.buttonCerrrar.Text = "Cerrar";
            this.buttonCerrrar.UseVisualStyleBackColor = false;
            this.buttonCerrrar.Click += new System.EventHandler(this.buttonCerrrar_Click);
            // 
            // comboBoxAsignaturas
            // 
            this.comboBoxAsignaturas.BackColor = System.Drawing.Color.White;
            this.comboBoxAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAsignaturas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAsignaturas.FormattingEnabled = true;
            this.comboBoxAsignaturas.Location = new System.Drawing.Point(328, 94);
            this.comboBoxAsignaturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAsignaturas.Name = "comboBoxAsignaturas";
            this.comboBoxAsignaturas.Size = new System.Drawing.Size(450, 28);
            this.comboBoxAsignaturas.TabIndex = 4;
            this.comboBoxAsignaturas.SelectedIndexChanged += new System.EventHandler(this.comboBoxAsignaturas_SelectedIndexChanged);
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.labelAsignatura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignatura.Location = new System.Drawing.Point(210, 96);
            this.labelAsignatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(110, 21);
            this.labelAsignatura.TabIndex = 5;
            this.labelAsignatura.Text = "Asignatura: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(327, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 1);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tiempos";
            // 
            // cboTiemposCursos
            // 
            this.cboTiemposCursos.DisplayMember = "0, -, +";
            this.cboTiemposCursos.FormattingEnabled = true;
            this.cboTiemposCursos.Items.AddRange(new object[] {
            "Menos",
            "0",
            "Mas"});
            this.cboTiemposCursos.Location = new System.Drawing.Point(886, 97);
            this.cboTiemposCursos.Name = "cboTiemposCursos";
            this.cboTiemposCursos.Size = new System.Drawing.Size(121, 24);
            this.cboTiemposCursos.TabIndex = 24;
            this.cboTiemposCursos.SelectedIndexChanged += new System.EventHandler(this.cboTiemposCursos_SelectedIndexChanged);
            // 
            // frmReporteSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1056, 598);
            this.Controls.Add(this.cboTiemposCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelReporteAsistencia);
            this.Controls.Add(this.dgvReporteSesiones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelAsignatura);
            this.Controls.Add(this.comboBoxAsignaturas);
            this.Controls.Add(this.buttonCerrrar);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteSesiones";
            this.Text = "frmReportesSesiones";
            this.Load += new System.EventHandler(this.frmReportesSesiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTiemposCursos;
    }
}