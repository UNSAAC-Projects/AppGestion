﻿
namespace CapaPresentacion
{
    partial class FrmPrincipalDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalDocente));
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.TEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASISTENCIA = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.pictureBoxLibros = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.AllowUserToAddRows = false;
            this.dgvCursosDocente.AllowUserToDeleteRows = false;
            this.dgvCursosDocente.AllowUserToOrderColumns = true;
            this.dgvCursosDocente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCursosDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursosDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursosDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosDocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCursosDocente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursosDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursosDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCursosDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosDocente.ColumnHeadersVisible = false;
            this.dgvCursosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEMA,
            this.ASISTENCIA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursosDocente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursosDocente.Location = new System.Drawing.Point(74, 114);
            this.dgvCursosDocente.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.ReadOnly = true;
            this.dgvCursosDocente.RowHeadersVisible = false;
            this.dgvCursosDocente.RowHeadersWidth = 51;
            this.dgvCursosDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCursosDocente.Size = new System.Drawing.Size(926, 542);
            this.dgvCursosDocente.TabIndex = 16;
            this.dgvCursosDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosDocente_CellContentClick);
            // 
            // TEMA
            // 
            this.TEMA.FillWeight = 100.1522F;
            this.TEMA.HeaderText = "TEMA";
            this.TEMA.MinimumWidth = 6;
            this.TEMA.Name = "TEMA";
            this.TEMA.ReadOnly = true;
            this.TEMA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TEMA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ASISTENCIA
            // 
            this.ASISTENCIA.FillWeight = 99.84779F;
            this.ASISTENCIA.HeaderText = "ASISTENCIA";
            this.ASISTENCIA.Image = global::CapaPresentacion.Properties.Resources.graduado_24px;
            this.ASISTENCIA.MinimumWidth = 6;
            this.ASISTENCIA.Name = "ASISTENCIA";
            this.ASISTENCIA.ReadOnly = true;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.BackColor = System.Drawing.Color.Transparent;
            this.labelMensaje.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelMensaje.Location = new System.Drawing.Point(313, 135);
            this.labelMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(425, 30);
            this.labelMensaje.TabIndex = 17;
            this.labelMensaje.Text = "No tiene ningún curso a dictar hoy";
            this.labelMensaje.Visible = false;
            // 
            // pictureBoxLibros
            // 
            this.pictureBoxLibros.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLibros.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLibros.Image")));
            this.pictureBoxLibros.Location = new System.Drawing.Point(226, 266);
            this.pictureBoxLibros.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLibros.Name = "pictureBoxLibros";
            this.pictureBoxLibros.Size = new System.Drawing.Size(648, 283);
            this.pictureBoxLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLibros.TabIndex = 18;
            this.pictureBoxLibros.TabStop = false;
            this.pictureBoxLibros.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "CURSOS  DICTADOS EN SEMESTRE LECTIVO";
            this.label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipalDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLibros);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.dgvCursosDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipalDocente";
            this.Text = "FrmPrincipalDocente";
            this.Load += new System.EventHandler(this.FrmPrincipalDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMA;
        private System.Windows.Forms.DataGridViewImageColumn ASISTENCIA;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.PictureBox pictureBoxLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}