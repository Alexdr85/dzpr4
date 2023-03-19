// SЗадача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int f(int a)
{
    int sum = 0;
    for(int i = 1; a > 0; i++)
    {
        sum = sum + a%10;
        a = a/10;
    }
    return sum;
}
Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр {f(x)}");