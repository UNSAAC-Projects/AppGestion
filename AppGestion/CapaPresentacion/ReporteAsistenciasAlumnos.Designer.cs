﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteAsistenciasAlumnos));
            this.dgvReporteAsistencia = new System.Windows.Forms.DataGridView();
            this.comboBoxCursosReporte = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizarFrmReporte = new System.Windows.Forms.PictureBox();
            this.btnCancelarFrmReporte = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvReporteAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteAsistencia.Location = new System.Drawing.Point(12, 137);
            this.dgvReporteAsistencia.Name = "dgvReporteAsistencia";
            this.dgvReporteAsistencia.RowHeadersWidth = 51;
            this.dgvReporteAsistencia.RowTemplate.Height = 24;
            this.dgvReporteAsistencia.Size = new System.Drawing.Size(1062, 657);
            this.dgvReporteAsistencia.TabIndex = 1;
            this.dgvReporteAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBoxCursosReporte
            // 
            this.comboBoxCursosReporte.FormattingEnabled = true;
            this.comboBoxCursosReporte.Location = new System.Drawing.Point(153, 86);
            this.comboBoxCursosReporte.Name = "comboBoxCursosReporte";
            this.comboBoxCursosReporte.Size = new System.Drawing.Size(233, 24);
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
            this.panel1.Size = new System.Drawing.Size(1086, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnMinimizarFrmReporte
            // 
            this.btnMinimizarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarFrmReporte.Image")));
            this.btnMinimizarFrmReporte.Location = new System.Drawing.Point(986, 9);
            this.btnMinimizarFrmReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizarFrmReporte.Name = "btnMinimizarFrmReporte";
            this.btnMinimizarFrmReporte.Size = new System.Drawing.Size(41, 37);
            this.btnMinimizarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarFrmReporte.TabIndex = 59;
            this.btnMinimizarFrmReporte.TabStop = false;
            this.btnMinimizarFrmReporte.Click += new System.EventHandler(this.btnMinimizarFrmReporte_Click);
            // 
            // btnCancelarFrmReporte
            // 
            this.btnCancelarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFrmReporte.Image")));
            this.btnCancelarFrmReporte.Location = new System.Drawing.Point(1033, 9);
            this.btnCancelarFrmReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarFrmReporte.Name = "btnCancelarFrmReporte";
            this.btnCancelarFrmReporte.Size = new System.Drawing.Size(41, 37);
            this.btnCancelarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarFrmReporte.TabIndex = 58;
            this.btnCancelarFrmReporte.TabStop = false;
            this.btnCancelarFrmReporte.Click += new System.EventHandler(this.btnCancelarFrmReporte_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 57;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(72, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "REPORTE DE ASISTENCIAS";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CURSO:";
            // 
            // ReporteAsistenciasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 806);
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
    }
}