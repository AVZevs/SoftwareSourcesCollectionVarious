﻿/* 
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n.

Примеры:

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

m = 3, n = 11 -> A(m,n) = 16381
m = 11, n = 3 -> A(m,n) -> Stack overflow

Заметка: Функция Аккермана - это всюду определённая вычислимая функция, которая не является примитивно рекурсивной.

Она принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число. Обозначается как A(n, m).

Эта функция растёт очень быстро. Например, число A(4, 4) настолько велико, что количество цифр в порядке этого числа многократно превосходит количество атомов в наблюдаемой части Вселенной.

В теоретической информатике функция Аккермана применяется для демонстрации пределов возможностей компьютеров и методов оптимизации.

https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0

*/

int FunctionAckerman(int m, int n) 
{ 
    if (m == 0) 
        return n + 1; 
    if (n == 0) 
        return FunctionAckerman(m - 1, 1); 
    return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1)); 
} 

Console.WriteLine("Программа вычисляет функцию Аккермана для чисел M и N. Числа M и N должны быть НЕотрицательными!");

int numM = -1;
while (numM < 0)
{
    Console.Write("Введите неотрицательное число M: ");
    numM = Convert.ToInt32(Console.ReadLine());
    if (numM <= 0) Console.WriteLine("Введенное число отрицательное! Повторите ввод.\n");
}

int numN = -1;
while (numN < 0)
{
    Console.Write("Введите неотрицательное число N: ");
    numN = Convert.ToInt32(Console.ReadLine());
    if (numN <= 0) Console.WriteLine("Введенное число отрицательное! Повторите ввод.\n");
}

int result = FunctionAckerman(numM, numN); 
Console.WriteLine($"Функия Аккермана для чисел ({numM}, {numN}) равна {result}"); 
