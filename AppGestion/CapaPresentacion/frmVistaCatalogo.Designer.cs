
namespace CapaPresentacion
{
    partial class frmVistaCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaCatalogo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.panelVistaCatalogo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btonCerrarVistaCatalogo = new System.Windows.Forms.PictureBox();
            this.btnMinVistaCatalogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.panelVistaCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonCerrarVistaCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinVistaCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnDescargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.Image")));
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.Location = new System.Drawing.Point(211, 382);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(144, 41);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "EXPORTAR EXCEL";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(59, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 45;
            this.label13.Text = "BUSCAR:";
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCatalogo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatalogo.Location = new System.Drawing.Point(25, 113);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.RowHeadersWidth = 51;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(804, 247);
            this.dgvCatalogo.TabIndex = 47;
            this.dgvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.editar_icono;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar_icono;
            this.Eliminar.Name = "Eliminar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(134, 64);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(358, 26);
            this.txtBuscar.TabIndex = 48;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnHorarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Image = ((System.Drawing.Image)(resources.GetObject("btnHorarios.Image")));
            this.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.Location = new System.Drawing.Point(504, 382);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(132, 41);
            this.btnHorarios.TabIndex = 49;
            this.btnHorarios.Text = "VER HORARIOS";
            this.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // panelVistaCatalogo
            // 
            this.panelVistaCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelVistaCatalogo.Controls.Add(this.label11);
            this.panelVistaCatalogo.Controls.Add(this.pictureBoxLogo);
            this.panelVistaCatalogo.Controls.Add(this.btonCerrarVistaCatalogo);
            this.panelVistaCatalogo.Controls.Add(this.btnMinVistaCatalogo);
            this.panelVistaCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVistaCatalogo.Location = new System.Drawing.Point(0, 0);
            this.panelVistaCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelVistaCatalogo.Name = "panelVistaCatalogo";
            this.panelVistaCatalogo.Size = new System.Drawing.Size(845, 33);
            this.panelVistaCatalogo.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(34, 2);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 22);
            this.label11.TabIndex = 51;
            this.label11.Text = "CATALOGO";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(26, 28);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 65;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btonCerrarVistaCatalogo
            // 
            this.btonCerrarVistaCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonCerrarVistaCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btonCerrarVistaCatalogo.Image")));
            this.btonCerrarVistaCatalogo.Location = new System.Drawing.Point(814, 2);
            this.btonCerrarVistaCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.btonCerrarVistaCatalogo.Name = "btonCerrarVistaCatalogo";
            this.btonCerrarVistaCatalogo.Size = new System.Drawing.Size(26, 26);
            this.btonCerrarVistaCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btonCerrarVistaCatalogo.TabIndex = 51;
            this.btonCerrarVistaCatalogo.TabStop = false;
            this.btonCerrarVistaCatalogo.Click += new System.EventHandler(this.btonCerrarVistaCatalogo_Click);
            // 
            // btnMinVistaCatalogo
            // 
            this.btnMinVistaCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinVistaCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnMinVistaCatalogo.Image")));
            this.btnMinVistaCatalogo.Location = new System.Drawing.Point(784, 2);
            this.btnMinVistaCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinVistaCatalogo.Name = "btnMinVistaCatalogo";
            this.btnMinVistaCatalogo.Size = new System.Drawing.Size(26, 26);
            this.btnMinVistaCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinVistaCatalogo.TabIndex = 51;
            this.btnMinVistaCatalogo.TabStop = false;
            this.btnMinVistaCatalogo.Click += new System.EventHandler(this.btnMinVistaCatalogo_Click);
            // 
            // frmVistaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.panelVistaCatalogo);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDescargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVistaCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaCatalogo";
            this.Load += new System.EventHandler(this.frmVistaCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.panelVistaCatalogo.ResumeLayout(false);
            this.panelVistaCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonCerrarVistaCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinVistaCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Panel panelVistaCatalogo;
        private System.Windows.Forms.PictureBox btonCerrarVistaCatalogo;
        private System.Windows.Forms.PictureBox btnMinVistaCatalogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}