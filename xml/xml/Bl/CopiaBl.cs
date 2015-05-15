using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xml.Dao;
using xml.Modelo;

namespace xml.Bl
{
    internal class CopiaBl
    {
        /// <summary>
        /// andrés naranjo 2015-01-01 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia(long cedula)
        {
            return new CopiaDao().BuscarDatosCopia(cedula).ToList();
        }
    }
}