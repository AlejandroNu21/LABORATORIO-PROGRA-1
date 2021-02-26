using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecProd_Click(object sender, EventArgs e)
        {

        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
            DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR O IGUAL A 50 NO TENDRÁ DESCUENTO", "<=50");
            DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100, TENDRÁ UN DESCUENTO DEL 0.05", ">50 and <100 ");
            DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR O IGUAL A 100 Y MENOR QUE 101, TENDRÁ UN DESCUENTO DEL 0.10", ">=100 and <101");
            DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR O IGUAL A 101 Y MENOR QUE 150, TENDRÁ UN DESCUENTO DEL 0.20", ">=101 and <150");
            DtgvTabla.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRÁ UN DESCUENTO DEL 0.50", ">150");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int multiplica;
                multiplica = Convert.ToInt32(txtPrecProd.Text) * Convert.ToInt32(txtCant.Text);
                lblTotSinIva.Text = multiplica.ToString();
            }
            catch (Exception ex ){

                MessageBox.Show("Se ha ingresado un dato incorrecto, intente nuevamente." );

            }

    }

        private void txtBIva_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotSd_Click(object sender, EventArgs e)
        {

        }
    }
}
