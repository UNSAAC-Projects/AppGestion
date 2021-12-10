
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMINIMIZAR = new System.Windows.Forms.PictureBox();
            this.btnCERRAR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMINIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCERRAR)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(785, 48);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(54, 9);
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
            this.labelLISTADOCENTE.Location = new System.Drawing.Point(107, 52);
            this.labelLISTADOCENTE.Name = "labelLISTADOCENTE";
            this.labelLISTADOCENTE.Size = new System.Drawing.Size(562, 69);
            this.labelLISTADOCENTE.TabIndex = 7;
            this.labelLISTADOCENTE.Text = "LISTA DE ALUMNOS DE LA ASIGNATURA:\r\n              Ingeneria Informatica y de Sist" +
    "emas\r\n                     Fecha y Hora:                                        " +
    "                        ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(212, 121);
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
            this.label2.Location = new System.Drawing.Point(12, 175);
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
            this.label3.Location = new System.Drawing.Point(399, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "OBSERVACIONES:";
            // 
            // textBoxTEMA
            // 
            this.textBoxTEMA.Location = new System.Drawing.Point(133, 174);
            this.textBoxTEMA.Name = "textBoxTEMA";
            this.textBoxTEMA.Size = new System.Drawing.Size(192, 22);
            this.textBoxTEMA.TabIndex = 13;
            // 
            // textBoxOBSERVACIONES
            // 
            this.textBoxOBSERVACIONES.Location = new System.Drawing.Point(542, 171);
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
            this.buttonGUARDAR.Location = new System.Drawing.Point(274, 697);
            this.buttonGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGUARDAR.Name = "buttonGUARDAR";
            this.buttonGUARDAR.Size = new System.Drawing.Size(129, 45);
            this.buttonGUARDAR.TabIndex = 15;
            this.buttonGUARDAR.Text = "GUARDAR";
            this.buttonGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGUARDAR.UseVisualStyleBackColor = false;
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
            this.buttonDESMARCAR.Location = new System.Drawing.Point(369, 225);
            this.buttonDESMARCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDESMARCAR.Name = "buttonDESMARCAR";
            this.buttonDESMARCAR.Size = new System.Drawing.Size(167, 30);
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
            this.buttonMARCAR.Location = new System.Drawing.Point(164, 225);
            this.buttonMARCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMARCAR.Name = "buttonMARCAR";
            this.buttonMARCAR.Size = new System.Drawing.Size(161, 30);
            this.buttonMARCAR.TabIndex = 8;
            this.buttonMARCAR.Text = "Marcar todos";
            this.buttonMARCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMARCAR.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Logo_unsaac11;
            this.pictureBox2.Location = new System.Drawing.Point(700, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 69);
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
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.menu_regular_242;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // btnMINIMIZAR
            // 
            this.btnMINIMIZAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMINIMIZAR.BackColor = System.Drawing.Color.DimGray;
            this.btnMINIMIZAR.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2021_11_21_at_12_53_18_PM;
            this.btnMINIMIZAR.Location = new System.Drawing.Point(700, 3);
            this.btnMINIMIZAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMINIMIZAR.Name = "btnMINIMIZAR";
            this.btnMINIMIZAR.Size = new System.Drawing.Size(32, 34);
            this.btnMINIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMINIMIZAR.TabIndex = 35;
            this.btnMINIMIZAR.TabStop = false;
            this.btnMINIMIZAR.Click += new System.EventHandler(this.btnMINIMIZAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.DimGray;
            this.btnCERRAR.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2021_11_21_at_12_53_18_PM__1_;
            this.btnCERRAR.Location = new System.Drawing.Point(739, 3);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(34, 35);
            this.btnCERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCERRAR.TabIndex = 36;
            this.btnCERRAR.TabStop = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 753);
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
            this.Name = "frmAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsistencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMINIMIZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCERRAR)).EndInit();
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
    }
}