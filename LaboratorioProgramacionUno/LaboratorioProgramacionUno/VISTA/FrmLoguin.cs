using LaboratorioProgramacionUno.DOMINIO;
using LaboratorioProgramacionUno.NEGOCIO;
using LaboratorioProgramacionUno.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno
{
    public partial class Form1 : Form
    {
        private string usuario;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Loguin log = new Loguin();

            log.Usuario = txtUsuario.Text;
            log.Password = txtPassword.Text;

            ClsLoguin ClsL = new ClsLoguin();

            int variabledeevaluacion= ClsL.acceso(log);

            if (variabledeevaluacion==1)
            {

                MessageBox.Show("Bienvenido" );
                FrmMenu frm = new FrmMenu();
                frm.Show();
          
            }
            else {
                MessageBox.Show("False");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
