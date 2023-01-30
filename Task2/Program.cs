// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
System.Console.WriteLine("Введите 5-и значное число");
int a = Convert.ToInt32(Console.ReadLine());
int firstnumber = a / 1000; 
int secondnumber = a % 100; 
if (firstnumber == secondnumber)
{
    System.Console.WriteLine("Введеное число является палиндромом");
}
else
{
    System.Console.WriteLine("Введеное число не является палиндромом");
}