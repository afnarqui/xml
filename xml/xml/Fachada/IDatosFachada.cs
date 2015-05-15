using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace xml.Fachada
{
    [ServiceContract]
    interface IDatosFachada
    {
        [OperationContract]
        System.Collections.Generic.List<xml.Modelo.copia> BuscarDatosCopia();
    }
}