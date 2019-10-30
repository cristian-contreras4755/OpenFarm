namespace OpenFarm.Mantenimiento
{
    partial class FrmProductoCrea
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
            this.btn_cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_nomcorto = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nud_stockmax = new System.Windows.Forms.NumericUpDown();
            this.nud_stockmin = new System.Windows.Forms.NumericUpDown();
            this.btn_buscar_img = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.txt_nom2 = new System.Windows.Forms.TextBox();
            this.txt_nom1 = new System.Windows.Forms.TextBox();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.OFD_imagen = new System.Windows.Forms.OpenFileDialog();
            this.pic_producto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.Location = new System.Drawing.Point(202, 382);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Primary = true;
            this.btn_cancelar.Size = new System.Drawing.Size(78, 32);
            this.btn_cancelar.TabIndex = 45;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl8.Location = new System.Drawing.Point(31, 301);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 19);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Marca :";
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(101, 301);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(207, 21);
            this.cb_marca.TabIndex = 43;
            this.cb_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cb_marca_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl7.Location = new System.Drawing.Point(3, 326);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 19);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Categoria :";
            // 
            // txt_nomcorto
            // 
            this.txt_nomcorto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomcorto.Location = new System.Drawing.Point(104, 136);
            this.txt_nomcorto.Name = "txt_nomcorto";
            this.txt_nomcorto.Size = new System.Drawing.Size(207, 25);
            this.txt_nomcorto.TabIndex = 41;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl6.Location = new System.Drawing.Point(7, 263);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 19);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "Stock Max :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl5.Location = new System.Drawing.Point(14, 231);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 19);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Stock Min :";
            // 
            // nud_stockmax
            // 
            this.nud_stockmax.Location = new System.Drawing.Point(105, 266);
            this.nud_stockmax.Name = "nud_stockmax";
            this.nud_stockmax.Size = new System.Drawing.Size(205, 20);
            this.nud_stockmax.TabIndex = 38;
            // 
            // nud_stockmin
            // 
            this.nud_stockmin.Location = new System.Drawing.Point(104, 234);
            this.nud_stockmin.Name = "nud_stockmin";
            this.nud_stockmin.Size = new System.Drawing.Size(205, 20);
            this.nud_stockmin.TabIndex = 37;
            // 
            // btn_buscar_img
            // 
            this.btn_buscar_img.Depth = 0;
            this.btn_buscar_img.Location = new System.Drawing.Point(370, 226);
            this.btn_buscar_img.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscar_img.Name = "btn_buscar_img";
            this.btn_buscar_img.Primary = true;
            this.btn_buscar_img.Size = new System.Drawing.Size(78, 24);
            this.btn_buscar_img.TabIndex = 36;
            this.btn_buscar_img.Text = "Abrir";
            this.btn_buscar_img.UseVisualStyleBackColor = true;
            this.btn_buscar_img.Click += new System.EventHandler(this.Btn_buscar_img_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl4.Location = new System.Drawing.Point(22, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 19);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "N.  Corto :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl3.Location = new System.Drawing.Point(24, 173);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 19);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Descrip :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(10, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 19);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Nombre 2:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(101, 328);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(207, 21);
            this.cb_categoria.TabIndex = 31;
            this.cb_categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cb_categoria_KeyPress);
            // 
            // txt_nom2
            // 
            this.txt_nom2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom2.Location = new System.Drawing.Point(105, 102);
            this.txt_nom2.Name = "txt_nom2";
            this.txt_nom2.Size = new System.Drawing.Size(207, 25);
            this.txt_nom2.TabIndex = 18;
            // 
            // txt_nom1
            // 
            this.txt_nom1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom1.Location = new System.Drawing.Point(105, 72);
            this.txt_nom1.Name = "txt_nom1";
            this.txt_nom1.Size = new System.Drawing.Size(207, 25);
            this.txt_nom1.TabIndex = 14;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Location = new System.Drawing.Point(105, 382);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Primary = true;
            this.btn_guardar.Size = new System.Drawing.Size(91, 32);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(102, 173);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Descripcion.Size = new System.Drawing.Size(207, 49);
            this.txt_Descripcion.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(11, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 19);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Nombre 1:";
            // 
            // OFD_imagen
            // 
            this.OFD_imagen.FileName = "openFileDialog1";
            // 
            // pic_producto
            // 
            this.pic_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_producto.Location = new System.Drawing.Point(318, 74);
            this.pic_producto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.pic_producto.Name = "pic_producto";
            this.pic_producto.Size = new System.Drawing.Size(130, 146);
            this.pic_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_producto.TabIndex = 35;
            this.pic_producto.TabStop = false;
            // 
            // FrmProductoCrea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(473, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nomcorto);
            this.Controls.Add(this.txt_nom1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_nom2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.nud_stockmax);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.nud_stockmin);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btn_buscar_img);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pic_producto);
            this.Name = "FrmProductoCrea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmProductoCrea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancelar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cb_marca;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txt_nomcorto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nud_stockmax;
        private System.Windows.Forms.NumericUpDown nud_stockmin;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscar_img;
        private System.Windows.Forms.PictureBox pic_producto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.TextBox txt_nom2;
        private System.Windows.Forms.TextBox txt_nom1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.OpenFileDialog OFD_imagen;
    }
}