int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

int number = ReadInt("Введите число: ");

if (number < 0)
{
    Console.WriteLine("Число должно быть больше или равно 0!");
}
else
{
    Console.WriteLine(SumOfDigits(number));
}

