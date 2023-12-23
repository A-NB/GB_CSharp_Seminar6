// Знакомство с языками программирования (семинары)
// Урок 6. Массивы и строки

// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


char[,] GetRandom2DArrayOfChar()
{
    string st = "0123456789abcdefjhijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯЁ~@#$%^&!№;%:?*()_+/-.,\"<>";
    Random rnd = new Random();
    int row = rnd.Next(2, 11);
    int col = rnd.Next(2, 11);
    char[,] array = new char[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = st[rnd.Next(rnd.Next(0, st.Length))];
        }
    }
    return array;
}

void PrintArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

string CreateString(char[,] array)
{
    string st = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            st += array[i, j];
        }
    }
    return st;
}

char[,] array = GetRandom2DArrayOfChar();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(CreateString(array));



// **************************** "ИДЕАЛЬНОЕ РЕШЕНИЕ" *****************************///
// 6 - ой семинар:
// Задача 1: Создание строки из двумерного массива символов
/* public class Task1
{
    public static void Main(string[] args)
    {
        // Инициализация двумерного массива символов
        char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
        // Вызов метода для создания строки из 2D массива
        string result = CreateStringFrom2DArray(charArray);
        // Вывод результата
        Console.WriteLine(result);
    }
    // Метод для создания строки из двумерного массива символов
    public static string CreateStringFrom2DArray(char[,] array)
    {
        string result = "";
        // Цикл по каждому элементу в двумерном массиве
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                // Добавление каждого символа в результирующую строку
                result += array[i, j];
            }
        }
        return result;
    }
} */