namespace administrador
{
    partial class frmprincipal
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
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btncerrarsession = new System.Windows.Forms.ToolStripButton();
            this.btncerrarcesion = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnseries = new System.Windows.Forms.ToolStripButton();
            this.btningresos = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnadministradores = new System.Windows.Forms.ToolStripButton();
            this.btncamioneros = new System.Windows.Forms.ToolStripButton();
            this.btnunidades = new System.Windows.Forms.ToolStripButton();
            this.btnclientes = new System.Windows.Forms.ToolStripSplitButton();
            this.PersonasNaturalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonasJurídicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnasignacioncarga = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnacercade = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncerrarsession,
            this.btncerrarcesion,
            this.ToolStripSeparator1,
            this.btnseries,
            this.btningresos,
            this.ToolStripSeparator2,
            this.btnadministradores,
            this.btncamioneros,
            this.btnunidades,
            this.btnclientes,
            this.ToolStripSeparator3,
            this.btnasignacioncarga,
            this.ToolStripSeparator4,
            this.btnacercade});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1053, 54);
            this.ToolStrip1.TabIndex = 3;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btncerrarsession
            // 
            this.btncerrarsession.Image = global::administrador.Properties.Resources.gnome_logout;
            this.btncerrarsession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncerrarsession.Name = "btncerrarsession";
            this.btncerrarsession.Size = new System.Drawing.Size(80, 51);
            this.btncerrarsession.Text = "Cerrar cesión";
            this.btncerrarsession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btncerrarcesion
            // 
            this.btncerrarcesion.Image = global::administrador.Properties.Resources.Keychain_Access;
            this.btncerrarcesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncerrarcesion.Name = "btncerrarcesion";
            this.btncerrarcesion.Size = new System.Drawing.Size(117, 51);
            this.btncerrarcesion.Text = "Cambiar contraseña";
            this.btncerrarcesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnseries
            // 
            this.btnseries.Image = global::administrador.Properties.Resources.Sales_by_Payment_Method_rep;
            this.btnseries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnseries.Name = "btnseries";
            this.btnseries.Size = new System.Drawing.Size(137, 51);
            this.btnseries.Text = "Series de comprobantes";
            this.btnseries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btningresos
            // 
            this.btningresos.Image = global::administrador.Properties.Resources.applications_utilities;
            this.btningresos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btningresos.Name = "btningresos";
            this.btningresos.Size = new System.Drawing.Size(120, 51);
            this.btningresos.Text = "Ingresos por periodo";
            this.btningresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btningresos.Visible = false;
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnadministradores
            // 
            this.btnadministradores.Image = global::administrador.Properties.Resources.people;
            this.btnadministradores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadministradores.Name = "btnadministradores";
            this.btnadministradores.Size = new System.Drawing.Size(118, 51);
            this.btnadministradores.Text = "Usuarios del sistema";
            this.btnadministradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btncamioneros
            // 
            this.btncamioneros.Image = global::administrador.Properties.Resources.personal;
            this.btncamioneros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncamioneros.Name = "btncamioneros";
            this.btncamioneros.Size = new System.Drawing.Size(75, 51);
            this.btncamioneros.Text = "Camioneros";
            this.btncamioneros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnunidades
            // 
            this.btnunidades.Image = global::administrador.Properties.Resources.truck;
            this.btnunidades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnunidades.Name = "btnunidades";
            this.btnunidades.Size = new System.Drawing.Size(133, 51);
            this.btnunidades.Text = "Unidades de transporte";
            this.btnunidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnclientes
            // 
            this.btnclientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonasNaturalesToolStripMenuItem,
            this.PersonasJurídicasToolStripMenuItem});
            this.btnclientes.Image = global::administrador.Properties.Resources.clients;
            this.btnclientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(65, 51);
            this.btnclientes.Text = "Clientes";
            this.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // PersonasNaturalesToolStripMenuItem
            // 
            this.PersonasNaturalesToolStripMenuItem.Name = "PersonasNaturalesToolStripMenuItem";
            this.PersonasNaturalesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.PersonasNaturalesToolStripMenuItem.Text = "Personas Naturales";
            // 
            // PersonasJurídicasToolStripMenuItem
            // 
            this.PersonasJurídicasToolStripMenuItem.Name = "PersonasJurídicasToolStripMenuItem";
            this.PersonasJurídicasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.PersonasJurídicasToolStripMenuItem.Text = "Personas Jurídicas";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // btnasignacioncarga
            // 
            this.btnasignacioncarga.Image = global::administrador.Properties.Resources.ark2;
            this.btnasignacioncarga.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnasignacioncarga.Name = "btnasignacioncarga";
            this.btnasignacioncarga.Size = new System.Drawing.Size(118, 51);
            this.btnasignacioncarga.Text = "Asignacion de carga";
            this.btnasignacioncarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // btnacercade
            // 
            this.btnacercade.Image = global::administrador.Properties.Resources.Information;
            this.btnacercade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnacercade.Name = "btnacercade";
            this.btnacercade.Size = new System.Drawing.Size(75, 51);
            this.btnacercade.Text = "Acerca de ...";
            this.btnacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 483);
            this.Controls.Add(this.ToolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmprincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btncerrarsession;
        internal System.Windows.Forms.ToolStripButton btncerrarcesion;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnseries;
        internal System.Windows.Forms.ToolStripButton btningresos;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btnadministradores;
        internal System.Windows.Forms.ToolStripButton btncamioneros;
        internal System.Windows.Forms.ToolStripButton btnunidades;
        internal System.Windows.Forms.ToolStripSplitButton btnclientes;
        internal System.Windows.Forms.ToolStripMenuItem PersonasNaturalesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PersonasJurídicasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton btnasignacioncarga;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton btnacercade;
    }
}

