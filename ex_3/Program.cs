// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
void FillArray(int[] collection)
{ 
 int length = collection.Length;
 int index = 0;
 while (index < length)
{
    collection[index] = new Random().Next(0, 1000); // выбрала такой диапазон значений
    index++;
}
Console.WriteLine();
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
{
    Console.Write($"{(position == 0 ? col[position] : "," + col[position])}");
    position++;
}
Console.WriteLine("]");
Console.WriteLine();
}

int [] array = new int [elementsCount];; // new int[число]; создать массив с определённым кол-ом чисел.изначально будет заполнен нулями
FillArray(array);
PrintArray(array);