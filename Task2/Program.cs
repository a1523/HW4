// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumm (int number)
{
    int sum = 0;
    int numbNext = 0;
    int temp = 0;
    string length = Convert.ToString(number);
    for (int i=0; i < length.Length; i++)
    {
        temp = Math.Abs(number)%10; 
        numbNext = number / 10; 
        number = numbNext; 
        sum = temp + sum; 
    }
    return sum;
}

try
{
    Console.WriteLine("Введите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    
    int sum = GetSumm(numb);
    Console.WriteLine($"Сумма всех цифр числа {numb} = {sum}");
}
catch 
{
    Console.WriteLine("Введен неверный формат числа. Введите целое число!");
}