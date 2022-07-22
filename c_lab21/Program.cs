/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите A(x): ");
int inputAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A(y): ");
int inputAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A(z): ");
int inputAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B(x): ");
int inputBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B(y): ");
int inputBy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B(z): ");
int inputBz = Convert.ToInt32(Console.ReadLine());
Расстояние(inputAx,inputAy,inputAz,inputBx,inputBy,inputBz);

void Расстояние (int Ax, int Ay,int Az,int Bx,int By,int Bz) {
    double result=Math.Round(Math.Sqrt((Bx-Ax)*(Bx-Ax) + (By-Ay)*(By-Ay) + (Bz-Az)*(Bz-Az)), 2);
    
    Console.WriteLine($"Расстояние между точками - {result}");
}