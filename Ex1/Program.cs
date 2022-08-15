// Напишите программу, котоорая принимает на вход число А
//и выдает сумму чисел от 1 до А

int FindSumm (int a)
{
    int sum = 0;
    for(int i = 0; i <= a; i++)
    {
        sum += i;
    }
    return sum;   
}
Console.WriteLine (FindSumm(10));
