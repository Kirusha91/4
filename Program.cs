﻿// Console.WriteLine("Введите номер: ");
// int num =Convert.ToInt32(Console.ReadLine());

// Задача 2: Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// int a = 5, b = 7;

// if(a > b)
// {
//     Console.Write($"Максимальное число {a}, минимальное число {b}");

// }
// else
// {
//     Console.Write($"Максимальное число {b}, минимальное число {a}");

// }


// int a = 2, b = 10;

// if(a > b)
// {
//     Console.Write($"Максимальное число {a}, минимальное число {b}");

// }
// else
// {
//     Console.Write($"Максимальное число {b}, минимальное число {a}");

// }


// int a = -9, b = -3;

// if(a > b)
// {
//     Console.Write($"Максимальное число {a}, минимальное число {b}");

// }
// else
// {
//     Console.Write($"Максимальное число {b}, минимальное число {a}");

// }


// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int a = 2, b = 3, c =7, d = 0;

// if(a > b){
//     d = a;
// }
// else{
//     d = b;
// }
// if(c > d){
//     Console.Write($"Максималльное число {c}");
// }
// else {
//     Console.Write($"Максимальное число {d}");
// }

// int a = 44, b = 5, c =78, d = 0;

// if(a > b){
//     d = a;
// }
// else{
//     d = b;
// }
// if(c > d){
//     Console.Write($"Максималльное число {c}");
// }
// else {
//     Console.Write($"Максимальное число {d}");
// }


// int a = 22, b = 3, c =9, d = 0;

// if(a > b){
//     d = a;
// }
// else{
//     d = b;
// }
// if(c > d){
//     Console.Write($"Максималльное число {c}");
// }
// else {
//     Console.Write($"Максимальное число {d}");
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// int a = 4;
// if( a % 2 == 0 ){
//     Console.Write($"Число {a} является четным");
// }
// else{
//     Console.Write($"Число {a} является не четным");
// }


// int a = -3;
// if( a % 2 == 0 ){
//     Console.Write($"Число {a} является четным");
// }
// else{
//     Console.Write($"Число {a} является не четным");
// }

// int a = 7;
// if( a % 2 == 0 ){
//     Console.Write($"Число {a} является четным");
// }
// else{
//     Console.Write($"Число {a} является не четным");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;

while( i <= n ){
    if( i % 2 == 0 ){
        Console.Write($" {i} ");
    }
    i += 1;
}