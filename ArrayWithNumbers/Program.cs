﻿

using System.Diagnostics.CodeAnalysis;

int[] numbers = new int[10];
Random rnd = new Random();
//kannan juhuslikud numbrid massiivi

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{ 
numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach (int number in numbers)
    //kuvame arvud massiivis
{
Console.WriteLine(number);
}
Console.WriteLine($"Total: {sum}");