namespace CapaPresentacion
{
    partial class frmReporteEstadoAlumno
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCursosReporte = new System.Windows.Forms.ComboBox();
            this.dgvEstadoAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAlumnos)).BeginInit();
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
            // comboBoxCursosReporte
            // 
            this.comboBoxCursosReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCursosReporte.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursosReporte.FormattingEnabled = true;
            this.comboBoxCursosReporte.Location = new System.Drawing.Point(107, 31);
            this.comboBoxCursosReporte.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxCursosReporte.Name = "comboBoxCursosReporte";
            this.comboBoxCursosReporte.Size = new System.Drawing.Size(320, 23);
            this.comboBoxCursosReporte.TabIndex = 23;
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
            this.dgvEstadoAlumnos.Location = new System.Drawing.Point(29, 107);
            this.dgvEstadoAlumnos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvEstadoAlumnos.Name = "dgvEstadoAlumnos";
            this.dgvEstadoAlumnos.RowHeadersVisible = false;
            this.dgvEstadoAlumnos.RowHeadersWidth = 51;
            this.dgvEstadoAlumnos.RowTemplate.Height = 24;
            this.dgvEstadoAlumnos.Size = new System.Drawing.Size(739, 287);
            this.dgvEstadoAlumnos.TabIndex = 26;
            // 
            // frmReporteEstadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstadoAlumnos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCursosReporte);
            this.Name = "frmReporteEstadoAlumno";
            this.Text = "frmReporteEstadoAlumno";
            this.Load += new System.EventHandler(this.frmReporteEstadoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCursosReporte;
        private System.Windows.Forms.DataGridView dgvEstadoAlumnos;
    }
}