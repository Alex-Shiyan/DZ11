using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11
{
    internal struct Uravnenie
    {
        double k;
        double b;

        public Uravnenie(double k, double b)
        {
            this.k = k; 
            this.b = b;
        }
            public string Root ()
        {
            if (k == 0)
                return "Решения нет";
            
            double x = (-1) * (b / k);
            return $"Ответ: неизвестное Х={x}";
        }

    }
}
    