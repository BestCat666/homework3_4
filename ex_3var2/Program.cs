// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] array = new int [elementsCount];
void FillArray(int[] collection)
{  
  for (int i = 0; i < collection.Length; i++)
{    
    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
    collection[i] = int.Parse(Console.ReadLine());
}
}
void PrintArray(int[] col)
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
{
   Console.Write($"{array[i]}, ");
}
Console.WriteLine("]");
Console.WriteLine();
}
FillArray(array);
PrintArray(array);









 
