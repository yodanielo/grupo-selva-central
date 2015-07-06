namespace gselvacentral
{
    partial class padre
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
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(padre));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grilla = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.uv = new Infragistics.Win.Misc.UltraValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.btnguardar);
            this.ultraGroupBox1.Controls.Add(this.btncancelar);
            this.ultraGroupBox1.Controls.Add(this.btnnuevo);
            this.ultraGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(546, 162);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "ultraGroupBox1";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(466, 134);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(385, 134);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(304, 134);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox2.Controls.Add(this.grilla);
            this.ultraGroupBox2.Location = new System.Drawing.Point(12, 180);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(768, 374);
            this.ultraGroupBox2.TabIndex = 1;
            this.ultraGroupBox2.Text = "Seleccione una fila para editarla";
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // grilla
            // 
            this.grilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            appearance4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grilla.DisplayLayout.Appearance = appearance4;
            this.grilla.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grilla.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance1.BorderColor = System.Drawing.SystemColors.Window;
            this.grilla.DisplayLayout.GroupByBox.Appearance = appearance1;
            appearance2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grilla.DisplayLayout.GroupByBox.BandLabelAppearance = appearance2;
            this.grilla.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grilla.DisplayLayout.GroupByBox.Prompt = "Arrastra una cabecera para agrupar por columnas";
            appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackColor2 = System.Drawing.SystemColors.Control;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grilla.DisplayLayout.GroupByBox.PromptAppearance = appearance3;
            this.grilla.DisplayLayout.MaxColScrollRegions = 1;
            this.grilla.DisplayLayout.MaxRowScrollRegions = 1;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grilla.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance7.BackColor = System.Drawing.SystemColors.Highlight;
            appearance7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grilla.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.grilla.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grilla.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            this.grilla.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance5.BorderColor = System.Drawing.Color.Silver;
            appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grilla.DisplayLayout.Override.CellAppearance = appearance5;
            this.grilla.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.grilla.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.grilla.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance11.TextHAlignAsString = "Left";
            this.grilla.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.grilla.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.grilla.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.BorderColor = System.Drawing.Color.Silver;
            this.grilla.DisplayLayout.Override.RowAppearance = appearance10;
            this.grilla.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grilla.DisplayLayout.Override.TemplateAddRowAppearance = appearance8;
            this.grilla.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grilla.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grilla.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.grilla.Location = new System.Drawing.Point(5, 21);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(758, 348);
            this.grilla.TabIndex = 0;
            this.grilla.Text = "ultraGrid1";
            // 
            // uv
            // 
            this.uv.NotificationSettings.Action = Infragistics.Win.Misc.NotificationAction.None;
            // 
            // padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "padre";
            this.Text = "padre";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        public Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        public Infragistics.Win.UltraWinGrid.UltraGrid grilla;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnnuevo;
        public Infragistics.Win.Misc.UltraValidator uv;

    }
}