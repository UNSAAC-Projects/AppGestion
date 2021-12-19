
namespace CapaPresentacion
{
    partial class frmVistaCursosDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaCursosDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelVistaHorario = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnCloseCursosDocente = new System.Windows.Forms.PictureBox();
            this.btnMinCursosDocente = new System.Windows.Forms.PictureBox();
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.PlanSesiones = new System.Windows.Forms.DataGridViewImageColumn();
            this.SubirSilabo = new System.Windows.Forms.DataGridViewImageColumn();
            this.VerSilabo = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDESCARGAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelVistaHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVistaHorario
            // 
            this.panelVistaHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelVistaHorario.Controls.Add(this.label11);
            this.panelVistaHorario.Controls.Add(this.pictureBoxLogo);
            this.panelVistaHorario.Controls.Add(this.btnCloseCursosDocente);
            this.panelVistaHorario.Controls.Add(this.btnMinCursosDocente);
            this.panelVistaHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVistaHorario.Location = new System.Drawing.Point(0, 0);
            this.panelVistaHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelVistaHorario.Name = "panelVistaHorario";
            this.panelVistaHorario.Size = new System.Drawing.Size(1040, 35);
            this.panelVistaHorario.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(36, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "CURSOS ASIGNADOS";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 55;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnCloseCursosDocente
            // 
            this.btnCloseCursosDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseCursosDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCursosDocente.Image")));
            this.btnCloseCursosDocente.Location = new System.Drawing.Point(1022, 3);
            this.btnCloseCursosDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseCursosDocente.Name = "btnCloseCursosDocente";
            this.btnCloseCursosDocente.Size = new System.Drawing.Size(27, 28);
            this.btnCloseCursosDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseCursosDocente.TabIndex = 1;
            this.btnCloseCursosDocente.TabStop = false;
            this.btnCloseCursosDocente.Click += new System.EventHandler(this.btnCloseCursosDocente_Click);
            // 
            // btnMinCursosDocente
            // 
            this.btnMinCursosDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinCursosDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnMinCursosDocente.Image")));
            this.btnMinCursosDocente.Location = new System.Drawing.Point(991, 3);
            this.btnMinCursosDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinCursosDocente.Name = "btnMinCursosDocente";
            this.btnMinCursosDocente.Size = new System.Drawing.Size(27, 28);
            this.btnMinCursosDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinCursosDocente.TabIndex = 0;
            this.btnMinCursosDocente.TabStop = false;
            this.btnMinCursosDocente.Click += new System.EventHandler(this.btnMinCursosDocente_Click);
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.AllowUserToAddRows = false;
            this.dgvCursosDocente.AllowUserToDeleteRows = false;
            this.dgvCursosDocente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCursosDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursosDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCursosDocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCursosDocente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursosDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCursosDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursosDocente.ColumnHeadersHeight = 35;
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCursosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanSesiones,
            this.SubirSilabo,
            this.VerSilabo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursosDocente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursosDocente.Location = new System.Drawing.Point(16, 111);
            this.dgvCursosDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCursosDocente.RowHeadersVisible = false;
            this.dgvCursosDocente.RowHeadersWidth = 51;
            this.dgvCursosDocente.RowTemplate.Height = 24;
            this.dgvCursosDocente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCursosDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCursosDocente.Size = new System.Drawing.Size(1021, 270);
            this.dgvCursosDocente.TabIndex = 10;
            this.dgvCursosDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosDocente_CellContentClick);
            // 
            // PlanSesiones
            // 
            this.PlanSesiones.HeaderText = "Plan de Sesiones";
            this.PlanSesiones.Image = global::CapaPresentacion.Properties.Resources.book_solid;
            this.PlanSesiones.MinimumWidth = 6;
            this.PlanSesiones.Name = "PlanSesiones";
            this.PlanSesiones.Width = 99;
            // 
            // SubirSilabo
            // 
            this.SubirSilabo.HeaderText = "Subir Silabo";
            this.SubirSilabo.Image = global::CapaPresentacion.Properties.Resources.pdf2_24px;
            this.SubirSilabo.MinimumWidth = 6;
            this.SubirSilabo.Name = "SubirSilabo";
            this.SubirSilabo.Width = 72;
            // 
            // VerSilabo
            // 
            this.VerSilabo.HeaderText = "Ver Silabo";
            this.VerSilabo.Image = global::CapaPresentacion.Properties.Resources.ver_24px;
            this.VerSilabo.MinimumWidth = 6;
            this.VerSilabo.Name = "VerSilabo";
            this.VerSilabo.Width = 65;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(399, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "TUS CURSOS SON:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel2.Location = new System.Drawing.Point(6, 468);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 3);
            this.panel2.TabIndex = 18;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Plan de Sesiones";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.book_solid;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 136;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Silabo";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.pdf_24px;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDESCARGAR
            // 
            this.buttonDESCARGAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDESCARGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonDESCARGAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.buttonDESCARGAR.FlatAppearance.BorderSize = 0;
            this.buttonDESCARGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.buttonDESCARGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.buttonDESCARGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDESCARGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDESCARGAR.ForeColor = System.Drawing.Color.White;
            this.buttonDESCARGAR.Image = global::CapaPresentacion.Properties.Resources.download_regular_241;
            this.buttonDESCARGAR.Location = new System.Drawing.Point(844, 409);
            this.buttonDESCARGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDESCARGAR.Name = "buttonDESCARGAR";
            this.buttonDESCARGAR.Size = new System.Drawing.Size(152, 37);
            this.buttonDESCARGAR.TabIndex = 13;
            this.buttonDESCARGAR.Text = "DESCARGAR";
            this.buttonDESCARGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDESCARGAR.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVistaCursosDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonDESCARGAR);
            this.Controls.Add(this.dgvCursosDocente);
            this.Controls.Add(this.panelVistaHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVistaCursosDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaCursosDocente";
            this.panelVistaHorario.ResumeLayout(false);
            this.panelVistaHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVistaHorario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox btnCloseCursosDocente;
        private System.Windows.Forms.PictureBox btnMinCursosDocente;
        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDESCARGAR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn PlanSesiones;
        private System.Windows.Forms.DataGridViewImageColumn SubirSilabo;
        private System.Windows.Forms.DataGridViewImageColumn VerSilabo;
        private System.Windows.Forms.Button button1;
    }
}