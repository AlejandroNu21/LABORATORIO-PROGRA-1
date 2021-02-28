using LaboratorioProgramacionUno.DAO;
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
        ClsListaUsuarios cls = new ClsListaUsuarios();

        public int acceso(Loguin log) {

            int estado = 0;
            for (int i=0;i< cls.user.Length;i++) { 
            if (log.Usuario.Equals(cls.user[i])&& log.Password.Equals(cls.pass[i])) {
              
                
                estado = 1;

            }
            }
            return estado;
        }
    }
}
