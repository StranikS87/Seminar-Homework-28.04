// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void Print(int[]mass)
{
    for(int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
}

int [] mass = new int [4];

for(int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-100, 100);
}

Print(mass);

int summNech = 0;
int summChet = 0;

for(int i = 0; i < mass.Length; i++)
{
    if(i % 2 == 0)
    summNech = summNech + mass[i];
    else
    summChet = summChet + mass[i];
}
Console.WriteLine($"Сумма нечётных чисел равна = {summNech}");