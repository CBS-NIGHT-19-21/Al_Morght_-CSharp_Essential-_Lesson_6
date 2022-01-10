using System;


namespace Task3
{
    internal class Program
    {
        static class FindAndReplaceManager
        {
            public static void EditNote(int count)
            {
                Book.Notes note = new Book.Notes(count);

                note[0] = "Chapter 1 - readed.";
                note[1] = "Chapter 2 - readed.";
                note[2] = "Chapter 3 - readed.";

                Console.WriteLine(new string('-', 30));

                for (int i = 0; i < count; i++)
                    Console.WriteLine(note[i]);
            }
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

            FindAndReplaceManager.EditNote(3);

            Console.ReadKey();
        }

    }
}
