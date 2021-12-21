
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
            this.Completado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPlanSesiones = new System.Windows.Forms.Label();
            this.lblNombreAsignatura = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregarTema = new System.Windows.Forms.Button();
            this.buttonGUARDAR = new System.Windows.Forms.Button();
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
            this.panelVistaHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVistaHorario.Name = "panelVistaHorario";
            this.panelVistaHorario.Size = new System.Drawing.Size(978, 43);
            this.panelVistaHorario.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(48, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "PLAN DE SESIONES";
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
            // btnClosePlanSesiones
            // 
            this.btnClosePlanSesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePlanSesiones.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePlanSesiones.Image")));
            this.btnClosePlanSesiones.Location = new System.Drawing.Point(908, 4);
            this.btnClosePlanSesiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClosePlanSesiones.Name = "btnClosePlanSesiones";
            this.btnClosePlanSesiones.Size = new System.Drawing.Size(36, 34);
            this.btnClosePlanSesiones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClosePlanSesiones.TabIndex = 1;
            this.btnClosePlanSesiones.TabStop = false;
            this.btnClosePlanSesiones.Click += new System.EventHandler(this.btnClosePlanSesiones_Click);
            // 
            // btnMinPlanSesiones
            // 
            this.btnMinPlanSesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinPlanSesiones.Image = ((System.Drawing.Image)(resources.GetObject("btnMinPlanSesiones.Image")));
            this.btnMinPlanSesiones.Location = new System.Drawing.Point(866, 4);
            this.btnMinPlanSesiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinPlanSesiones.Name = "btnMinPlanSesiones";
            this.btnMinPlanSesiones.Size = new System.Drawing.Size(36, 34);
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
            this.eliminar,
            this.Completado,
            this.observacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanSesiones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanSesiones.Location = new System.Drawing.Point(36, 137);
            this.dgvPlanSesiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPlanSesiones.Name = "dgvPlanSesiones";
            this.dgvPlanSesiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlanSesiones.RowHeadersVisible = false;
            this.dgvPlanSesiones.RowHeadersWidth = 51;
            this.dgvPlanSesiones.RowTemplate.Height = 24;
            this.dgvPlanSesiones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPlanSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPlanSesiones.Size = new System.Drawing.Size(908, 335);
            this.dgvPlanSesiones.TabIndex = 11;
            this.dgvPlanSesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanSesiones_CellContentClick);
            this.dgvPlanSesiones.DoubleClick += new System.EventHandler(this.dgvPlanSesiones_DoubleClick);
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar_icono;
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.Width = 72;
            // 
            // Completado
            // 
            this.Completado.HeaderText = "Completado";
            this.Completado.MinimumWidth = 6;
            this.Completado.Name = "Completado";
            this.Completado.Width = 108;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observacion";
            this.observacion.MinimumWidth = 6;
            this.observacion.Name = "observacion";
            this.observacion.Width = 132;
            // 
            // labelPlanSesiones
            // 
            this.labelPlanSesiones.AutoSize = true;
            this.labelPlanSesiones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanSesiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelPlanSesiones.Location = new System.Drawing.Point(282, 51);
            this.labelPlanSesiones.Name = "labelPlanSesiones";
            this.labelPlanSesiones.Size = new System.Drawing.Size(364, 23);
            this.labelPlanSesiones.TabIndex = 14;
            this.labelPlanSesiones.Text = "PLAN DE SESIONES DE LA ASIGNATURA :";
            // 
            // lblNombreAsignatura
            // 
            this.lblNombreAsignatura.AutoSize = true;
            this.lblNombreAsignatura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAsignatura.Location = new System.Drawing.Point(264, 83);
            this.lblNombreAsignatura.Name = "lblNombreAsignatura";
            this.lblNombreAsignatura.Size = new System.Drawing.Size(16, 21);
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
            // btnAgregarTema
            // 
            this.btnAgregarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnAgregarTema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnAgregarTema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnAgregarTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTema.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTema.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTema.Image")));
            this.btnAgregarTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTema.Location = new System.Drawing.Point(546, 491);
            this.btnAgregarTema.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(201, 46);
            this.btnAgregarTema.TabIndex = 21;
            this.btnAgregarTema.Text = "AGREGAR TEMA";
            this.btnAgregarTema.UseVisualStyleBackColor = false;
            // 
            // buttonGUARDAR
            // 
            this.buttonGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonGUARDAR.FlatAppearance.BorderSize = 0;
            this.buttonGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGUARDAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGUARDAR.ForeColor = System.Drawing.Color.White;
            this.buttonGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonGUARDAR.Image")));
            this.buttonGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGUARDAR.Location = new System.Drawing.Point(786, 491);
            this.buttonGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGUARDAR.Name = "buttonGUARDAR";
            this.buttonGUARDAR.Size = new System.Drawing.Size(158, 46);
            this.buttonGUARDAR.TabIndex = 23;
            this.buttonGUARDAR.Text = "GUARDAR";
            this.buttonGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGUARDAR.UseVisualStyleBackColor = false;
            // 
            // frmPlanDeSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 570);
            this.Controls.Add(this.buttonGUARDAR);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.lblNombreAsignatura);
            this.Controls.Add(this.labelPlanSesiones);
            this.Controls.Add(this.dgvPlanSesiones);
            this.Controls.Add(this.panelVistaHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlanDeSesiones";
            this.Text = "frmPlanDeSesiones";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmPlanDeSesiones_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmPlanDeSesiones_DragOver);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPlanDeSesiones_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPlanDeSesiones_MouseMove);
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
        private System.Windows.Forms.Label labelPlanSesiones;
        public System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnAgregarTema;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.Button buttonGUARDAR;
    }
}