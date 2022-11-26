namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        //Домашнее задание семинара №5

        void Task_34()
        {
            /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
            Напишите программу, которая покажет количество чётных чисел в массиве.
            [345, 897, 568, 234] -> 2 */
            Console.WriteLine();
            int size = 4;
            int[] numberArray = new int[size];
            FillArray(numberArray, 99, 1000);
            Console.WriteLine("       --Задача 34--");
            Console.WriteLine("Количество чётных чисел в массиве:");

            PrintArray(numberArray);
            int sum = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0) sum = sum + 1;
            }
            Console.WriteLine($" -> {sum} ");
        }

        void Task_36()
        {
            /* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
            Найдите сумму элементов с нечётными индексами.
             0   1  2   3
            [3, 7, 23, 12] -> 19
            [-4, -6, 89, 6] -> 0*/
            Console.WriteLine();
            int size = 4;
            int[] numberArray = new int[size];
            FillArray(numberArray, -10, 10);
            Console.WriteLine("       --Задача 36--");
            Console.WriteLine("Сумма элементов с нечётными индексами в массиве:");

            PrintArray(numberArray);
            int sum = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i % 2 == 1) sum = sum + numberArray[i];
            }
            Console.WriteLine($" -> {sum} ");
        }

        void Task_38()
        {
            /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
            максимальным и минимальным элементов массива.
            [3,21 7,04 22,93 - 2,71 78,24] -> 80,95 */
            Console.WriteLine();
            int size = 4;
            double[] numberArray = new double[size];
            int[] number = new int[size];
            Console.WriteLine("       --Задача 38--");
            Console.WriteLine("Pазницa между максимальным и минимальным элементом в массиве:");

            FillArray(number, -99, 999);
            for (int i = 0; i < size; i++) numberArray[i] = Math.Round(Convert.ToDouble(number[i]), 2) / 10;
            PrintArrayDouble(numberArray);

            double difference = MaxValue(numberArray) - MinValue(numberArray);

            Console.WriteLine($" -> {Math.Round(difference, 2)}");
        }

        void FillArray(int[] nums, int minValue = 0, int maxValue = 9) //метод заполнения массива случайными числами
        {
            maxValue++;
            Random rand = new Random();
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                nums[i] = rand.Next(minValue, maxValue);
            }
        }

        void PrintArray(int[] nums)//печать массива
        {
            int length = nums.Length;
            Console.Write("[ ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.Write("]");

        }

        void PrintArrayDouble(double[] nums)//печать массива
        {
            int length = nums.Length;
            Console.Write("[ ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.Write("]");

        }

        double MinValue(double[] array)
        {
            double minN = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minN) minN = array[i];
            }
            return minN;
        }

        double MaxValue(double[] array)
        {
            double maxN = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxN) maxN = array[i];
            }
            return maxN;
        }

        Task_34();
        Task_36();
        Task_38();

    }
}
