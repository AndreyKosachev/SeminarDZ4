﻿// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int prompt (string message)
{
    System.console.Write (message);
    String ReadInput = System.console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
Не успеваю сделать