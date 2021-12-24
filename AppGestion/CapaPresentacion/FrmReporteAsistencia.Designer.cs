
namespace CapaPresentacion
{
    partial class FrmReporteAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAsistencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAsistenciaCurso = new System.Windows.Forms.ComboBox();
            this.pnlFrmReporteAsistencia = new System.Windows.Forms.Panel();
            this.btnMinimizarFrmReporte = new System.Windows.Forms.PictureBox();
            this.btnCancelarFrmReporte = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Asistencia = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvAsistenciaReporte = new System.Windows.Forms.DataGridView();
            this.pnlFrmReporteAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarFrmReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarFrmReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por :";
            // 
            // cboAsistenciaCurso
            // 
            this.cboAsistenciaCurso.BackColor = System.Drawing.Color.White;
            this.cboAsistenciaCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAsistenciaCurso.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAsistenciaCurso.FormattingEnabled = true;
            this.cboAsistenciaCurso.Location = new System.Drawing.Point(151, 93);
            this.cboAsistenciaCurso.Name = "cboAsistenciaCurso";
            this.cboAsistenciaCurso.Size = new System.Drawing.Size(366, 25);
            this.cboAsistenciaCurso.TabIndex = 1;
            this.cboAsistenciaCurso.SelectedIndexChanged += new System.EventHandler(this.cboAsistenciaCurso_SelectedIndexChanged);
            this.cboAsistenciaCurso.Click += new System.EventHandler(this.cboAsistenciaCurso_Click);
            // 
            // pnlFrmReporteAsistencia
            // 
            this.pnlFrmReporteAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.pnlFrmReporteAsistencia.Controls.Add(this.label11);
            this.pnlFrmReporteAsistencia.Controls.Add(this.pictureBoxLogo);
            this.pnlFrmReporteAsistencia.Controls.Add(this.btnCancelarFrmReporte);
            this.pnlFrmReporteAsistencia.Controls.Add(this.btnMinimizarFrmReporte);
            this.pnlFrmReporteAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFrmReporteAsistencia.Location = new System.Drawing.Point(0, 0);
            this.pnlFrmReporteAsistencia.Name = "pnlFrmReporteAsistencia";
            this.pnlFrmReporteAsistencia.Size = new System.Drawing.Size(826, 43);
            this.pnlFrmReporteAsistencia.TabIndex = 3;
            this.pnlFrmReporteAsistencia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFrmReporteAsistencia_MouseMove);
            // 
            // btnMinimizarFrmReporte
            // 
            this.btnMinimizarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarFrmReporte.Image")));
            this.btnMinimizarFrmReporte.Location = new System.Drawing.Point(744, 3);
            this.btnMinimizarFrmReporte.Name = "btnMinimizarFrmReporte";
            this.btnMinimizarFrmReporte.Size = new System.Drawing.Size(41, 37);
            this.btnMinimizarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarFrmReporte.TabIndex = 4;
            this.btnMinimizarFrmReporte.TabStop = false;
            this.btnMinimizarFrmReporte.Click += new System.EventHandler(this.btnMinimizarFrmReporte_Click);
            // 
            // btnCancelarFrmReporte
            // 
            this.btnCancelarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFrmReporte.Image")));
            this.btnCancelarFrmReporte.Location = new System.Drawing.Point(782, 3);
            this.btnCancelarFrmReporte.Name = "btnCancelarFrmReporte";
            this.btnCancelarFrmReporte.Size = new System.Drawing.Size(41, 37);
            this.btnCancelarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarFrmReporte.TabIndex = 4;
            this.btnCancelarFrmReporte.TabStop = false;
            this.btnCancelarFrmReporte.Click += new System.EventHandler(this.btnCancelarFrmReporte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 56;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(48, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "REPORTE DE ASISTENCIAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(540, 637);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.ForeColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(0, 682);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 5);
            this.panel4.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-13, 657);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(111, 703);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 5);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(647, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(259, 162);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-13, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 125);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(620, 40);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(93, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.Image = global::CapaPresentacion.Properties.Resources.pdf_24px;
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Asistencia.Width = 88;
            // 
            // dgvAsistenciaReporte
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvAsistenciaReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsistenciaReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsistenciaReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsistenciaReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsistenciaReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsistenciaReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistenciaReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistenciaReporte.ColumnHeadersHeight = 35;
            this.dgvAsistenciaReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsistenciaReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistenciaReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsistenciaReporte.Location = new System.Drawing.Point(49, 152);
            this.dgvAsistenciaReporte.Name = "dgvAsistenciaReporte";
            this.dgvAsistenciaReporte.RowHeadersVisible = false;
            this.dgvAsistenciaReporte.RowHeadersWidth = 51;
            this.dgvAsistenciaReporte.RowTemplate.Height = 24;
            this.dgvAsistenciaReporte.Size = new System.Drawing.Size(725, 499);
            this.dgvAsistenciaReporte.TabIndex = 2;
            this.dgvAsistenciaReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistenciaReporte_CellContentClick);
            // 
            // FrmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(826, 732);
            this.Controls.Add(this.pnlFrmReporteAsistencia);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAsistenciaReporte);
            this.Controls.Add(this.cboAsistenciaCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteAsistencia";
            this.Text = "FrmReporteAsistencia";
            this.Load += new System.EventHandler(this.FrmReporteAsistencia_Load);
            this.pnlFrmReporteAsistencia.ResumeLayout(false);
            this.pnlFrmReporteAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarFrmReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarFrmReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAsistenciaCurso;
        private System.Windows.Forms.Panel pnlFrmReporteAsistencia;
        private System.Windows.Forms.PictureBox btnMinimizarFrmReporte;
        private System.Windows.Forms.PictureBox btnCancelarFrmReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridViewImageColumn Asistencia;
        private System.Windows.Forms.DataGridView dgvAsistenciaReporte;
    }
}