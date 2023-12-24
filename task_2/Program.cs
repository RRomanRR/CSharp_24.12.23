// 2. Напишите программу, которая принимает на вход трёхзначное
//    число и возводит вторую цифру этого числа в степень, равную
//    третьей цифре.


int a = int.Parse(Console.ReadLine()!);

int SecondNum = a / 10 %10;

int ThirdNumber = a % 10;

Console.WriteLine (Math.Pow(SecondNum,ThirdNumber));