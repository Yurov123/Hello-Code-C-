﻿// Метод + Массив

int[] array = {14, 42, 33, 4, 65,18, 6, 87, 18};

int n = array.Length;
int find = 18;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    } 

    index++;
}






