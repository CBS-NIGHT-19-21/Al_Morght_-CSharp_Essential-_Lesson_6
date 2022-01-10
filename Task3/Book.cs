using System;

namespace Task3
{
    internal class Book
    {
        string[] text = new string[5];

        public Book()
        {
            text[0] = "Chapter 1";
            text[1] = "Chapter 2";
            text[2] = "Chapter 3";
            text[3] = "Chapter 4";
            text[4] = "Chapter 5";
        }

        public string this[string index]
        {
            get
            {
                if (index != null)
                {
                    for (int i = 0; i < text.Length; i++)
                        if (text[i] == index)
                            return text[i];
                    return "Запрашиваемый результат отсутствует.";
                }
                return "Не коректный ввод.";

            }
        }
        public class Notes
        {
            string[] note = null;

            public Notes(int count)
            {
                note = new string[count];
            }
            public string this[int index]
            {
                get
                {
                    if ((index < note.Length) && (index >= 0))
                        return note[index];
                    else
                        return "Нет такой заметки.";
                }
                set
                {
                    if ((index <= note.Length) && (index >= 0))
                        note[index] = value;
                    else
                        Console.WriteLine("Привышен размер массива.");
                }
            }
        }
    }
}
