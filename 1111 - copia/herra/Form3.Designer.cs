namespace herra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Salir_Registro = new System.Windows.Forms.Button();
            this.Telefono = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Registro_clientes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 31;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Black;
            this.txtTelefono.ForeColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Location = new System.Drawing.Point(583, 188);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 26);
            this.txtTelefono.TabIndex = 30;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Black;
            this.txtCorreo.ForeColor = System.Drawing.Color.Transparent;
            this.txtCorreo.Location = new System.Drawing.Point(583, 291);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(175, 26);
            this.txtCorreo.TabIndex = 29;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.Black;
            this.txtDocumento.ForeColor = System.Drawing.Color.Transparent;
            this.txtDocumento.Location = new System.Drawing.Point(203, 291);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(175, 26);
            this.txtDocumento.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Black;
            this.txtNombre.ForeColor = System.Drawing.Color.Transparent;
            this.txtNombre.Location = new System.Drawing.Point(203, 188);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 26);
            this.txtNombre.TabIndex = 27;
            // 
            // Salir_Registro
            // 
            this.Salir_Registro.BackColor = System.Drawing.Color.Black;
            this.Salir_Registro.ForeColor = System.Drawing.Color.Transparent;
            this.Salir_Registro.Location = new System.Drawing.Point(657, 384);
            this.Salir_Registro.Name = "Salir_Registro";
            this.Salir_Registro.Size = new System.Drawing.Size(122, 42);
            this.Salir_Registro.TabIndex = 26;
            this.Salir_Registro.Text = "SALIR";
            this.Salir_Registro.UseVisualStyleBackColor = false;
            this.Salir_Registro.Click += new System.EventHandler(this.Salir_Registro_Click);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.BackColor = System.Drawing.Color.White;
            this.Telefono.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Telefono.Image = ((System.Drawing.Image)(resources.GetObject("Telefono.Image")));
            this.Telefono.Location = new System.Drawing.Point(445, 188);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(121, 23);
            this.Telefono.TabIndex = 25;
            this.Telefono.Text = "TELÉFONO:";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.BackColor = System.Drawing.Color.White;
            this.Correo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Correo.Image = ((System.Drawing.Image)(resources.GetObject("Correo.Image")));
            this.Correo.Location = new System.Drawing.Point(454, 291);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(103, 23);
            this.Correo.TabIndex = 24;
            this.Correo.Text = "CORREO:";
            // 
            // Documento
            // 
            this.Documento.AutoSize = true;
            this.Documento.BackColor = System.Drawing.Color.White;
            this.Documento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Documento.Image = ((System.Drawing.Image)(resources.GetObject("Documento.Image")));
            this.Documento.Location = new System.Drawing.Point(41, 291);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(146, 23);
            this.Documento.TabIndex = 23;
            this.Documento.Text = "DOCUMENTO:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombre.Image = ((System.Drawing.Image)(resources.GetObject("Nombre.Image")));
            this.Nombre.Location = new System.Drawing.Point(58, 188);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(103, 23);
            this.Nombre.TabIndex = 22;
            this.Nombre.Text = "NOMBRE:";
            // 
            // Registro_clientes
            // 
            this.Registro_clientes.AutoSize = true;
            this.Registro_clientes.BackColor = System.Drawing.Color.Black;
            this.Registro_clientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro_clientes.ForeColor = System.Drawing.Color.Transparent;
            this.Registro_clientes.Location = new System.Drawing.Point(178, 45);
            this.Registro_clientes.Name = "Registro_clientes";
            this.Registro_clientes.Size = new System.Drawing.Size(535, 49);
            this.Registro_clientes.TabIndex = 21;
            this.Registro_clientes.Text = "REGISTRO DE CLIENTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Location = new System.Drawing.Point(482, 384);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(149, 42);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.Salir_Registro);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Registro_clientes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button Salir_Registro;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label Documento;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Registro_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}