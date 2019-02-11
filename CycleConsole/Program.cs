using System;

namespace CycleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, count = 0, correct = 0, incorrect = 0;
            string contin = "";
            do
            {
                Random r = new Random();
                a = r.Next(1, 9);
                b = r.Next(1, 9);
                Console.Write("Решите пример: " + a + " * " + b + " = ");
                int c = Convert.ToInt32(Console.ReadLine());
                count++;
                if (c == a * b)
                {
                    Console.WriteLine("Ответ верный!");
                    correct++;
                }
                else
                {
                    Console.WriteLine("Ответ неверный! " + "Правильный ответ: " + a * b);
                    incorrect++;
                }

                Console.WriteLine("Хотите продолжить? д/н");
                contin = Console.ReadLine();

            } while (contin == "д");

            Console.WriteLine("Всего попыток: " + count);
            Console.WriteLine("Из них верно: " + correct);
            Console.WriteLine("Из них неверно: " + incorrect);
            Console.ReadKey();
        }
    }
}
