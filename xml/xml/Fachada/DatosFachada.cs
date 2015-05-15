using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xml.Bl;
using xml.Modelo;

namespace xml.Fachada
{
    public class DatosFachada:IDatosFachada
    {

        /// <summary>
        /// andrés naranjo 2015-01-01 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia() {
            return new CopiaBl().BuscarDatosCopia().ToList();
        }
    }
}