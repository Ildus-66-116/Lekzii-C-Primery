// Вид 1 - Ничего не принимает и ничего не возвращает:

// Console.Clear();
// void Method1()
//     {
//     Console.WriteLine("Автор...");
//     }
// Method1();

// Вид 2 - принимает, но не возвращает:

// Console.Clear();
// void Method2 (string msg)
//     {
//     Console.WriteLine (msg);
//     }
// Method2 (msg: "Текст");

// Вид 3 - не принимает, но возвращает (например генератор случайных чисел, или дата):

// Console.Clear();
// int Method3()
//     {
//     return DateTime.Now.Year;
//     }
//     int year = Method3();
//     Console.WriteLine (year);

// 4 вид - принимает и возвращает (самый популярный):

// Console.Clear();
// string Method4 (int count, string c)
//     {
//     int i = 0;
//     string Result = "";
//     while (i < count)
//         {
//         Result = Result + c;
//         i++;
//         }
//     return Result;
//     }
//     string Res = Method4 (10, "Proverka ");
//     Console.WriteLine (Res);

// Цикл for - for (int i = 0; i < 10; i++) {тело цикла}:

// Console.Clear();
// string Method4 (int count, string c)
//      {
//     string Result = string.Empty;
//     for (int i = 0; i < count; i++)
//         {
//         Result = Result + c;
//         }
//     return Result;
//     }
//     string Res = Method4 (10, "Proverka ");
//     Console.WriteLine (Res);

// Цикл for пример - таблица умножения

// Console.Clear();
// for (int i = 1; i <= 10; i++)
//     {
//     for (int j = 1; j <= 10; j++)
//         {
//         Console.WriteLine ($"{i} x {j} = {i * j}");
//         }
//     Console.WriteLine();
//     }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// Console.Clear();
// string text = "Я думаю, сказал князь, улыбаясь что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string Replase (string text, char oldValue, char newValue)
//     {
//     string result = string.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//         {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//         }
//     return result;
//     }
//     string newText = Replase (text, ' ', '|');
//     Console.WriteLine (newText);
//     Console.WriteLine();
//     newText = Replase (newText, 'к', 'К');
//     Console.WriteLine (newText);

// Упорядочить массив - алгоритм выбоа min (или max)

// Console.Clear();
// int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray (int[] array)
//     {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//         {
//         Console.Write ($"{array[i]} ");
//         }
//     Console.WriteLine();
//     }

// void SelectionSort (int[] array)
//     {
//     for (int i = 0; i < array.Length - 1; i++)
//         {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//             {
//             if (array[j] < array[minPosition]) minPosition = j;
//             }
//         int temparray = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temparray;
//         }
//     }

// PrintArray (arr);
// SelectionSort(arr);

// PrintArray(arr);



//  Лекция 4

// Console.Clear();
// string[,] table = new string[2, 5];
// string.Empty - инциализация пустая строка - ставит 0 по умолчанию
// table[0, 0], table[0, 1], table[0, 2], table[0, 4]
// table[1, 0], table[1, 1], table[1, 2], table[1, 4]

// table[1, 2] = "слово";

// for(int rows = 0; rows < 2; rows++)
//     {
//         for(int colums = 0; colums < 5; colums++)
//         {
//             Console.WriteLine($"-{table[rows, colums]}-");
//         }
//     }
// void PrintArray(int[,] matrix)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = new Random().Next(1, 10);
//     }
//     Console.WriteLine();
// }

// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);

// Закраска картинки

// void PrintImage(int[,] image)
// {
// for(int i = 0; i < image.GetLength(0); i++)
//     {
//         for(int j = 0; j < image.GetLength(1); j++)
//         {
//             // 
//             if(image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//     Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] =1;
//         FillImage(row -1, col);
//         FillImage(row, col-1);
//         FillImage(row +1, col);
//         FillImage(row, col+1);
//     }
// }

// int[,] pic = new int[,]
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
// };
// PrintImage(pic);

// double Factorial (double n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// for(int i = 1; i < 40; i++)
// Console.WriteLine($"{i}! = {Factorial(i)}");

//Фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibanachi(double n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibanachi(n-1) + Fibanachi(n-2);
// }
// for(int i = 1; i < 50; i++) Console.WriteLine($"{i} = {Fibanachi(i)}");


// Лекция 5 

// using System.Linq;
// var a = 12;
// // Console.WriteLine (a.GetType());

// var data = new int[] {1,2,3,4}
//             .Where(e=> e>0)
//             .Select(e=> new{q = e, w = e+1});
// Console.WriteLine(data.GetType());

// Лекция 6

using System.Linq;
Console.Clear();
string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")
                .Replace(")", "");
Console.WriteLine(text);
var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 10, point.y + 10))
                .ToArray();
for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}


