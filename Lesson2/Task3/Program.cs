﻿int n = 10;
int[] array = {2,4,6,8,434,544,654,54,65,75};
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}