/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

int number = ReadInt("Введите десятичное число: ");
string binaryNumber = "";
int baseNumber = 2;
while(number > 0)
{
    int divider = number % baseNumber;
    binaryNumber = divider + binaryNumber;
    number /= baseNumber;
}
Console.WriteLine(binaryNumber);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}