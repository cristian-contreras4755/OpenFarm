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
            this.txt_nom2 = new System.Windows.Forms.TextBox();
            this.txt_nom1 = new System.Windows.Forms.TextBox();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.OFD_imagen = new System.Windows.Forms.OpenFileDialog();
            this.pic_producto = new System.Windows.Forms.PictureBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_presentacion = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.btn_buscarMarca = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_buscarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_buscarPresentacion = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.Location = new System.Drawing.Point(223, 399);
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
            this.labelControl8.Location = new System.Drawing.Point(59, 292);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 19);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Marca :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl7.Location = new System.Drawing.Point(26, 322);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 19);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Categoria :";
            // 
            // txt_nomcorto
            // 
            this.txt_nomcorto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomcorto.Location = new System.Drawing.Point(128, 134);
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
            this.labelControl6.Location = new System.Drawing.Point(30, 261);
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
            this.labelControl5.Location = new System.Drawing.Point(37, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 19);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Stock Min :";
            // 
            // nud_stockmax
            // 
            this.nud_stockmax.Location = new System.Drawing.Point(129, 264);
            this.nud_stockmax.Name = "nud_stockmax";
            this.nud_stockmax.Size = new System.Drawing.Size(205, 20);
            this.nud_stockmax.TabIndex = 38;
            // 
            // nud_stockmin
            // 
            this.nud_stockmin.Location = new System.Drawing.Point(128, 232);
            this.nud_stockmin.Name = "nud_stockmin";
            this.nud_stockmin.Size = new System.Drawing.Size(205, 20);
            this.nud_stockmin.TabIndex = 37;
            // 
            // btn_buscar_img
            // 
            this.btn_buscar_img.Depth = 0;
            this.btn_buscar_img.Location = new System.Drawing.Point(394, 224);
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
            this.labelControl4.Location = new System.Drawing.Point(45, 135);
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
            this.labelControl3.Location = new System.Drawing.Point(47, 171);
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
            this.labelControl2.Location = new System.Drawing.Point(33, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 19);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Nombre 2:";
            // 
            // txt_nom2
            // 
            this.txt_nom2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom2.Location = new System.Drawing.Point(129, 100);
            this.txt_nom2.Name = "txt_nom2";
            this.txt_nom2.Size = new System.Drawing.Size(207, 25);
            this.txt_nom2.TabIndex = 18;
            // 
            // txt_nom1
            // 
            this.txt_nom1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom1.Location = new System.Drawing.Point(129, 70);
            this.txt_nom1.Name = "txt_nom1";
            this.txt_nom1.Size = new System.Drawing.Size(207, 25);
            this.txt_nom1.TabIndex = 14;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Location = new System.Drawing.Point(126, 399);
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
            this.txt_Descripcion.Location = new System.Drawing.Point(126, 171);
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
            this.labelControl1.Location = new System.Drawing.Point(34, 72);
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
            this.pic_producto.Location = new System.Drawing.Point(342, 72);
            this.pic_producto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.pic_producto.Name = "pic_producto";
            this.pic_producto.Size = new System.Drawing.Size(130, 146);
            this.pic_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_producto.TabIndex = 35;
            this.pic_producto.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl9.Location = new System.Drawing.Point(8, 355);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(110, 19);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "Presentacion :";
            // 
            // txt_presentacion
            // 
            this.txt_presentacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_presentacion.Location = new System.Drawing.Point(126, 354);
            this.txt_presentacion.Name = "txt_presentacion";
            this.txt_presentacion.Size = new System.Drawing.Size(207, 25);
            this.txt_presentacion.TabIndex = 50;
            // 
            // txt_marca
            // 
            this.txt_marca.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(127, 290);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(207, 25);
            this.txt_marca.TabIndex = 48;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.Location = new System.Drawing.Point(127, 320);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(207, 25);
            this.txt_categoria.TabIndex = 49;
            // 
            // btn_buscarMarca
            // 
            this.btn_buscarMarca.Depth = 0;
            this.btn_buscarMarca.Location = new System.Drawing.Point(340, 291);
            this.btn_buscarMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscarMarca.Name = "btn_buscarMarca";
            this.btn_buscarMarca.Primary = true;
            this.btn_buscarMarca.Size = new System.Drawing.Size(34, 24);
            this.btn_buscarMarca.TabIndex = 51;
            this.btn_buscarMarca.Text = "....";
            this.btn_buscarMarca.UseVisualStyleBackColor = true;
            this.btn_buscarMarca.Click += new System.EventHandler(this.Btn_buscarMarca_Click);
            // 
            // btn_buscarCategoria
            // 
            this.btn_buscarCategoria.Depth = 0;
            this.btn_buscarCategoria.Location = new System.Drawing.Point(340, 324);
            this.btn_buscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscarCategoria.Name = "btn_buscarCategoria";
            this.btn_buscarCategoria.Primary = true;
            this.btn_buscarCategoria.Size = new System.Drawing.Size(34, 24);
            this.btn_buscarCategoria.TabIndex = 52;
            this.btn_buscarCategoria.Text = "....";
            this.btn_buscarCategoria.UseVisualStyleBackColor = true;
            this.btn_buscarCategoria.Click += new System.EventHandler(this.Btn_buscarCategoria_Click);
            // 
            // btn_buscarPresentacion
            // 
            this.btn_buscarPresentacion.Depth = 0;
            this.btn_buscarPresentacion.Location = new System.Drawing.Point(340, 355);
            this.btn_buscarPresentacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscarPresentacion.Name = "btn_buscarPresentacion";
            this.btn_buscarPresentacion.Primary = true;
            this.btn_buscarPresentacion.Size = new System.Drawing.Size(34, 24);
            this.btn_buscarPresentacion.TabIndex = 53;
            this.btn_buscarPresentacion.Text = "....";
            this.btn_buscarPresentacion.UseVisualStyleBackColor = true;
            this.btn_buscarPresentacion.Click += new System.EventHandler(this.Btn_buscarPresentacion_Click);
            // 
            // FrmProductoCrea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btn_buscarPresentacion);
            this.Controls.Add(this.btn_buscarCategoria);
            this.Controls.Add(this.btn_buscarMarca);
            this.Controls.Add(this.txt_presentacion);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nomcorto);
            this.Controls.Add(this.txt_nom1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_nom2);
            this.Controls.Add(this.labelControl5);
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
        private System.Windows.Forms.TextBox txt_nom2;
        private System.Windows.Forms.TextBox txt_nom1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.OpenFileDialog OFD_imagen;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txt_presentacion;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_categoria;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscarMarca;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscarPresentacion;
    }
}