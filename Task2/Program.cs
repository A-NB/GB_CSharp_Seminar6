// Знакомство с языками программирования (семинары)
// Урок 6. Массивы и строки

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string st = "ThIs iS an eXAaMplE OF a stRinG coNsiSTiNg of LATin lEtTers in BOth rEgiSterS";
System.Console.WriteLine(st.ToLower());


// **************************** "ИДЕАЛЬНОЕ РЕШЕНИЕ" ********************//
/* Задача 2: Замена заглавных букв на строчные в строке
public class Task2
{
    public static void Main(string[] args)
    {
        // Входная строка со смешанными буквами обоих регистровstring input = "aBcD1ef!-";
        // Преобразование всех заглавных букв в строчные
        string result = input.ToLower();
        // Вывод результата
        Console.WriteLine(result);
    }
} */