using System;

namespace inf_dz
{
    class Program
    {
        public static int[] sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
                for(int j = 0; j < arr.Length - i - 1; j++)
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
            return arr;
        }
        public static int BinarySearch(int[] arr, int num)
        {
            int low = 0;
            int high = arr.Length - 1;
            while(low <= high)
            {
                int mid = (low + high)/2;
                int guess = arr[mid];
                if(guess == num)
                    return mid;
                else if(guess > num)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Поиск ведётся по отсортировонному массиву с помощью алгоритма бинарного поиска Юсуф Якубов");
            Random random = new Random();
            int[] array = new int[10];
            for(int i = 0; i <= 9; i++)
                array[i] = random.Next(1, 100);
            sort(array);
            Console.Write("Массив Данных: ");
            foreach(int i in array)
                Console.Write($"{i} ");
            Console.Write("\nНапишите число: ");
            int readnum = int.Parse(Console.ReadLine());
            int elem = BinarySearch(array, readnum);
            if(elem != -1)
                Console.WriteLine($"Элемент найден, его индекс: {elem}");
            else
                Console.WriteLine("Данного элемента нету в списке");
            Console.ReadKey();
        }
    }
}
