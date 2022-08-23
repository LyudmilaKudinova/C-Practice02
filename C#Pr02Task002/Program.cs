//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 999 && a > 99)
{
    Console.WriteLine((a / 10) % 10);
}

if(a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
 
if(a > 999)
{
    Console.WriteLine(a>99 ? a.ToString()[2] : '-');
    Console.ReadKey(true);
}

   
