
namespace Task2
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
    }
}
