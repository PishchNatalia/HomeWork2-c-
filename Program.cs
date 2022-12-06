// Домашняя работа 2
// Задача 1.Напишите программу,которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)  // Метод выделения второго числа.

{
 int second =num / 10 % 10;
 return second;
}

Console.WriteLine("Введите трехзначное число: ");
 int num = Convert.ToInt32(Console.ReadLine());

    if (num > 999 || num <100)
    Console.WriteLine("Вы ввели не трехзначное число!");

else 

 {
    int newnum = SecondDigit(num);
    Console.WriteLine("Вторая цифра этого числа: " + newnum);
 
*/

// Задача 2.Напишите программу,которая выводит третью цифру заданного числа  или сообщает, что третьей цифры нет.
/*
int CutThirdDigit(int number)
{
    while(number > 999)
    {
    number = number /10;
    }
    int thirdNum = number % 10;
    return thirdNum;
}

Console.WriteLine("Enter a number: ");
 int num = Convert.ToInt32(Console.ReadLine());
 if (num < 100)
 {
    Console.WriteLine("Entered number does not have a third digit");
 }
 else
 {
    int cut = CutThirdDigit(num);
    Console.WriteLine($"The third digit of number {num} is {cut}");
 }

 */

 // Задача 3.Напишите программу, которая принимает на вход цифру,обозначающую день недели и проверяет ,является ли этот день выходным.
/*
bool Weekend(int num)
{
    if (num ==6 || num == 7)
{
return true;
}
else
{
    return false;
}
}
Console.WriteLine("Введите число,обозначающее день недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <1 || num > 7)
{
    Console.WriteLine("Такого дня недели нет");

}
else
{
    bool sandays = Weekend(num);
    if (sandays == true)
{

    Console.WriteLine("Этот день выходной!");
}
else
{
    Console.WriteLine("Этот день не выходной!");
}
}
*/