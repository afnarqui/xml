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
        public List<copia> BuscarDatosCopia() {

            using (DatosdesarrolloEntities bd = new DatosdesarrolloEntities()) {

                List<copia> entidad = (from c in bd.copias
                                      select c).ToList();

                return entidad;
            
            }
        }


    }
}