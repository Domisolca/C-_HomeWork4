int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int DegreeOfNumber(int number, int degree)
{
    int result = 1;
    
    for (int i = 1; i <= degree; i++)
    {
        result *= number;
    }

    return result;
}

int number = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень: ");

if (number < 0 || degree < 0)
{
    Console.WriteLine("Число и степень должны быть больше либо равны 0!");
}
else
{
    Console.WriteLine(DegreeOfNumber(number, degree));
}



