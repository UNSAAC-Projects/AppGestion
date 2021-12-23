
namespace CapaPresentacion
{
    partial class FrmLogin
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
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.panelLinea = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.labelTipo = new System.Windows.Forms.Label();
            this.buttonDirEscuela = new System.Windows.Forms.Button();
            this.buttonDirDep = new System.Windows.Forms.Button();
            this.buttonDocente = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLinea2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLinea5 = new System.Windows.Forms.Panel();
            this.panelLinea3 = new System.Windows.Forms.Panel();
            this.pnlLateral.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.pnlLateral.Controls.Add(this.panelLinea);
            this.pnlLateral.Controls.Add(this.panelOpciones);
            this.pnlLateral.Controls.Add(this.pictureBoxLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(206, 361);
            this.pnlLateral.TabIndex = 0;
            this.pnlLateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLateral_MouseDown);
            // 
            // panelLinea
            // 
            this.panelLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.panelLinea.Location = new System.Drawing.Point(11, 152);
            this.panelLinea.Margin = new System.Windows.Forms.Padding(2);
            this.panelLinea.Name = "panelLinea";
            this.panelLinea.Size = new System.Drawing.Size(188, 4);
            this.panelLinea.TabIndex = 4;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.labelTipo);
            this.panelOpciones.Controls.Add(this.buttonDirEscuela);
            this.panelOpciones.Controls.Add(this.buttonDirDep);
            this.panelOpciones.Controls.Add(this.buttonDocente);
            this.panelOpciones.Location = new System.Drawing.Point(0, 161);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(206, 184);
            this.panelOpciones.TabIndex = 9;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.Color.White;
            this.labelTipo.Location = new System.Drawing.Point(12, 8);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(140, 25);
            this.labelTipo.TabIndex = 8;
            this.labelTipo.Text = "Ingresar como:";
            // 
            // buttonDirEscuela
            // 
            this.buttonDirEscuela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonDirEscuela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDirEscuela.FlatAppearance.BorderSize = 0;
            this.buttonDirEscuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDirEscuela.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirEscuela.ForeColor = System.Drawing.Color.White;
            this.buttonDirEscuela.Location = new System.Drawing.Point(0, 78);
            this.buttonDirEscuela.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDirEscuela.Name = "buttonDirEscuela";
            this.buttonDirEscuela.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDirEscuela.Size = new System.Drawing.Size(206, 49);
            this.buttonDirEscuela.TabIndex = 8;
            this.buttonDirEscuela.Text = "Director de Escuela Profesional";
            this.buttonDirEscuela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDirEscuela.UseVisualStyleBackColor = false;
            this.buttonDirEscuela.Click += new System.EventHandler(this.buttonDirEscuela_Click);
            // 
            // buttonDirDep
            // 
            this.buttonDirDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonDirDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDirDep.FlatAppearance.BorderSize = 0;
            this.buttonDirDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDirDep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirDep.ForeColor = System.Drawing.Color.White;
            this.buttonDirDep.Location = new System.Drawing.Point(0, 129);
            this.buttonDirDep.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDirDep.Name = "buttonDirDep";
            this.buttonDirDep.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDirDep.Size = new System.Drawing.Size(206, 47);
            this.buttonDirDep.TabIndex = 9;
            this.buttonDirDep.Text = "Director de Departamento Académico\r\n";
            this.buttonDirDep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDirDep.UseVisualStyleBackColor = false;
            this.buttonDirDep.Click += new System.EventHandler(this.buttonDirDep_Click);
            // 
            // buttonDocente
            // 
            this.buttonDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDocente.FlatAppearance.BorderSize = 0;
            this.buttonDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDocente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDocente.ForeColor = System.Drawing.Color.White;
            this.buttonDocente.Location = new System.Drawing.Point(0, 36);
            this.buttonDocente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDocente.Name = "buttonDocente";
            this.buttonDocente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDocente.Size = new System.Drawing.Size(206, 40);
            this.buttonDocente.TabIndex = 7;
            this.buttonDocente.Text = "Docente";
            this.buttonDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDocente.UseVisualStyleBackColor = false;
            this.buttonDocente.Click += new System.EventHandler(this.buttonDocente_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(37, 8);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(124, 135);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLogo_MouseDown);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.labelBienvenido.Location = new System.Drawing.Point(241, 24);
            this.labelBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(176, 41);
            this.labelBienvenido.TabIndex = 1;
            this.labelBienvenido.Text = "Bienvenido";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(278, 116);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(222, 25);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(278, 198);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(221, 25);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            this.textBoxContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContraseña_KeyDown);
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciarSesion.Enabled = false;
            this.buttonIniciarSesion.FlatAppearance.BorderSize = 0;
            this.buttonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSesion.Location = new System.Drawing.Point(274, 257);
            this.buttonIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(208, 34);
            this.buttonIniciarSesion.TabIndex = 3;
            this.buttonIniciarSesion.Text = "Iniciar Sesion";
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.EnabledChanged += new System.EventHandler(this.buttonIniciarSesion_EnabledChanged);
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.White;
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCerrar.Location = new System.Drawing.Point(274, 311);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(208, 34);
            this.buttonCerrar.TabIndex = 10;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // panelLinea2
            // 
            this.panelLinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panelLinea2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panelLinea2.Location = new System.Drawing.Point(230, 63);
            this.panelLinea2.Margin = new System.Windows.Forms.Padding(2);
            this.panelLinea2.Name = "panelLinea2";
            this.panelLinea2.Size = new System.Drawing.Size(289, 4);
            this.panelLinea2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.user_regular_24;
            this.pictureBox1.Location = new System.Drawing.Point(247, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.lock_alt_regular_24;
            this.pictureBox2.Location = new System.Drawing.Point(247, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panelLinea5
            // 
            this.panelLinea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.panelLinea5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panelLinea5.Location = new System.Drawing.Point(243, 144);
            this.panelLinea5.Margin = new System.Windows.Forms.Padding(2);
            this.panelLinea5.Name = "panelLinea5";
            this.panelLinea5.Size = new System.Drawing.Size(250, 2);
            this.panelLinea5.TabIndex = 6;
            // 
            // panelLinea3
            // 
            this.panelLinea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.panelLinea3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panelLinea3.Location = new System.Drawing.Point(241, 224);
            this.panelLinea3.Margin = new System.Windows.Forms.Padding(2);
            this.panelLinea3.Name = "panelLinea3";
            this.panelLinea3.Size = new System.Drawing.Size(250, 2);
            this.panelLinea3.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 361);
            this.Controls.Add(this.panelLinea3);
            this.Controls.Add(this.panelLinea5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLinea2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.pnlLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlLateral.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Button buttonDirEscuela;
        private System.Windows.Forms.Button buttonDirDep;
        private System.Windows.Forms.Button buttonDocente;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLinea2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelLinea5;
        private System.Windows.Forms.Panel panelLinea3;
        public System.Windows.Forms.TextBox textBoxUsuario;
    }
}