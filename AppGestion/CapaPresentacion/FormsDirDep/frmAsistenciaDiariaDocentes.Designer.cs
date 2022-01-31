
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonGUARDAR = new System.Windows.Forms.Button();
            this.buttonDESMARCAR = new System.Windows.Forms.Button();
            this.buttonMarcar = new System.Windows.Forms.Button();
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGUARDAR
            // 
            this.buttonGUARDAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.buttonGUARDAR.Location = new System.Drawing.Point(796, 564);
            this.buttonGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGUARDAR.Name = "buttonGUARDAR";
            this.buttonGUARDAR.Size = new System.Drawing.Size(70, 73);
            this.buttonGUARDAR.TabIndex = 15;
            this.buttonGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGUARDAR.UseVisualStyleBackColor = false;
            this.buttonGUARDAR.Click += new System.EventHandler(this.buttonGUARDAR_Click);
            // 
            // buttonDESMARCAR
            // 
            this.buttonDESMARCAR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDESMARCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonDESMARCAR.FlatAppearance.BorderSize = 0;
            this.buttonDESMARCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.buttonDESMARCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDESMARCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDESMARCAR.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDESMARCAR.ForeColor = System.Drawing.Color.White;
            this.buttonDESMARCAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDESMARCAR.Image")));
            this.buttonDESMARCAR.Location = new System.Drawing.Point(65, 319);
            this.buttonDESMARCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDESMARCAR.Name = "buttonDESMARCAR";
            this.buttonDESMARCAR.Size = new System.Drawing.Size(99, 142);
            this.buttonDESMARCAR.TabIndex = 9;
            this.buttonDESMARCAR.Text = "Desmarcar\r\ntodos";
            this.buttonDESMARCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDESMARCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDESMARCAR.UseVisualStyleBackColor = false;
            this.buttonDESMARCAR.Click += new System.EventHandler(this.buttonDESMARCAR_Click);
            // 
            // buttonMarcar
            // 
            this.buttonMarcar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonMarcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonMarcar.FlatAppearance.BorderSize = 0;
            this.buttonMarcar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.buttonMarcar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarcar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarcar.ForeColor = System.Drawing.Color.White;
            this.buttonMarcar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMarcar.Image")));
            this.buttonMarcar.Location = new System.Drawing.Point(65, 174);
            this.buttonMarcar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMarcar.Name = "buttonMarcar";
            this.buttonMarcar.Size = new System.Drawing.Size(99, 142);
            this.buttonMarcar.TabIndex = 8;
            this.buttonMarcar.Text = "Marcar \r\ntodos";
            this.buttonMarcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMarcar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMarcar.UseVisualStyleBackColor = false;
            this.buttonMarcar.Click += new System.EventHandler(this.buttonMARCAR_Click);
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AllowUserToDeleteRows = false;
            this.dgvAsistencia.AllowUserToResizeColumns = false;
            this.dgvAsistencia.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvAsistencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsistencia.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvAsistencia.ColumnHeadersHeight = 32;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvAsistencia.EnableHeadersVisualStyles = false;
            this.dgvAsistencia.Location = new System.Drawing.Point(170, 22);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAsistencia.RowHeadersVisible = false;
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.RowTemplate.Height = 24;
            this.dgvAsistencia.Size = new System.Drawing.Size(775, 538);
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
            this.Asistencia.Width = 86;
            // 
            // labelTextoFecha
            // 
            this.labelTextoFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTextoFecha.AutoSize = true;
            this.labelTextoFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.labelTextoFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelTextoFecha.Location = new System.Drawing.Point(1076, 267);
            this.labelTextoFecha.Name = "labelTextoFecha";
            this.labelTextoFecha.Size = new System.Drawing.Size(83, 23);
            this.labelTextoFecha.TabIndex = 17;
            this.labelTextoFecha.Text = "Fecha: ";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFecha.Location = new System.Drawing.Point(1181, 267);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(17, 23);
            this.labelFecha.TabIndex = 18;
            this.labelFecha.Text = "-";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.ForeColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(34, 607);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 5);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.ForeColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(34, 591);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 5);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel5.Location = new System.Drawing.Point(880, 609);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(91, 5);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel6.Location = new System.Drawing.Point(895, 599);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(76, 5);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(34, 599);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(712, 5);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.ForeColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(872, 591);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(99, 5);
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
            this.labelNroDocentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNroDocentes.AutoSize = true;
            this.labelNroDocentes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDocentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNroDocentes.Location = new System.Drawing.Point(1182, 344);
            this.labelNroDocentes.Name = "labelNroDocentes";
            this.labelNroDocentes.Size = new System.Drawing.Size(18, 23);
            this.labelNroDocentes.TabIndex = 27;
            this.labelNroDocentes.Text = "-";
            // 
            // labelTextoNroDoc
            // 
            this.labelTextoNroDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTextoNroDoc.AutoSize = true;
            this.labelTextoNroDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.labelTextoNroDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoNroDoc.ForeColor = System.Drawing.Color.DimGray;
            this.labelTextoNroDoc.Location = new System.Drawing.Point(971, 344);
            this.labelTextoNroDoc.Name = "labelTextoNroDoc";
            this.labelTextoNroDoc.Size = new System.Drawing.Size(186, 23);
            this.labelTextoNroDoc.TabIndex = 28;
            this.labelTextoNroDoc.Text = "Nro. de docentes:";
            // 
            // lblAsistio
            // 
            this.lblAsistio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAsistio.AutoSize = true;
            this.lblAsistio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistio.Location = new System.Drawing.Point(1182, 387);
            this.lblAsistio.Name = "lblAsistio";
            this.lblAsistio.Size = new System.Drawing.Size(30, 23);
            this.lblAsistio.TabIndex = 29;
            this.lblAsistio.Text = "__";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(1050, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Asistentes:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1066, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Faltaron";
            // 
            // lblFaltaron
            // 
            this.lblFaltaron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFaltaron.AutoSize = true;
            this.lblFaltaron.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaron.Location = new System.Drawing.Point(1182, 423);
            this.lblFaltaron.Name = "lblFaltaron";
            this.lblFaltaron.Size = new System.Drawing.Size(30, 23);
            this.lblFaltaron.TabIndex = 32;
            this.lblFaltaron.Text = "__";
            // 
            // labelTextoHora
            // 
            this.labelTextoHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTextoHora.AutoSize = true;
            this.labelTextoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.labelTextoHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelTextoHora.Location = new System.Drawing.Point(1095, 304);
            this.labelTextoHora.Name = "labelTextoHora";
            this.labelTextoHora.Size = new System.Drawing.Size(62, 23);
            this.labelTextoHora.TabIndex = 33;
            this.labelTextoHora.Text = "Hora:";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelHora.Location = new System.Drawing.Point(1181, 304);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(18, 23);
            this.labelHora.TabIndex = 34;
            this.labelHora.Text = "-";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(975, -4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(334, 356);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmAsistenciaDiariaDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1337, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGUARDAR);
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
            this.Controls.Add(this.buttonDESMARCAR);
            this.Controls.Add(this.buttonMarcar);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAsistenciaDiariaDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " k";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMarcar;
        private System.Windows.Forms.Button buttonDESMARCAR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonGUARDAR;
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}