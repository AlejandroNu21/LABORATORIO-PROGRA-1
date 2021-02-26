
namespace LaboratorioProgramacionUno.VISTA
{
    partial class FrmOperaciones
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
            this.lblTabladeDes = new System.Windows.Forms.Label();
            this.lblUsuac = new System.Windows.Forms.Label();
            this.lblTotalPa = new System.Windows.Forms.Label();
            this.lblTotsdIincl = new System.Windows.Forms.Label();
            this.lblIvaaAg = new System.Windows.Forms.Label();
            this.lblTotSinIva = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblTotSd = new System.Windows.Forms.Label();
            this.lblIvaAg = new System.Windows.Forms.Label();
            this.lblTsI = new System.Windows.Forms.Label();
            this.txtNomPro = new System.Windows.Forms.TextBox();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPrecProd = new System.Windows.Forms.TextBox();
            this.DtgvTabla = new System.Windows.Forms.DataGridView();
            this.ACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBIva = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPrecProd = new System.Windows.Forms.Label();
            this.lblNombProd = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblTABLATITULO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabladeDes
            // 
            this.lblTabladeDes.AutoSize = true;
            this.lblTabladeDes.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabladeDes.Location = new System.Drawing.Point(261, 64);
            this.lblTabladeDes.Name = "lblTabladeDes";
            this.lblTabladeDes.Size = new System.Drawing.Size(274, 26);
            this.lblTabladeDes.TabIndex = 0;
            this.lblTabladeDes.Text = "TABLA DE DESCUENTOS";
            this.lblTabladeDes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTabladeDes.Click += new System.EventHandler(this.lblTabladeDes_Click);
            // 
            // lblUsuac
            // 
            this.lblUsuac.AutoSize = true;
            this.lblUsuac.Location = new System.Drawing.Point(662, 8);
            this.lblUsuac.Name = "lblUsuac";
            this.lblUsuac.Size = new System.Drawing.Size(76, 13);
            this.lblUsuac.TabIndex = 1;
            this.lblUsuac.Text = "Usuario Actual";
            // 
            // lblTotalPa
            // 
            this.lblTotalPa.AutoSize = true;
            this.lblTotalPa.Location = new System.Drawing.Point(715, 413);
            this.lblTotalPa.Name = "lblTotalPa";
            this.lblTotalPa.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPa.TabIndex = 43;
            this.lblTotalPa.Text = "label4";
            this.lblTotalPa.Click += new System.EventHandler(this.lblTotalPa_Click);
            // 
            // lblTotsdIincl
            // 
            this.lblTotsdIincl.AutoSize = true;
            this.lblTotsdIincl.Location = new System.Drawing.Point(715, 376);
            this.lblTotsdIincl.Name = "lblTotsdIincl";
            this.lblTotsdIincl.Size = new System.Drawing.Size(35, 13);
            this.lblTotsdIincl.TabIndex = 42;
            this.lblTotsdIincl.Text = "label3";
            this.lblTotsdIincl.Click += new System.EventHandler(this.lblTotsdIincl_Click);
            // 
            // lblIvaaAg
            // 
            this.lblIvaaAg.AutoSize = true;
            this.lblIvaaAg.Location = new System.Drawing.Point(715, 339);
            this.lblIvaaAg.Name = "lblIvaaAg";
            this.lblIvaaAg.Size = new System.Drawing.Size(35, 13);
            this.lblIvaaAg.TabIndex = 41;
            this.lblIvaaAg.Text = "label2";
            this.lblIvaaAg.Click += new System.EventHandler(this.lblIvaaAg_Click);
            // 
            // lblTotSinIva
            // 
            this.lblTotSinIva.AutoSize = true;
            this.lblTotSinIva.Location = new System.Drawing.Point(715, 292);
            this.lblTotSinIva.Name = "lblTotSinIva";
            this.lblTotSinIva.Size = new System.Drawing.Size(35, 13);
            this.lblTotSinIva.TabIndex = 40;
            this.lblTotSinIva.Text = "label1";
            this.lblTotSinIva.Click += new System.EventHandler(this.lblTotSinIva_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(470, 413);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(71, 13);
            this.lblT.TabIndex = 39;
            this.lblT.Text = "Total a Pagar";
            this.lblT.Click += new System.EventHandler(this.lblT_Click);
            // 
            // lblTotSd
            // 
            this.lblTotSd.AutoSize = true;
            this.lblTotSd.Location = new System.Drawing.Point(470, 376);
            this.lblTotSd.Name = "lblTotSd";
            this.lblTotSd.Size = new System.Drawing.Size(186, 13);
            this.lblTotSd.TabIndex = 38;
            this.lblTotSd.Text = "Total sin descuento y con Iva incluido";
            this.lblTotSd.Click += new System.EventHandler(this.lblTotSd_Click);
            // 
            // lblIvaAg
            // 
            this.lblIvaAg.AutoSize = true;
            this.lblIvaAg.Location = new System.Drawing.Point(471, 339);
            this.lblIvaAg.Name = "lblIvaAg";
            this.lblIvaAg.Size = new System.Drawing.Size(70, 13);
            this.lblIvaAg.TabIndex = 37;
            this.lblIvaAg.Text = "Iva a agregar";
            this.lblIvaAg.Click += new System.EventHandler(this.lblIvaAg_Click);
            // 
            // lblTsI
            // 
            this.lblTsI.AutoSize = true;
            this.lblTsI.Location = new System.Drawing.Point(470, 298);
            this.lblTsI.Name = "lblTsI";
            this.lblTsI.Size = new System.Drawing.Size(64, 13);
            this.lblTsI.TabIndex = 36;
            this.lblTsI.Text = "Total sin iva";
            this.lblTsI.Click += new System.EventHandler(this.lblTsI_Click);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(177, 285);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(208, 20);
            this.txtNomPro.TabIndex = 35;
            this.txtNomPro.TextChanged += new System.EventHandler(this.txtNomPro_TextChanged);
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(301, 413);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(112, 38);
            this.bttnCalcular.TabIndex = 34;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // Producto
            // 
            this.Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(471, 208);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 33;
            this.Producto.Text = "Producto";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(177, 376);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(212, 20);
            this.txtCant.TabIndex = 32;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            // 
            // txtPrecProd
            // 
            this.txtPrecProd.Location = new System.Drawing.Point(177, 332);
            this.txtPrecProd.Name = "txtPrecProd";
            this.txtPrecProd.Size = new System.Drawing.Size(212, 20);
            this.txtPrecProd.TabIndex = 31;
            this.txtPrecProd.TextChanged += new System.EventHandler(this.txtPrecProd_TextChanged);
            // 
            // DtgvTabla
            // 
            this.DtgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCION,
            this.REGLA});
            this.DtgvTabla.Location = new System.Drawing.Point(77, 64);
            this.DtgvTabla.Name = "DtgvTabla";
            this.DtgvTabla.Size = new System.Drawing.Size(639, 135);
            this.DtgvTabla.TabIndex = 30;
            this.DtgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvTabla_CellContentClick);
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
            // txtBIva
            // 
            this.txtBIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBIva.Location = new System.Drawing.Point(177, 238);
            this.txtBIva.Name = "txtBIva";
            this.txtBIva.Size = new System.Drawing.Size(208, 20);
            this.txtBIva.TabIndex = 29;
            this.txtBIva.TextChanged += new System.EventHandler(this.txtBIva_TextChanged);
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(50, 376);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 28;
            this.lblCant.Text = "Cantidad";
            this.lblCant.Click += new System.EventHandler(this.lblCant_Click);
            // 
            // lblPrecProd
            // 
            this.lblPrecProd.AutoSize = true;
            this.lblPrecProd.Location = new System.Drawing.Point(50, 332);
            this.lblPrecProd.Name = "lblPrecProd";
            this.lblPrecProd.Size = new System.Drawing.Size(99, 13);
            this.lblPrecProd.TabIndex = 27;
            this.lblPrecProd.Text = "Precio del producto";
            this.lblPrecProd.Click += new System.EventHandler(this.lblPrecProd_Click);
            // 
            // lblNombProd
            // 
            this.lblNombProd.AutoSize = true;
            this.lblNombProd.Location = new System.Drawing.Point(50, 285);
            this.lblNombProd.Name = "lblNombProd";
            this.lblNombProd.Size = new System.Drawing.Size(107, 13);
            this.lblNombProd.TabIndex = 26;
            this.lblNombProd.Text = "Nombre del Producto";
            this.lblNombProd.Click += new System.EventHandler(this.lblNombProd_Click);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(50, 238);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 13);
            this.lblIVA.TabIndex = 25;
            this.lblIVA.Text = "IVA";
            this.lblIVA.Click += new System.EventHandler(this.lblIVA_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(681, 29);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(35, 13);
            this.LblUsuario.TabIndex = 24;
            this.LblUsuario.Text = "label1";
            // 
            // lblTABLATITULO
            // 
            this.lblTABLATITULO.AutoSize = true;
            this.lblTABLATITULO.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTABLATITULO.Location = new System.Drawing.Point(160, 16);
            this.lblTABLATITULO.Name = "lblTABLATITULO";
            this.lblTABLATITULO.Size = new System.Drawing.Size(274, 26);
            this.lblTABLATITULO.TabIndex = 23;
            this.lblTABLATITULO.Text = "TABLA DE DESCUENTOS";
            this.lblTABLATITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 483);
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
            this.Controls.Add(this.lblTABLATITULO);
            this.Controls.Add(this.lblUsuac);
            this.Controls.Add(this.lblTabladeDes);
            this.Name = "FrmOperaciones";
            this.Text = "FrmOperaciones";
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabladeDes;
        private System.Windows.Forms.Label lblUsuac;
        private System.Windows.Forms.Label lblTotalPa;
        private System.Windows.Forms.Label lblTotsdIincl;
        private System.Windows.Forms.Label lblIvaaAg;
        private System.Windows.Forms.Label lblTotSinIva;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblTotSd;
        private System.Windows.Forms.Label lblIvaAg;
        private System.Windows.Forms.Label lblTsI;
        private System.Windows.Forms.TextBox txtNomPro;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPrecProd;
        private System.Windows.Forms.DataGridView DtgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGLA;
        private System.Windows.Forms.TextBox txtBIva;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPrecProd;
        private System.Windows.Forms.Label lblNombProd;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label lblTABLATITULO;
    }
}