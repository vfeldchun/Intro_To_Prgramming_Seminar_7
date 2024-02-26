// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int m;
int n;

Console.WriteLine("Введите целые числв M и N, где |М| < N");
while (true)
{
    m = GetNumber('M');
    n = GetNumber('N');

    if (m < n && (n != -1 && m != -1))
    {
        PrintNumbers(m, n);
        break;
    }
    else
    {
        Console.WriteLine("Введите чтсла M и N заново. М и N не могут быть пусьыми или |M| < N.");
    }
}

void PrintNumbers(int m, int n)
{
    if (n == (m - 1)) return;
    PrintNumbers(m, n - 1);
    Console.Write($"{n} ");
}


int GetNumber(char numberName)
{
    Console.Write("Введите целое число: " + numberName + ": ");
    var inputString = Console.ReadLine();

    if (inputString is not null)
    {
        if (int.TryParse(inputString, out int number))
            return Math.Abs(number);
    }

    return -1;
}
