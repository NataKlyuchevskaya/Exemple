// разные примеры решения задач


void Zadacha24()
{
// задача 24. Напишите программу, которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А.
// 7->28, 4->10, 8->36

Console.WriteLine("Напишите программу,которая принимает на вход число (А) и выдает сумму чисел от 1 до А.");                  
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number; i++)
{
    sum += i;
}
Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");

}


void Zadacha26()
{
// напишите программу, которая принимает на вход число и выдает количество цифр в числе

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number > 0)
{
   number = number / 10;
   count++; 
}
Console.WriteLine($"Количество цифр в числе {number} равна {count}");
}

void Zadacha28()
{
//напишите программу, которая принимает на вход число N и выдает
//произведение чисел от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int fact = 1;

for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }
Console.WriteLine($"Произведение чисел {number} равно {fact}");
}


void Zadacha30()
{
//прога, которая выводит массив из из 8 элементов, заполненный
//нулями и единицами в случайном порядке

int size = 8;
int[] array = new int[size];
int x;
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    x = rand.Next(0, 2);
    array[i] = x;
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
}


void Zadacha25()
{
//напишите цикл, который принимает на вход два числа А и В 
//и возводит число А в натуральную степень В
int a = 5;
int b = 3;
Power(a, b);
Math.Pow(a, b);
}


void Zadacha27()
{
//напишете программу, которая принимает на вход число
//и выдает сумму цифр в числе.
int number = 1873;
SumOfDigits(number);
}

void SumOfDigits(int number)
{
    int sum = 0;
    Console.Write("Сумма цифр числа " + number);
    while(number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    Console.WriteLine(" равна " + sum);
}

void Zadacha29()
{
//напишите программу, которая задает массив из 8 случайных целых чисел
//и выводит отсортированный по модулю массив.
int size = 8;
int[] array = new int[size];
FullArray(array);
PrintArray(array);
Sort(array);
PrintArray(array);
}


void Zadacha31()
{
//задайте массив из 12 элементов, заполненный случайными числами из промежутка -9, 9 
//Найдите сумму отрицательных и положительных элементов массива
int size = 12;
int[] array = new int[size];
FullArray(array, -9, 9);
PrintArray(array);

int sumPositive = 0;
int sumNegetive = 0;
for(int i = 0; i < size; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else

            sumNegetive += array[i];
    }
        Console.WriteLine("Сумма положительных элементов равна " + sumPositive);
        Console.WriteLine("Сумма отрицательных элементов равна " + sumNegetive);
}

void Zadacha32()
{
//напишите программу замены элементов массива: положительные элементы замените на
//соответствующие отрицательные и наоборот
int size = new Random().Next(4, 10);
int[] array = new int[size];
FullArray(array);
PrintArray(array);
Reverse(array);
PrintArray(array);
}

void Zadacha33()
{
//задайте массив. Напишите программу,которая определяет,
//присутствует ли заданное число в массиве. 4; массив [6,7, 19, 345, 3] -> нет
int size = new Random().Next(4, 10);
int[] array = new int[size];
FullArray(array);
PrintArray(array);


Console.WriteLine("введите искомый элемент ");
int number = Convert.ToInt32(Console.ReadLine());
bool flag = false;
for (int i = 0; i < size && !flag; i++)  //!flag - обозначает отрицание лжи, а значит истина
    {
        if (number == array[i]) // flag = number ==array[i];
        {
            flag = true;
        }
    }    
if (flag) Console.WriteLine("Элемент "  + number + " найден в массиве");
else Console.WriteLine(" элемент не найден");

}

void Zadacha35()
{
//задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10, 99]
int size = 10;
int[] array = new int[size];
FullArray(array, -99, 100);
PrintArray(array);

int count = 0;
for (int i = 0; i < size; i++) 
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
Console.WriteLine($"в массисе {count} чисел, лежащих на отрезке от [10, 99]");
}

void Zadacha37()
{
//найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
//элемент второй и предпоследний и т.д. Результат запишите в новом массиве.
int size = 7;
int[] array = new int[size];
FullArray(array);
PrintArray(array);

    int maxIndex = size - 1;
    int halfSize = size / 2;
    for (int i = 0; i < halfSize; i++) 
        {
            Console.WriteLine($"{array[i]} * {array[maxIndex -i]} = {array[i] * array[maxIndex -i]}");
        }
        if (size % 2 == 1)
        {
            Console.WriteLine(array[halfSize]);
        }
}



void Reverse(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] *= -1;
    }
}

void FullArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
  finishNumber++;
  Random random = new Random();
for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }  
}


void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
Console.WriteLine();
}



void Sort(int[] array)
{
for (int i = array.Length -1; i > 0; i--)
    {
        for(int k = 0; k < i; k++)
        {
            if(Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        } 
    }

}



void Power(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}

// примеры из домашней работы
//


void Zadacha34()
{
    //задайте массив заполненный случайными положительными трёхзначными числами. 
    //напишите программу, которая покажет количество чётных чисел в массиве.

    Random random = new Random();
    int size = random.Next(5, 11);
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0) count++;
        }
    Console.WriteLine($"В массиве {count} четных чисел");  
}

