
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCERRAR = new System.Windows.Forms.PictureBox();
            this.btnMINIMIZAR = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelLISTADOCENTE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTEMA = new System.Windows.Forms.TextBox();
            this.textBoxOBSERVACIONES = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonGUARDAR = new System.Windows.Forms.Button();
            this.buttonDESMARCAR = new System.Windows.Forms.Button();
            this.buttonMARCAR = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMINIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnCERRAR);
            this.panel1.Controls.Add(this.btnMINIMIZAR);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.DimGray;
            this.btnCERRAR.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2021_11_21_at_12_53_18_PM__1_;
            this.btnCERRAR.Location = new System.Drawing.Point(825, 2);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(35, 34);
            this.btnCERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCERRAR.TabIndex = 36;
            this.btnCERRAR.TabStop = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnMINIMIZAR
            // 
            this.btnMINIMIZAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMINIMIZAR.BackColor = System.Drawing.Color.DimGray;
            this.btnMINIMIZAR.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2021_11_21_at_12_53_18_PM;
            this.btnMINIMIZAR.Location = new System.Drawing.Point(786, 2);
            this.btnMINIMIZAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMINIMIZAR.Name = "btnMINIMIZAR";
            this.btnMINIMIZAR.Size = new System.Drawing.Size(32, 34);
            this.btnMINIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMINIMIZAR.TabIndex = 35;
            this.btnMINIMIZAR.TabStop = false;
            this.btnMINIMIZAR.Click += new System.EventHandler(this.btnMINIMIZAR_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.menu_regular_242;
            this.pictureBox3.Location = new System.Drawing.Point(12, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(53, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 22);
            this.label11.TabIndex = 33;
            this.label11.Text = "ASISTENCIA DE ALUMNOS";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelLISTADOCENTE
            // 
            this.labelLISTADOCENTE.AutoSize = true;
            this.labelLISTADOCENTE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLISTADOCENTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.labelLISTADOCENTE.Location = new System.Drawing.Point(214, 52);
            this.labelLISTADOCENTE.Name = "labelLISTADOCENTE";
            this.labelLISTADOCENTE.Size = new System.Drawing.Size(410, 69);
            this.labelLISTADOCENTE.TabIndex = 7;
            this.labelLISTADOCENTE.Text = "         LISTA DE ALUMNOS DE LA ASIGNATURA:\r\n              Ingeneria Informatica " +
    "y de Sistemas\r\n                     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(282, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Docente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(69, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "TEMA A DICTAR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(470, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "OBSERVACIONES:";
            // 
            // textBoxTEMA
            // 
            this.textBoxTEMA.Location = new System.Drawing.Point(198, 176);
            this.textBoxTEMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTEMA.Name = "textBoxTEMA";
            this.textBoxTEMA.Size = new System.Drawing.Size(224, 22);
            this.textBoxTEMA.TabIndex = 13;
            // 
            // textBoxOBSERVACIONES
            // 
            this.textBoxOBSERVACIONES.Location = new System.Drawing.Point(612, 175);
            this.textBoxOBSERVACIONES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOBSERVACIONES.Name = "textBoxOBSERVACIONES";
            this.textBoxOBSERVACIONES.Size = new System.Drawing.Size(179, 22);
            this.textBoxOBSERVACIONES.TabIndex = 14;
            // 
            // buttonGUARDAR
            // 
            this.buttonGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonGUARDAR.FlatAppearance.BorderSize = 0;
            this.buttonGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGUARDAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGUARDAR.Image = global::CapaPresentacion.Properties.Resources.save_solid_24;
            this.buttonGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGUARDAR.Location = new System.Drawing.Point(346, 831);
            this.buttonGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGUARDAR.Name = "buttonGUARDAR";
            this.buttonGUARDAR.Size = new System.Drawing.Size(167, 46);
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
            this.buttonDESMARCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDESMARCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDESMARCAR.ForeColor = System.Drawing.Color.White;
            this.buttonDESMARCAR.Image = global::CapaPresentacion.Properties.Resources.checkbox_regular_24;
            this.buttonDESMARCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDESMARCAR.Location = new System.Drawing.Point(612, 225);
            this.buttonDESMARCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDESMARCAR.Name = "buttonDESMARCAR";
            this.buttonDESMARCAR.Size = new System.Drawing.Size(191, 37);
            this.buttonDESMARCAR.TabIndex = 9;
            this.buttonDESMARCAR.Text = "Desmarcar todos";
            this.buttonDESMARCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDESMARCAR.UseVisualStyleBackColor = false;
            // 
            // buttonMARCAR
            // 
            this.buttonMARCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonMARCAR.FlatAppearance.BorderSize = 0;
            this.buttonMARCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMARCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMARCAR.ForeColor = System.Drawing.Color.White;
            this.buttonMARCAR.Image = global::CapaPresentacion.Properties.Resources.check_square_regular_24;
            this.buttonMARCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMARCAR.Location = new System.Drawing.Point(57, 225);
            this.buttonMARCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMARCAR.Name = "buttonMARCAR";
            this.buttonMARCAR.Size = new System.Drawing.Size(183, 37);
            this.buttonMARCAR.TabIndex = 8;
            this.buttonMARCAR.Text = "Marcar todos";
            this.buttonMARCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMARCAR.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Logo_unsaac11;
            this.pictureBox2.Location = new System.Drawing.Point(776, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AllowUserToOrderColumns = true;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.Observacion});
            this.dgvAsistencia.Location = new System.Drawing.Point(57, 282);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.RowTemplate.Height = 24;
            this.dgvAsistencia.Size = new System.Drawing.Size(761, 531);
            this.dgvAsistencia.TabIndex = 16;
            this.dgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha y Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(428, 140);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(13, 17);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "-";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(428, 115);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(13, 17);
            this.lblDocente.TabIndex = 19;
            this.lblDocente.Text = "-";
            // 
            // A
            // 
            this.A.FalseValue = "F";
            this.A.HeaderText = "Asistencia";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            this.A.TrueValue = "P";
            this.A.Width = 80;
            // 
            // Observacion
            // 
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 885);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.buttonGUARDAR);
            this.Controls.Add(this.textBoxOBSERVACIONES);
            this.Controls.Add(this.textBoxTEMA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDESMARCAR);
            this.Controls.Add(this.buttonMARCAR);
            this.Controls.Add(this.labelLISTADOCENTE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelLISTADOCENTE;
        private System.Windows.Forms.Button buttonMARCAR;
        private System.Windows.Forms.Button buttonDESMARCAR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTEMA;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}