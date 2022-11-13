using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            Maths math = new Maths();
            //Console.WriteLine("Введите x ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double v = Equations2(x);
            //Console.WriteLine(v);

            double v1 = math.Log(128, 2);
            Console.WriteLine(v1);




            Console.ReadKey();
        }
        static double Equations1(double x)
        {
            Maths math = new Maths();
            double answer;
            answer = (math.Power((math.Func_sin(x) + math.Func_cos(x) + math.Func_cos(x)),2));
            return answer; // заглушка 1 (уравнение 1)
        }
        static double Equations2(double x)
        {
            Maths math = new Maths();
            const double E = 2.71828;
            double answer;
            answer = math.Log(x,E)*math.Log(x,5);
            return answer; // заглушка 2 (уравнение 2)
        }
    }
}