void Zadacha23()
{
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях
    Random random = new Random();
    int size = random.Next(5, 11);
    int[] array = new int[size];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;
    for (int i = 1; i < array.Length; i+= 2)
        {
            sum += array[i];
        }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {sum}");  
}


void Zadacha38()
{
//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементом массива.
Random random = new Random();
int size = random.Next(5, 11);
double[] array = new double[size];
FillArrayDouble(array, 1000, 100000);
PrintArrayDouble(array);

double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
    Console.WriteLine($"Разница между минимальным элементом {min}  и максимальным {max} равна {max - min}");
}


void Zadacha39()
{
//напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)

Random random = new Random();
int size = random.Next(5, 11);
int[] array = new int[size];
FillArray(array, 0, 10);
PrintArray(array);

int halfsize = size/2;
int maxIndex = size - 1;
for (int i = 0; i < halfsize; i++)
    {
        int temp = array[i];
        array[i] = array[maxIndex - 1];
        array[maxIndex - 1] = temp;
    }
PrintArray(array);
}


void Zadacha40()
{
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
// треугольник со сторонами такой длинны (теорема о неравенстве треугольника: каждая сторона
// треугольника меньше суммы двух других сторон)

Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a+b<=c || a+c<=b || b+c<=a) Console.WriteLine("данный треугольник не существует");
else Console.WriteLine("данный треугольник существует");
}

void Zadacha42()
{
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.WriteLine("Введите десятичное число и нажмите Еnter");
int i = Convert.ToInt32(Console.ReadLine());
string s= Convert.ToString(i,2);
Console.WriteLine("В двоичном коде это: " + s);

}
    /*
    // хорошее решение задачи 42, но не вывелось
    Console.WriteLine("Напишите число ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = 0;
    int i = 0;
    while (a > 0);
    {
        int temp = a%2;
        b += temp*Pow(10,i);
        a = a/2;
        i++;
    }
    Console.WriteLine(b);


    int Pow(int num, int prod)
    {
        int temp = 1;
        for (int i = 0; i < prod; i++)
        {
            temp = temp * num;
        }
        return temp;
    }
*/



void Zadacha44()
{
//не используя рекурсию, выведите первые N чисел Фибоначчи. первые два числа Фибоначчи: 0 и 1

    double numberFirst = 0;
    double numberSecond = 1;
    Console.WriteLine("введите число: ");
    int count = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < count; i++)
        {
            Console.WriteLine(numberFirst);
            double temp = numberFirst;
            numberFirst = numberSecond;
            numberSecond = numberFirst + temp;

        }
}


void Zadacha45()
{
//напишите программу, которая будет создавать копию заданного массива с 
//помощью поэлементного копирования
Random random = new Random();
int size = random.Next(5, 11);
int[] array = new int[size];
FillArray(array, 0, 10);
PrintArray(array);

int[] arraySecond = new int[array.Length];
for (int i = 0; i < size; i++)
{
    arraySecond[i] = array[i];
}
PrintArray(arraySecond);
}

void Zadacha46()
{
//задайте двумерный массив размером m x n заполненный случайными целыми числами
//m = 3, n = 4

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] array = new int[rows, columns];
FillArray2(array, -99, 99);
PrintArray2(array);
}


void Zadacha48()
{
//задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: A = m+n.  Выведите полученный массив на экран 

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] array = new int[rows, columns];
FillArray3(array);
PrintArray3(array);
}

void Zadacha49()
{
//задайте двумерный массив. Найдите элементы, у которых оба индекса четные, 
//и замените эти элементы на их квадраты.
Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] array = new int[rows, columns];
FillArray3(array, 0, 10);
PrintArray3(array);
CheckArray(array);
Console.WriteLine();
PrintArray3(array);
}

void Zadacha51()
{
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0));
// (1; 1) и т.д.
Random random = new Random();
int rows = random.Next(8, 8);
int columns = random.Next(8, 8);
int[,] array = new int[rows, columns];
FillArray3(array, 0, 10);
PrintArray3(array);
DiagonalArray(array);
}

void DiagonalArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {
            if (i == j) sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма элементов на главной диагонали равна {sum}");
}



void CheckArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array [i, j] * array[i, j];
        }
    }
}



void FillArray3(int[,] array, int startNumber = 0, int finishNumber = 9)
{
    finishNumber++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
}

void PrintArray3(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray2(int[,] array, int startNumber = 0, int finishNumber = 9)
{
    finishNumber++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray2(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


void FillArrayDouble(double[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 10 - 5, 2);
    }
}


void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArrayDouble(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine();
}









//Zadacha24();
//Zadacha26();
//Zadacha28();
//Zadacha30();
//Zadacha25();
//Zadacha27();
//Zadacha29();
//Zadacha31();
//Zadacha32();
//Zadacha33();
//Zadacha35();
//Zadacha37();
//Zadacha34();
//Zadacha23();
//Zadacha38();
//Zadacha39();
//Zadacha40();
//Zadacha42();
//Zadacha44();
//Zadacha45();
//Zadacha46();
//Zadacha48();
//Zadacha49();
Zadacha51();