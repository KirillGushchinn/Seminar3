/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
cub(input);

void cub (int num) {
    int i=1;
    Console.Write($"{num} -> ");
    while (i<=num){
       Console.Write($" {i*i*i}");
       i++;
    }
}