// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int GetInput(string text)
{
    Console.Write(text);
    string num = Console.ReadLine();
    int value = 0;
    int count = 0;

    while (count == 0)
    {
        if (int.TryParse(num, out value) & Convert.ToInt32(num) > 0)
        {
            count = 1;
        }
        else
        {
            Console.Write("Вы ввели неверное значение, введите новое значение: ");
            num = Console.ReadLine();
            count = 0;
        }
    }
    return value;
}

int m = GetInput("Введите 1-е неотрицательное число: ");
int n = GetInput("Введите 2-е неотрицательное число: ");
int result = Ackermann(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A({m}, {n}) = {result}");