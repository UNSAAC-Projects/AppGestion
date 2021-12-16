
namespace CapaPresentacion
{
    partial class frmPlanDeSesiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanDeSesiones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelVistaHorario = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnClosePlanSesiones = new System.Windows.Forms.PictureBox();
            this.btnMinPlanSesiones = new System.Windows.Forms.PictureBox();
            this.dgvPlanSesiones = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelPlanSesiones = new System.Windows.Forms.Label();
            this.lblNombreAsignatura = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSubirSilabo = new System.Windows.Forms.Button();
            this.btnVerSilabo = new System.Windows.Forms.Button();
            this.btnAgregarTema = new System.Windows.Forms.Button();
            this.panelVistaHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinPlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVistaHorario
            // 
            this.panelVistaHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelVistaHorario.Controls.Add(this.label11);
            this.panelVistaHorario.Controls.Add(this.pictureBoxLogo);
            this.panelVistaHorario.Controls.Add(this.btnClosePlanSesiones);
            this.panelVistaHorario.Controls.Add(this.btnMinPlanSesiones);
            this.panelVistaHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVistaHorario.Location = new System.Drawing.Point(0, 0);
            this.panelVistaHorario.Margin = new System.Windows.Forms.Padding(2);
            this.panelVistaHorario.Name = "panelVistaHorario";
            this.panelVistaHorario.Size = new System.Drawing.Size(861, 35);
            this.panelVistaHorario.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(36, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "PLAN DE SESIONES";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 55;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnClosePlanSesiones
            // 
            this.btnClosePlanSesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePlanSesiones.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePlanSesiones.Image")));
            this.btnClosePlanSesiones.Location = new System.Drawing.Point(817, 3);
            this.btnClosePlanSesiones.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosePlanSesiones.Name = "btnClosePlanSesiones";
            this.btnClosePlanSesiones.Size = new System.Drawing.Size(27, 28);
            this.btnClosePlanSesiones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClosePlanSesiones.TabIndex = 1;
            this.btnClosePlanSesiones.TabStop = false;
            this.btnClosePlanSesiones.Click += new System.EventHandler(this.btnClosePlanSesiones_Click);
            // 
            // btnMinPlanSesiones
            // 
            this.btnMinPlanSesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinPlanSesiones.Image = ((System.Drawing.Image)(resources.GetObject("btnMinPlanSesiones.Image")));
            this.btnMinPlanSesiones.Location = new System.Drawing.Point(785, 3);
            this.btnMinPlanSesiones.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinPlanSesiones.Name = "btnMinPlanSesiones";
            this.btnMinPlanSesiones.Size = new System.Drawing.Size(27, 28);
            this.btnMinPlanSesiones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinPlanSesiones.TabIndex = 0;
            this.btnMinPlanSesiones.TabStop = false;
            this.btnMinPlanSesiones.Click += new System.EventHandler(this.btnMinPlanSesiones_Click);
            // 
            // dgvPlanSesiones
            // 
            this.dgvPlanSesiones.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvPlanSesiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlanSesiones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanSesiones.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanSesiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPlanSesiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanSesiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanSesiones.ColumnHeadersHeight = 35;
            this.dgvPlanSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlanSesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanSesiones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanSesiones.Location = new System.Drawing.Point(27, 111);
            this.dgvPlanSesiones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlanSesiones.Name = "dgvPlanSesiones";
            this.dgvPlanSesiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlanSesiones.RowHeadersWidth = 51;
            this.dgvPlanSesiones.RowTemplate.Height = 24;
            this.dgvPlanSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanSesiones.Size = new System.Drawing.Size(806, 272);
            this.dgvPlanSesiones.TabIndex = 11;
            this.dgvPlanSesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanSesiones_CellContentClick);
            this.dgvPlanSesiones.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvPlanSesiones_DragDrop);
            this.dgvPlanSesiones.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvPlanSesiones_DragOver);
            this.dgvPlanSesiones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPlanSesiones_MouseDown);
            this.dgvPlanSesiones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPlanSesiones_MouseMove);
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar_icono;
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.Width = 58;
            // 
            // labelPlanSesiones
            // 
            this.labelPlanSesiones.AutoSize = true;
            this.labelPlanSesiones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanSesiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelPlanSesiones.Location = new System.Drawing.Point(138, 56);
            this.labelPlanSesiones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlanSesiones.Name = "labelPlanSesiones";
            this.labelPlanSesiones.Size = new System.Drawing.Size(291, 18);
            this.labelPlanSesiones.TabIndex = 14;
            this.labelPlanSesiones.Text = "PLAN DE SESIONES DE LA ASIGNATURA :";
            // 
            // lblNombreAsignatura
            // 
            this.lblNombreAsignatura.AutoSize = true;
            this.lblNombreAsignatura.Location = new System.Drawing.Point(416, 60);
            this.lblNombreAsignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreAsignatura.Name = "lblNombreAsignatura";
            this.lblNombreAsignatura.Size = new System.Drawing.Size(10, 13);
            this.lblNombreAsignatura.TabIndex = 20;
            this.lblNombreAsignatura.Text = "-";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.editar_icono;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 55;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.eliminar_icono;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 72;
            // 
            // btnSubirSilabo
            // 
            this.btnSubirSilabo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnSubirSilabo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubirSilabo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirSilabo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnSubirSilabo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnSubirSilabo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSubirSilabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirSilabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirSilabo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubirSilabo.Image = global::CapaPresentacion.Properties.Resources.export_regular_24;
            this.btnSubirSilabo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirSilabo.Location = new System.Drawing.Point(27, 409);
            this.btnSubirSilabo.Name = "btnSubirSilabo";
            this.btnSubirSilabo.Size = new System.Drawing.Size(168, 34);
            this.btnSubirSilabo.TabIndex = 13;
            this.btnSubirSilabo.Text = "SUBIR SILABO";
            this.btnSubirSilabo.UseVisualStyleBackColor = false;
            // 
            // btnVerSilabo
            // 
            this.btnVerSilabo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnVerSilabo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerSilabo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerSilabo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnVerSilabo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnVerSilabo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerSilabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSilabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSilabo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVerSilabo.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSilabo.Image")));
            this.btnVerSilabo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerSilabo.Location = new System.Drawing.Point(208, 409);
            this.btnVerSilabo.Name = "btnVerSilabo";
            this.btnVerSilabo.Size = new System.Drawing.Size(168, 34);
            this.btnVerSilabo.TabIndex = 12;
            this.btnVerSilabo.Text = "VER SILABO";
            this.btnVerSilabo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnAgregarTema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnAgregarTema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnAgregarTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTema.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarTema.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTema.Image")));
            this.btnAgregarTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTema.Location = new System.Drawing.Point(665, 409);
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(168, 34);
            this.btnAgregarTema.TabIndex = 21;
            this.btnAgregarTema.Text = "AGREGAR TEMA";
            this.btnAgregarTema.UseVisualStyleBackColor = false;
            // 
            // frmPlanDeSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 463);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.lblNombreAsignatura);
            this.Controls.Add(this.labelPlanSesiones);
            this.Controls.Add(this.btnSubirSilabo);
            this.Controls.Add(this.btnVerSilabo);
            this.Controls.Add(this.dgvPlanSesiones);
            this.Controls.Add(this.panelVistaHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlanDeSesiones";
            this.Text = "frmPlanDeSesiones";
            this.panelVistaHorario.ResumeLayout(false);
            this.panelVistaHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinPlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanSesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVistaHorario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox btnClosePlanSesiones;
        private System.Windows.Forms.PictureBox btnMinPlanSesiones;
        private System.Windows.Forms.DataGridView dgvPlanSesiones;
        private System.Windows.Forms.Button btnVerSilabo;
        private System.Windows.Forms.Button btnSubirSilabo;
        private System.Windows.Forms.Label labelPlanSesiones;
        public System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnAgregarTema;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}