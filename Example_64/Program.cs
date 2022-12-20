// Задача 64: Задайте значения M и N. Напишите программу, которая 
// выведет все чётные натуральные числа в промежутке от M до N 
// с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int FindNumber(int ot, int do1)
{
    if (ot > do1) return 0;
    else if (ot % 2 == 0)
        Console.Write(ot + ", ");
    return FindNumber(ot + 1, do1);
}

if (m > n) FindNumber(n, m);
else FindNumber(m, n);

