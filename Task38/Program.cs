// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[]array = new int[5];
FillArray(array, -100, 100);
PrintArray(array);

// найти миниальное число массива.
int min = array[0], minIndex = 0;
for (int i = 0; i < array.Length; i++)
{
	if (min > array[i])
	{
		min = array[i];
		minIndex = i;
	}
}
Console.WriteLine($"Минимальное число массива = {min}");

// найти миниальное число массива.
int max = array[0], maxIndex = 0;
for (int i = 0; i < array.Length; i++)
{
	if (max < array[i])
	{
		max = array[i];
		maxIndex = i;
	}
}
Console.WriteLine($"Минимальное число массива = {max}");

// Разница между максимальным и минимальным
// элементов массива

int num = 0;
num = max - min;
Console.WriteLine($"Разница между максимальным и минимальным значением {num}");
