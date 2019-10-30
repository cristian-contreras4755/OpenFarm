namespace OpenFarm.Mantenimiento
{
    partial class FrmCliente
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
            this.txt_NDoc = new System.Windows.Forms.TextBox();
            this.btn_buscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_RSocial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_pjur = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbt_pnat = new MaterialSkin.Controls.MaterialRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tlf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ApMat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ApPat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NComercial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Cd_TDI = new System.Windows.Forms.ComboBox();
            this.DT_Cliente = new System.Windows.Forms.DataGridView();
            this.contextMenucrud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Cliente)).BeginInit();
            this.contextMenucrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NDoc
            // 
            this.txt_NDoc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NDoc.Location = new System.Drawing.Point(99, 139);
            this.txt_NDoc.Name = "txt_NDoc";
            this.txt_NDoc.Size = new System.Drawing.Size(278, 25);
            this.txt_NDoc.TabIndex = 23;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Depth = 0;
            this.btn_buscar.Location = new System.Drawing.Point(935, 76);
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
            this.txt_buscar.Location = new System.Drawing.Point(441, 75);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(488, 25);
            this.txt_buscar.TabIndex = 26;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Location = new System.Drawing.Point(119, 390);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Primary = true;
            this.btn_guardar.Size = new System.Drawing.Size(79, 27);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.Location = new System.Drawing.Point(204, 390);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Primary = true;
            this.btn_cancelar.Size = new System.Drawing.Size(75, 27);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // txt_RSocial
            // 
            this.txt_RSocial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RSocial.Location = new System.Drawing.Point(99, 108);
            this.txt_RSocial.Name = "txt_RSocial";
            this.txt_RSocial.Size = new System.Drawing.Size(278, 25);
            this.txt_RSocial.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.txt_correo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_tlf);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Nom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_ApMat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ApPat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NComercial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cb_Cd_TDI);
            this.panel1.Controls.Add(this.txt_RSocial);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.txt_NDoc);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 621);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_pjur);
            this.groupBox1.Controls.Add(this.rbt_pnat);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 62);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "T. Cliente";
            // 
            // rbt_pjur
            // 
            this.rbt_pjur.AutoSize = true;
            this.rbt_pjur.Checked = true;
            this.rbt_pjur.Depth = 0;
            this.rbt_pjur.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbt_pjur.Location = new System.Drawing.Point(202, 23);
            this.rbt_pjur.Margin = new System.Windows.Forms.Padding(0);
            this.rbt_pjur.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbt_pjur.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbt_pjur.Name = "rbt_pjur";
            this.rbt_pjur.Ripple = true;
            this.rbt_pjur.Size = new System.Drawing.Size(78, 30);
            this.rbt_pjur.TabIndex = 1;
            this.rbt_pjur.TabStop = true;
            this.rbt_pjur.Text = "Juridica";
            this.rbt_pjur.UseVisualStyleBackColor = true;
            // 
            // rbt_pnat
            // 
            this.rbt_pnat.AutoSize = true;
            this.rbt_pnat.Depth = 0;
            this.rbt_pnat.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbt_pnat.Location = new System.Drawing.Point(93, 23);
            this.rbt_pnat.Margin = new System.Windows.Forms.Padding(0);
            this.rbt_pnat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbt_pnat.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbt_pnat.Name = "rbt_pnat";
            this.rbt_pnat.Ripple = true;
            this.rbt_pnat.Size = new System.Drawing.Size(74, 30);
            this.rbt_pnat.TabIndex = 0;
            this.rbt_pnat.Text = "Natural";
            this.rbt_pnat.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(13, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "Direcion :";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(99, 293);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(278, 25);
            this.txt_direccion.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(22, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Tipo Doc.:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl.Location = new System.Drawing.Point(23, 359);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(69, 19);
            this.lbl.TabIndex = 49;
            this.lbl.Text = "Correo :";
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(99, 359);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(278, 25);
            this.txt_correo.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(62, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tlf :";
            // 
            // txt_tlf
            // 
            this.txt_tlf.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tlf.Location = new System.Drawing.Point(99, 327);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.Size = new System.Drawing.Size(278, 25);
            this.txt_tlf.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(14, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nombre :";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.Location = new System.Drawing.Point(99, 262);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(278, 25);
            this.txt_Nom.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ap. Mat :";
            // 
            // txt_ApMat
            // 
            this.txt_ApMat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApMat.Location = new System.Drawing.Point(99, 231);
            this.txt_ApMat.Name = "txt_ApMat";
            this.txt_ApMat.Size = new System.Drawing.Size(278, 25);
            this.txt_ApMat.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ap. Pat :";
            // 
            // txt_ApPat
            // 
            this.txt_ApPat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApPat.Location = new System.Drawing.Point(99, 200);
            this.txt_ApPat.Name = "txt_ApPat";
            this.txt_ApPat.Size = new System.Drawing.Size(278, 25);
            this.txt_ApPat.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "N. Com :";
            // 
            // txt_NComercial
            // 
            this.txt_NComercial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NComercial.Location = new System.Drawing.Point(99, 169);
            this.txt_NComercial.Name = "txt_NComercial";
            this.txt_NComercial.Size = new System.Drawing.Size(278, 25);
            this.txt_NComercial.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "RSocial :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(14, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nro Doc.:";
            // 
            // cb_Cd_TDI
            // 
            this.cb_Cd_TDI.FormattingEnabled = true;
            this.cb_Cd_TDI.Location = new System.Drawing.Point(107, 16);
            this.cb_Cd_TDI.Name = "cb_Cd_TDI";
            this.cb_Cd_TDI.Size = new System.Drawing.Size(278, 21);
            this.cb_Cd_TDI.TabIndex = 32;
            // 
            // DT_Cliente
            // 
            this.DT_Cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DT_Cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DT_Cliente.BackgroundColor = System.Drawing.Color.White;
            this.DT_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_Cliente.ContextMenuStrip = this.contextMenucrud;
            this.DT_Cliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DT_Cliente.GridColor = System.Drawing.Color.SteelBlue;
            this.DT_Cliente.Location = new System.Drawing.Point(441, 106);
            this.DT_Cliente.MultiSelect = false;
            this.DT_Cliente.Name = "DT_Cliente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DT_Cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DT_Cliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DT_Cliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DT_Cliente.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DT_Cliente.Size = new System.Drawing.Size(1011, 590);
            this.DT_Cliente.TabIndex = 29;
            this.DT_Cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_Cliente_CellContentClick);
            this.DT_Cliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_Cliente_CellContentDoubleClick);
            // 
            // contextMenucrud
            // 
            this.contextMenucrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenucrud.Name = "contextMenucrud";
            this.contextMenucrud.Size = new System.Drawing.Size(118, 26);
            this.contextMenucrud.Text = "Opciones";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 754);
            this.Controls.Add(this.DT_Cliente);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Cliente)).EndInit();
            this.contextMenucrud.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NDoc;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancelar;
        private System.Windows.Forms.TextBox txt_RSocial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_Cd_TDI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ApMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ApPat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NComercial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tlf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.DataGridView DT_Cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton rbt_pjur;
        private MaterialSkin.Controls.MaterialRadioButton rbt_pnat;
        private System.Windows.Forms.ContextMenuStrip contextMenucrud;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}