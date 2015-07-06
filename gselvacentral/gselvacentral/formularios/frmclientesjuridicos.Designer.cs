namespace gselvacentral.formularios
{
    partial class frmclientesjuridicos
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclientesjuridicos));
            this.txtrepresentante = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnhacercomprobante = new System.Windows.Forms.Button();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.btnhacercomprobante);
            this.ultraGroupBox1.Controls.Add(this.txtrepresentante);
            this.ultraGroupBox1.Controls.Add(this.Label5);
            this.ultraGroupBox1.Controls.Add(this.txtruc);
            this.ultraGroupBox1.Controls.Add(this.Label3);
            this.ultraGroupBox1.Controls.Add(this.txtrazonsocial);
            this.ultraGroupBox1.Controls.Add(this.Label4);
            this.ultraGroupBox1.Size = new System.Drawing.Size(378, 87);
            this.ultraGroupBox1.Text = "Formulario de Clientes Jurídicos";
            this.ultraGroupBox1.Controls.SetChildIndex(this.btnnuevo, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.btncancelar, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.btnguardar, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.Label4, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.txtrazonsocial, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.Label3, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.txtruc, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.Label5, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.txtrepresentante, 0);
            this.ultraGroupBox1.Controls.SetChildIndex(this.btnhacercomprobante, 0);
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Location = new System.Drawing.Point(12, 105);
            this.ultraGroupBox2.Size = new System.Drawing.Size(768, 279);
            // 
            // grilla
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grilla.DisplayLayout.Appearance = appearance1;
            this.grilla.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grilla.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.grilla.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grilla.DisplayLayout.GroupByBox.Prompt = "Arrastra una cabecera para agrupar por columnas";
            this.grilla.DisplayLayout.MaxColScrollRegions = 1;
            this.grilla.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            appearance2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grilla.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.Highlight;
            appearance3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grilla.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.grilla.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grilla.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            this.grilla.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BorderColor = System.Drawing.Color.Silver;
            appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grilla.DisplayLayout.Override.CellAppearance = appearance5;
            this.grilla.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.grilla.DisplayLayout.Override.CellPadding = 0;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.grilla.DisplayLayout.Override.GroupByRowAppearance = appearance6;
            appearance7.TextHAlignAsString = "Left";
            this.grilla.DisplayLayout.Override.HeaderAppearance = appearance7;
            this.grilla.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.grilla.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            this.grilla.DisplayLayout.Override.RowAppearance = appearance8;
            this.grilla.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grilla.DisplayLayout.Override.TemplateAddRowAppearance = appearance9;
            this.grilla.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grilla.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grilla.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.grilla.Size = new System.Drawing.Size(758, 253);
            this.grilla.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.grilla_AfterSelectChange);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.Location = new System.Drawing.Point(168, 59);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(87, 59);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Location = new System.Drawing.Point(6, 59);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // uv
            // 
            this.uv.NotificationSettings.Action = Infragistics.Win.Misc.NotificationAction.None;
            // 
            // txtrepresentante
            // 
            this.txtrepresentante.Location = new System.Drawing.Point(232, 37);
            this.txtrepresentante.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtrepresentante.Name = "txtrepresentante";
            this.txtrepresentante.Size = new System.Drawing.Size(140, 20);
            this.txtrepresentante.TabIndex = 2;
            this.uv.GetValidationSettings(this.txtrepresentante).IsRequired = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(229, 21);
            this.Label5.Margin = new System.Windows.Forms.Padding(3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 13);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "Representante:";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(120, 37);
            this.txtruc.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(100, 20);
            this.txtruc.TabIndex = 1;
            this.uv.GetValidationSettings(this.txtruc).Condition = new Infragistics.Win.RangeCondition("9999999999", ((long)(99999999999)), typeof(double));
            this.uv.GetValidationSettings(this.txtruc).IsRequired = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(117, 21);
            this.Label3.Margin = new System.Windows.Forms.Padding(3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(33, 13);
            this.Label3.TabIndex = 72;
            this.Label3.Text = "RUC:";
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(8, 37);
            this.txtrazonsocial.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(100, 20);
            this.txtrazonsocial.TabIndex = 0;
            this.uv.GetValidationSettings(this.txtrazonsocial).IsRequired = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(5, 21);
            this.Label4.Margin = new System.Windows.Forms.Padding(3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 13);
            this.Label4.TabIndex = 70;
            this.Label4.Text = "Razon Social:";
            // 
            // btnhacercomprobante
            // 
            this.btnhacercomprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhacercomprobante.Location = new System.Drawing.Point(249, 59);
            this.btnhacercomprobante.Name = "btnhacercomprobante";
            this.btnhacercomprobante.Size = new System.Drawing.Size(124, 23);
            this.btnhacercomprobante.TabIndex = 6;
            this.btnhacercomprobante.Text = "Hacer Comprobante";
            this.btnhacercomprobante.UseVisualStyleBackColor = true;
            this.btnhacercomprobante.Click += new System.EventHandler(this.btnhacercomprobante_Click);
            // 
            // ultraDataSource1
            // 
            this.ultraDataSource1.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.True;
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Controls.Add(this.TextBox1);
            this.ultraGroupBox3.Controls.Add(this.TextBox3);
            this.ultraGroupBox3.Controls.Add(this.Label1);
            this.ultraGroupBox3.Controls.Add(this.Label6);
            this.ultraGroupBox3.Controls.Add(this.TextBox2);
            this.ultraGroupBox3.Controls.Add(this.Label2);
            this.ultraGroupBox3.Location = new System.Drawing.Point(396, 12);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(344, 87);
            this.ultraGroupBox3.TabIndex = 8;
            this.ultraGroupBox3.Text = "Buscar";
            this.ultraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(232, 37);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 65;
            this.TextBox1.Tag = "jurrepresentante";
            this.TextBox1.TextChanged += new System.EventHandler(this.filtrar_changed);
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(8, 37);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 63;
            this.TextBox3.Tag = "jurrazonsocial";
            this.TextBox3.TextChanged += new System.EventHandler(this.filtrar_changed);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(229, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 13);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Representante:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(5, 21);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(73, 13);
            this.Label6.TabIndex = 66;
            this.Label6.Text = "Razon Social:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(120, 37);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 64;
            this.TextBox2.Tag = "cliruc";
            this.TextBox2.TextChanged += new System.EventHandler(this.filtrar_changed);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(117, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 67;
            this.Label2.Text = "RUC:";
            // 
            // frmclientesjuridicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 396);
            this.Controls.Add(this.ultraGroupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmclientesjuridicos";
            this.Text = "Clientes Jurídicos";
            this.Controls.SetChildIndex(this.ultraGroupBox1, 0);
            this.Controls.SetChildIndex(this.ultraGroupBox3, 0);
            this.Controls.SetChildIndex(this.ultraGroupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            this.ultraGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtrepresentante;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtruc;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtrazonsocial;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Button btnhacercomprobante;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        internal Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
    }
}
