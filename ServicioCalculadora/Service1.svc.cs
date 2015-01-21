using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioCalculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServicioCalculadora : ICalculadora
    {
        public double Sumar(double op1, double op2)
        {
            return op1 + op2;
        }

        public double Restar(double op1, double op2)
        {
            return op1 - op2;
        }


        public ResultadoSuma SumaCompleja(double[] op)
        {
            var r = op.Sum();
            var rs = new ResultadoSuma()
            {
                Operandos = op.Length,
                Resultado = r
            };
            return rs;
        }

        public double Dividir(double op1, double op2)
        {

            if (op2 == 0)
            {
                var err = new ErrorDivision() {Descripcion = "Fallo por dividir x 0", Divisor = 0};

                throw new FaultException<ErrorDivision>(err,"Error al dividir por 0");
            }
            

            return op1/op2;
        }
    }
}
