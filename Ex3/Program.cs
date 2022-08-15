//Напишите тимаеторая прин которая принимает на вход число А
// и выводит произведение этих чисед от 1 до А
 int FindFactor(int a)
 {
    int resalt = 1;
    for(int i = 1; i <= a; i++)
    {
        resalt *= i;
    }
    return resalt;
 }
Console.WriteLine (FindFactor(5));
