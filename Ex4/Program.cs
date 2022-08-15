// Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке
//[1,1,1,0,1,0,1]

void FindArr()
{
int[] array = new int[8];
Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = rand.Next(2);
    Console.Write($"{array[i]} ");
    }
}
 FindArr();