namespace OpenFarm.Mantenimiento
{
    partial class FrmDialogMarca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtg_Marca = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Marca)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtg_Marca
            // 
            this.Dtg_Marca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Marca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtg_Marca.BackgroundColor = System.Drawing.Color.White;
            this.Dtg_Marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Marca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dtg_Marca.GridColor = System.Drawing.Color.SteelBlue;
            this.Dtg_Marca.Location = new System.Drawing.Point(3, 101);
            this.Dtg_Marca.MultiSelect = false;
            this.Dtg_Marca.Name = "Dtg_Marca";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Marca.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Dtg_Marca.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dtg_Marca.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.Dtg_Marca.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtg_Marca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Marca.Size = new System.Drawing.Size(417, 253);
            this.Dtg_Marca.TabIndex = 24;
            this.Dtg_Marca.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Marca_CellContentDoubleClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Depth = 0;
            this.btn_buscar.Location = new System.Drawing.Point(280, 70);
            this.btn_buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Primary = true;
            this.btn_buscar.Size = new System.Drawing.Size(69, 25);
            this.btn_buscar.TabIndex = 23;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(3, 70);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(275, 25);
            this.txt_buscar.TabIndex = 22;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // FrmDialogMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 364);
            this.Controls.Add(this.Dtg_Marca);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FrmDialogMarca";
            this.Text = "FrmDialogMarca";
            this.Load += new System.EventHandler(this.FrmDialogMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Marca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtg_Marca;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}