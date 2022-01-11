
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
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
            this.dgvReporteAsistencia.Location = new System.Drawing.Point(38, 116);
            this.dgvReporteAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReporteAsistencia.Name = "dgvReporteAsistencia";
            this.dgvReporteAsistencia.RowHeadersVisible = false;
            this.dgvReporteAsistencia.RowHeadersWidth = 51;
            this.dgvReporteAsistencia.RowTemplate.Height = 24;
            this.dgvReporteAsistencia.Size = new System.Drawing.Size(694, 435);
            this.dgvReporteAsistencia.TabIndex = 1;
            this.dgvReporteAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBoxCursosReporte
            // 
            this.comboBoxCursosReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCursosReporte.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursosReporte.FormattingEnabled = true;
            this.comboBoxCursosReporte.Location = new System.Drawing.Point(115, 70);
            this.comboBoxCursosReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCursosReporte.Name = "comboBoxCursosReporte";
            this.comboBoxCursosReporte.Size = new System.Drawing.Size(320, 23);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 35);
            this.panel1.TabIndex = 3;
            // 
            // btnMinimizarFrmReporte
            // 
            this.btnMinimizarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarFrmReporte.Image")));
            this.btnMinimizarFrmReporte.Location = new System.Drawing.Point(708, 3);
            this.btnMinimizarFrmReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizarFrmReporte.Name = "btnMinimizarFrmReporte";
            this.btnMinimizarFrmReporte.Size = new System.Drawing.Size(31, 30);
            this.btnMinimizarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarFrmReporte.TabIndex = 59;
            this.btnMinimizarFrmReporte.TabStop = false;
            this.btnMinimizarFrmReporte.Click += new System.EventHandler(this.btnMinimizarFrmReporte_Click);
            // 
            // btnCancelarFrmReporte
            // 
            this.btnCancelarFrmReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFrmReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFrmReporte.Image")));
            this.btnCancelarFrmReporte.Location = new System.Drawing.Point(743, 3);
            this.btnCancelarFrmReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarFrmReporte.Name = "btnCancelarFrmReporte";
            this.btnCancelarFrmReporte.Size = new System.Drawing.Size(31, 30);
            this.btnCancelarFrmReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarFrmReporte.TabIndex = 58;
            this.btnCancelarFrmReporte.TabStop = false;
            this.btnCancelarFrmReporte.Click += new System.EventHandler(this.btnCancelarFrmReporte_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 57;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "REPORTE DE ASISTENCIAS";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CURSO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(106, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 2);
            this.panel2.TabIndex = 22;
            // 
            // comboBoxUnidad
            // 
            this.comboBoxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUnidad.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnidad.FormattingEnabled = true;
            this.comboBoxUnidad.Items.AddRange(new object[] {
            "1era unidad",
            "2da unidad",
            "3ra unidad"});
            this.comboBoxUnidad.Location = new System.Drawing.Point(622, 70);
            this.comboBoxUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUnidad.Name = "comboBoxUnidad";
            this.comboBoxUnidad.Size = new System.Drawing.Size(117, 23);
            this.comboBoxUnidad.TabIndex = 23;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnidad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnidad.Location = new System.Drawing.Point(547, 72);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(65, 17);
            this.lblUnidad.TabIndex = 24;
            this.lblUnidad.Text = "UNIDAD:";
            // 
            // ReporteAsistenciasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(776, 603);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.comboBoxUnidad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCursosReporte);
            this.Controls.Add(this.dgvReporteAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private System.Windows.Forms.Label lblUnidad;
    }
}