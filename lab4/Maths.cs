using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{

    public class Maths
     {
        const double pi = 3.14159265358979323846;
        public double Func_cos(double x, double n = 0, double precision = 1e-10)  // вычисление косинуса в радианах 
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((int)(2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }
            return t + Func_cos(x, n + 1, precision);
        }

        public double Func_sin(double x, double eps = 1e-12)  // вычисление синуса в радианах 
        {
            int sign = (x < 0) ? -1 : 1;
            // Приводим к [0, 2*pi]
            x = (Abs(x) % (2 * pi));
            // Приводим к [0, pi]
            if (x > pi) { x -= pi; sign *= -1; }
            // Приводим к [0, pi/2]
            if (x > pi / 2) x = pi - x;

            double t = x, s = x;
            for (int n = 3; Abs(t) > eps; n += 2)
                s += t = -t * x * x / n / (n - 1);
            return s * sign;
        }

        public double Log(double osn, double x) // логорифм
        {

            for (int s = 1; s <x;s++)
            {
                if (s == x)
                {
                    return s;
                }
                
            }
            double s2 = 0.00001;
            while (Power(osn, s2) < x)
            {
                s2 = s2 + 0.00001;
            }
            return s2;
                    
        }


        public double Abs(double x) // модуль 
        {
            if (x >= 0) { }
            else { x *= -1; }
            return x;
        }

        public double Factorial(int num) // факториал
        {
            if (num <= 1)
            {
                return 1d;
            }

            return num * Factorial(num - 1);
        }

        public double Power(double num, double pow) // степень
        {
            double p= pow;
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= pow; i++)
                {
                    p = p * pow;
                }
                return p;
            }
        }
    }
}
