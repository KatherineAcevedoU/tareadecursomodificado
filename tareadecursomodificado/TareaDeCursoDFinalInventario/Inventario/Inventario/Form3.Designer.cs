namespace Inventario
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoVeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadVender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.dtFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerificarVenta = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnCalcularVenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubTotalFactura = new System.Windows.Forms.TextBox();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.btnGenerarPago = new System.Windows.Forms.Button();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.dtgVentaProductos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreVendido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del producto a vender:";
            // 
            // txtCodigoVeri
            // 
            this.txtCodigoVeri.Location = new System.Drawing.Point(216, 36);
            this.txtCodigoVeri.Name = "txtCodigoVeri";
            this.txtCodigoVeri.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoVeri.TabIndex = 1;
            this.txtCodigoVeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoVeri_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(216, 92);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "cantidad a vender:";
            // 
            // txtCantidadVender
            // 
            this.txtCantidadVender.Location = new System.Drawing.Point(216, 124);
            this.txtCantidadVender.Name = "txtCantidadVender";
            this.txtCantidadVender.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVender.TabIndex = 5;
            this.txtCantidadVender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadVender_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(33, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SubTotal;";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(216, 174);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 7;
            // 
            // dtFechaVenta
            // 
            this.dtFechaVenta.Location = new System.Drawing.Point(36, 253);
            this.dtFechaVenta.Name = "dtFechaVenta";
            this.dtFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaVenta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(33, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // btnVerificarVenta
            // 
            this.btnVerificarVenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVerificarVenta.Location = new System.Drawing.Point(341, 33);
            this.btnVerificarVenta.Name = "btnVerificarVenta";
            this.btnVerificarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarVenta.TabIndex = 11;
            this.btnVerificarVenta.Text = "Buscar";
            this.btnVerificarVenta.UseVisualStyleBackColor = false;
            this.btnVerificarVenta.Click += new System.EventHandler(this.btnVerificarVenta_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregarVenta.Location = new System.Drawing.Point(458, 39);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(94, 34);
            this.btnAgregarVenta.TabIndex = 13;
            this.btnAgregarVenta.Text = "Agregar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnCalcularVenta
            // 
            this.btnCalcularVenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcularVenta.Location = new System.Drawing.Point(458, 89);
            this.btnCalcularVenta.Name = "btnCalcularVenta";
            this.btnCalcularVenta.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularVenta.TabIndex = 14;
            this.btnCalcularVenta.Text = "Calcular";
            this.btnCalcularVenta.UseVisualStyleBackColor = false;
            this.btnCalcularVenta.Click += new System.EventHandler(this.btnCalcularVenta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(581, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "SubTotalFactura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(585, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "TotalFactura";
            // 
            // txtSubTotalFactura
            // 
            this.txtSubTotalFactura.Location = new System.Drawing.Point(676, 395);
            this.txtSubTotalFactura.Name = "txtSubTotalFactura";
            this.txtSubTotalFactura.Size = new System.Drawing.Size(65, 20);
            this.txtSubTotalFactura.TabIndex = 17;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(676, 428);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(65, 20);
            this.txtTotalFactura.TabIndex = 18;
            // 
            // btnGenerarPago
            // 
            this.btnGenerarPago.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarPago.Location = new System.Drawing.Point(458, 131);
            this.btnGenerarPago.Name = "btnGenerarPago";
            this.btnGenerarPago.Size = new System.Drawing.Size(92, 23);
            this.btnGenerarPago.TabIndex = 19;
            this.btnGenerarPago.Text = "Generar Pago";
            this.btnGenerarPago.UseVisualStyleBackColor = false;
            this.btnGenerarPago.Click += new System.EventHandler(this.btnGenerarPago_Click);
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(458, 171);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(103, 23);
            this.BtnRegistrarProducto.TabIndex = 20;
            this.BtnRegistrarProducto.Text = "Registrar Producto";
            this.BtnRegistrarProducto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // dtgVentaProductos
            // 
            this.dtgVentaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaProductos.Location = new System.Drawing.Point(36, 296);
            this.dtgVentaProductos.Name = "dtgVentaProductos";
            this.dtgVentaProductos.RowHeadersWidth = 51;
            this.dtgVentaProductos.Size = new System.Drawing.Size(532, 150);
            this.dtgVentaProductos.TabIndex = 21;
            this.dtgVentaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVentaProductos_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Realizacion de la venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Location = new System.Drawing.Point(638, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cantodad con la que pagara:";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(792, 107);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(100, 20);
            this.txtCash.TabIndex = 24;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(647, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 134);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Moneda";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dolares";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cordobas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(708, 296);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(644, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cambio:";
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFactura.Location = new System.Drawing.Point(814, 307);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(78, 44);
            this.btnFactura.TabIndex = 30;
            this.btnFactura.Text = "Generar Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPagar.Location = new System.Drawing.Point(647, 322);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(161, 29);
            this.btnPagar.TabIndex = 29;
            this.btnPagar.Text = "pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Location = new System.Drawing.Point(33, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Nombre del producto:";
            // 
            // txtNombreVendido
            // 
            this.txtNombreVendido.Location = new System.Drawing.Point(216, 66);
            this.txtNombreVendido.Name = "txtNombreVendido";
            this.txtNombreVendido.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVendido.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(644, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(791, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnLimpiar.Location = new System.Drawing.Point(458, 211);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 35;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(791, 430);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 36;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(903, 473);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNombreVendido);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgVentaProductos);
            this.Controls.Add(this.BtnRegistrarProducto);
            this.Controls.Add(this.btnGenerarPago);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.txtSubTotalFactura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcularVenta);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.btnVerificarVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaVenta);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadVender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoVeri);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadVender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.DateTimePicker dtFechaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerificarVenta;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnCalcularVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubTotalFactura;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Button btnGenerarPago;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.DataGridView dtgVentaProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreVendido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
    }
}