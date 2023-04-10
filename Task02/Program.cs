// Задача 2. Напишите программу, 
// которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее

Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int min;
int max;
if (numA > numB) 
{
    max = numA;
    min = numB;
    Console.WriteLine($"большее число {max} меньшее число {min}");
}
else if (numA < numB)
{
    max = numB;
    min = numA;
    Console.WriteLine($"большее число {max} меньшее число {min}");
}
else 
{
    Console.WriteLine("Вы ввели неверное число");
}