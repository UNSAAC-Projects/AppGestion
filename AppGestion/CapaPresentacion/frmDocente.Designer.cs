
namespace CapaPresentacion
{
    partial class frmDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            this.ContenedorLogin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnVerCursosDocente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DOCENTE = new System.Windows.Forms.Label();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCERRAR = new System.Windows.Forms.PictureBox();
            this.btnMINIMIZAR = new System.Windows.Forms.PictureBox();
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.TEMA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ASISTENCIA = new System.Windows.Forms.DataGridViewImageColumn();
            this.ContenedorLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMINIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorLogin
            // 
            this.ContenedorLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.ContenedorLogin.Controls.Add(this.button1);
            this.ContenedorLogin.Controls.Add(this.pictureBoxLogo);
            this.ContenedorLogin.Controls.Add(this.label3);
            this.ContenedorLogin.Controls.Add(this.labelNombre);
            this.ContenedorLogin.Controls.Add(this.btnVerCursosDocente);
            this.ContenedorLogin.Controls.Add(this.panel2);
            this.ContenedorLogin.Controls.Add(this.panel1);
            this.ContenedorLogin.Controls.Add(this.DOCENTE);
            this.ContenedorLogin.Controls.Add(this.pictureBoxImagen);
            this.ContenedorLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContenedorLogin.Location = new System.Drawing.Point(0, 0);
            this.ContenedorLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContenedorLogin.Name = "ContenedorLogin";
            this.ContenedorLogin.Size = new System.Drawing.Size(291, 644);
            this.ContenedorLogin.TabIndex = 2;
            this.ContenedorLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.ContenedorLogin_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::CapaPresentacion.Properties.Resources.registered_solid_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "REPORTE DE CURSOS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 78);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 10;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "INGENIERIA INFORMATICA \r\nY DE SISTEMAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(37, 322);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(178, 22);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "NOMBRE USUARIO";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // btnVerCursosDocente
            // 
            this.btnVerCursosDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnVerCursosDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerCursosDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerCursosDocente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnVerCursosDocente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.btnVerCursosDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerCursosDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCursosDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCursosDocente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVerCursosDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnVerCursosDocente.Image")));
            this.btnVerCursosDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCursosDocente.Location = new System.Drawing.Point(13, 402);
            this.btnVerCursosDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerCursosDocente.Name = "btnVerCursosDocente";
            this.btnVerCursosDocente.Size = new System.Drawing.Size(261, 42);
            this.btnVerCursosDocente.TabIndex = 11;
            this.btnVerCursosDocente.Text = "VER TODOS MIS CURSOS";
            this.btnVerCursosDocente.UseVisualStyleBackColor = false;
            this.btnVerCursosDocente.Click += new System.EventHandler(this.btnVerCursosDocente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.panel2.Location = new System.Drawing.Point(13, 382);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 2);
            this.panel1.TabIndex = 5;
            // 
            // DOCENTE
            // 
            this.DOCENTE.AutoSize = true;
            this.DOCENTE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DOCENTE.ForeColor = System.Drawing.Color.White;
            this.DOCENTE.Location = new System.Drawing.Point(85, 126);
            this.DOCENTE.Name = "DOCENTE";
            this.DOCENTE.Size = new System.Drawing.Size(94, 23);
            this.DOCENTE.TabIndex = 3;
            this.DOCENTE.Text = "Docente";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagen.Image")));
            this.pictureBoxImagen.Location = new System.Drawing.Point(59, 164);
            this.pictureBoxImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(131, 135);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 0;
            this.pictureBoxImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(463, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "CURSOS  DICTADOS EN SEMESTRE LECTIVO";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.DimGray;
            this.btnCERRAR.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2021_11_21_at_12_53_18_PM__1_;
            this.btnCERRAR.Location = new System.Drawing.Point(1179, 0);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(43, 41);
            this.btnCERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCERRAR.TabIndex = 13;
            this.btnCERRAR.TabStop = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnMINIMIZAR
            // 
            this.btnMINIMIZAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMINIMIZAR.BackColor = System.Drawing.Color.DimGray;
            this.btnMINIMIZAR.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2021_11_21_at_12_53_18_PM;
            this.btnMINIMIZAR.Location = new System.Drawing.Point(1129, 0);
            this.btnMINIMIZAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMINIMIZAR.Name = "btnMINIMIZAR";
            this.btnMINIMIZAR.Size = new System.Drawing.Size(43, 41);
            this.btnMINIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMINIMIZAR.TabIndex = 12;
            this.btnMINIMIZAR.TabStop = false;
            this.btnMINIMIZAR.Click += new System.EventHandler(this.btnMINIMIZAR_Click);
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.AllowUserToAddRows = false;
            this.dgvCursosDocente.AllowUserToDeleteRows = false;
            this.dgvCursosDocente.AllowUserToOrderColumns = true;
            this.dgvCursosDocente.AllowUserToResizeRows = false;
            this.dgvCursosDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEMA,
            this.ASISTENCIA});
            this.dgvCursosDocente.Location = new System.Drawing.Point(316, 85);
            this.dgvCursosDocente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.RowHeadersWidth = 51;
            this.dgvCursosDocente.Size = new System.Drawing.Size(877, 503);
            this.dgvCursosDocente.TabIndex = 15;
            this.dgvCursosDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosDocente_CellContentClick_1);
            // 
            // TEMA
            // 
            this.TEMA.HeaderText = "TEMA";
            this.TEMA.MinimumWidth = 6;
            this.TEMA.Name = "TEMA";
            this.TEMA.Width = 125;
            // 
            // ASISTENCIA
            // 
            this.ASISTENCIA.HeaderText = "ASISTENCIA";
            this.ASISTENCIA.MinimumWidth = 6;
            this.ASISTENCIA.Name = "ASISTENCIA";
            this.ASISTENCIA.Width = 125;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 644);
            this.Controls.Add(this.dgvCursosDocente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnMINIMIZAR);
            this.Controls.Add(this.ContenedorLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDocente";
            this.Load += new System.EventHandler(this.frmDocente_Load);
            this.ContenedorLogin.ResumeLayout(false);
            this.ContenedorLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCERRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMINIMIZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DOCENTE;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button btnVerCursosDocente;
        private System.Windows.Forms.PictureBox btnMINIMIZAR;
        private System.Windows.Forms.PictureBox btnCERRAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.DataGridViewComboBoxColumn TEMA;
        private System.Windows.Forms.DataGridViewImageColumn ASISTENCIA;
    }
}