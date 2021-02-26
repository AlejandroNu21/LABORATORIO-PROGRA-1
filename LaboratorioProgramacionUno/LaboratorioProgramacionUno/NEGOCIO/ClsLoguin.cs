using LaboratorioProgramacionUno.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.NEGOCIO
{
    class ClsLoguin
    {
        

        public int acceso(Loguin log) {

            int estado = 0;
            if (log.Usuario.Equals("Carlos")&& log.Password.Equals("123" )) {
              
                
                estado = 1;

            }
            return estado;
        }
    }
}
