// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

void Print(int[]array)
{
    for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int [] mass = new int [4];

for(int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100,999);
}

Print(mass);
int count = 0;

for (int i=0;  i < mass.Length; i++)
{
    if( mass[i] / 2 == 0)
    {
        count++;
    }
    
}
Console.WriteLine(count);
