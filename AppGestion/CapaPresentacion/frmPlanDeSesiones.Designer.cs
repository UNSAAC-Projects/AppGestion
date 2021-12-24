
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
            this.pnlPlanDeSeciones = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnClosePlanSesiones = new System.Windows.Forms.PictureBox();
            this.btnMinPlanSesiones = new System.Windows.Forms.PictureBox();
            this.dgvPlanSesiones = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Completado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelPlanSesiones = new System.Windows.Forms.Label();
            this.lblNombreAsignatura = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevaFila = new System.Windows.Forms.Button();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlPlanDeSeciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinPlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlanDeSeciones
            // 
            this.pnlPlanDeSeciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.pnlPlanDeSeciones.Controls.Add(this.label11);
            this.pnlPlanDeSeciones.Controls.Add(this.pictureBoxLogo);
            this.pnlPlanDeSeciones.Controls.Add(this.btnClosePlanSesiones);
            this.pnlPlanDeSeciones.Controls.Add(this.btnMinPlanSesiones);
            this.pnlPlanDeSeciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlanDeSeciones.Location = new System.Drawing.Point(0, 0);
            this.pnlPlanDeSeciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPlanDeSeciones.Name = "pnlPlanDeSeciones";
            this.pnlPlanDeSeciones.Size = new System.Drawing.Size(837, 35);
            this.pnlPlanDeSeciones.TabIndex = 10;
            this.pnlPlanDeSeciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlanDeSeciones_Paint);
            this.pnlPlanDeSeciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPlanDeSeciones_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "PLAN DE SESIONES";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 55;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnClosePlanSesiones
            // 
            this.btnClosePlanSesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePlanSesiones.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePlanSesiones.Image")));
            this.btnClosePlanSesiones.Location = new System.Drawing.Point(801, 3);
            this.btnClosePlanSesiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnMinPlanSesiones.Location = new System.Drawing.Point(770, 3);
            this.btnMinPlanSesiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dgvPlanSesiones.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvPlanSesiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlanSesiones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanSesiones.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanSesiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.Observacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanSesiones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanSesiones.Location = new System.Drawing.Point(27, 111);
            this.dgvPlanSesiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPlanSesiones.Name = "dgvPlanSesiones";
            this.dgvPlanSesiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlanSesiones.RowHeadersVisible = false;
            this.dgvPlanSesiones.RowHeadersWidth = 51;
            this.dgvPlanSesiones.RowTemplate.Height = 24;
            this.dgvPlanSesiones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPlanSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPlanSesiones.Size = new System.Drawing.Size(782, 272);
            this.dgvPlanSesiones.TabIndex = 11;
            this.dgvPlanSesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanSesiones_CellContentClick);
            this.dgvPlanSesiones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanSesiones_CellValueChanged);
            this.dgvPlanSesiones.DoubleClick += new System.EventHandler(this.dgvPlanSesiones_DoubleClick);
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar_icono;
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.Width = 58;
            // 
            // Completado
            // 
            this.Completado.FalseValue = "NO";
            this.Completado.HeaderText = "Completado";
            this.Completado.MinimumWidth = 6;
            this.Completado.Name = "Completado";
            this.Completado.TrueValue = "SI";
            this.Completado.Width = 87;
            // 
            // labelPlanSesiones
            // 
            this.labelPlanSesiones.AutoSize = true;
            this.labelPlanSesiones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanSesiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelPlanSesiones.Location = new System.Drawing.Point(104, 55);
            this.labelPlanSesiones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlanSesiones.Name = "labelPlanSesiones";
            this.labelPlanSesiones.Size = new System.Drawing.Size(291, 18);
            this.labelPlanSesiones.TabIndex = 14;
            this.labelPlanSesiones.Text = "PLAN DE SESIONES DE LA ASIGNATURA :";
            // 
            // lblNombreAsignatura
            // 
            this.lblNombreAsignatura.AutoSize = true;
            this.lblNombreAsignatura.Location = new System.Drawing.Point(388, 59);
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(861, 503);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 37);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "GUARDAR ";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(9, 470);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 3);
            this.panel1.TabIndex = 22;
            // 
            // btnNuevaFila
            // 
            this.btnNuevaFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnNuevaFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevaFila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaFila.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnNuevaFila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnNuevaFila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNuevaFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFila.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFila.ForeColor = System.Drawing.Color.White;
            this.btnNuevaFila.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFila.Location = new System.Drawing.Point(629, 503);
            this.btnNuevaFila.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaFila.Name = "btnNuevaFila";
            this.btnNuevaFila.Size = new System.Drawing.Size(151, 37);
            this.btnNuevaFila.TabIndex = 23;
            this.btnNuevaFila.Text = "ANADIR NUEVA FILA";
            this.btnNuevaFila.UseVisualStyleBackColor = false;
            this.btnNuevaFila.Click += new System.EventHandler(this.btnNuevaFila_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-63, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(955, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // frmPlanDeSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(837, 475);
            this.Controls.Add(this.btnNuevaFila);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreAsignatura);
            this.Controls.Add(this.labelPlanSesiones);
            this.Controls.Add(this.dgvPlanSesiones);
            this.Controls.Add(this.pnlPlanDeSeciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPlanDeSesiones";
            this.Text = "frmPlanDeSesiones";
            this.Load += new System.EventHandler(this.frmPlanDeSesiones_Load);
            this.pnlPlanDeSeciones.ResumeLayout(false);
            this.pnlPlanDeSeciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinPlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlanDeSeciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox btnClosePlanSesiones;
        private System.Windows.Forms.PictureBox btnMinPlanSesiones;
        private System.Windows.Forms.DataGridView dgvPlanSesiones;
        private System.Windows.Forms.Label labelPlanSesiones;
        public System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevaFila;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}