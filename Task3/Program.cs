int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SetAnArray(int[] collection)
{
    for(int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] collection)
{
    for(int index = 0; index < collection.Length; index++)
    {
        Console.Write(collection[index] + " ");
    }
}

int len = ReadInt("Введите длину массива: ");

if (len <= 0)
{
    Console.WriteLine("Длина массива должна быть больше 0!");
}
else
{
    int[] array = new int[len];
    SetAnArray(array);
    PrintArray(array);
}

