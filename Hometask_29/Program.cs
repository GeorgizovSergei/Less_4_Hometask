// Задача 29: 
// Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void Fillarray(int[] namemassive) 
{
    int lenght = namemassive.Length;                                      
    int index = 0;                   
    while (index < lenght) 
    {
        namemassive[index] = new Random().Next(1, 50); 
        index++;
    }
}

void Printarray(int[] namass)
{
    int sizemass = namass.Length;
    int posit = 0;
    Console.Write("[ ");
    while (posit < sizemass)
    {
        Console.Write($"{namass[posit]} ");
        posit++;
    }
    Console.Write("]");
}

int[] array1 = new int[8]; 

Fillarray(array1);
Printarray(array1);

