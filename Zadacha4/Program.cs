// Напишите программу, которая на вход принимает целое число N,
// а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());

int a=1;

while(a<=N)
{
    if (a % 2 ==0)
       {
        Console.Write(a +", ");
       }
    a=a+1;
}
