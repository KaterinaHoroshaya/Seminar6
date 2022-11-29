int count = ReadInt("Введите количество членов ряда Фибоначчи: ");
int[] fibonacci = new int[count];

if(count > 0)
    fibonacci[0] = 0;
if(count > 1)
    fibonacci[1] = 1;

for (int i = 2; i < count; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}
WriteArray(fibonacci);

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

