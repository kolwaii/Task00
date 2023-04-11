// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int ThirdtNumber = Convert.ToInt32(Console.ReadLine());
int max;

if (firstNumber > SecondNumber)
{
    max = firstNumber;
}
else
{
    max = SecondNumber;
}
if (ThirdtNumber > max)
{
    max = ThirdtNumber;
    Console.WriteLine($"Максимальное из трех чисел: {max}");
}
else
{
    Console.WriteLine($"Максимальное из трех чисел: {max}");
}
