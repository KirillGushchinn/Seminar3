/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
Check(input);
    
void Check (int num) 
{
    int ish=num;
    int temp;
    int revers=0;
    while (num>0)
    {
        temp=num%10;
        revers=revers*10+temp;
        num=num/10;
    }
    //Console.WriteLine(revers);
    if (ish==revers) {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}