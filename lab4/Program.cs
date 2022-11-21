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
            m1: Console.WriteLine("Введите x для первого уравнения (х<=0)");
            double x1 = Convert.ToDouble(Console.ReadLine());
            if (x1 > 0)
            {
                Console.WriteLine("Повторите ввод x");
                goto m1;
            }
            m2: Console.WriteLine("Введите x для второго уравнения  (х>0)");
            double x2 = Convert.ToDouble(Console.ReadLine());
            if (x2 <= 0)
            {
                Console.WriteLine("Повторите ввод x");
                goto m2;
            }
            double rezult1 = Equations1(x1);
            double rezult2 = Equations2(x2);
            
            
            Console.WriteLine("Ответ на первое уравнение {0}",rezult1);
            Console.WriteLine("Ответ на второе уравнение {0}", rezult2);

            Plug_Rezult_2_level(); // заглушка
            Console.ReadKey();
        }

        static double Plug_cos_or_sin() // заглушка работы уравнения с синусам и косинусам
        {
            double x = 0;
            return x;
        }

        static double Plug_Power(double num, double pow) // заглушка работы степени
        {
            double x = 4 * 4;
            return x;
        }

        static double Plug_Log(double osn, double x) // заглушка  работы логарифма
        {
            x = 2;
            return x;
        }
        static void Plug_Rezult_2_level() // заглушка печати результата степень, косинуса, синуса, логарифма используя заглушки 
        {
            Maths m = new Maths();
            double s, c, l, p, eq1, eq2, eq11 , eq22, abs, f;
            eq1=(Plug_Power((Plug_cos_or_sin() + Plug_cos_or_sin() + Plug_cos_or_sin()), 2)); // уравнение 1 используя заглушку (алгоритм)
            eq2=(Plug_Log(2, 4) * Plug_Log(3, 9)); // уравнение 2 используя заглушку (алгоритм)
            eq11 = Equations1(0); // уравнение 1 используя заглушку
            eq22 = Equations2(0); //  уравнение 2 используя заглушку
            p = m.Power(2, 3); // степень 
            s = m.Func_sin(0); // синус
            c = m.Func_cos(0); // косинус
            l = m.Log(2, 16); // логарифм
            abs = m.Abs(2); // модуль
            f = m.Factorial(4); // факториал
            Console.WriteLine("Главные модули (алгоритм) (Уравнение 1= {0} , Уравнение 2 = {1})", eq1, eq2);
            Console.WriteLine("Главные модули при подставновке (Уравнение 1= {0} , Уравнение 2 = {1})", eq11, eq22);
            Console.WriteLine("Модули для 1 и 2 уравнения (степень(2в3) ={0}, синус(0) ={1},  косинус(0) ={2} , логарифм(16по2) ={3} )", p , s , c ,l);
            Console.WriteLine("Модули для проверки степени, синуса, косинуса и логарифма (Модуль(2) ={0}, факториал(4) ={1})", abs, f);
        }
        

        static double Equations1(double x) // уравнение 1 
        {
            Maths math = new Maths();
            double answer;
            answer = (math.Power((math.Func_sin(x) + math.Func_cos(x) + math.Func_cos(x)), 2));
            return answer; 
        }
        static double Equations2(double x) // уравнение 2
        {
            Maths math = new Maths();
            const double E = 2.71828;
            double answer;
            answer = math.Log(E, x) * math.Log(5, x);
            return answer;
        }
    }
}
