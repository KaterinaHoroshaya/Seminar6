int number = ReadInt("Введите десятичное число: ");
int baseNumber = 2;
int tempNumber = number;
int count = 0;
while(tempNumber > 0)
{
    count++;
    tempNumber /= baseNumber;
}
int[] binary = new int[count];

for(int i = binary.Length - 1; i >= 0; i--)
{
    binary[i] = number % baseNumber;
    number /= baseNumber;
}

WriteArray(binary);

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

