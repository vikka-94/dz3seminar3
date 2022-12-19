//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("Введите пятизначное значное число: ");
string number = Console.ReadLine();
int size = number.Length;
if (size == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " Палиндром :)");
    }
    else
    {
        Console.WriteLine(number + " Не являетс палиндромом :(");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}