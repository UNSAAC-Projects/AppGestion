
namespace CapaPresentacion
{
    partial class frmAsistenciaDiariaDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistenciaDiariaDocentes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAsistencia = new System.Windows.Forms.Panel();
            this.btnCERRAR = new System.Windows.Forms.PictureBox();
            this.btnMINIMIZAR = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonGUARDAR = new System.Windows.Forms.Button();
            this.buttonDESMARCAR = new System.Windows.Forms.Button();
            this.buttonMarcar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.Asistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelTextoFecha = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.labelNroDocentes = new System.Windows.Forms.Label();
            this.labelTextoNroDoc = new System.Windows.Forms.Label();
            this.lblAsistio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFaltaron = new System.Windows.Forms.Label();
            this.labelTextoHora = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pnlAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMINIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAsistencia
            // 
            this.pnlAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.pnlAsistencia.Controls.Add(this.btnCERRAR);
            this.pnlAsistencia.Controls.Add(this.btnMINIMIZAR);
            this.pnlAsistencia.Controls.Add(this.pictureBox3);
            this.pnlAsistencia.Controls.Add(this.label11);
            this.pnlAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAsistencia.Location = new System.Drawing.Point(0, 0);
            this.pnlAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAsistencia.Name = "pnlAsistencia";
            this.pnlAsistencia.Size = new System.Drawing.Size(725, 36);
            this.pnlAsistencia.TabIndex = 1;
            this.pnlAsistencia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAsistencia_MouseMove);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.Transparent;
            this.btnCERRAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCERRAR.Image")));
            this.btnCERRAR.Location = new System.Drawing.Point(693, 2);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(27, 29);
            this.btnCERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCERRAR.TabIndex = 36;
            this.btnCERRAR.TabStop = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnMINIMIZAR
            // 
            this.btnMINIMIZAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMINIMIZAR.BackColor = System.Drawing.Color.Transparent;
            this.btnMINIMIZAR.Image = ((System.Drawing.Image)(resources.GetObject("btnMINIMIZAR.Image")));
            this.btnMINIMIZAR.Location = new System.Drawing.Point(662, 2);
            this.btnMINIMIZAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMINIMIZAR.Name = "btnMINIMIZAR";
            this.btnMINIMIZAR.Size = new System.Drawing.Size(27, 29);
            this.btnMINIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMINIMIZAR.TabIndex = 35;
            this.btnMINIMIZAR.TabStop = false;
            this.btnMINIMIZAR.Click += new System.EventHandler(this.btnMINIMIZAR_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.menu_regular_242;
            this.pictureBox3.Location = new System.Drawing.Point(9, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(40, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "ASISTENCIA DIARIA DE DOCENTES";
            // 
            // buttonGUARDAR
            // 
            this.buttonGUARDAR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGUARDAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGUARDAR.BackgroundImage")));
            this.buttonGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGUARDAR.FlatAppearance.BorderSize = 0;
            this.buttonGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.buttonGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGUARDAR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGUARDAR.ForeColor = System.Drawing.Color.DimGray;
            this.buttonGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGUARDAR.Location = new System.Drawing.Point(579, 453);
            this.buttonGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGUARDAR.Name = "buttonGUARDAR";
            this.buttonGUARDAR.Size = new System.Drawing.Size(63, 58);
            this.buttonGUARDAR.TabIndex = 15;
            this.buttonGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGUARDAR.UseVisualStyleBackColor = false;
            this.buttonGUARDAR.Click += new System.EventHandler(this.buttonGUARDAR_Click);
            // 
            // buttonDESMARCAR
            // 
            this.buttonDESMARCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonDESMARCAR.FlatAppearance.BorderSize = 0;
            this.buttonDESMARCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.buttonDESMARCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDESMARCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDESMARCAR.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDESMARCAR.ForeColor = System.Drawing.Color.White;
            this.buttonDESMARCAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDESMARCAR.Image")));
            this.buttonDESMARCAR.Location = new System.Drawing.Point(26, 280);
            this.buttonDESMARCAR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDESMARCAR.Name = "buttonDESMARCAR";
            this.buttonDESMARCAR.Size = new System.Drawing.Size(74, 115);
            this.buttonDESMARCAR.TabIndex = 9;
            this.buttonDESMARCAR.Text = "Desmarcar\r\ntodos";
            this.buttonDESMARCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDESMARCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDESMARCAR.UseVisualStyleBackColor = false;
            this.buttonDESMARCAR.Click += new System.EventHandler(this.buttonDESMARCAR_Click);
            // 
            // buttonMarcar
            // 
            this.buttonMarcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonMarcar.FlatAppearance.BorderSize = 0;
            this.buttonMarcar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.buttonMarcar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarcar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarcar.ForeColor = System.Drawing.Color.White;
            this.buttonMarcar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMarcar.Image")));
            this.buttonMarcar.Location = new System.Drawing.Point(26, 159);
            this.buttonMarcar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMarcar.Name = "buttonMarcar";
            this.buttonMarcar.Size = new System.Drawing.Size(74, 115);
            this.buttonMarcar.TabIndex = 8;
            this.buttonMarcar.Text = "Marcar \r\ntodos";
            this.buttonMarcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMarcar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMarcar.UseVisualStyleBackColor = false;
            this.buttonMarcar.Click += new System.EventHandler(this.buttonMARCAR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(662, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AllowUserToDeleteRows = false;
            this.dgvAsistencia.AllowUserToResizeColumns = false;
            this.dgvAsistencia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvAsistencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsistencia.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistencia.ColumnHeadersHeight = 38;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsistencia.Location = new System.Drawing.Point(108, 130);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAsistencia.RowHeadersVisible = false;
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.RowTemplate.Height = 24;
            this.dgvAsistencia.Size = new System.Drawing.Size(581, 319);
            this.dgvAsistencia.TabIndex = 16;
            this.dgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellContentClick);
            this.dgvAsistencia.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellValueChanged);
            // 
            // Asistencia
            // 
            this.Asistencia.FalseValue = "F";
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.TrueValue = "P";
            this.Asistencia.Width = 72;
            // 
            // labelTextoFecha
            // 
            this.labelTextoFecha.AutoSize = true;
            this.labelTextoFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelTextoFecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelTextoFecha.Location = new System.Drawing.Point(105, 59);
            this.labelTextoFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextoFecha.Name = "labelTextoFecha";
            this.labelTextoFecha.Size = new System.Drawing.Size(58, 17);
            this.labelTextoFecha.TabIndex = 17;
            this.labelTextoFecha.Text = "Fecha: ";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFecha.Location = new System.Drawing.Point(167, 59);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(12, 15);
            this.labelFecha.TabIndex = 18;
            this.labelFecha.Text = "-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.ForeColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(6, 487);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 4);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.ForeColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(6, 474);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 4);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel5.Location = new System.Drawing.Point(652, 488);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(68, 4);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel6.Location = new System.Drawing.Point(663, 480);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 4);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(6, 480);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 4);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.ForeColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(646, 474);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(74, 4);
            this.panel8.TabIndex = 24;
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAsignatura.Location = new System.Drawing.Point(100, 100);
            this.lblAsignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(12, 16);
            this.lblAsignatura.TabIndex = 26;
            this.lblAsignatura.Text = "-";
            // 
            // labelNroDocentes
            // 
            this.labelNroDocentes.AutoSize = true;
            this.labelNroDocentes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDocentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNroDocentes.Location = new System.Drawing.Point(484, 62);
            this.labelNroDocentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNroDocentes.Name = "labelNroDocentes";
            this.labelNroDocentes.Size = new System.Drawing.Size(12, 15);
            this.labelNroDocentes.TabIndex = 27;
            this.labelNroDocentes.Text = "-";
            // 
            // labelTextoNroDoc
            // 
            this.labelTextoNroDoc.AutoSize = true;
            this.labelTextoNroDoc.BackColor = System.Drawing.Color.Transparent;
            this.labelTextoNroDoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoNroDoc.ForeColor = System.Drawing.Color.DimGray;
            this.labelTextoNroDoc.Location = new System.Drawing.Point(338, 60);
            this.labelTextoNroDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextoNroDoc.Name = "labelTextoNroDoc";
            this.labelTextoNroDoc.Size = new System.Drawing.Size(114, 17);
            this.labelTextoNroDoc.TabIndex = 28;
            this.labelTextoNroDoc.Text = "Nro. de docentes:";
            // 
            // lblAsistio
            // 
            this.lblAsistio.AutoSize = true;
            this.lblAsistio.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistio.Location = new System.Drawing.Point(406, 94);
            this.lblAsistio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsistio.Name = "lblAsistio";
            this.lblAsistio.Size = new System.Drawing.Size(19, 15);
            this.lblAsistio.TabIndex = 29;
            this.lblAsistio.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(338, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Asistentes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(471, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Faltaron";
            // 
            // lblFaltaron
            // 
            this.lblFaltaron.AutoSize = true;
            this.lblFaltaron.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaron.Location = new System.Drawing.Point(532, 97);
            this.lblFaltaron.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaltaron.Name = "lblFaltaron";
            this.lblFaltaron.Size = new System.Drawing.Size(19, 15);
            this.lblFaltaron.TabIndex = 32;
            this.lblFaltaron.Text = "__";
            // 
            // labelTextoHora
            // 
            this.labelTextoHora.AutoSize = true;
            this.labelTextoHora.BackColor = System.Drawing.Color.Transparent;
            this.labelTextoHora.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelTextoHora.Location = new System.Drawing.Point(105, 86);
            this.labelTextoHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextoHora.Name = "labelTextoHora";
            this.labelTextoHora.Size = new System.Drawing.Size(44, 17);
            this.labelTextoHora.TabIndex = 33;
            this.labelTextoHora.Text = "Hora:";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelHora.Location = new System.Drawing.Point(153, 88);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(12, 15);
            this.labelHora.TabIndex = 34;
            this.labelHora.Text = "-";
            // 
            // frmAsistenciaDiariaDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(725, 517);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelTextoHora);
            this.Controls.Add(this.lblFaltaron);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAsistio);
            this.Controls.Add(this.labelTextoNroDoc);
            this.Controls.Add(this.labelNroDocentes);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTextoFecha);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.buttonGUARDAR);
            this.Controls.Add(this.buttonDESMARCAR);
            this.Controls.Add(this.buttonMarcar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAsistenciaDiariaDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " k";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.pnlAsistencia.ResumeLayout(false);
            this.pnlAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCERRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMINIMIZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAsistencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonMarcar;
        private System.Windows.Forms.Button buttonDESMARCAR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonGUARDAR;
        private System.Windows.Forms.PictureBox btnMINIMIZAR;
        private System.Windows.Forms.PictureBox btnCERRAR;
        public System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.Label labelTextoFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label labelNroDocentes;
        private System.Windows.Forms.Label labelTextoNroDoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asistencia;
        private System.Windows.Forms.Label lblAsistio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFaltaron;
        private System.Windows.Forms.Label labelTextoHora;
        private System.Windows.Forms.Label labelHora;
    }
}