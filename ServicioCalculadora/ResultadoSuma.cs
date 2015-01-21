using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServicioCalculadora
{

    [DataContract]
   public class ResultadoSuma
    {

        [DataMember]
       public Double Resultado { get; set; }

       [DataMember]
        public int Operandos { get; set; }

    }
}
