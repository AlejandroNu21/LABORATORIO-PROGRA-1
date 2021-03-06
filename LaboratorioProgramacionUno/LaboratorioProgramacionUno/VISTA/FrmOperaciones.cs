﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.VISTA
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        public String UsuarioEstado;
        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = UsuarioEstado;

                DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR O IGUAL A 50 NO TENDRÁ DESCUENTO", "<=50");
                DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100, TENDRÁ UN DESCUENTO DEL 0.05", ">50 and <100 ");
                DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR O IGUAL A 100 Y MENOR QUE 101, TENDRÁ UN DESCUENTO DEL 0.10", ">=100 and <101");
                DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR O IGUAL A 101 Y MENOR QUE 150, TENDRÁ UN DESCUENTO DEL 0.20", ">=101 and <150");
                DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRÁ UN DESCUENTO DEL 0.50", ">150");

        }

        private void lblTabladeDes_Click(object sender, EventArgs e)
        {

        }

        private void DtgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblIVA_Click(object sender, EventArgs e)
        {

        }

        private void txtBIva_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombProd_Click(object sender, EventArgs e)
        {

        }

        private void txtNomPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecProd_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCant_Click(object sender, EventArgs e)
        {

        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotSinIva_Click(object sender, EventArgs e)
        {

        }

        private void lblTsI_Click(object sender, EventArgs e)
        {

        }

        private void lblIvaAg_Click(object sender, EventArgs e)
        {

        }

        private void lblIvaaAg_Click(object sender, EventArgs e)
        {

        }

        private void lblTotSd_Click(object sender, EventArgs e)
        {

        }

        private void lblTotsdIincl_Click(object sender, EventArgs e)
        {

        }

        private void lblT_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPa_Click(object sender, EventArgs e)
        {

        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double multiplica;
                multiplica = Convert.ToDouble(txtPrecProd.Text) * Convert.ToDouble(txtCant.Text);
                lblTotSinIva.Text = multiplica.ToString();

                double multiplicar;
                multiplicar = Convert.ToDouble(txtPrecProd.Text) * Convert.ToDouble(txtBIva.Text);
                lblIvaaAg.Text = multiplicar.ToString();

                double suma;
                suma = Convert.ToDouble(lblTotSinIva.Text) + Convert.ToDouble(lblIvaaAg.Text);
                lblTotsdIincl.Text = suma.ToString();

                if (Convert.ToDouble(txtPrecProd.Text) <= 50) {
                    lblTotalPa.Text = lblTotsdIincl.Text;

                }
                else if (Convert.ToDouble(txtPrecProd.Text) > 50)
                {
                    double resta;
                    resta = Convert.ToDouble(lblTotsdIincl.Text) - Convert.ToDouble(lblTotsdIincl.Text)*0.05;
                    lblTotalPa.Text = resta.ToString();
                    {if (Convert.ToDouble(txtPrecProd.Text) < 100);

                    double restar;
                    restar = Convert.ToDouble(lblTotsdIincl.Text) - Convert.ToDouble(lblTotsdIincl.Text) * 0.05;
                        lblTotalPa.Text = restar.ToString(); 
                    }

                }
                if (Convert.ToDouble(txtPrecProd.Text) >= 100)
                {
                    double resta;
                    resta = Convert.ToDouble(lblTotsdIincl.Text) - Convert.ToDouble(lblTotsdIincl.Text) * 0.10;
                    lblTotalPa.Text = resta.ToString();
                    {
                        if ((Convert.ToDouble(txtPrecProd.Text) < 101)) ;

                        double restar;
                        restar = Convert.ToDouble(lblTotsdIincl.Text) - Convert.ToDouble(lblTotsdIincl.Text) * 0.10;
                        lblTotalPa.Text = restar.ToString();
                    }
                }
                if (Convert.ToDouble(txtPrecProd.Text) >= 101)
                {
                    double resta;
                    resta = Convert.ToDouble(lblTotsdIincl.Text) - Convert.ToDouble(lblTotsdIincl.Text) * 0.20;
                    lblTotalPa.Text = resta.ToString();
                    {
                        if ((Convert.ToDouble(txtPrecProd.Text) < 150)) ;

                        double restar;
                        restar = Convert.ToDouble(lblTotsdIincl.Text) - Convert.ToDouble(lblTotsdIincl.Text) * 0.20;
                        lblTotalPa.Text = restar.ToString();
                    }
                }
                if (Convert.ToDouble(txtPrecProd.Text) >150)
                {
                    double resta;
                    resta = Convert.ToDouble(lblTotsdIincl.Text) - Convert.ToDouble(lblTotsdIincl.Text) * 0.50;
                    lblTotalPa.Text = resta.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Se ha ingresado un dato incorrecto, intente nuevamente.");

            }
        }


        private void LblMostProd_Click(object sender, EventArgs e)
        {
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
