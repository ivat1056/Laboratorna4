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
        double Func_cos(double x, double n = 0, double precision = 1e-10)  // вычисление косинуса в радианах 
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((int)(2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }
            return t + Func_cos(x, n + 1, precision);

        }

        double Func_sin(double x, double eps = 1e-12)  // вычисление синуса в радианах 
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

        double Log(double n, double r)
        {
            return (n > 1) ? 1 + Log(n / r, r) : 0;
        }

        double Abs(double x) // модуль 
        {
            if (x >= 0) { }
            else { x *= -1; }
            return x;
        }

        double Factorial(int num) // факториал
        {
            if (num <= 1)
            {
                return 1d;
            }

            return num * Factorial(num - 1);
        }

        double Power(double num, double pow) // степень
        {
            if (pow == 0)
            {
                return 1;
            }

            return num * Power(num, pow - 1);
        }
    }
}
