// Задача 34. Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



void Zadacha34()
    {
    Random random = new Random();
    int size = random.Next(5, 20);
    int[] array = new int[size];
    FillArray(array);
    EvenParityArray(array);
    }

    void FillArray(int[] array)
        {
        Console.Write("[ ");
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-999, 1000);
                Console.Write(array[i] + " ");
            }
        Console.Write("]");
        Console.WriteLine();
        }

    void EvenParityArray(int[] array)
        {
        int num = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0)
                    {
                        num++;
                    }
            }
        Console.WriteLine("Количество четных чисел в массиве: " + num);
        }


// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void Zadacha36()
{
    Random random = new Random();
    int size = random.Next(5, 10);
    int[] array = new int[size];
    FillArray(array);
    SumOdd(array);

    void SumOdd(int[] array)
    {
        int num = array[1];
        
        for (int i = 3; i < array.Length; i++)
            {
                if (i % 2 == 1)
                    {
                        num = num + array[i];
                    }
            }
        Console.WriteLine("Сумма нечетных элементов массива: " + num);
    }
}

// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha38()
{
    Random random = new Random();
    int size = random.Next(5, 10);
    double[] array = new double[size];
    FillArrayDouble (array);
    SearchMinMax (array);
    
        void FillArrayDouble(double[] array)
            {
            Console.Write("[ ");
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-99, 100);
                    array[i] = array[i] + Math.Round((rand.NextDouble()/100), 2);
                    Console.Write(array[i] + " ");
                }
            Console.Write("]");
            Console.WriteLine();
            }
        void SearchMinMax(double[] array)
            {
                double min = array[0];
                double max = array[0];

                for (int i = 0; i < array.Length; i++)
                    {
                    if (array[i] < min)
                        {
                            min = array[i];
                        }
                        
                    if (array[i] > max)
                        {
                            max = array[i];
                        }
                    }
                Console.WriteLine("Максимальный элемент массива равен " + max);
                Console.WriteLine("Минимальный элемент массива равен " + min);
                Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + (max-min));
            }
}

//Zadacha34();
//Zadacha36();
//Zadacha38();