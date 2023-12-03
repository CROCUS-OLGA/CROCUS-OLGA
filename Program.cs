// comment

// Console.Clear();
// Console.Write("Введите число: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(s+5);
// Console.WriteLine(s);

// задача проверяет, является ли  первое число квадратом второго. Если да ответ yes? иначе no/
// -----------------------------------------------------------------------------------------------

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int i = n * (-1);
// while (i <= n)
// {
//     Console.Write(i +" ");
//     i ++;
// }
//-----------------------------------------------------------------

//  int numberA = new Random().Next(1,10); // 123456789
//  Console.WriteLine(numberA);
//  int numberB = new Random().Next(1,10);  // 123456789
//  Console.WriteLine(numberB);
//   Console.WriteLine(numberA + numberB);
//-----------------------------------------------------------
// double numberA = 55;
// double numberB = 9;
// Console.WriteLine(numberA / numberB);

// Console.Write("введите имя пользователя:");
// string username = Console.ReadLine();
// if (username.ToLower() == "Olga")
// {
//     Console.WriteLine("Ура, это же Olga!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }
// ------------------------------------------------


// int xa = 3;
// int ya = 3;
// int xb = 1;
// int yb = 7;
// int xc = 9;
// int yc = 80;
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");
// ---------------------------------------------------------------------------------------------------------
// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Первое число `" + firstNumber + "` больше чем второе число `" + secondNumber + "`");
// }

// else if (firstNumber == secondNumber)
// {
//     Console.WriteLine("введенные числа равны " + firstNumber);
// }

// else
// {
//     Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber + "`"); 
// }
// ----------------------------------------------------------------------------------------------------------------
// static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         if (firstNumber == secondNumber)
//         {
//             Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//         }
//         if (firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//         }
//         if (firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//         }
//     }
// --------------------------------------------------------------------------------------------------------------------
// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третие  число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// int max = firstNumber;
// if (max < secondNumber)
//     max = secondNumber;
// if (max < thirdNumber)
//     max = thirdNumber;
// Console.WriteLine(max);
// ----------------------------------------------------------------------------------------------------------------------------
// Console.WriteLine("Введите  число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
//     Console.WriteLine($"Число `{number}` четное ");
// else
//     Console.WriteLine($"Число `{number}` нeчетное ");
//----------------------------------------------------------------------------------------------------------
// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//         if ((number % 2) == 0)
//         {
//             Console.WriteLine($"Число `{number}` чётное");
//         }
//         else
//         {
//             Console.WriteLine($"Число `{number}` нечётное");
//         }
//     }
// --------------------------------------------------------------------------------------------------
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 6;
//         }

//         CheckIfEven(number);
//     }
// }
// ----------------------------------------------------------------------------------------------------------
Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = 2;

    while ((num <= number))
{
    Console.Write(num);
    Console.Write("\t");
    num += 2;
}



