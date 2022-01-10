using System;

namespace Task2
{
    internal class Program
    {
        static class FindAndReplaceManager
        {
            public static void FindNext(string str)
            {
                Book book = new Book();

                Console.WriteLine(book[str]);
            }
        }

        static void Main(string[] args)
        {
            string question = "Chapter 3";
            string question2 = "Chapter 6";
            string question3 = null;

            FindAndReplaceManager.FindNext(question);
            FindAndReplaceManager.FindNext(question2);
            FindAndReplaceManager.FindNext(question3);

            Console.ReadKey();
        }
    }
}
