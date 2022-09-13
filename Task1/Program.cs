// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу 
// с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetPow(int a, int b)
{
    int bAbs = Math.Abs(b);
    double result = Math.Pow(a, bAbs);
    return result;
}

try
{
    Console.WriteLine("Введите первое число А: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число B: ");
    int b = int.Parse(Console.ReadLine());

    double result = GetPow(a, b);
    Console.WriteLine($"Число A в натуральной степени B = {result}");
}
catch
{
    Console.WriteLine("Число введено в неверном формате. Введите число!");
}