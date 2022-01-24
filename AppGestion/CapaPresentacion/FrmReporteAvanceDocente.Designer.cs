
namespace CapaPresentacion
{
    partial class FrmReporteAvanceDocente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvAvanceDocenteSesion = new System.Windows.Forms.DataGridView();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDocenteSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(410, 79);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(378, 366);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dgvAvanceDocenteSesion
            // 
            this.dgvAvanceDocenteSesion.AllowUserToAddRows = false;
            this.dgvAvanceDocenteSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvanceDocenteSesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Porcentaje});
            this.dgvAvanceDocenteSesion.Location = new System.Drawing.Point(12, 79);
            this.dgvAvanceDocenteSesion.Name = "dgvAvanceDocenteSesion";
            this.dgvAvanceDocenteSesion.RowHeadersWidth = 51;
            this.dgvAvanceDocenteSesion.RowTemplate.Height = 24;
            this.dgvAvanceDocenteSesion.Size = new System.Drawing.Size(376, 451);
            this.dgvAvanceDocenteSesion.TabIndex = 1;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.MinimumWidth = 6;
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Width = 125;
            // 
            // FrmReporteAvanceDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.dgvAvanceDocenteSesion);
            this.Controls.Add(this.chart1);
            this.Name = "FrmReporteAvanceDocente";
            this.Text = "FrmReporteAvanceDocente";
            this.Load += new System.EventHandler(this.FrmReporteAvanceDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDocenteSesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvAvanceDocenteSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}