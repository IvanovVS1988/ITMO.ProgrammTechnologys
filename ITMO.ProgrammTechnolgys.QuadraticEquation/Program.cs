using System;

namespace ProgrammTechnologys.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x, x1, x2;
            string answer;
            Console.WriteLine("Программа для решения квадратного уравнения вида: ax^2+bx+c=0");
            do
            {
                Console.WriteLine("Введите значение коэффициента а");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение коэффициента b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение коэффициента c");
                c = Convert.ToDouble(Console.ReadLine());
                D = b * b - 4 * a * c; //Вычисление Дискриминанта
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Уравнение имеет два корня: первый корень уравнения x={0}, второй корень уравнения x={1}", x1, x2);
                }
                else if (D == 0)
                {
                    x = (-b) / (2 * a);
                    Console.WriteLine("Уравнение имеет один корень x={0}", x);
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решения");
                }
                Console.WriteLine("Решить новое квадратное уравнение? Введите да или нет");
                answer = Console.ReadLine();
            }
            while (answer != "нет");
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}