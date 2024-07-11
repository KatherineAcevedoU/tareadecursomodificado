namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PbMostrar = new System.Windows.Forms.PictureBox();
            this.PbOcultar = new System.Windows.Forms.PictureBox();
            this.pbrInicio = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(91, 92);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(93, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Ingrese el usuario:";
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Location = new System.Drawing.Point(94, 145);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(112, 13);
            this.LblContrasena.TabIndex = 1;
            this.LblContrasena.Text = "Ingrese la contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(246, 92);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(246, 138);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(100, 20);
            this.TxtContrasena.TabIndex = 3;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnIngresar.Location = new System.Drawing.Point(94, 203);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(90, 46);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnEliminar.Location = new System.Drawing.Point(246, 201);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(79, 48);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "cancelar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PbMostrar
            // 
            this.PbMostrar.Image = global::Inventario.Properties.Resources.Ver;
            this.PbMostrar.Location = new System.Drawing.Point(352, 138);
            this.PbMostrar.Name = "PbMostrar";
            this.PbMostrar.Size = new System.Drawing.Size(25, 25);
            this.PbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMostrar.TabIndex = 7;
            this.PbMostrar.TabStop = false;
            this.PbMostrar.Click += new System.EventHandler(this.PbMostrar_Click);
            // 
            // PbOcultar
            // 
            this.PbOcultar.Image = global::Inventario.Properties.Resources.No_ver;
            this.PbOcultar.Location = new System.Drawing.Point(352, 138);
            this.PbOcultar.Name = "PbOcultar";
            this.PbOcultar.Size = new System.Drawing.Size(25, 25);
            this.PbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbOcultar.TabIndex = 6;
            this.PbOcultar.TabStop = false;
            this.PbOcultar.Click += new System.EventHandler(this.PbOcultar_Click);
            // 
            // pbrInicio
            // 
            this.pbrInicio.Location = new System.Drawing.Point(97, 326);
            this.pbrInicio.Name = "pbrInicio";
            this.pbrInicio.Size = new System.Drawing.Size(280, 23);
            this.pbrInicio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inicio de sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbrInicio);
            this.Controls.Add(this.PbOcultar);
            this.Controls.Add(this.PbMostrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.LblUsuario);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox PbOcultar;
        private System.Windows.Forms.PictureBox PbMostrar;
        private System.Windows.Forms.ProgressBar pbrInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

