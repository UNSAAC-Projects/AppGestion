
namespace CapaPresentacion
{
    partial class frmAlumnosMatriculadosPorCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnosMatriculadosPorCurso));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.dgvMatriculados = new System.Windows.Forms.DataGridView();
            this.pictureCANCEL1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCANCEL1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alumnos Matriculados";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE ASIGNATURA: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "GRUPO: ";
            // 
            // labelGrupo
            // 
            this.labelGrupo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.Location = new System.Drawing.Point(114, 116);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(17, 20);
            this.labelGrupo.TabIndex = 12;
            this.labelGrupo.Text = "_";
            this.labelGrupo.Click += new System.EventHandler(this.labelGrupo_Click);
            // 
            // dgvMatriculados
            // 
            this.dgvMatriculados.AllowUserToAddRows = false;
            this.dgvMatriculados.AllowUserToDeleteRows = false;
            this.dgvMatriculados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvMatriculados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriculados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMatriculados.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriculados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatriculados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMatriculados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriculados.ColumnHeadersHeight = 32;
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriculados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriculados.EnableHeadersVisualStyles = false;
            this.dgvMatriculados.Location = new System.Drawing.Point(30, 153);
            this.dgvMatriculados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatriculados.RowHeadersVisible = false;
            this.dgvMatriculados.RowHeadersWidth = 51;
            this.dgvMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatriculados.Size = new System.Drawing.Size(890, 410);
            this.dgvMatriculados.TabIndex = 49;
            // 
            // pictureCANCEL1
            // 
            this.pictureCANCEL1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureCANCEL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCANCEL1.Image = ((System.Drawing.Image)(resources.GetObject("pictureCANCEL1.Image")));
            this.pictureCANCEL1.Location = new System.Drawing.Point(883, 15);
            this.pictureCANCEL1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureCANCEL1.Name = "pictureCANCEL1";
            this.pictureCANCEL1.Size = new System.Drawing.Size(37, 34);
            this.pictureCANCEL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCANCEL1.TabIndex = 50;
            this.pictureCANCEL1.TabStop = false;
            this.pictureCANCEL1.Click += new System.EventHandler(this.pictureCANCEL1_Click);
            // 
            // frmAlumnosMatriculadosPorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 582);
            this.Controls.Add(this.pictureCANCEL1);
            this.Controls.Add(this.dgvMatriculados);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAlumnosMatriculadosPorCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlumnosMatriculadosPorCurso";
            this.Load += new System.EventHandler(this.frmAlumnosMatriculadosPorCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCANCEL1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.DataGridView dgvMatriculados;
        private System.Windows.Forms.PictureBox pictureCANCEL1;
    }
}