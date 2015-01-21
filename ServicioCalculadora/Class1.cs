using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioCalculadora
{
    [DataContract]
    public class ErrorDivision
    {
        [DataMember]
        public String Descripcion { get; set; }

        [DataMember]
        public Double Divisor { get; set; }

    }
}