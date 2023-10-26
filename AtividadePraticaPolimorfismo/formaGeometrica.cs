using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaPolimorfismo
{
    public class formaGeometrica
    {
        public virtual double CalculaArea(int Base, int Altura)
        {
            double Area = Base * Altura;

            return Area;
        }
    }
    
    public class formaGeometria2: formaGeometrica
    {
        public override double CalculaArea(int Base, int Altura)
        {
            double Area = (Base * Altura) / 2;

            return Area;
        }
    }
}
