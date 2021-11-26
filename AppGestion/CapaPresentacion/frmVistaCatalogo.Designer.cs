
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaCatalogo));
            this.btnDescargar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.panelVistaCatalogo = new System.Windows.Forms.Panel();
            this.btnMinVistaCatalogo = new System.Windows.Forms.PictureBox();
            this.btonCerrarVistaCatalogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.panelVistaCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinVistaCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonCerrarVistaCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(315, 500);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(171, 39);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "EXPORTAR EXCEL";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(62, 83);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(94, 23);
            this.label13.TabIndex = 45;
            this.label13.Text = "BUSCAR:";
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AllowUserToOrderColumns = true;
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogo.Location = new System.Drawing.Point(33, 139);
            this.dgvCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.RowHeadersWidth = 51;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(1072, 304);
            this.dgvCatalogo.TabIndex = 47;
            this.dgvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.editar_icono;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar_icono;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(171, 71);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(524, 38);
            this.txtBuscar.TabIndex = 48;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnHorarios
            // 
            this.btnHorarios.Location = new System.Drawing.Point(630, 502);
            this.btnHorarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(147, 39);
            this.btnHorarios.TabIndex = 49;
            this.btnHorarios.Text = "VER HORARIOS";
            this.btnHorarios.UseVisualStyleBackColor = true;
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
            this.panelVistaCatalogo.Name = "panelVistaCatalogo";
            this.panelVistaCatalogo.Size = new System.Drawing.Size(1127, 41);
            this.panelVistaCatalogo.TabIndex = 50;
            // 
            // btnMinVistaCatalogo
            // 
            this.btnMinVistaCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnMinVistaCatalogo.Image")));
            this.btnMinVistaCatalogo.Location = new System.Drawing.Point(1046, 3);
            this.btnMinVistaCatalogo.Name = "btnMinVistaCatalogo";
            this.btnMinVistaCatalogo.Size = new System.Drawing.Size(35, 32);
            this.btnMinVistaCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinVistaCatalogo.TabIndex = 51;
            this.btnMinVistaCatalogo.TabStop = false;
            this.btnMinVistaCatalogo.Click += new System.EventHandler(this.btnMinVistaCatalogo_Click);
            // 
            // btonCerrarVistaCatalogo
            // 
            this.btonCerrarVistaCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btonCerrarVistaCatalogo.Image")));
            this.btonCerrarVistaCatalogo.Location = new System.Drawing.Point(1085, 3);
            this.btonCerrarVistaCatalogo.Name = "btonCerrarVistaCatalogo";
            this.btonCerrarVistaCatalogo.Size = new System.Drawing.Size(35, 32);
            this.btonCerrarVistaCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btonCerrarVistaCatalogo.TabIndex = 51;
            this.btonCerrarVistaCatalogo.TabStop = false;
            this.btonCerrarVistaCatalogo.Click += new System.EventHandler(this.btonCerrarVistaCatalogo_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(34, 35);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 65;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(45, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 30);
            this.label11.TabIndex = 51;
            this.label11.Text = "CATALOGO";
            // 
            // frmVistaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1127, 554);
            this.Controls.Add(this.panelVistaCatalogo);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDescargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVistaCatalogo";
            this.Text = "frmVistaCatalogo";
            this.Load += new System.EventHandler(this.frmVistaCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.panelVistaCatalogo.ResumeLayout(false);
            this.panelVistaCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinVistaCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonCerrarVistaCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelVistaCatalogo;
        private System.Windows.Forms.PictureBox btonCerrarVistaCatalogo;
        private System.Windows.Forms.PictureBox btnMinVistaCatalogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label11;
    }
}