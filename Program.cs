/*
// ?

string name = "Elena";
int age = 99;
Console.WriteLine($"Name: {name, -10} Age: {age}");
Console.WriteLine($"Name: {name, 15} Age: {age}");


// ?

int x = 8;
int y = 7;
String result = $"{x} + {y} = {x + y}";
Console.WriteLine(result);



// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateRandomArray(int size, int min, int max)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(min, max + 1);
}
return array;
}

void SammResalt(int[] array)
{
int resaltA = 0;
int resaltB = 0;

for (int i = 0; i < 12; i++)
{
if (array[i] < 0)
{
resaltA += array[i];
}
else
{
resaltB += array[i];
}
}
Console.WriteLine($"Сумма отрицательных чисел = {resaltA}");
Console.WriteLine($"Сумма положительных чисел = {resaltB}");
}


void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
}


int[] MayArray = CreateRandomArray(12, -9, 9);

ShowArray(MayArray);
Console.WriteLine();
SammResalt(MayArray);

// 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] creatRandomArray(int size, int min, int max)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(min, max + 1);
}
return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
Console.WriteLine();
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input start: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input end: ");
int end = Convert.ToInt32(Console.ReadLine());
int[] newArray = creatRandomArray(size, start, end); // новый массив , в ктр. записывается результат метода

ShowArray(newArray);

for (int i = 0; i < size; i++)
{
newArray[i] = newArray[i] * -1; // newArray[i] *= -1;
}
ShowArray(newArray);


// 3. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int size, int min, int max)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
// for (int i = 0; i < 8; i++)
{
array[i] = new Random().Next(min,max);
}

return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
// for (int i = 0; i < 8; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

void PruductMassive(int [] array)
{
int result = 1;
int length = array.Length / 2;

for (int i = 0; i < length; i++)
{
result = array[i] * array[array.Length - 1 - i];
Console.WriteLine(result);
}

}

Console.WriteLine("Input quantity of elements of the massive: ");
int elements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of the massive: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of the massive: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateArray(elements, minimum, maximum);
ShowArray(myArray);
PruductMassive(myArray);




// Домашняя работа.

// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] numbers = new int [9];

void Random(int [] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    Console.WriteLine();
}

void Write(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
}

int Positive(int [] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

Random(numbers, 100, 1000);
Write(numbers);
Console.WriteLine();

int quantity = Positive(numbers);
Console.WriteLine($"Number of even numbers: {quantity}");
Console.WriteLine();


// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.Write("Array: ");
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);
        Console.Write(randomNumbers[i] + " ");
        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

Console.WriteLine();
Console.Write("Input array length: ");
int numberElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int randomNumbers = RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nSum of elements in odd positions: {randomNumbers}");
Console.WriteLine();
*/

// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[6];
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}

double result = max - min;

Console.WriteLine($"\nDifference between the maximum number {max} and minimal {min} number = {result}");
Console.WriteLine();