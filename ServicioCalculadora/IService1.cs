using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioCalculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculadora
    {

        [OperationContract]
        Double Sumar(Double op1, Double op2);

        [OperationContract]
        Double Restar(Double op1, Double op2);

        [OperationContract]
        ResultadoSuma SumaCompleja(Double[] op);

        [OperationContract]
        [FaultContract(typeof(ErrorDivision))]
        Double Dividir(Double op1, Double op2);
    }
}
