namespace OpenFarm.Seguridad
{
    partial class FrmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DRG_usuario = new System.Windows.Forms.DataGridView();
            this.contextMenucrud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Editar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_salir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Nuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_buscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DRG_usuario)).BeginInit();
            this.contextMenucrud.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DRG_usuario
            // 
            this.DRG_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DRG_usuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DRG_usuario.BackgroundColor = System.Drawing.Color.White;
            this.DRG_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DRG_usuario.ContextMenuStrip = this.contextMenucrud;
            this.DRG_usuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DRG_usuario.GridColor = System.Drawing.Color.SteelBlue;
            this.DRG_usuario.Location = new System.Drawing.Point(120, 97);
            this.DRG_usuario.MultiSelect = false;
            this.DRG_usuario.Name = "DRG_usuario";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DRG_usuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DRG_usuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DRG_usuario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DRG_usuario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRG_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DRG_usuario.Size = new System.Drawing.Size(952, 470);
            this.DRG_usuario.TabIndex = 25;
            this.DRG_usuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DRG_usuario_CellContentDoubleClick);
            // 
            // contextMenucrud
            // 
            this.contextMenucrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenucrud.Name = "contextMenucrud";
            this.contextMenucrud.Size = new System.Drawing.Size(118, 48);
            this.contextMenucrud.Text = "Opciones";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_Editar);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 501);
            this.panel1.TabIndex = 28;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Depth = 0;
            this.btn_eliminar.Location = new System.Drawing.Point(12, 110);
            this.btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Primary = true;
            this.btn_eliminar.Size = new System.Drawing.Size(91, 40);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Depth = 0;
            this.btn_Editar.Location = new System.Drawing.Point(12, 64);
            this.btn_Editar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Primary = true;
            this.btn_Editar.Size = new System.Drawing.Size(91, 40);
            this.btn_Editar.TabIndex = 15;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Depth = 0;
            this.btn_salir.Location = new System.Drawing.Point(12, 160);
            this.btn_salir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Primary = true;
            this.btn_salir.Size = new System.Drawing.Size(91, 40);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Depth = 0;
            this.btn_Nuevo.Location = new System.Drawing.Point(12, 18);
            this.btn_Nuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Primary = true;
            this.btn_Nuevo.Size = new System.Drawing.Size(91, 40);
            this.btn_Nuevo.TabIndex = 13;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Depth = 0;
            this.btn_buscar.Location = new System.Drawing.Point(560, 67);
            this.btn_buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Primary = true;
            this.btn_buscar.Size = new System.Drawing.Size(69, 25);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(120, 66);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(424, 25);
            this.txt_buscar.TabIndex = 26;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 581);
            this.Controls.Add(this.DRG_usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DRG_usuario)).EndInit();
            this.contextMenucrud.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DRG_usuario;
        private System.Windows.Forms.ContextMenuStrip contextMenucrud;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_eliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Editar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_salir;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Nuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}