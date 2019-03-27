using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Multiplicacion
    {
        private double m1, m2, resultado;

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double M2
        {
            get { return m2; }
            set { m2 = value; }
        }

        public double M1
        {
            get { return m1; }
            set { m1 = value; }
        }

        //GET y SET
        

        public Multiplicacion() 
        {
            this.m1 = 0;
            this.m2 = 0;
        }

        public double Multiplicar() 
        {
            resultado = m1 * m2;
            return resultado;
        }
    }
}
