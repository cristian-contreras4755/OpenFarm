namespace OpenFarm.Ventas
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.DT_DetVta = new System.Windows.Forms.DataGridView();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.btn_buscar_cliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_cobrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.printDocumentTicket = new System.Drawing.Printing.PrintDocument();
            this.printDialogticket = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialogTicket = new System.Windows.Forms.PrintPreviewDialog();
            this.txt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DT_DetVta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DT_DetVta
            // 
            this.DT_DetVta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DT_DetVta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DT_DetVta.BackgroundColor = System.Drawing.Color.White;
            this.DT_DetVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_DetVta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DT_DetVta.GridColor = System.Drawing.Color.SteelBlue;
            this.DT_DetVta.Location = new System.Drawing.Point(7, 83);
            this.DT_DetVta.MultiSelect = false;
            this.DT_DetVta.Name = "DT_DetVta";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DT_DetVta.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DT_DetVta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DT_DetVta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DT_DetVta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_DetVta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DT_DetVta.Size = new System.Drawing.Size(847, 506);
            this.DT_DetVta.TabIndex = 25;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_Marca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Marca.Location = new System.Drawing.Point(22, 453);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(207, 41);
            this.txt_Marca.TabIndex = 22;
            this.txt_Marca.Text = "100.00";
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Depth = 0;
            this.btn_buscar_cliente.Location = new System.Drawing.Point(635, 15);
            this.btn_buscar_cliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Primary = true;
            this.btn_buscar_cliente.Size = new System.Drawing.Size(66, 25);
            this.btn_buscar_cliente.TabIndex = 27;
            this.btn_buscar_cliente.Text = "Buscar";
            this.btn_buscar_cliente.UseVisualStyleBackColor = true;
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(89, 13);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(540, 27);
            this.txt_producto.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.btn_cliente);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_cobrar);
            this.panel1.Location = new System.Drawing.Point(1273, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 609);
            this.panel1.TabIndex = 28;
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.Lime;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Location = new System.Drawing.Point(14, 6);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(119, 59);
            this.btn_cliente.TabIndex = 18;
            this.btn_cliente.Text = "CLIENTE";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.Btn_cliente_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Lime;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(14, 136);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(119, 59);
            this.btn_print.TabIndex = 17;
            this.btn_print.Text = "IMPRIMIR";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.Btn_print_Click);
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.BackColor = System.Drawing.Color.Lime;
            this.btn_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar.Location = new System.Drawing.Point(14, 71);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(119, 59);
            this.btn_cobrar.TabIndex = 16;
            this.btn_cobrar.Text = "COBRAR";
            this.btn_cobrar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Marca);
            this.panel2.Location = new System.Drawing.Point(860, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 589);
            this.panel2.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(73, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "cristian aaaaaaaaa aaaaaaaaaaaa aaa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(4, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cliente :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(18, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Devolución :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(16, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "S/.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(71, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "1000.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total   apagar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "S/.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(71, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "1000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(18, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Monto Recibido :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "venta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btn_agregar_producto);
            this.panel3.Controls.Add(this.DT_DetVta);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1422, 609);
            this.panel3.TabIndex = 31;
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.BackColor = System.Drawing.Color.Lime;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.Location = new System.Drawing.Point(717, 3);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(137, 74);
            this.btn_agregar_producto.TabIndex = 35;
            this.btn_agregar_producto.Text = "CLIENTE";
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.btn_buscar_cliente);
            this.panel5.Controls.Add(this.txt_producto);
            this.panel5.Location = new System.Drawing.Point(7, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(704, 74);
            this.panel5.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Producto :";
            // 
            // printDialogticket
            // 
            this.printDialogticket.UseEXDialog = true;
            // 
            // printPreviewDialogTicket
            // 
            this.printPreviewDialogTicket.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTicket.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTicket.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogTicket.Enabled = true;
            this.printPreviewDialogTicket.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogTicket.Icon")));
            this.printPreviewDialogTicket.Name = "printPreviewDialogTicket";
            this.printPreviewDialogTicket.Visible = false;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.Lime;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(14, 201);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(119, 59);
            this.txt.TabIndex = 19;
            this.txt.Text = "COBRAR";
            this.txt.UseVisualStyleBackColor = false;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1425, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DT_DetVta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DT_DetVta;
        private System.Windows.Forms.TextBox txt_Marca;
        private MaterialSkin.Controls.MaterialRaisedButton btn_buscar_cliente;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Drawing.Printing.PrintDocument printDocumentTicket;
        private System.Windows.Forms.PrintDialog printDialogticket;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogTicket;
        private System.Windows.Forms.Button btn_cobrar;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.Button txt;
    }
}