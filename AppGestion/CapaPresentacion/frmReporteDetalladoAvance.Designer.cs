
namespace CapaPresentacion
{
    partial class frmReporteDetalladoAvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteDetalladoAvance));
            this.labelReporteAsistencia = new System.Windows.Forms.Label();
            this.dgvAvanceDetallado = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCerrrar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreAsignatura = new System.Windows.Forms.Label();
            this.completos = new System.Windows.Forms.Label();
            this.nrocompletos = new System.Windows.Forms.Label();
            this.nocompletadas = new System.Windows.Forms.Label();
            this.nroNOcompletos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDetallado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReporteAsistencia
            // 
            this.labelReporteAsistencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelReporteAsistencia.AutoSize = true;
            this.labelReporteAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.labelReporteAsistencia.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReporteAsistencia.ForeColor = System.Drawing.Color.DimGray;
            this.labelReporteAsistencia.Location = new System.Drawing.Point(285, 16);
            this.labelReporteAsistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReporteAsistencia.Name = "labelReporteAsistencia";
            this.labelReporteAsistencia.Size = new System.Drawing.Size(488, 39);
            this.labelReporteAsistencia.TabIndex = 26;
            this.labelReporteAsistencia.Text = "REPORTE AVANCE DETALLADO";
            // 
            // dgvAvanceDetallado
            // 
            this.dgvAvanceDetallado.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvAvanceDetallado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAvanceDetallado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvanceDetallado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvanceDetallado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAvanceDetallado.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvanceDetallado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvanceDetallado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAvanceDetallado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvanceDetallado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAvanceDetallado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvanceDetallado.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAvanceDetallado.Location = new System.Drawing.Point(35, 130);
            this.dgvAvanceDetallado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAvanceDetallado.Name = "dgvAvanceDetallado";
            this.dgvAvanceDetallado.RowHeadersVisible = false;
            this.dgvAvanceDetallado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvAvanceDetallado.Size = new System.Drawing.Size(1046, 365);
            this.dgvAvanceDetallado.TabIndex = 25;
            this.dgvAvanceDetallado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvanceDetallado_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(334, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 1);
            this.panel2.TabIndex = 31;
            // 
            // buttonCerrrar
            // 
            this.buttonCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrrar.FlatAppearance.BorderSize = 3;
            this.buttonCerrrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrrar.Location = new System.Drawing.Point(872, 504);
            this.buttonCerrrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCerrrar.Name = "buttonCerrrar";
            this.buttonCerrrar.Size = new System.Drawing.Size(183, 41);
            this.buttonCerrrar.TabIndex = 28;
            this.buttonCerrrar.Text = "Cerrar";
            this.buttonCerrrar.UseVisualStyleBackColor = false;
            this.buttonCerrrar.Click += new System.EventHandler(this.buttonCerrrar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportar.BackColor = System.Drawing.Color.Transparent;
            this.buttonExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.FlatAppearance.BorderSize = 3;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonExportar.Location = new System.Drawing.Point(666, 505);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(182, 41);
            this.buttonExportar.TabIndex = 27;
            this.buttonExportar.Text = "Exportar Excel";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreAsignatura
            // 
            this.lblNombreAsignatura.AutoSize = true;
            this.lblNombreAsignatura.Location = new System.Drawing.Point(352, 71);
            this.lblNombreAsignatura.Name = "lblNombreAsignatura";
            this.lblNombreAsignatura.Size = new System.Drawing.Size(16, 17);
            this.lblNombreAsignatura.TabIndex = 33;
            this.lblNombreAsignatura.Text = "  ";
            // 
            // completos
            // 
            this.completos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.completos.AutoSize = true;
            this.completos.Location = new System.Drawing.Point(163, 516);
            this.completos.Name = "completos";
            this.completos.Size = new System.Drawing.Size(150, 17);
            this.completos.TabIndex = 34;
            this.completos.Text = "Sesiones completadas";
            // 
            // nrocompletos
            // 
            this.nrocompletos.AutoSize = true;
            this.nrocompletos.Location = new System.Drawing.Point(331, 516);
            this.nrocompletos.Name = "nrocompletos";
            this.nrocompletos.Size = new System.Drawing.Size(13, 17);
            this.nrocompletos.TabIndex = 35;
            this.nrocompletos.Text = "-";
            this.nrocompletos.Click += new System.EventHandler(this.nrocompletos_Click);
            // 
            // nocompletadas
            // 
            this.nocompletadas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nocompletadas.AutoSize = true;
            this.nocompletadas.Location = new System.Drawing.Point(376, 516);
            this.nocompletadas.Name = "nocompletadas";
            this.nocompletadas.Size = new System.Drawing.Size(175, 17);
            this.nocompletadas.TabIndex = 36;
            this.nocompletadas.Text = "Sesiones NO completadas";
            // 
            // nroNOcompletos
            // 
            this.nroNOcompletos.AutoSize = true;
            this.nroNOcompletos.Location = new System.Drawing.Point(557, 516);
            this.nroNOcompletos.Name = "nroNOcompletos";
            this.nroNOcompletos.Size = new System.Drawing.Size(13, 17);
            this.nroNOcompletos.TabIndex = 37;
            this.nroNOcompletos.Text = "-";
            // 
            // frmReporteDetalladoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 557);
            this.Controls.Add(this.nroNOcompletos);
            this.Controls.Add(this.nocompletadas);
            this.Controls.Add(this.nrocompletos);
            this.Controls.Add(this.completos);
            this.Controls.Add(this.lblNombreAsignatura);
            this.Controls.Add(this.labelReporteAsistencia);
            this.Controls.Add(this.dgvAvanceDetallado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonCerrrar);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteDetalladoAvance";
            this.Text = "frmReporteAvancePlanDetallado";
            this.Load += new System.EventHandler(this.frmReporteDetalladoAvance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvanceDetallado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReporteAsistencia;
        private System.Windows.Forms.DataGridView dgvAvanceDetallado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCerrrar;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.Label completos;
        private System.Windows.Forms.Label nrocompletos;
        private System.Windows.Forms.Label nocompletadas;
        private System.Windows.Forms.Label nroNOcompletos;
    }
}