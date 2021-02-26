
namespace lab02
{
    partial class Operaciones
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
            this.lblTABLATITULO = new System.Windows.Forms.Label();
            this.lblUsuarioAc = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblNombProd = new System.Windows.Forms.Label();
            this.lblPrecProd = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtBIva = new System.Windows.Forms.TextBox();
            this.DtgvTabla = new System.Windows.Forms.DataGridView();
            this.txtPrecProd = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.Producto = new System.Windows.Forms.Label();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.txtNomPro = new System.Windows.Forms.TextBox();
            this.lblTsI = new System.Windows.Forms.Label();
            this.lblIvaAg = new System.Windows.Forms.Label();
            this.lblTotSd = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblTotSinIva = new System.Windows.Forms.Label();
            this.lblIvaaAg = new System.Windows.Forms.Label();
            this.lblTotsdIincl = new System.Windows.Forms.Label();
            this.lblTotalPa = new System.Windows.Forms.Label();
            this.ACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTABLATITULO
            // 
            this.lblTABLATITULO.AutoSize = true;
            this.lblTABLATITULO.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTABLATITULO.Location = new System.Drawing.Point(149, 54);
            this.lblTABLATITULO.Name = "lblTABLATITULO";
            this.lblTABLATITULO.Size = new System.Drawing.Size(274, 26);
            this.lblTABLATITULO.TabIndex = 0;
            this.lblTABLATITULO.Text = "TABLA DE DESCUENTOS";
            this.lblTABLATITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTABLATITULO.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsuarioAc
            // 
            this.lblUsuarioAc.AutoSize = true;
            this.lblUsuarioAc.Location = new System.Drawing.Point(629, 9);
            this.lblUsuarioAc.Name = "lblUsuarioAc";
            this.lblUsuarioAc.Size = new System.Drawing.Size(76, 13);
            this.lblUsuarioAc.TabIndex = 1;
            this.lblUsuarioAc.Text = "Usuario Actual";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(670, 37);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(35, 13);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "label1";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(39, 246);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 13);
            this.lblIVA.TabIndex = 3;
            this.lblIVA.Text = "IVA";
            // 
            // lblNombProd
            // 
            this.lblNombProd.AutoSize = true;
            this.lblNombProd.Location = new System.Drawing.Point(39, 284);
            this.lblNombProd.Name = "lblNombProd";
            this.lblNombProd.Size = new System.Drawing.Size(107, 13);
            this.lblNombProd.TabIndex = 4;
            this.lblNombProd.Text = "Nombre del Producto";
            // 
            // lblPrecProd
            // 
            this.lblPrecProd.AutoSize = true;
            this.lblPrecProd.Location = new System.Drawing.Point(39, 336);
            this.lblPrecProd.Name = "lblPrecProd";
            this.lblPrecProd.Size = new System.Drawing.Size(99, 13);
            this.lblPrecProd.TabIndex = 5;
            this.lblPrecProd.Text = "Precio del producto";
            this.lblPrecProd.Click += new System.EventHandler(this.lblPrecProd_Click);
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(39, 399);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 6;
            this.lblCant.Text = "Cantidad";
            // 
            // txtBIva
            // 
            this.txtBIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBIva.Location = new System.Drawing.Point(166, 239);
            this.txtBIva.Name = "txtBIva";
            this.txtBIva.Size = new System.Drawing.Size(212, 20);
            this.txtBIva.TabIndex = 7;
            this.txtBIva.TextChanged += new System.EventHandler(this.txtBIva_TextChanged);
            // 
            // DtgvTabla
            // 
            this.DtgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCION,
            this.REGLA});
            this.DtgvTabla.Location = new System.Drawing.Point(66, 83);
            this.DtgvTabla.Name = "DtgvTabla";
            this.DtgvTabla.Size = new System.Drawing.Size(639, 135);
            this.DtgvTabla.TabIndex = 8;
            this.DtgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtPrecProd
            // 
            this.txtPrecProd.Location = new System.Drawing.Point(166, 336);
            this.txtPrecProd.Name = "txtPrecProd";
            this.txtPrecProd.Size = new System.Drawing.Size(212, 20);
            this.txtPrecProd.TabIndex = 10;
            this.txtPrecProd.TextChanged += new System.EventHandler(this.txtPrecProd_TextChanged);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(166, 392);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(212, 20);
            this.txtCant.TabIndex = 11;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            // 
            // Producto
            // 
            this.Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(459, 221);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 12;
            this.Producto.Text = "Producto";
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(290, 451);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(112, 38);
            this.bttnCalcular.TabIndex = 13;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(169, 290);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(208, 20);
            this.txtNomPro.TabIndex = 14;
            this.txtNomPro.TextChanged += new System.EventHandler(this.txtNomPro_TextChanged);
            // 
            // lblTsI
            // 
            this.lblTsI.AutoSize = true;
            this.lblTsI.Location = new System.Drawing.Point(459, 336);
            this.lblTsI.Name = "lblTsI";
            this.lblTsI.Size = new System.Drawing.Size(64, 13);
            this.lblTsI.TabIndex = 15;
            this.lblTsI.Text = "Total sin iva";
            // 
            // lblIvaAg
            // 
            this.lblIvaAg.AutoSize = true;
            this.lblIvaAg.Location = new System.Drawing.Point(460, 377);
            this.lblIvaAg.Name = "lblIvaAg";
            this.lblIvaAg.Size = new System.Drawing.Size(70, 13);
            this.lblIvaAg.TabIndex = 16;
            this.lblIvaAg.Text = "Iva a agregar";
            // 
            // lblTotSd
            // 
            this.lblTotSd.AutoSize = true;
            this.lblTotSd.Location = new System.Drawing.Point(459, 414);
            this.lblTotSd.Name = "lblTotSd";
            this.lblTotSd.Size = new System.Drawing.Size(186, 13);
            this.lblTotSd.TabIndex = 17;
            this.lblTotSd.Text = "Total sin descuento y con Iva incluido";
            this.lblTotSd.Click += new System.EventHandler(this.lblTotSd_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(459, 451);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(71, 13);
            this.lblT.TabIndex = 18;
            this.lblT.Text = "Total a Pagar";
            // 
            // lblTotSinIva
            // 
            this.lblTotSinIva.AutoSize = true;
            this.lblTotSinIva.Location = new System.Drawing.Point(704, 330);
            this.lblTotSinIva.Name = "lblTotSinIva";
            this.lblTotSinIva.Size = new System.Drawing.Size(35, 13);
            this.lblTotSinIva.TabIndex = 19;
            this.lblTotSinIva.Text = "label1";
            // 
            // lblIvaaAg
            // 
            this.lblIvaaAg.AutoSize = true;
            this.lblIvaaAg.Location = new System.Drawing.Point(704, 377);
            this.lblIvaaAg.Name = "lblIvaaAg";
            this.lblIvaaAg.Size = new System.Drawing.Size(35, 13);
            this.lblIvaaAg.TabIndex = 20;
            this.lblIvaaAg.Text = "label2";
            // 
            // lblTotsdIincl
            // 
            this.lblTotsdIincl.AutoSize = true;
            this.lblTotsdIincl.Location = new System.Drawing.Point(704, 414);
            this.lblTotsdIincl.Name = "lblTotsdIincl";
            this.lblTotsdIincl.Size = new System.Drawing.Size(35, 13);
            this.lblTotsdIincl.TabIndex = 21;
            this.lblTotsdIincl.Text = "label3";
            // 
            // lblTotalPa
            // 
            this.lblTotalPa.AutoSize = true;
            this.lblTotalPa.Location = new System.Drawing.Point(704, 451);
            this.lblTotalPa.Name = "lblTotalPa";
            this.lblTotalPa.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPa.TabIndex = 22;
            this.lblTotalPa.Text = "label4";
            // 
            // ACCION
            // 
            this.ACCION.HeaderText = "ACCION";
            this.ACCION.Name = "ACCION";
            // 
            // REGLA
            // 
            this.REGLA.HeaderText = "REGLA";
            this.REGLA.Name = "REGLA";
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.lblTotalPa);
            this.Controls.Add(this.lblTotsdIincl);
            this.Controls.Add(this.lblIvaaAg);
            this.Controls.Add(this.lblTotSinIva);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblTotSd);
            this.Controls.Add(this.lblIvaAg);
            this.Controls.Add(this.lblTsI);
            this.Controls.Add(this.txtNomPro);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtPrecProd);
            this.Controls.Add(this.DtgvTabla);
            this.Controls.Add(this.txtBIva);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblPrecProd);
            this.Controls.Add(this.lblNombProd);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.lblUsuarioAc);
            this.Controls.Add(this.lblTABLATITULO);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Operaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTABLATITULO;
        private System.Windows.Forms.Label lblUsuarioAc;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblNombProd;
        private System.Windows.Forms.Label lblPrecProd;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox txtBIva;
        private System.Windows.Forms.DataGridView DtgvTabla;
        private System.Windows.Forms.TextBox txtPrecProd;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.TextBox txtNomPro;
        private System.Windows.Forms.Label lblTsI;
        private System.Windows.Forms.Label lblIvaAg;
        private System.Windows.Forms.Label lblTotSd;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblTotSinIva;
        private System.Windows.Forms.Label lblIvaaAg;
        private System.Windows.Forms.Label lblTotsdIincl;
        private System.Windows.Forms.Label lblTotalPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGLA;
    }
}

