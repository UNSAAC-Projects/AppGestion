namespace CapaPresentacion
{
    partial class frmReporteEstadoAlumnos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCursosReporte = new System.Windows.Forms.ComboBox();
            this.dgvEstadoAlumnos = new System.Windows.Forms.DataGridView();
            this.chartReporte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(98, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 3);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "CURSO:";
            // 
            // cbCursosReporte
            // 
            this.cbCursosReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCursosReporte.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCursosReporte.FormattingEnabled = true;
            this.cbCursosReporte.Location = new System.Drawing.Point(107, 31);
            this.cbCursosReporte.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbCursosReporte.Name = "cbCursosReporte";
            this.cbCursosReporte.Size = new System.Drawing.Size(320, 23);
            this.cbCursosReporte.TabIndex = 23;
            this.cbCursosReporte.SelectedIndexChanged += new System.EventHandler(this.cbCursosReporte_SelectedIndexChanged);
            // 
            // dgvEstadoAlumnos
            // 
            this.dgvEstadoAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvEstadoAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstadoAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadoAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstadoAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstadoAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadoAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEstadoAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadoAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadoAlumnos.EnableHeadersVisualStyles = false;
            this.dgvEstadoAlumnos.Location = new System.Drawing.Point(11, 73);
            this.dgvEstadoAlumnos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvEstadoAlumnos.Name = "dgvEstadoAlumnos";
            this.dgvEstadoAlumnos.RowHeadersVisible = false;
            this.dgvEstadoAlumnos.RowHeadersWidth = 51;
            this.dgvEstadoAlumnos.RowTemplate.Height = 24;
            this.dgvEstadoAlumnos.Size = new System.Drawing.Size(476, 369);
            this.dgvEstadoAlumnos.TabIndex = 26;
            // 
            // chartReporte
            // 
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Name = "ChartArea1";
            this.chartReporte.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartReporte.Legends.Add(legend1);
            this.chartReporte.Location = new System.Drawing.Point(511, 73);
            this.chartReporte.Name = "chartReporte";
            this.chartReporte.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "#.##%";
            series1.Legend = "Legend1";
            series1.Name = "Estado";
            series1.YValuesPerPoint = 4;
            this.chartReporte.Series.Add(series1);
            this.chartReporte.Size = new System.Drawing.Size(369, 300);
            this.chartReporte.TabIndex = 27;
            this.chartReporte.Text = "chart";
            title1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Reporte";
            this.chartReporte.Titles.Add(title1);
            // 
            // frmReporteEstadoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 495);
            this.Controls.Add(this.chartReporte);
            this.Controls.Add(this.dgvEstadoAlumnos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCursosReporte);
            this.Name = "frmReporteEstadoAlumnos";
            this.Text = "frmReporteEstadoAlumno";
            this.Load += new System.EventHandler(this.frmReporteEstadoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCursosReporte;
        private System.Windows.Forms.DataGridView dgvEstadoAlumnos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReporte;
    }
}