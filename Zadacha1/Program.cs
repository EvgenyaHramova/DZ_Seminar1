// Напишите программу,которая на вход принимает два целых числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2=Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.WriteLine("Максимальным является число: " + num1);
    Console.WriteLine("Минимальным является число: " + num2);
}
else
{
    Console.WriteLine("Максимальным является число: " + num2);
    Console.WriteLine("Минимальным является число: " + num1);
}
