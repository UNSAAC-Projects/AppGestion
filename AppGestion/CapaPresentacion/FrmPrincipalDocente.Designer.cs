
namespace CapaPresentacion
{
    partial class FrmPrincipalDocente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalDocente));
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.TEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASISTENCIA = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.pictureBoxLibros = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxComputadora = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputadora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.AllowUserToAddRows = false;
            this.dgvCursosDocente.AllowUserToDeleteRows = false;
            this.dgvCursosDocente.AllowUserToOrderColumns = true;
            this.dgvCursosDocente.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCursosDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCursosDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursosDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosDocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCursosDocente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursosDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursosDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCursosDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCursosDocente.ColumnHeadersHeight = 32;
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCursosDocente.ColumnHeadersVisible = false;
            this.dgvCursosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEMA,
            this.ASISTENCIA});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursosDocente.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCursosDocente.EnableHeadersVisualStyles = false;
            this.dgvCursosDocente.Location = new System.Drawing.Point(14, 142);
            this.dgvCursosDocente.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.ReadOnly = true;
            this.dgvCursosDocente.RowHeadersVisible = false;
            this.dgvCursosDocente.RowHeadersWidth = 51;
            this.dgvCursosDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCursosDocente.Size = new System.Drawing.Size(974, 504);
            this.dgvCursosDocente.TabIndex = 16;
            this.dgvCursosDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosDocente_CellContentClick);
            // 
            // TEMA
            // 
            this.TEMA.FillWeight = 100.1522F;
            this.TEMA.HeaderText = "TEMA";
            this.TEMA.MinimumWidth = 6;
            this.TEMA.Name = "TEMA";
            this.TEMA.ReadOnly = true;
            this.TEMA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TEMA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ASISTENCIA
            // 
            this.ASISTENCIA.FillWeight = 99.84779F;
            this.ASISTENCIA.HeaderText = "ASISTENCIA";
            this.ASISTENCIA.Image = global::CapaPresentacion.Properties.Resources.graduado_24px;
            this.ASISTENCIA.MinimumWidth = 6;
            this.ASISTENCIA.Name = "ASISTENCIA";
            this.ASISTENCIA.ReadOnly = true;
            // 
            // labelMensaje
            // 
            this.labelMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.BackColor = System.Drawing.Color.Transparent;
            this.labelMensaje.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.labelMensaje.Location = new System.Drawing.Point(235, 198);
            this.labelMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(518, 37);
            this.labelMensaje.TabIndex = 17;
            this.labelMensaje.Text = "No tiene ningún curso a dictar hoy";
            this.labelMensaje.Visible = false;
            // 
            // pictureBoxLibros
            // 
            this.pictureBoxLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLibros.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLibros.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLibros.Image")));
            this.pictureBoxLibros.Location = new System.Drawing.Point(175, 269);
            this.pictureBoxLibros.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLibros.Name = "pictureBoxLibros";
            this.pictureBoxLibros.Size = new System.Drawing.Size(648, 283);
            this.pictureBoxLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLibros.TabIndex = 18;
            this.pictureBoxLibros.TabStop = false;
            this.pictureBoxLibros.Visible = false;
            this.pictureBoxLibros.Click += new System.EventHandler(this.pictureBoxLibros_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(-10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "CURSOS  DICTADOS EN SEMESTRE LECTIVO";
            this.label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(866, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxComputadora
            // 
            this.pictureBoxComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxComputadora.BackColor = System.Drawing.Color.White;
            this.pictureBoxComputadora.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxComputadora.Image")));
            this.pictureBoxComputadora.Location = new System.Drawing.Point(514, 335);
            this.pictureBoxComputadora.Name = "pictureBoxComputadora";
            this.pictureBoxComputadora.Size = new System.Drawing.Size(612, 359);
            this.pictureBoxComputadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxComputadora.TabIndex = 21;
            this.pictureBoxComputadora.TabStop = false;
            this.pictureBoxComputadora.Click += new System.EventHandler(this.pictureBoxComputadora_Click);
            // 
            // FrmPrincipalDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1002, 694);
            this.Controls.Add(this.pictureBoxLibros);
            this.Controls.Add(this.pictureBoxComputadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.dgvCursosDocente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipalDocente";
            this.Text = "FrmPrincipalDocente";
            this.Load += new System.EventHandler(this.FrmPrincipalDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMA;
        private System.Windows.Forms.DataGridViewImageColumn ASISTENCIA;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.PictureBox pictureBoxLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxComputadora;
    }
}