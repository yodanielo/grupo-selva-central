namespace gselvacentral.formularios
{
    partial class frmcabiarcontrasena
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcabiarcontrasena));
            this.uv = new Infragistics.Win.Misc.UltraValidator(this.components);
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtanterior = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtpass1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Location = new System.Drawing.Point(398, 53);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "&Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(479, 53);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtanterior
            // 
            this.txtanterior.Location = new System.Drawing.Point(149, 27);
            this.txtanterior.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtanterior.Name = "txtanterior";
            this.txtanterior.Size = new System.Drawing.Size(127, 20);
            this.txtanterior.TabIndex = 1;
            this.txtanterior.UseSystemPasswordChar = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(149, 11);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 13);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Password anterior:";
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(427, 27);
            this.txtpass2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(127, 20);
            this.txtpass2.TabIndex = 3;
            this.txtpass2.UseSystemPasswordChar = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(427, 11);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(113, 13);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Confirme su password:";
            // 
            // txtpass1
            // 
            this.txtpass1.Location = new System.Drawing.Point(288, 27);
            this.txtpass1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(127, 20);
            this.txtpass1.TabIndex = 2;
            this.txtpass1.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(288, 11);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 13);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Nuevo Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(10, 27);
            this.txtuser.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(127, 20);
            this.txtuser.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Usuario:";
            // 
            // frmcabiarcontrasena
            // 
            this.AcceptButton = this.btnaceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(565, 87);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtanterior);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtpass2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtpass1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcabiarcontrasena";
            this.Text = "Cambiar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.uv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Infragistics.Win.Misc.UltraValidator uv;
        internal System.Windows.Forms.Button btnaceptar;
        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.TextBox txtanterior;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtpass2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtpass1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtuser;
        internal System.Windows.Forms.Label Label1;
    }
}