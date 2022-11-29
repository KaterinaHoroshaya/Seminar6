int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

for(int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = numbers[i];
    numbers[i] = temp;
}
WriteArray(numbers);

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

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

