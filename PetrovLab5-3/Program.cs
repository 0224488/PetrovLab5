using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 2. Не обязательная...
            /*Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом
             из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.*/
            Random rnd = new Random();
            int [] box = new int [15];
            for (int i = 0; i < 15; i++)
            {
                box[i] = rnd.Next(0, 50);
                Console.Write("{0,4}", box[i]); // Добавил для наглядности
            }
            int max = box[0];
            int min = box[14];
            for (int j = 0; j < 15; j++)
            {
                if (box[j] > max)
                {
                    max = box[j];
                }
                if (box[j] < min)
                {
                    min = box[j];
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Мах = {0}, Min = {1}", max, min); // Это тоже для наглядности
            Console.WriteLine(" Сумма = {0}", max+ min);
            Console.ReadKey();
            // К предложению делать доп.задания. Дело в отсутствии времени, а не желания! Я совмещаю две работы и учёбу.
        }
    }
}
