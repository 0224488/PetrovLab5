using System;

namespace PetrovLab5_1

{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1. Обязательная.
            int[] box = new int[7];
            int S = 0;
            Console.WriteLine("Введите 7 целочисленных чисел");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0}-е: ", i + 1);
                box[i] = Convert.ToInt32(Console.ReadLine());
                S += box[i];
            }
            Console.Write("Среднее арифметическое = {0}", S / 7);
            Console.ReadKey();
        }

    }
}
