﻿namespace CapaPresentacion
{
    partial class frmReporteEstadoDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteEstadoDocentes));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chartReporte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvEstadoDocentes = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonCerrrar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // chartReporte
            // 
            chartArea3.Area3DStyle.Inclination = 10;
            chartArea3.Name = "ChartArea1";
            this.chartReporte.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartReporte.Legends.Add(legend3);
            resources.ApplyResources(this.chartReporte, "chartReporte");
            this.chartReporte.Name = "chartReporte";
            this.chartReporte.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "#.##%";
            series3.Legend = "Legend1";
            series3.Name = "Estado";
            series3.YValuesPerPoint = 4;
            this.chartReporte.Series.Add(series3);
            title3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Reporte";
            this.chartReporte.Titles.Add(title3);
            // 
            // dgvEstadoDocentes
            // 
            this.dgvEstadoDocentes.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvEstadoDocentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.dgvEstadoDocentes, "dgvEstadoDocentes");
            this.dgvEstadoDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstadoDocentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstadoDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadoDocentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEstadoDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEstadoDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadoDocentes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEstadoDocentes.EnableHeadersVisualStyles = false;
            this.dgvEstadoDocentes.Name = "dgvEstadoDocentes";
            this.dgvEstadoDocentes.RowHeadersVisible = false;
            this.dgvEstadoDocentes.RowTemplate.Height = 24;
            // 
            // labelTitulo
            // 
            resources.ApplyResources(this.labelTitulo, "labelTitulo");
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitulo.Name = "labelTitulo";
            // 
            // buttonCerrrar
            // 
            resources.ApplyResources(this.buttonCerrrar, "buttonCerrrar");
            this.buttonCerrrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrrar.FlatAppearance.BorderSize = 3;
            this.buttonCerrrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrrar.Name = "buttonCerrrar";
            this.buttonCerrrar.UseVisualStyleBackColor = false;
            this.buttonCerrrar.Click += new System.EventHandler(this.buttonCerrrar_Click);
            // 
            // buttonExportar
            // 
            resources.ApplyResources(this.buttonExportar, "buttonExportar");
            this.buttonExportar.BackColor = System.Drawing.Color.Transparent;
            this.buttonExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.FlatAppearance.BorderSize = 3;
            this.buttonExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // frmReporteEstadoDocentes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCerrrar);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgvEstadoDocentes);
            this.Controls.Add(this.chartReporte);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmReporteEstadoDocentes";
            this.Load += new System.EventHandler(this.frmReporteEstadoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReporte;
        private System.Windows.Forms.DataGridView dgvEstadoDocentes;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonCerrrar;
        private System.Windows.Forms.Button buttonExportar;
    }
}