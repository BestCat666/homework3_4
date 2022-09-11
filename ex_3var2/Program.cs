// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// В этом варианте пользователь задаёт не только кол-во элементов в массиве, но и сам вводит элементы с клавиатуры.

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
   Console.Write($"{(i == 0 ? col[i] : "," + col[i])}");
}
Console.WriteLine("]");
Console.WriteLine();
}
FillArray(array);
PrintArray(array);









 
