// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummOfNumbersFromRange(int startNumber, int finishNumber)
{
    if (finishNumber == startNumber) return startNumber;
    return finishNumber + SummOfNumbersFromRange(startNumber, finishNumber - 1);
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

int startNumber = GetInput("Введите натуральное число: ");
int finishNumber = GetInput("Введите натуральное число: ");
Console.Write($"M = {startNumber}; N = {finishNumber} -> " +
    $"{SummOfNumbersFromRange(startNumber, finishNumber)}");