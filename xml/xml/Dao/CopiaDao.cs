using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xml.Modelo;

namespace xml.Dao
{
    internal class CopiaDao
    {

        /// <summary>
        /// andres naranjo 2015-02-03 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia(long cedula) {

            using (DatosdesarrolloEntities bd = new DatosdesarrolloEntities()) {

              
                return bd.copias.Where(afn=> cedula == 0 ? afn.cedulasociado== afn.cedulasociado : afn.cedulasociado==cedula).Take(10).ToList();
            
            }
        }


    }
}