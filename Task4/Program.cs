using System;

namespace Task4
{
    static class Extention
    {
        public static int[] SortMethod(this int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            return array;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] array = new int[10];
                Random rnd = new Random();

                for (int i = 0; i < array.Length; i++)
                    array[i] = rnd.Next(-100, 100);

                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");

                Extention.SortMethod(array);

                Console.WriteLine(" ");
                Console.WriteLine(new string('-', 30));

                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");

                Console.ReadKey();
            }
        }
    }
}
