
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPlanDeSeciones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClosePlanSesiones = new System.Windows.Forms.PictureBox();
            this.btnMinPlanSesiones = new System.Windows.Forms.PictureBox();
            this.dgvPlanSesiones = new System.Windows.Forms.DataGridView();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPlanSesiones = new System.Windows.Forms.Label();
            this.lblNombreAsignatura = new System.Windows.Forms.Label();
            this.pnlLineaLibros = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureLibro3 = new System.Windows.Forms.PictureBox();
            this.btnNuevaFila = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureLibro1 = new System.Windows.Forms.PictureBox();
            this.pictureLibro2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImportarDatos = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Completado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VariacionH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlPlanDeSeciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinPlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibro2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlanDeSeciones
            // 
            this.pnlPlanDeSeciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.pnlPlanDeSeciones.Controls.Add(this.pictureBox1);
            this.pnlPlanDeSeciones.Controls.Add(this.label11);
            this.pnlPlanDeSeciones.Controls.Add(this.btnClosePlanSesiones);
            this.pnlPlanDeSeciones.Controls.Add(this.btnMinPlanSesiones);
            this.pnlPlanDeSeciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlanDeSeciones.Location = new System.Drawing.Point(0, 0);
            this.pnlPlanDeSeciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlanDeSeciones.Name = "pnlPlanDeSeciones";
            this.pnlPlanDeSeciones.Size = new System.Drawing.Size(1116, 43);
            this.pnlPlanDeSeciones.TabIndex = 10;
            this.pnlPlanDeSeciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPlanDeSeciones_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(48, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "PLAN DE SESIONES";
            // 
            // btnClosePlanSesiones
            // 
            this.btnClosePlanSesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePlanSesiones.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePlanSesiones.Image")));
            this.btnClosePlanSesiones.Location = new System.Drawing.Point(1068, 4);
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
            this.btnMinPlanSesiones.Location = new System.Drawing.Point(1027, 4);
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
            this.VariacionH,
            this.Tiempo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanSesiones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanSesiones.Location = new System.Drawing.Point(36, 114);
            this.dgvPlanSesiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPlanSesiones.Name = "dgvPlanSesiones";
            this.dgvPlanSesiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanSesiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlanSesiones.RowHeadersVisible = false;
            this.dgvPlanSesiones.RowHeadersWidth = 51;
            this.dgvPlanSesiones.RowTemplate.Height = 24;
            this.dgvPlanSesiones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPlanSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPlanSesiones.Size = new System.Drawing.Size(1043, 347);
            this.dgvPlanSesiones.TabIndex = 11;
            this.dgvPlanSesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanSesiones_CellContentClick);
            this.dgvPlanSesiones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanSesiones_CellValueChanged);
            // 
            // Observacion
            // 
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 132;
            // 
            // labelPlanSesiones
            // 
            this.labelPlanSesiones.AutoSize = true;
            this.labelPlanSesiones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanSesiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelPlanSesiones.Location = new System.Drawing.Point(75, 70);
            this.labelPlanSesiones.Name = "labelPlanSesiones";
            this.labelPlanSesiones.Size = new System.Drawing.Size(388, 23);
            this.labelPlanSesiones.TabIndex = 14;
            this.labelPlanSesiones.Text = "PLAN DE SESIONES DE LA ASIGNATURA :";
            // 
            // lblNombreAsignatura
            // 
            this.lblNombreAsignatura.AutoSize = true;
            this.lblNombreAsignatura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAsignatura.Location = new System.Drawing.Point(468, 70);
            this.lblNombreAsignatura.Name = "lblNombreAsignatura";
            this.lblNombreAsignatura.Size = new System.Drawing.Size(16, 21);
            this.lblNombreAsignatura.TabIndex = 20;
            this.lblNombreAsignatura.Text = "-";
            // 
            // pnlLineaLibros
            // 
            this.pnlLineaLibros.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLineaLibros.Location = new System.Drawing.Point(4, 572);
            this.pnlLineaLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLineaLibros.Name = "pnlLineaLibros";
            this.pnlLineaLibros.Size = new System.Drawing.Size(1109, 6);
            this.pnlLineaLibros.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(36, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 2);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(39, 460);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 2);
            this.panel3.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(36, 114);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 347);
            this.panel5.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(1077, 114);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 347);
            this.panel4.TabIndex = 37;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.editar_icono;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 55;
            // 
            // pictureLibro3
            // 
            this.pictureLibro3.Image = ((System.Drawing.Image)(resources.GetObject("pictureLibro3.Image")));
            this.pictureLibro3.Location = new System.Drawing.Point(185, 517);
            this.pictureLibro3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureLibro3.Name = "pictureLibro3";
            this.pictureLibro3.Size = new System.Drawing.Size(83, 68);
            this.pictureLibro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLibro3.TabIndex = 32;
            this.pictureLibro3.TabStop = false;
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
            this.btnNuevaFila.Location = new System.Drawing.Point(706, 517);
            this.btnNuevaFila.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevaFila.Name = "btnNuevaFila";
            this.btnNuevaFila.Size = new System.Drawing.Size(215, 46);
            this.btnNuevaFila.TabIndex = 23;
            this.btnNuevaFila.Text = "AÑADIR NUEVA FILA";
            this.btnNuevaFila.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaFila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaFila.UseVisualStyleBackColor = false;
            this.btnNuevaFila.Click += new System.EventHandler(this.btnNuevaFila_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(931, 517);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 46);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "GUARDAR ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1273, 84);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureLibro1
            // 
            this.pictureLibro1.Image = ((System.Drawing.Image)(resources.GetObject("pictureLibro1.Image")));
            this.pictureLibro1.Location = new System.Drawing.Point(5, 485);
            this.pictureLibro1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureLibro1.Name = "pictureLibro1";
            this.pictureLibro1.Size = new System.Drawing.Size(104, 82);
            this.pictureLibro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLibro1.TabIndex = 35;
            this.pictureLibro1.TabStop = false;
            // 
            // pictureLibro2
            // 
            this.pictureLibro2.Image = ((System.Drawing.Image)(resources.GetObject("pictureLibro2.Image")));
            this.pictureLibro2.Location = new System.Drawing.Point(89, 501);
            this.pictureLibro2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureLibro2.Name = "pictureLibro2";
            this.pictureLibro2.Size = new System.Drawing.Size(112, 70);
            this.pictureLibro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLibro2.TabIndex = 34;
            this.pictureLibro2.TabStop = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.eliminar_icono;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 72;
            // 
            // btnImportarDatos
            // 
            this.btnImportarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnImportarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImportarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnImportarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnImportarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnImportarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarDatos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarDatos.ForeColor = System.Drawing.Color.White;
            this.btnImportarDatos.Location = new System.Drawing.Point(412, 517);
            this.btnImportarDatos.Margin = new System.Windows.Forms.Padding(5);
            this.btnImportarDatos.Name = "btnImportarDatos";
            this.btnImportarDatos.Size = new System.Drawing.Size(284, 46);
            this.btnImportarDatos.TabIndex = 38;
            this.btnImportarDatos.Text = "IMPORTAR PLAN DE SESIONES ";
            this.btnImportarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarDatos.UseVisualStyleBackColor = false;
            this.btnImportarDatos.Click += new System.EventHandler(this.btnImportarDatos_Click);
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
            this.Completado.FalseValue = "NO";
            this.Completado.HeaderText = "Completado";
            this.Completado.MinimumWidth = 6;
            this.Completado.Name = "Completado";
            this.Completado.TrueValue = "SI";
            this.Completado.Width = 108;
            // 
            // VariacionH
            // 
            this.VariacionH.HeaderText = "Variacion";
            this.VariacionH.Items.AddRange(new object[] {
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4"});
            this.VariacionH.MinimumWidth = 6;
            this.VariacionH.Name = "VariacionH";
            this.VariacionH.Width = 87;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Horas";
            this.Tiempo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.Tiempo.MinimumWidth = 6;
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Width = 55;
            // 
            // frmPlanDeSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1116, 585);
            this.Controls.Add(this.btnImportarDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlLineaLibros);
            this.Controls.Add(this.pictureLibro3);
            this.Controls.Add(this.btnNuevaFila);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreAsignatura);
            this.Controls.Add(this.labelPlanSesiones);
            this.Controls.Add(this.pnlPlanDeSeciones);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureLibro1);
            this.Controls.Add(this.pictureLibro2);
            this.Controls.Add(this.dgvPlanSesiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPlanDeSesiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlanDeSesiones";
            this.Load += new System.EventHandler(this.frmPlanDeSesiones_Load);
            this.pnlPlanDeSeciones.ResumeLayout(false);
            this.pnlPlanDeSeciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinPlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlanDeSeciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnClosePlanSesiones;
        private System.Windows.Forms.PictureBox btnMinPlanSesiones;
        private System.Windows.Forms.DataGridView dgvPlanSesiones;
        private System.Windows.Forms.Label labelPlanSesiones;
        public System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlLineaLibros;
        private System.Windows.Forms.Button btnNuevaFila;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureLibro3;
        private System.Windows.Forms.PictureBox pictureLibro2;
        private System.Windows.Forms.PictureBox pictureLibro1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.Button btnImportarDatos;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completado;
        private System.Windows.Forms.DataGridViewComboBoxColumn VariacionH;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tiempo;
    }
}