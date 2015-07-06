namespace gselvacentral.formularios
{
    partial class frmcomprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcomprobante));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.txtremision = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbunidad = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdirremitente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbtipcomprobante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdirdestinatario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrucdestinatario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomdestinatario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrucremitente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdfecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomremitente = new System.Windows.Forms.TextBox();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grdpunitario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.grdpeso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.grdcodigo = new System.Windows.Forms.TextBox();
            this.grdcantidad = new System.Windows.Forms.TextBox();
            this.grddescripcion = new System.Windows.Forms.TextBox();
            this.grdumedida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.dencodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dendescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dencantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denpreciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new Infragistics.Win.Misc.UltraValidator(this.components);
            this.uv2 = new Infragistics.Win.Misc.UltraValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv2)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.txtremision);
            this.ultraGroupBox1.Controls.Add(this.label16);
            this.ultraGroupBox1.Controls.Add(this.label13);
            this.ultraGroupBox1.Controls.Add(this.cbunidad);
            this.ultraGroupBox1.Controls.Add(this.btnguardar);
            this.ultraGroupBox1.Controls.Add(this.btncancelar);
            this.ultraGroupBox1.Controls.Add(this.btnnuevo);
            this.ultraGroupBox1.Controls.Add(this.label12);
            this.ultraGroupBox1.Controls.Add(this.txtdirremitente);
            this.ultraGroupBox1.Controls.Add(this.label7);
            this.ultraGroupBox1.Controls.Add(this.cmbtipcomprobante);
            this.ultraGroupBox1.Controls.Add(this.label6);
            this.ultraGroupBox1.Controls.Add(this.txtdirdestinatario);
            this.ultraGroupBox1.Controls.Add(this.label4);
            this.ultraGroupBox1.Controls.Add(this.txtrucdestinatario);
            this.ultraGroupBox1.Controls.Add(this.label5);
            this.ultraGroupBox1.Controls.Add(this.txtnomdestinatario);
            this.ultraGroupBox1.Controls.Add(this.label3);
            this.ultraGroupBox1.Controls.Add(this.txtrucremitente);
            this.ultraGroupBox1.Controls.Add(this.label1);
            this.ultraGroupBox1.Controls.Add(this.cmdfecha);
            this.ultraGroupBox1.Controls.Add(this.label2);
            this.ultraGroupBox1.Controls.Add(this.txtnomremitente);
            this.ultraGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(519, 209);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "Cabecera del Comprobante de Pago";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // txtremision
            // 
            this.txtremision.Location = new System.Drawing.Point(367, 37);
            this.txtremision.Name = "txtremision";
            this.txtremision.Size = new System.Drawing.Size(145, 20);
            this.txtremision.TabIndex = 57;
            this.uv.GetValidationSettings(this.txtremision).Condition = new Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.GreaterThan, 0, true, typeof(double));
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(364, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Guia de Remisión";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(364, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Unidad de Transporte";
            // 
            // cbunidad
            // 
            this.cbunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunidad.FormattingEnabled = true;
            this.cbunidad.Items.AddRange(new object[] {
            "Boleta",
            "Factura",
            "Orden de despacho"});
            this.cbunidad.Location = new System.Drawing.Point(367, 75);
            this.cbunidad.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cbunidad.Name = "cbunidad";
            this.cbunidad.Size = new System.Drawing.Size(145, 21);
            this.cbunidad.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(397, 180);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(115, 23);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "&Guardar e Imprimir";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(316, 180);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(235, 180);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Teléfono:";
            // 
            // txtdirremitente
            // 
            this.txtdirremitente.Location = new System.Drawing.Point(275, 155);
            this.txtdirremitente.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtdirremitente.Name = "txtdirremitente";
            this.txtdirremitente.Size = new System.Drawing.Size(80, 20);
            this.txtdirremitente.TabIndex = 5;
            this.uv.GetValidationSettings(this.txtdirremitente).IsRequired = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo de comprobante:";
            // 
            // cmbtipcomprobante
            // 
            this.cmbtipcomprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipcomprobante.FormattingEnabled = true;
            this.cmbtipcomprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmbtipcomprobante.Location = new System.Drawing.Point(11, 37);
            this.cmbtipcomprobante.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cmbtipcomprobante.Name = "cmbtipcomprobante";
            this.cmbtipcomprobante.Size = new System.Drawing.Size(121, 21);
            this.cmbtipcomprobante.TabIndex = 0;
            this.uv.GetValidationSettings(this.cmbtipcomprobante).IsRequired = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Dirección:";
            // 
            // txtdirdestinatario
            // 
            this.txtdirdestinatario.Location = new System.Drawing.Point(11, 155);
            this.txtdirdestinatario.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtdirdestinatario.Name = "txtdirdestinatario";
            this.txtdirdestinatario.Size = new System.Drawing.Size(252, 20);
            this.txtdirdestinatario.TabIndex = 8;
            this.uv.GetValidationSettings(this.txtdirdestinatario).IsRequired = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "RUC:";
            // 
            // txtrucdestinatario
            // 
            this.txtrucdestinatario.Location = new System.Drawing.Point(275, 115);
            this.txtrucdestinatario.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtrucdestinatario.Name = "txtrucdestinatario";
            this.txtrucdestinatario.Size = new System.Drawing.Size(80, 20);
            this.txtrucdestinatario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Destinatario:";
            // 
            // txtnomdestinatario
            // 
            this.txtnomdestinatario.Location = new System.Drawing.Point(11, 115);
            this.txtnomdestinatario.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtnomdestinatario.Name = "txtnomdestinatario";
            this.txtnomdestinatario.Size = new System.Drawing.Size(252, 20);
            this.txtnomdestinatario.TabIndex = 6;
            this.uv.GetValidationSettings(this.txtnomdestinatario).IsRequired = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "RUC:";
            // 
            // txtrucremitente
            // 
            this.txtrucremitente.Location = new System.Drawing.Point(275, 76);
            this.txtrucremitente.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtrucremitente.Name = "txtrucremitente";
            this.txtrucremitente.ReadOnly = true;
            this.txtrucremitente.Size = new System.Drawing.Size(80, 20);
            this.txtrucremitente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Fecha:";
            // 
            // cmdfecha
            // 
            this.cmdfecha.Enabled = false;
            this.cmdfecha.Location = new System.Drawing.Point(144, 38);
            this.cmdfecha.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cmdfecha.Name = "cmdfecha";
            this.cmdfecha.Size = new System.Drawing.Size(211, 20);
            this.cmdfecha.TabIndex = 1;
            this.uv.GetValidationSettings(this.cmdfecha).IsRequired = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Remitente:";
            // 
            // txtnomremitente
            // 
            this.txtnomremitente.Location = new System.Drawing.Point(11, 76);
            this.txtnomremitente.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtnomremitente.Name = "txtnomremitente";
            this.txtnomremitente.ReadOnly = true;
            this.txtnomremitente.Size = new System.Drawing.Size(252, 20);
            this.txtnomremitente.TabIndex = 3;
            this.uv.GetValidationSettings(this.txtnomremitente).IsRequired = true;
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGroupBox2.Controls.Add(this.grdpunitario);
            this.ultraGroupBox2.Controls.Add(this.label15);
            this.ultraGroupBox2.Controls.Add(this.grdpeso);
            this.ultraGroupBox2.Controls.Add(this.label14);
            this.ultraGroupBox2.Controls.Add(this.button5);
            this.ultraGroupBox2.Controls.Add(this.grdcodigo);
            this.ultraGroupBox2.Controls.Add(this.grdcantidad);
            this.ultraGroupBox2.Controls.Add(this.grddescripcion);
            this.ultraGroupBox2.Controls.Add(this.grdumedida);
            this.ultraGroupBox2.Controls.Add(this.label11);
            this.ultraGroupBox2.Controls.Add(this.label10);
            this.ultraGroupBox2.Controls.Add(this.label9);
            this.ultraGroupBox2.Controls.Add(this.label8);
            this.ultraGroupBox2.Controls.Add(this.dgvdetalle);
            this.ultraGroupBox2.Location = new System.Drawing.Point(12, 227);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(734, 327);
            this.ultraGroupBox2.TabIndex = 1;
            this.ultraGroupBox2.Text = "Detalle del comprobante";
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003;
            // 
            // grdpunitario
            // 
            this.grdpunitario.Location = new System.Drawing.Point(417, 44);
            this.grdpunitario.Name = "grdpunitario";
            this.grdpunitario.Size = new System.Drawing.Size(68, 20);
            this.grdpunitario.TabIndex = 5;
            this.uv.GetValidationSettings(this.grdpunitario).Enabled = false;
            this.uv2.GetValidationSettings(this.grdpunitario).IsRequired = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(414, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "P. Unitario:";
            // 
            // grdpeso
            // 
            this.grdpeso.Location = new System.Drawing.Point(269, 44);
            this.grdpeso.Name = "grdpeso";
            this.grdpeso.Size = new System.Drawing.Size(68, 20);
            this.grdpeso.TabIndex = 3;
            this.uv.GetValidationSettings(this.grdpeso).Enabled = false;
            this.uv2.GetValidationSettings(this.grdpeso).IsRequired = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Peso Total:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(500, 43);
            this.button5.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Actualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // grdcodigo
            // 
            this.grdcodigo.Location = new System.Drawing.Point(11, 44);
            this.grdcodigo.Name = "grdcodigo";
            this.grdcodigo.Size = new System.Drawing.Size(63, 20);
            this.grdcodigo.TabIndex = 0;
            this.uv.GetValidationSettings(this.grdcodigo).Enabled = false;
            this.uv2.GetValidationSettings(this.grdcodigo).IsRequired = true;
            // 
            // grdcantidad
            // 
            this.grdcantidad.Location = new System.Drawing.Point(81, 44);
            this.grdcantidad.Name = "grdcantidad";
            this.grdcantidad.Size = new System.Drawing.Size(65, 20);
            this.grdcantidad.TabIndex = 1;
            this.uv.GetValidationSettings(this.grdcantidad).Enabled = false;
            this.uv2.GetValidationSettings(this.grdcantidad).IsRequired = true;
            // 
            // grddescripcion
            // 
            this.grddescripcion.Location = new System.Drawing.Point(152, 44);
            this.grddescripcion.Name = "grddescripcion";
            this.grddescripcion.Size = new System.Drawing.Size(111, 20);
            this.grddescripcion.TabIndex = 2;
            this.uv.GetValidationSettings(this.grddescripcion).Enabled = false;
            this.uv2.GetValidationSettings(this.grddescripcion).IsRequired = true;
            // 
            // grdumedida
            // 
            this.grdumedida.Location = new System.Drawing.Point(343, 43);
            this.grdumedida.Name = "grdumedida";
            this.grdumedida.Size = new System.Drawing.Size(68, 20);
            this.grdumedida.TabIndex = 4;
            this.uv.GetValidationSettings(this.grdumedida).Enabled = false;
            this.uv2.GetValidationSettings(this.grdumedida).IsRequired = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "U. Medida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Código:";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dencodigo,
            this.dendescripcion,
            this.dencantidad,
            this.peso,
            this.umedida,
            this.denpreciounitario,
            this.denimporte});
            this.dgvdetalle.Location = new System.Drawing.Point(8, 70);
            this.dgvdetalle.MultiSelect = false;
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.ShowEditingIcon = false;
            this.dgvdetalle.Size = new System.Drawing.Size(721, 252);
            this.dgvdetalle.TabIndex = 17;
            // 
            // dencodigo
            // 
            this.dencodigo.HeaderText = "Código";
            this.dencodigo.Name = "dencodigo";
            this.dencodigo.ReadOnly = true;
            this.dencodigo.Width = 65;
            // 
            // dendescripcion
            // 
            this.dendescripcion.HeaderText = "Descripción";
            this.dendescripcion.Name = "dendescripcion";
            this.dendescripcion.ReadOnly = true;
            this.dendescripcion.Width = 88;
            // 
            // dencantidad
            // 
            this.dencantidad.HeaderText = "Cantidad";
            this.dencantidad.Name = "dencantidad";
            this.dencantidad.ReadOnly = true;
            this.dencantidad.Width = 74;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso Total";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 83;
            // 
            // umedida
            // 
            this.umedida.HeaderText = "U. de Medida";
            this.umedida.Name = "umedida";
            this.umedida.ReadOnly = true;
            this.umedida.Width = 96;
            // 
            // denpreciounitario
            // 
            this.denpreciounitario.HeaderText = "P. Unitario";
            this.denpreciounitario.Name = "denpreciounitario";
            this.denpreciounitario.ReadOnly = true;
            this.denpreciounitario.Width = 81;
            // 
            // denimporte
            // 
            this.denimporte.HeaderText = "Importe";
            this.denimporte.Name = "denimporte";
            this.denimporte.ReadOnly = true;
            this.denimporte.Width = 67;
            // 
            // frmcomprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 566);
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcomprobante";
            this.Text = "Comprobante de Pago";
            this.Load += new System.EventHandler(this.frmcomprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdirremitente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbtipcomprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdirdestinatario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrucdestinatario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomdestinatario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrucremitente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cmdfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomremitente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox grdcodigo;
        private System.Windows.Forms.TextBox grdcantidad;
        private System.Windows.Forms.TextBox grddescripcion;
        private System.Windows.Forms.TextBox grdumedida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private Infragistics.Win.Misc.UltraValidator uv;
        private Infragistics.Win.Misc.UltraValidator uv2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dencodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dendescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dencantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn umedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn denpreciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn denimporte;
        private System.Windows.Forms.TextBox grdpunitario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox grdpeso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtremision;
    }
}