
namespace CapaPresentacion
{
    partial class frmAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAsistencia = new System.Windows.Forms.Panel();
            this.btnCERRAR = new System.Windows.Forms.PictureBox();
            this.btnMINIMIZAR = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelLISTADOCENTE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOBSERVACIONES = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonGUARDAR = new System.Windows.Forms.Button();
            this.buttonDESMARCAR = new System.Windows.Forms.Button();
            this.buttonMARCAR = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.Asistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.comboBoxTema = new System.Windows.Forms.ComboBox();
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
            this.pnlAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAsistencia.Name = "pnlAsistencia";
            this.pnlAsistencia.Size = new System.Drawing.Size(692, 36);
            this.pnlAsistencia.TabIndex = 1;
            this.pnlAsistencia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAsistencia_MouseMove);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.Transparent;
            this.btnCERRAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCERRAR.Image")));
            this.btnCERRAR.Location = new System.Drawing.Point(660, 2);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnMINIMIZAR.Location = new System.Drawing.Point(628, 2);
            this.btnMINIMIZAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label11.Size = new System.Drawing.Size(193, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "ASISTENCIA DE ALUMNOS";
            // 
            // labelLISTADOCENTE
            // 
            this.labelLISTADOCENTE.AutoSize = true;
            this.labelLISTADOCENTE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLISTADOCENTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelLISTADOCENTE.Location = new System.Drawing.Point(210, 42);
            this.labelLISTADOCENTE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLISTADOCENTE.Name = "labelLISTADOCENTE";
            this.labelLISTADOCENTE.Size = new System.Drawing.Size(296, 18);
            this.labelLISTADOCENTE.TabIndex = 7;
            this.labelLISTADOCENTE.Text = "LISTA DE ALUMNOS DE LA ASIGNATURA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(129, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Docente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "TEMA A DICTAR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(350, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "OBSERVACIONES:";
            // 
            // textBoxOBSERVACIONES
            // 
            this.textBoxOBSERVACIONES.Location = new System.Drawing.Point(457, 121);
            this.textBoxOBSERVACIONES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOBSERVACIONES.Name = "textBoxOBSERVACIONES";
            this.textBoxOBSERVACIONES.Size = new System.Drawing.Size(189, 20);
            this.textBoxOBSERVACIONES.TabIndex = 14;
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
            this.buttonGUARDAR.Location = new System.Drawing.Point(289, 520);
            this.buttonGUARDAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGUARDAR.Name = "buttonGUARDAR";
            this.buttonGUARDAR.Size = new System.Drawing.Size(118, 37);
            this.buttonGUARDAR.TabIndex = 15;
            this.buttonGUARDAR.Text = "GUARDAR";
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
            this.buttonDESMARCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDESMARCAR.Location = new System.Drawing.Point(340, 154);
            this.buttonDESMARCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDESMARCAR.Name = "buttonDESMARCAR";
            this.buttonDESMARCAR.Size = new System.Drawing.Size(130, 30);
            this.buttonDESMARCAR.TabIndex = 9;
            this.buttonDESMARCAR.Text = "Desmarcar todos";
            this.buttonDESMARCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDESMARCAR.UseVisualStyleBackColor = false;
            this.buttonDESMARCAR.Click += new System.EventHandler(this.buttonDESMARCAR_Click);
            // 
            // buttonMARCAR
            // 
            this.buttonMARCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonMARCAR.FlatAppearance.BorderSize = 0;
            this.buttonMARCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.buttonMARCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMARCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMARCAR.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMARCAR.ForeColor = System.Drawing.Color.White;
            this.buttonMARCAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonMARCAR.Image")));
            this.buttonMARCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMARCAR.Location = new System.Drawing.Point(206, 154);
            this.buttonMARCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMARCAR.Name = "buttonMARCAR";
            this.buttonMARCAR.Size = new System.Drawing.Size(119, 30);
            this.buttonMARCAR.TabIndex = 8;
            this.buttonMARCAR.Text = "Marcar todos";
            this.buttonMARCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMARCAR.UseVisualStyleBackColor = false;
            this.buttonMARCAR.Click += new System.EventHandler(this.buttonMARCAR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(625, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.dgvAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistencia.ColumnHeadersHeight = 38;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia,
            this.Observacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsistencia.Location = new System.Drawing.Point(70, 188);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAsistencia.RowHeadersVisible = false;
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.RowTemplate.Height = 24;
            this.dgvAsistencia.Size = new System.Drawing.Size(561, 327);
            this.dgvAsistencia.TabIndex = 16;
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
            // Observacion
            // 
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(129, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha y Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(239, 104);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(10, 13);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "-";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(239, 81);
            this.lblDocente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(10, 13);
            this.lblDocente.TabIndex = 19;
            this.lblDocente.Text = "-";
            // 
            // comboBoxTema
            // 
            this.comboBoxTema.FormattingEnabled = true;
            this.comboBoxTema.Location = new System.Drawing.Point(139, 119);
            this.comboBoxTema.Name = "comboBoxTema";
            this.comboBoxTema.Size = new System.Drawing.Size(163, 21);
            this.comboBoxTema.TabIndex = 20;
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(692, 561);
            this.Controls.Add(this.comboBoxTema);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.buttonGUARDAR);
            this.Controls.Add(this.textBoxOBSERVACIONES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDESMARCAR);
            this.Controls.Add(this.buttonMARCAR);
            this.Controls.Add(this.labelLISTADOCENTE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsistencia";
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
        private System.Windows.Forms.Label labelLISTADOCENTE;
        private System.Windows.Forms.Button buttonMARCAR;
        private System.Windows.Forms.Button buttonDESMARCAR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOBSERVACIONES;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonGUARDAR;
        private System.Windows.Forms.PictureBox btnMINIMIZAR;
        private System.Windows.Forms.PictureBox btnCERRAR;
        public System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.ComboBox comboBoxTema;
    }
}