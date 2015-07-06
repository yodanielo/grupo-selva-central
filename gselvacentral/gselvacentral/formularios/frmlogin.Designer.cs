namespace gselvacentral.formularios
{
    partial class frmlogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gselvacentral.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(258, 97);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(177, 97);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "&Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.Location = new System.Drawing.Point(152, 70);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(181, 21);
            this.txtcontrasena.TabIndex = 1;
            this.txtcontrasena.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(149, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Contraseña:";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(152, 28);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(181, 21);
            this.txtuser.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(149, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Usuario:";
            // 
            // frmlogin
            // 
            this.AcceptButton = this.btningresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(342, 134);
            this.ControlBox = false;
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmlogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingreso de usuario";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.Button btningresar;
        internal System.Windows.Forms.TextBox txtcontrasena;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtuser;
        internal System.Windows.Forms.Label Label1;
    }
}