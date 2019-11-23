namespace OpenFarm.Seguridad
{
    partial class FrmDialogRol
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
            this.DRG_Rol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DRG_Rol)).BeginInit();
            this.SuspendLayout();
            // 
            // DRG_Rol
            // 
            this.DRG_Rol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DRG_Rol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DRG_Rol.BackgroundColor = System.Drawing.Color.White;
            this.DRG_Rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DRG_Rol.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DRG_Rol.GridColor = System.Drawing.Color.SteelBlue;
            this.DRG_Rol.Location = new System.Drawing.Point(3, 65);
            this.DRG_Rol.MultiSelect = false;
            this.DRG_Rol.Name = "DRG_Rol";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DRG_Rol.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DRG_Rol.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DRG_Rol.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DRG_Rol.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRG_Rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DRG_Rol.Size = new System.Drawing.Size(367, 278);
            this.DRG_Rol.TabIndex = 27;
            this.DRG_Rol.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DRG_Rol_CellContentDoubleClick);
            // 
            // FrmDialogRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 350);
            this.ControlBox = false;
            this.Controls.Add(this.DRG_Rol);
            this.Name = "FrmDialogRol";
            this.Text = "FrmDialogRol";
            this.Load += new System.EventHandler(this.FrmDialogRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DRG_Rol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DRG_Rol;
    }
}