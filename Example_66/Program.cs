// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int FindNumber(int ot, int do1)
{
    if (ot > do1) return 0;
    return ot + FindNumber(ot + 1, do1);
}

Console.WriteLine(m < n ? $"Сумма натуральных элементов в промежутке от {m} до {n} = {FindNumber(m, n)}" : $"Сумма натуральных элементов в промежутке от {n} до {m} = {FindNumber(n, m)}");