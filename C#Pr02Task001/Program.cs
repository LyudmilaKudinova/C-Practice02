// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());

    if(num1 < 99)
    {
        Console.WriteLine("Ошибка! Введите трехзначное число: ");
    }
int num2 = ((num1/10) % 10);
 Console.WriteLine(num2); 
    
    