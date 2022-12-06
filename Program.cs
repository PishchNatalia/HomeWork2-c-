// Домашняя работа 2
// Задача 1.Напишите программу,которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutSecondNumber(int num) // Метод выделения второго числа.
{
 int sot =num / 10 ;
 int des = sot % 10;

return des;
}
// Проверяем число на трехзначность.
/*bool ChekingDigit(int num)
{
    if (num < 100 || num >1000)
}
retern false;

else 
 {
    retern true;
 }
*/
/*
Console.WriteLine("Введите трехзначное число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 if (ChekingDigit(num) == true)

 {
    int des = CutSecondNumber(num);
    Console.WriteLine($"New version of a number {num} is {des} ");
 }
else
{
    Console.WriteLine("Вы ввели не трехзначное число! ");
}
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

 
