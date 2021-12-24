
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlVistaCursosAsig = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnCloseCursosDocente = new System.Windows.Forms.PictureBox();
            this.btnMinCursosDocente = new System.Windows.Forms.PictureBox();
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.PlanSesiones = new System.Windows.Forms.DataGridViewImageColumn();
            this.SubirSilabo = new System.Windows.Forms.DataGridViewImageColumn();
            this.VerSilabo = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonDESCARGAR = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlVistaCursosAsig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVistaCursosAsig
            // 
            this.pnlVistaCursosAsig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.pnlVistaCursosAsig.Controls.Add(this.label11);
            this.pnlVistaCursosAsig.Controls.Add(this.pictureBoxLogo);
            this.pnlVistaCursosAsig.Controls.Add(this.btnCloseCursosDocente);
            this.pnlVistaCursosAsig.Controls.Add(this.btnMinCursosDocente);
            this.pnlVistaCursosAsig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVistaCursosAsig.Location = new System.Drawing.Point(0, 0);
            this.pnlVistaCursosAsig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVistaCursosAsig.Name = "pnlVistaCursosAsig";
            this.pnlVistaCursosAsig.Size = new System.Drawing.Size(1387, 43);
            this.pnlVistaCursosAsig.TabIndex = 9;
            this.pnlVistaCursosAsig.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVistaCursosAsig_Paint);
            this.pnlVistaCursosAsig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlVistaCursosAsig_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(48, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "CURSOS ASIGNADOS";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 55;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnCloseCursosDocente
            // 
            this.btnCloseCursosDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseCursosDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCursosDocente.Image")));
            this.btnCloseCursosDocente.Location = new System.Drawing.Point(1344, 2);
            this.btnCloseCursosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseCursosDocente.Name = "btnCloseCursosDocente";
            this.btnCloseCursosDocente.Size = new System.Drawing.Size(36, 34);
            this.btnCloseCursosDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseCursosDocente.TabIndex = 1;
            this.btnCloseCursosDocente.TabStop = false;
            this.btnCloseCursosDocente.Click += new System.EventHandler(this.btnCloseCursosDocente_Click);
            // 
            // btnMinCursosDocente
            // 
            this.btnMinCursosDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinCursosDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnMinCursosDocente.Image")));
            this.btnMinCursosDocente.Location = new System.Drawing.Point(1302, 2);
            this.btnMinCursosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinCursosDocente.Name = "btnMinCursosDocente";
            this.btnMinCursosDocente.Size = new System.Drawing.Size(36, 34);
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
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCursosDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCursosDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCursosDocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCursosDocente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursosDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursosDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCursosDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCursosDocente.ColumnHeadersHeight = 35;
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCursosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanSesiones,
            this.SubirSilabo,
            this.VerSilabo});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursosDocente.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCursosDocente.Location = new System.Drawing.Point(24, 140);
            this.dgvCursosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCursosDocente.RowHeadersVisible = false;
            this.dgvCursosDocente.RowHeadersWidth = 51;
            this.dgvCursosDocente.RowTemplate.Height = 24;
            this.dgvCursosDocente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCursosDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCursosDocente.Size = new System.Drawing.Size(1340, 332);
            this.dgvCursosDocente.TabIndex = 10;
            this.dgvCursosDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosDocente_CellContentClick);
            // 
            // PlanSesiones
            // 
            this.PlanSesiones.HeaderText = "Plan de Sesiones";
            this.PlanSesiones.Image = global::CapaPresentacion.Properties.Resources.book_solid;
            this.PlanSesiones.MinimumWidth = 6;
            this.PlanSesiones.Name = "PlanSesiones";
            this.PlanSesiones.Width = 136;
            // 
            // SubirSilabo
            // 
            this.SubirSilabo.HeaderText = "Subir Silabo";
            this.SubirSilabo.Image = global::CapaPresentacion.Properties.Resources.pdf2_24px;
            this.SubirSilabo.MinimumWidth = 6;
            this.SubirSilabo.Name = "SubirSilabo";
            // 
            // VerSilabo
            // 
            this.VerSilabo.HeaderText = "Ver Silabo";
            this.VerSilabo.Image = global::CapaPresentacion.Properties.Resources.ver_24px;
            this.VerSilabo.MinimumWidth = 6;
            this.VerSilabo.Name = "VerSilabo";
            this.VerSilabo.Width = 90;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(27)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(587, 73);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "TUS CURSOS SON :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // buttonDESCARGAR
            // 
            this.buttonDESCARGAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDESCARGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonDESCARGAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.buttonDESCARGAR.FlatAppearance.BorderSize = 0;
            this.buttonDESCARGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.buttonDESCARGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDESCARGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDESCARGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDESCARGAR.ForeColor = System.Drawing.Color.White;
            this.buttonDESCARGAR.Image = global::CapaPresentacion.Properties.Resources.download_regular_241;
            this.buttonDESCARGAR.Location = new System.Drawing.Point(1118, 507);
            this.buttonDESCARGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDESCARGAR.Name = "buttonDESCARGAR";
            this.buttonDESCARGAR.Size = new System.Drawing.Size(203, 41);
            this.buttonDESCARGAR.TabIndex = 13;
            this.buttonDESCARGAR.Text = "DESCARGAR";
            this.buttonDESCARGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDESCARGAR.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(215)))), ((int)(((byte)(114)))));
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(340, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(690, 1);
            this.panel7.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(812, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 10);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(141)))));
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 10);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1092, 492);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(141)))));
            this.panel3.Location = new System.Drawing.Point(24, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1340, 2);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(141)))));
            this.panel4.Location = new System.Drawing.Point(24, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1340, 2);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(141)))));
            this.panel5.Location = new System.Drawing.Point(24, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 326);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(141)))));
            this.panel6.Location = new System.Drawing.Point(1361, 143);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 326);
            this.panel6.TabIndex = 31;
            // 
            // frmVistaCursosDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1387, 571);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.buttonDESCARGAR);
            this.Controls.Add(this.dgvCursosDocente);
            this.Controls.Add(this.pnlVistaCursosAsig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVistaCursosDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaCursosDocente";
            this.Load += new System.EventHandler(this.frmVistaCursosDocente_Load);
            this.pnlVistaCursosAsig.ResumeLayout(false);
            this.pnlVistaCursosAsig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVistaCursosAsig;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox btnCloseCursosDocente;
        private System.Windows.Forms.PictureBox btnMinCursosDocente;
        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDESCARGAR;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn PlanSesiones;
        private System.Windows.Forms.DataGridViewImageColumn SubirSilabo;
        private System.Windows.Forms.DataGridViewImageColumn VerSilabo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}