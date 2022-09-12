using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа принимает N чисел от пользователя и показывает,
    {                   // сколько из них меньше нуля
        static void Main (string[] args)
        {
            int[] createNewArray(int size)
            {
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Введите {i+1} число: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                return array;
            }

            void printArray(int[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

            int findCountOfNegativeNumbers(int[] array)
            {
                int count = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    if(array[i] < 0) count++;
                }
                return count;
            }

            try
            {
            Console.Write("Сколько чисел вы собираетесь ввести?: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = createNewArray(arraySize);
            Console.Write("Введённые Вами числа: ");
            printArray(numbers);
            Console.WriteLine($"Среди них чисел меньше нуля: {findCountOfNegativeNumbers(numbers)}");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода. Вводите данные цифрами.");
            }
        }
    }
}