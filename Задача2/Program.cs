﻿/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */

int A = ReadInt("Введите длину стороны A: ");
int B = ReadInt("Введите длину стороны B: ");
int C = ReadInt("Введите длину стороны C: ");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

if (A < (B+C) && B < (A+C) && C < (A+B))
{
    Console.WriteLine($"Треугольник со сторонами {A}, {B} и {C} существует");
}
else 
{
    Console.WriteLine("Такого треугольника существовать не может");
}