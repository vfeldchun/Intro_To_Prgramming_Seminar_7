// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int m;
int n;
int result;
string? chooseAction;

Console.WriteLine("Введите целые положительные числа M и N, для расчета функции Акермана!");
while (true)
{
    m = GetNumber('M');
    n = GetNumber('N');

    if (n != -1 && m != -1)
    {
        if ((m >= 4 && n > 0) || (m == 3 && n > 11) || (m == 2 && n > 9600)) 
        {
            Console.WriteLine($"Такое значение M: {m} и N: {n}, может вызвать переполнение стека!");
            Console.Write("Для продолжения введите y, для повтороного ввода M любой другой символ: ");
            chooseAction = Console.ReadLine();
            if (chooseAction != "y")
                continue;
        }
        result = CalculateAkermanFunction(m, n);
        Console.WriteLine($"Результат вычисления функции Акермана A({m},{n}): {result}");
        break;
    }
    else
    {
        Console.WriteLine("Введите чтсла M и N заново. М и N не могут быть пусьыми или < 0");
    }
}

int GetNumber(char numberName)
{
    Console.Write("Введите целое положительное число: " + numberName + ": ");
    var inputString = Console.ReadLine();

    if (inputString is not null)
    {
        if (int.TryParse(inputString.Trim(), out int number))
            if (number >= 0)
                return number;
    }

    return -1;
}

int CalculateAkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return CalculateAkermanFunction(m - 1, 1);
    else return CalculateAkermanFunction(m - 1, CalculateAkermanFunction(m, n - 1));
}
