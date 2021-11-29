
namespace CapaPresentacion
{
    partial class frmAsignarDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelHT = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelAula = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxCreditos = new System.Windows.Forms.TextBox();
            this.textBoxAula = new System.Windows.Forms.TextBox();
            this.textBoxHT = new System.Windows.Forms.TextBox();
            this.textBoxHP = new System.Windows.Forms.TextBox();
            this.textBoxGrupo = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dgvHorarioCurso = new System.Windows.Forms.DataGridView();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelCodigo.Location = new System.Drawing.Point(43, 74);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(100, 22);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "CÓDIGO:";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelCurso.Location = new System.Drawing.Point(243, 74);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(204, 22);
            this.labelCurso.TabIndex = 1;
            this.labelCurso.Text = "NOMBRE DEL CURSO:";
            // 
            // labelCreditos
            // 
            this.labelCreditos.AutoSize = true;
            this.labelCreditos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelCreditos.Location = new System.Drawing.Point(460, 165);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(105, 22);
            this.labelCreditos.TabIndex = 2;
            this.labelCreditos.Text = "CRÉDITOS:";
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelGrupo.Location = new System.Drawing.Point(768, 165);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(84, 22);
            this.labelGrupo.TabIndex = 4;
            this.labelGrupo.Text = "GRUPO:";
            // 
            // labelHT
            // 
            this.labelHT.AutoSize = true;
            this.labelHT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelHT.Location = new System.Drawing.Point(43, 165);
            this.labelHT.Name = "labelHT";
            this.labelHT.Size = new System.Drawing.Size(177, 22);
            this.labelHT.TabIndex = 5;
            this.labelHT.Text = "HORAS TEÓRICAS:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelHP.Location = new System.Drawing.Point(238, 165);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(191, 22);
            this.labelHP.TabIndex = 6;
            this.labelHP.Text = "HORAS PRÁCTICAS:";
            // 
            // labelAula
            // 
            this.labelAula.AutoSize = true;
            this.labelAula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(25)))));
            this.labelAula.Location = new System.Drawing.Point(613, 165);
            this.labelAula.Name = "labelAula";
            this.labelAula.Size = new System.Drawing.Size(66, 22);
            this.labelAula.TabIndex = 10;
            this.labelAula.Text = "AULA:";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelBarraTitulo.Controls.Add(this.pictureBoxLogo);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxMinimizar);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxCerrar);
            this.panelBarraTitulo.Controls.Add(this.labelTitulo);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(932, 44);
            this.panelBarraTitulo.TabIndex = 11;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(29, 32);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 54;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(852, 3);
            this.pictureBoxMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(34, 32);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizar.TabIndex = 52;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(888, 3);
            this.pictureBoxCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(34, 32);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerrar.TabIndex = 53;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTitulo.Location = new System.Drawing.Point(37, 5);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(305, 30);
            this.labelTitulo.TabIndex = 31;
            this.labelTitulo.Text = "Asignación de docentes";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(47, 104);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 27);
            this.textBoxCodigo.TabIndex = 12;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Enabled = false;
            this.textBoxCurso.Location = new System.Drawing.Point(242, 104);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(630, 27);
            this.textBoxCurso.TabIndex = 12;
            // 
            // textBoxCreditos
            // 
            this.textBoxCreditos.Enabled = false;
            this.textBoxCreditos.Location = new System.Drawing.Point(464, 204);
            this.textBoxCreditos.Name = "textBoxCreditos";
            this.textBoxCreditos.Size = new System.Drawing.Size(100, 27);
            this.textBoxCreditos.TabIndex = 12;
            // 
            // textBoxAula
            // 
            this.textBoxAula.Enabled = false;
            this.textBoxAula.Location = new System.Drawing.Point(617, 204);
            this.textBoxAula.Name = "textBoxAula";
            this.textBoxAula.Size = new System.Drawing.Size(100, 27);
            this.textBoxAula.TabIndex = 12;
            // 
            // textBoxHT
            // 
            this.textBoxHT.Enabled = false;
            this.textBoxHT.Location = new System.Drawing.Point(47, 204);
            this.textBoxHT.Name = "textBoxHT";
            this.textBoxHT.Size = new System.Drawing.Size(100, 27);
            this.textBoxHT.TabIndex = 12;
            // 
            // textBoxHP
            // 
            this.textBoxHP.Enabled = false;
            this.textBoxHP.Location = new System.Drawing.Point(242, 204);
            this.textBoxHP.Name = "textBoxHP";
            this.textBoxHP.Size = new System.Drawing.Size(100, 27);
            this.textBoxHP.TabIndex = 12;
            // 
            // textBoxGrupo
            // 
            this.textBoxGrupo.Enabled = false;
            this.textBoxGrupo.Location = new System.Drawing.Point(772, 204);
            this.textBoxGrupo.Name = "textBoxGrupo";
            this.textBoxGrupo.Size = new System.Drawing.Size(100, 27);
            this.textBoxGrupo.TabIndex = 15;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(748, 499);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(152, 33);
            this.buttonGuardar.TabIndex = 58;
            this.buttonGuardar.Text = "Aceptar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonCancelar.Location = new System.Drawing.Point(581, 499);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(136, 33);
            this.buttonCancelar.TabIndex = 58;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dgvHorarioCurso
            // 
            this.dgvHorarioCurso.AllowUserToAddRows = false;
            this.dgvHorarioCurso.AllowUserToDeleteRows = false;
            this.dgvHorarioCurso.AllowUserToResizeColumns = false;
            this.dgvHorarioCurso.AllowUserToResizeRows = false;
            this.dgvHorarioCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarioCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorarioCurso.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHorarioCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHorarioCurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHorarioCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarioCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorarioCurso.ColumnHeadersHeight = 40;
            this.dgvHorarioCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorarioCurso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHorarioCurso.Location = new System.Drawing.Point(31, 260);
            this.dgvHorarioCurso.Name = "dgvHorarioCurso";
            this.dgvHorarioCurso.RowHeadersVisible = false;
            this.dgvHorarioCurso.RowHeadersWidth = 51;
            this.dgvHorarioCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHorarioCurso.Size = new System.Drawing.Size(869, 218);
            this.dgvHorarioCurso.TabIndex = 59;
            // 
            // frmAsignarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 561);
            this.Controls.Add(this.dgvHorarioCurso);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxGrupo);
            this.Controls.Add(this.textBoxAula);
            this.Controls.Add(this.textBoxHT);
            this.Controls.Add(this.textBoxHP);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.textBoxCreditos);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.labelAula);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelHT);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.labelCreditos);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.labelCodigo);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAsignarDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsignarDocente";
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelHT;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelAula;
        public System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.TextBox textBoxCodigo;
        public System.Windows.Forms.TextBox textBoxCurso;
        public System.Windows.Forms.TextBox textBoxCreditos;
        public System.Windows.Forms.TextBox textBoxAula;
        public System.Windows.Forms.TextBox textBoxHT;
        public System.Windows.Forms.TextBox textBoxHP;
        public System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.DataGridView dgvHorarioCurso;
    }
}