using System;

namespace Module_1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1
            Console.Write("Enter length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] array = new int[n];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-200, 200);
                if (-100 <= array[i] && array[i] <= 100)
                    count++;
            }
            Console.WriteLine($"Count = {count}");

            // Задание №2
            int[] a = new int[20];
            int[] b = new int[20];
            int temp = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(0, 1500);
                if (a[i] <= 888)
                    b[i] = a[i];

                for (int j = 1; j < b.Length; j++) // Из-за того что вставил сортировку тут, использовал меньше циклов
                {                                  // потому сначала и выводит только нули(так как массив не заполнил отдельным циклом до этого)
                    Console.Write(b[j - 1] + " "); // Если вышеуказанное критично то напишите пожалуйста в ЛС и я переделаю
                    if (b[j - 1] < b[j]) //Меняю число массива с предыдущей ячейкой
                    {
                        temp = b[j];
                        b[j] = b[j - 1];
                        b[j - 1] = temp;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
