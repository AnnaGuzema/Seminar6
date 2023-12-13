// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int ReadInt(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// } 

// int M = ReadInt("Введите начало:");
// int N = ReadInt("Введите конец:");


// void PrintNumbers(int M, int N)
// {
//     if(M > N) return;
//     Console.Write(M + " ");
//     PrintNumbers(M + 1, N);
// }

// PrintNumbers(M, N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int ReadInt(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// } 

// int M = ReadInt("Введите первое неотрицательное число:");
// int N = ReadInt("Введите второе неотрицательное число:");

// static int PrintAckermann(int M, int N)
// {
//     if(M == 0)
//     {
//         return N + 1;
//     }
//     else if(M > 0 && N == 0)
//     {
//      return PrintAckermann(M - 1, 1);
//     }
//     else if(M > 0 && N > 0)
//     {
//         return PrintAckermann(M - 1, PrintAckermann(M, N - 1));
//     }
//     else
//     {
//         return -1;
//     }
// }

// int result = PrintAckermann(M, N);
// System.Console.Write(result);


// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = { 5, 8, 2, 3, 9 };

static void PrintNewArray(int[] array, int i)
{
    if(i < 0)
    {
        return;
    }

    System.Console.Write(array[i] + " ");
    PrintNewArray(array, i - 1);

}

System.Console.WriteLine("Элементы массива начиная с конца:");
PrintNewArray(array, array.Length - 1);