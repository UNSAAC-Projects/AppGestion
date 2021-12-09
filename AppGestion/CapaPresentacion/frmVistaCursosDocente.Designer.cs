
namespace CapaPresentacion
{
    partial class frmVistaCursosDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaCursosDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelVistaHorario = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnCloseCursosDocente = new System.Windows.Forms.PictureBox();
            this.btnMinCursosDocente = new System.Windows.Forms.PictureBox();
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.panelVistaHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVistaHorario
            // 
            this.panelVistaHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelVistaHorario.Controls.Add(this.label11);
            this.panelVistaHorario.Controls.Add(this.pictureBoxLogo);
            this.panelVistaHorario.Controls.Add(this.btnCloseCursosDocente);
            this.panelVistaHorario.Controls.Add(this.btnMinCursosDocente);
            this.panelVistaHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVistaHorario.Location = new System.Drawing.Point(0, 0);
            this.panelVistaHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVistaHorario.Name = "panelVistaHorario";
            this.panelVistaHorario.Size = new System.Drawing.Size(905, 43);
            this.panelVistaHorario.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(49, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "CURSOS ASIGNADOS";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 55;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnCloseCursosDocente
            // 
            this.btnCloseCursosDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseCursosDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCursosDocente.Image")));
            this.btnCloseCursosDocente.Location = new System.Drawing.Point(857, 4);
            this.btnCloseCursosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseCursosDocente.Name = "btnCloseCursosDocente";
            this.btnCloseCursosDocente.Size = new System.Drawing.Size(36, 34);
            this.btnCloseCursosDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseCursosDocente.TabIndex = 1;
            this.btnCloseCursosDocente.TabStop = false;
            this.btnCloseCursosDocente.Click += new System.EventHandler(this.btnCloseCursosDocente_Click);
            // 
            // btnMinCursosDocente
            // 
            this.btnMinCursosDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinCursosDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnMinCursosDocente.Image")));
            this.btnMinCursosDocente.Location = new System.Drawing.Point(815, 4);
            this.btnMinCursosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinCursosDocente.Name = "btnMinCursosDocente";
            this.btnMinCursosDocente.Size = new System.Drawing.Size(36, 34);
            this.btnMinCursosDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinCursosDocente.TabIndex = 0;
            this.btnMinCursosDocente.TabStop = false;
            this.btnMinCursosDocente.Click += new System.EventHandler(this.btnMinCursosDocente_Click);
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.AllowUserToAddRows = false;
            this.dgvCursosDocente.AllowUserToDeleteRows = false;
            this.dgvCursosDocente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCursosDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursosDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosDocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCursosDocente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursosDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursosDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCursosDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursosDocente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursosDocente.Location = new System.Drawing.Point(28, 79);
            this.dgvCursosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCursosDocente.RowHeadersVisible = false;
            this.dgvCursosDocente.RowHeadersWidth = 51;
            this.dgvCursosDocente.RowTemplate.Height = 24;
            this.dgvCursosDocente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCursosDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCursosDocente.Size = new System.Drawing.Size(844, 394);
            this.dgvCursosDocente.TabIndex = 10;
            // 
            // frmVistaCursosDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 508);
            this.Controls.Add(this.dgvCursosDocente);
            this.Controls.Add(this.panelVistaHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVistaCursosDocente";
            this.Text = "frmVistaCursosDocente";
            this.panelVistaHorario.ResumeLayout(false);
            this.panelVistaHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVistaHorario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox btnCloseCursosDocente;
        private System.Windows.Forms.PictureBox btnMinCursosDocente;
        private System.Windows.Forms.DataGridView dgvCursosDocente;
    }
}