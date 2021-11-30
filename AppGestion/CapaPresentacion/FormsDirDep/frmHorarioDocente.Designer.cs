
namespace CapaPresentacion 
{ 
    partial class frmHorarioDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarioDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dgvHorarioDocente = new System.Windows.Forms.DataGridView();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxHDictado = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelHorasDictado = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelBarraTitulo.Controls.Add(this.pictureBoxMin);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxClose);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxLogo);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxMinimizar);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxCerrar);
            this.panelBarraTitulo.Controls.Add(this.labelTitulo);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(724, 34);
            this.panelBarraTitulo.TabIndex = 12;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMin.Image")));
            this.pictureBoxMin.Location = new System.Drawing.Point(657, 3);
            this.pictureBoxMin.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMin.TabIndex = 55;
            this.pictureBoxMin.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(689, 3);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 56;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 54;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(930, 8);
            this.pictureBoxMinimizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizar.TabIndex = 52;
            this.pictureBoxMinimizar.TabStop = false;
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(977, 8);
            this.pictureBoxCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerrar.TabIndex = 53;
            this.pictureBoxCerrar.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTitulo.Location = new System.Drawing.Point(40, 9);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(160, 22);
            this.labelTitulo.TabIndex = 31;
            this.labelTitulo.Text = "Horario docente\r\n";
            // 
            // dgvHorarioDocente
            // 
            this.dgvHorarioDocente.AllowUserToAddRows = false;
            this.dgvHorarioDocente.AllowUserToDeleteRows = false;
            this.dgvHorarioDocente.AllowUserToResizeColumns = false;
            this.dgvHorarioDocente.AllowUserToResizeRows = false;
            this.dgvHorarioDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarioDocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorarioDocente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHorarioDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHorarioDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHorarioDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarioDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHorarioDocente.ColumnHeadersHeight = 40;
            this.dgvHorarioDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorarioDocente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHorarioDocente.Location = new System.Drawing.Point(20, 224);
            this.dgvHorarioDocente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHorarioDocente.Name = "dgvHorarioDocente";
            this.dgvHorarioDocente.RowHeadersVisible = false;
            this.dgvHorarioDocente.RowHeadersWidth = 51;
            this.dgvHorarioDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHorarioDocente.Size = new System.Drawing.Size(684, 173);
            this.dgvHorarioDocente.TabIndex = 60;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(19, 68);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(132, 23);
            this.textBoxCodigo.TabIndex = 61;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(19, 122);
            this.textBoxNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.ReadOnly = true;
            this.textBoxNombres.Size = new System.Drawing.Size(270, 23);
            this.textBoxNombres.TabIndex = 62;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(19, 177);
            this.textBoxEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(154, 23);
            this.textBoxEstado.TabIndex = 63;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxApellidos.Location = new System.Drawing.Point(348, 122);
            this.textBoxApellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.ReadOnly = true;
            this.textBoxApellidos.Size = new System.Drawing.Size(332, 23);
            this.textBoxApellidos.TabIndex = 63;
            // 
            // textBoxHDictado
            // 
            this.textBoxHDictado.Location = new System.Drawing.Point(348, 177);
            this.textBoxHDictado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHDictado.Name = "textBoxHDictado";
            this.textBoxHDictado.ReadOnly = true;
            this.textBoxHDictado.Size = new System.Drawing.Size(132, 23);
            this.textBoxHDictado.TabIndex = 63;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelCodigo.Location = new System.Drawing.Point(15, 47);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(69, 17);
            this.labelCodigo.TabIndex = 64;
            this.labelCodigo.Text = "CÓDIGO:";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelNombres.Location = new System.Drawing.Point(15, 100);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(72, 17);
            this.labelNombres.TabIndex = 64;
            this.labelNombres.Text = "NOMBRES:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelEstado.Location = new System.Drawing.Point(15, 156);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(60, 17);
            this.labelEstado.TabIndex = 64;
            this.labelEstado.Text = "ESTADO:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelApellidos.Location = new System.Drawing.Point(344, 100);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(78, 17);
            this.labelApellidos.TabIndex = 64;
            this.labelApellidos.Text = "APELLIDOS:";
            // 
            // labelHorasDictado
            // 
            this.labelHorasDictado.AutoSize = true;
            this.labelHorasDictado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelHorasDictado.Location = new System.Drawing.Point(344, 156);
            this.labelHorasDictado.Name = "labelHorasDictado";
            this.labelHorasDictado.Size = new System.Drawing.Size(139, 17);
            this.labelHorasDictado.TabIndex = 64;
            this.labelHorasDictado.Text = "HORAS DE DICTADO:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(576, 413);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(116, 29);
            this.buttonCerrar.TabIndex = 65;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // frmHorarioDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 460);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelHorasDictado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelNombres);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxHDictado);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.dgvHorarioDocente);
            this.Controls.Add(this.panelBarraTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHorarioDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHorarioDocente";
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dgvHorarioDocente;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelHorasDictado;
        private System.Windows.Forms.Button buttonCerrar;
        public System.Windows.Forms.TextBox textBoxCodigo;
        public System.Windows.Forms.TextBox textBoxNombres;
        public System.Windows.Forms.TextBox textBoxEstado;
        public System.Windows.Forms.TextBox textBoxApellidos;
        public System.Windows.Forms.TextBox textBoxHDictado;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}