
namespace CapaPresentacion
{
    partial class frmAlumnosMatriculados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMatriculados = new System.Windows.Forms.DataGridView();
            this.cboAsistenciaCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriculados
            // 
            this.dgvMatriculados.AllowUserToAddRows = false;
            this.dgvMatriculados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvMatriculados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriculados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriculados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatriculados.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriculados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatriculados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMatriculados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriculados.ColumnHeadersHeight = 38;
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriculados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriculados.EnableHeadersVisualStyles = false;
            this.dgvMatriculados.Location = new System.Drawing.Point(35, 158);
            this.dgvMatriculados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriculados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatriculados.RowHeadersWidth = 51;
            this.dgvMatriculados.RowTemplate.Height = 24;
            this.dgvMatriculados.Size = new System.Drawing.Size(829, 438);
            this.dgvMatriculados.TabIndex = 3;
            this.dgvMatriculados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculados_CellContentClick);
            // 
            // cboAsistenciaCurso
            // 
            this.cboAsistenciaCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboAsistenciaCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboAsistenciaCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAsistenciaCurso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAsistenciaCurso.ForeColor = System.Drawing.Color.Black;
            this.cboAsistenciaCurso.FormattingEnabled = true;
            this.cboAsistenciaCurso.Location = new System.Drawing.Point(260, 87);
            this.cboAsistenciaCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAsistenciaCurso.Name = "cboAsistenciaCurso";
            this.cboAsistenciaCurso.Size = new System.Drawing.Size(436, 29);
            this.cboAsistenciaCurso.TabIndex = 4;
            this.cboAsistenciaCurso.SelectedIndexChanged += new System.EventHandler(this.cboAsistenciaCurso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar por :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alumnos Matriculados";
            // 
            // frmAlumnosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAsistenciaCurso);
            this.Controls.Add(this.dgvMatriculados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlumnosMatriculados";
            this.Text = "frmAlumnosMatriculados";
            this.Load += new System.EventHandler(this.frmAlumnosMatriculados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriculados;
        private System.Windows.Forms.ComboBox cboAsistenciaCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}