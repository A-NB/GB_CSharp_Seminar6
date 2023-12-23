// Знакомство с языками программирования (семинары)
// Урок 6. Массивы и строки

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.


string st = "I have two eyes and I can see a book and pen infront of me"; //Hello my world";

string newSt = string.Empty, sep = " ";
string[] stArray = st.Split(" ");

for (int i = stArray.Length - 1; i >= 0; i--)
{
    if (i == 0) sep = string.Empty;
    newSt += (stArray[i] + sep);
}

System.Console.WriteLine($"\"{newSt}\"");


// ************************************ " ИДЕАЛЬНОЕ РЕШЕНИЕ"  ****************************//
// Задача 4 (необязательная): Обратный порядок слов в строке
/* public class Task4
{
    public static void Main(string[] args)
    {
        // Входная строка со словами, разделенными пробелами
        string input = "Hello my world";
        // Вызов метода для обращения порядка слов в строке
        string result = ReverseWords(input);
        // Вывод результата
        Console.WriteLine(result);
    }
    // Метод для обращения порядка слов в строке
    public static string ReverseWords(string str)
    {
        // Разделение строки на слова
        string[] words = str.Split(' ');
        // Обращение порядка слов
        Array.Reverse(words);
        // Соединение слов обратно в строку с пробелами
        return string.Join(" ", words);
    }
} */