namespace OpenFarm.Mantenimiento
{
    partial class FrmDialogCategoria
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
            this.Dtg_Categoria = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtg_Categoria
            // 
            this.Dtg_Categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Categoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtg_Categoria.BackgroundColor = System.Drawing.Color.White;
            this.Dtg_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Categoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dtg_Categoria.GridColor = System.Drawing.Color.SteelBlue;
            this.Dtg_Categoria.Location = new System.Drawing.Point(12, 99);
            this.Dtg_Categoria.MultiSelect = false;
            this.Dtg_Categoria.Name = "Dtg_Categoria";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Categoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Dtg_Categoria.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtg_Categoria.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.Dtg_Categoria.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtg_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Categoria.Size = new System.Drawing.Size(417, 253);
            this.Dtg_Categoria.TabIndex = 27;
            this.Dtg_Categoria.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Categoria_CellContentDoubleClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Depth = 0;
            this.btn_buscar.Location = new System.Drawing.Point(289, 68);
            this.btn_buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Primary = true;
            this.btn_buscar.Size = new System.Drawing.Size(69, 25);
            this.btn_buscar.TabIndex = 26;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(12, 68);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(275, 25);
            this.txt_buscar.TabIndex = 25;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // FrmDialogCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 372);
            this.Controls.Add(this.Dtg_Categoria);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FrmDialogCategoria";
            this.Text = "FrmDialogCategoria";
            this.Load += new System.EventHandler(this.FrmDialogCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtg_Categoria;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}