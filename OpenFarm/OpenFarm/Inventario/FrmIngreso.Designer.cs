namespace OpenFarm.Inventario
{
    partial class FrmIngreso
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
            this.DT_IngresoDet = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Cd_TD = new System.Windows.Forms.ComboBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lblimpuesto = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_precioVta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_precioCom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Agregaritem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.npd_cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_buscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_FP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_FV = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DT_IngresoDet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npd_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_IngresoDet
            // 
            this.DT_IngresoDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DT_IngresoDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DT_IngresoDet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DT_IngresoDet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DT_IngresoDet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DT_IngresoDet.GridColor = System.Drawing.Color.SteelBlue;
            this.DT_IngresoDet.Location = new System.Drawing.Point(10, 155);
            this.DT_IngresoDet.MultiSelect = false;
            this.DT_IngresoDet.Name = "DT_IngresoDet";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DT_IngresoDet.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DT_IngresoDet.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DT_IngresoDet.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DT_IngresoDet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_IngresoDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DT_IngresoDet.Size = new System.Drawing.Size(862, 266);
            this.DT_IngresoDet.TabIndex = 33;
            this.DT_IngresoDet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DT_IngresoDet_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(18, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 74;
            this.label7.Text = "Tipo Doc.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(48, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "Serie :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(54, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 60;
            this.label10.Text = "Nro. :";
            // 
            // cb_Cd_TD
            // 
            this.cb_Cd_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cd_TD.FormattingEnabled = true;
            this.cb_Cd_TD.Location = new System.Drawing.Point(105, 71);
            this.cb_Cd_TD.Name = "cb_Cd_TD";
            this.cb_Cd_TD.Size = new System.Drawing.Size(147, 26);
            this.cb_Cd_TD.TabIndex = 1;
            // 
            // txt_serie
            // 
            this.txt_serie.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.Location = new System.Drawing.Point(105, 103);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(136, 25);
            this.txt_serie.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.Location = new System.Drawing.Point(401, 721);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Primary = true;
            this.btn_cancelar.Size = new System.Drawing.Size(75, 27);
            this.btn_cancelar.TabIndex = 56;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroDoc.Location = new System.Drawing.Point(105, 135);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(278, 25);
            this.txt_nroDoc.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Location = new System.Drawing.Point(316, 721);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Primary = true;
            this.btn_guardar.Size = new System.Drawing.Size(79, 27);
            this.btn_guardar.TabIndex = 55;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(498, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 78;
            this.label9.Text = "Proveedor. :";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.Location = new System.Drawing.Point(601, 70);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(278, 25);
            this.txt_proveedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(642, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Sub. Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(640, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "Impuesto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(675, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 81;
            this.label4.Text = "Total :";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.White;
            this.lbl_subtotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_subtotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_subtotal.Location = new System.Drawing.Point(734, 603);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(49, 19);
            this.lbl_subtotal.TabIndex = 82;
            this.lbl_subtotal.Text = "00.00";
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.AutoSize = true;
            this.lblimpuesto.BackColor = System.Drawing.Color.White;
            this.lblimpuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblimpuesto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblimpuesto.Location = new System.Drawing.Point(734, 632);
            this.lblimpuesto.Name = "lblimpuesto";
            this.lblimpuesto.Size = new System.Drawing.Size(49, 19);
            this.lblimpuesto.TabIndex = 83;
            this.lblimpuesto.Text = "00.00";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.White;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_total.Location = new System.Drawing.Point(734, 663);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(49, 19);
            this.lbl_total.TabIndex = 84;
            this.lbl_total.Text = "00.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_precioVta);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_precioCom);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_Agregaritem);
            this.panel1.Controls.Add(this.DT_IngresoDet);
            this.panel1.Controls.Add(this.npd_cantidad);
            this.panel1.Location = new System.Drawing.Point(6, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 524);
            this.panel1.TabIndex = 85;
            // 
            // label14
            // 
            this.label14.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(306, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 19);
            this.label14.TabIndex = 99;
            this.label14.Text = "Precio Vta. :";
            // 
            // txt_precioVta
            // 
            this.txt_precioVta.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txt_precioVta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioVta.Location = new System.Drawing.Point(411, 82);
            this.txt_precioVta.Name = "txt_precioVta";
            this.txt_precioVta.Size = new System.Drawing.Size(153, 25);
            this.txt_precioVta.TabIndex = 98;
            this.txt_precioVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_precioVta_KeyPress);
            // 
            // label13
            // 
            this.label13.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(21, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 19);
            this.label13.TabIndex = 97;
            this.label13.Text = "Precio Com. :";
            // 
            // txt_precioCom
            // 
            this.txt_precioCom.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txt_precioCom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioCom.Location = new System.Drawing.Point(140, 82);
            this.txt_precioCom.Name = "txt_precioCom";
            this.txt_precioCom.Size = new System.Drawing.Size(153, 25);
            this.txt_precioCom.TabIndex = 96;
            this.txt_precioCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_precioCom_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(535, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "Cantidad:";
            // 
            // btn_Agregaritem
            // 
            this.btn_Agregaritem.Depth = 0;
            this.btn_Agregaritem.Location = new System.Drawing.Point(10, 124);
            this.btn_Agregaritem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Agregaritem.Name = "btn_Agregaritem";
            this.btn_Agregaritem.Primary = true;
            this.btn_Agregaritem.Size = new System.Drawing.Size(69, 25);
            this.btn_Agregaritem.TabIndex = 95;
            this.btn_Agregaritem.Text = "Agregar";
            this.btn_Agregaritem.UseVisualStyleBackColor = true;
            this.btn_Agregaritem.Click += new System.EventHandler(this.Btn_Agregaritem_Click);
            // 
            // npd_cantidad
            // 
            this.npd_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npd_cantidad.Location = new System.Drawing.Point(628, 51);
            this.npd_cantidad.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.npd_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npd_cantidad.Name = "npd_cantidad";
            this.npd_cantidad.Size = new System.Drawing.Size(101, 26);
            this.npd_cantidad.TabIndex = 8;
            this.npd_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Depth = 0;
            this.btn_buscarCliente.Location = new System.Drawing.Point(640, 185);
            this.btn_buscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Primary = true;
            this.btn_buscarCliente.Size = new System.Drawing.Size(69, 25);
            this.btn_buscarCliente.TabIndex = 5;
            this.btn_buscarCliente.Text = "Buscar";
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.Btn_buscarCliente_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(146, 185);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(488, 25);
            this.txt_producto.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(56, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 89;
            this.label5.Text = "Producto:";
            // 
            // dt_FP
            // 
            this.dt_FP.CustomFormat = "dd-MM-yyyy";
            this.dt_FP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FP.Location = new System.Drawing.Point(148, 219);
            this.dt_FP.Name = "dt_FP";
            this.dt_FP.Size = new System.Drawing.Size(115, 22);
            this.dt_FP.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "F.  Producción.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(277, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 93;
            this.label8.Text = "F.  Vencimiento.:";
            // 
            // dt_FV
            // 
            this.dt_FV.CustomFormat = "dd-MM-yyyy";
            this.dt_FV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FV.Location = new System.Drawing.Point(419, 219);
            this.dt_FV.Name = "dt_FV";
            this.dt_FV.Size = new System.Drawing.Size(115, 22);
            this.dt_FV.TabIndex = 7;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 751);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_FV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_FP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_buscarCliente);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lblimpuesto);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_Cd_TD);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIngreso";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DT_IngresoDet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npd_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DT_IngresoDet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_Cd_TD;
        private System.Windows.Forms.TextBox txt_serie;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancelar;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lblimpuesto;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscarCliente;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.NumericUpDown npd_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_FP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_FV;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Agregaritem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_precioVta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_precioCom;
    }
}