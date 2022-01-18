
namespace CapaPresentacion
{
    partial class FrmPrincipalDirecAcademico
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
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDESCARGAR = new System.Windows.Forms.Button();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonIMPORTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.White;
            this.buttonActualizar.Image = global::CapaPresentacion.Properties.Resources.refresh_regular_24;
            this.buttonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.Location = new System.Drawing.Point(786, 498);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.buttonActualizar.Size = new System.Drawing.Size(175, 46);
            this.buttonActualizar.TabIndex = 12;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(147, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(691, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "CATÁLOGO 2021-II   INFORMÁTICA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.buttonDESCARGAR.ForeColor = System.Drawing.Color.White;
            this.buttonDESCARGAR.Image = global::CapaPresentacion.Properties.Resources.download_regular_241;
            this.buttonDESCARGAR.Location = new System.Drawing.Point(581, 498);
            this.buttonDESCARGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDESCARGAR.Name = "buttonDESCARGAR";
            this.buttonDESCARGAR.Size = new System.Drawing.Size(189, 46);
            this.buttonDESCARGAR.TabIndex = 10;
            this.buttonDESCARGAR.Text = "DESCARGAR";
            this.buttonDESCARGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDESCARGAR.UseVisualStyleBackColor = false;
            this.buttonDESCARGAR.Click += new System.EventHandler(this.buttonDESCARGAR_Click_1);
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCatalogo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCatalogo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogo.ColumnHeadersHeight = 32;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogo.ColumnHeadersVisible = false;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR});
            this.dgvCatalogo.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatalogo.EnableHeadersVisualStyles = false;
            this.dgvCatalogo.GridColor = System.Drawing.Color.Silver;
            this.dgvCatalogo.Location = new System.Drawing.Point(22, 124);
            this.dgvCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.RowHeadersWidth = 80;
            this.dgvCatalogo.RowTemplate.Height = 24;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(955, 344);
            this.dgvCatalogo.TabIndex = 9;
            this.dgvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_CellContentClick_1);
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = global::CapaPresentacion.Properties.Resources.pencil_16px;
            this.EDITAR.MinimumWidth = 6;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            this.EDITAR.Width = 6;
            // 
            // buttonIMPORTAR
            // 
            this.buttonIMPORTAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonIMPORTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.buttonIMPORTAR.FlatAppearance.BorderSize = 0;
            this.buttonIMPORTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.buttonIMPORTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.buttonIMPORTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIMPORTAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonIMPORTAR.Image = global::CapaPresentacion.Properties.Resources.export_regular_24;
            this.buttonIMPORTAR.Location = new System.Drawing.Point(22, 503);
            this.buttonIMPORTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIMPORTAR.Name = "buttonIMPORTAR";
            this.buttonIMPORTAR.Size = new System.Drawing.Size(263, 41);
            this.buttonIMPORTAR.TabIndex = 13;
            this.buttonIMPORTAR.Text = "IMPORTAR DOCENTES";
            this.buttonIMPORTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIMPORTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIMPORTAR.UseVisualStyleBackColor = false;
            this.buttonIMPORTAR.Click += new System.EventHandler(this.buttonIMPORTAR_Click);
            // 
            // FrmPrincipalDirecAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1002, 564);
            this.Controls.Add(this.buttonIMPORTAR);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDESCARGAR);
            this.Controls.Add(this.dgvCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipalDirecAcademico";
            this.Text = "FrmPrincipalDirecAcademico";
            this.Load += new System.EventHandler(this.FrmPrincipalDirecAcademico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDESCARGAR;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.Button buttonIMPORTAR;
    }
}