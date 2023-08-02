// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string ShowNuumbersFromNTo1(int numberN)
{
    if (numberN > 1) return numberN + ", " + ShowNuumbersFromNTo1(numberN - 1);
    else return numberN.ToString();
}

int GetInput(string text)
{
    Console.Write(text);
    string num = Console.ReadLine();
    int value = 0;
    int count = 0;

    while (count == 0)
    {
        if (int.TryParse(num, out value))
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

int numberN = GetInput("Введите натуральное число: ");
Console.Write($"N = {numberN} -> {ShowNuumbersFromNTo1(numberN)}");