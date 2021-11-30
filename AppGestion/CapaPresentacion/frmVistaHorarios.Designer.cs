
namespace CapaPresentacion
{
    partial class frmVistaHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaHorarios));
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.panelVistaHorario = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnMaxVistaHorario = new System.Windows.Forms.PictureBox();
            this.btnMinVistaHorario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.panelVistaHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxVistaHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinVistaHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHorarios.Location = new System.Drawing.Point(21, 64);
            this.dgvHorarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHorarios.RowHeadersVisible = false;
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.RowTemplate.Height = 24;
            this.dgvHorarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(1109, 464);
            this.dgvHorarios.TabIndex = 6;
            this.dgvHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellContentClick);
            // 
            // panelVistaHorario
            // 
            this.panelVistaHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelVistaHorario.Controls.Add(this.label11);
            this.panelVistaHorario.Controls.Add(this.pictureBoxLogo);
            this.panelVistaHorario.Controls.Add(this.btnMaxVistaHorario);
            this.panelVistaHorario.Controls.Add(this.btnMinVistaHorario);
            this.panelVistaHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVistaHorario.Location = new System.Drawing.Point(0, 0);
            this.panelVistaHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVistaHorario.Name = "panelVistaHorario";
            this.panelVistaHorario.Size = new System.Drawing.Size(1152, 43);
            this.panelVistaHorario.TabIndex = 8;
            this.panelVistaHorario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVistaHorario_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(49, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "HORARIOS";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_Sistemas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 55;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnMaxVistaHorario
            // 
            this.btnMaxVistaHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxVistaHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxVistaHorario.Image")));
            this.btnMaxVistaHorario.Location = new System.Drawing.Point(1111, 2);
            this.btnMaxVistaHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaxVistaHorario.Name = "btnMaxVistaHorario";
            this.btnMaxVistaHorario.Size = new System.Drawing.Size(36, 34);
            this.btnMaxVistaHorario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaxVistaHorario.TabIndex = 1;
            this.btnMaxVistaHorario.TabStop = false;
            this.btnMaxVistaHorario.Click += new System.EventHandler(this.btnMaxVistaHorario_Click);
            // 
            // btnMinVistaHorario
            // 
            this.btnMinVistaHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinVistaHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnMinVistaHorario.Image")));
            this.btnMinVistaHorario.Location = new System.Drawing.Point(1069, 2);
            this.btnMinVistaHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinVistaHorario.Name = "btnMinVistaHorario";
            this.btnMinVistaHorario.Size = new System.Drawing.Size(36, 34);
            this.btnMinVistaHorario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinVistaHorario.TabIndex = 0;
            this.btnMinVistaHorario.TabStop = false;
            this.btnMinVistaHorario.Click += new System.EventHandler(this.btnMinVistaHorario_Click);
            // 
            // frmVistaHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 554);
            this.Controls.Add(this.panelVistaHorario);
            this.Controls.Add(this.dgvHorarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVistaHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaHorarios";
            this.Load += new System.EventHandler(this.frmVistaHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.panelVistaHorario.ResumeLayout(false);
            this.panelVistaHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxVistaHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinVistaHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Panel panelVistaHorario;
        private System.Windows.Forms.PictureBox btnMaxVistaHorario;
        private System.Windows.Forms.PictureBox btnMinVistaHorario;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label11;
    }
}