// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите 3х значное число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// if(value > 99 && value < 1000)
// {
//     int number = (value / 10) % 10;
//     Console.WriteLine($"Ответ: {number}");
// }
// else
// {
//     Console.WriteLine($"Вы ввели не 3х значное чило!");
// }


// Задача 13: Напишите программу, которая выводит третью цифру ПЯТИЗНАЧНОГО числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите 5-ти значное число: ");
//int value = Convert.ToInt32(Console.ReadLine());
int value = 12345;
if(value > 9999 && value < 100000)
{
    // int number1 = (value / 10000);
    // Console.WriteLine($"Ответ 1я цифра: {number1}");

    // int number2 = (value / 1000) % 10;
    // Console.WriteLine($"Ответ 2я цифра: {number2}");

     int number3 = (value / 100) % 10;
     Console.WriteLine($"Ответ 3я цифра: {number3}");

    // int number4 = (value / 10) % 10;
    // Console.WriteLine($"Ответ 4я цифра: {number4}");

    // int number5 = (value % 10);
    // Console.WriteLine($"Ответ 5я цифра: {number5}");
}
else
{
    Console.WriteLine($"Третей цифры нет!");
}


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите день недели, цифрой: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day > 0 && day < 8)
// {
//     if(day > 5)
//     {
//         Console.WriteLine($"да");
//     }
//     else
//         Console.WriteLine($"нет");
// }
// else
// {
//     Console.WriteLine($"Вы ввели не верное значение");
// }
