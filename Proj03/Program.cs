using System.Threading.Channels;

namespace Proj03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Input a Number");

            //int.TryParse(Console.ReadLine(), out int num);

            //if (num % 3 == 0 && num % 4 ==0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion





            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Input Number to check if its negative number");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num < 0)
            //{
            //    Console.WriteLine("Negative Number");
            //}
            //else 
            //{
            //    Console.WriteLine("Poisitive");
            //}



            #endregion








            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.WriteLine("Input just three numbers to get the max number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out int num3);

            //Console.WriteLine(Math.Max(num1, Math.Max(num2, num3)));
            #endregion







            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Input number to check if its even or odd");
            //int.TryParse(Console.ReadLine(), out int num);

            //string msg =  num % 2 == 0 ? "Even Number" : "Odd Number";

            //Console.WriteLine(msg);



            #endregion




            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).


            //Console.WriteLine("Input any character to check if its vowel or consonant");

            //char.TryParse( Console.ReadLine(),out char c);

            //switch (c)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':

            //        Console.WriteLine("vowel");
            //        break;


            //        default:
            //        Console.WriteLine("consonant");
            //        break;

            //}




            #endregion




            #region 6 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("Input number");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= num; i++)
            //{

            //    Console.WriteLine(i);
            //}


            #endregion




            #region 7 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("Input number");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= 12; i++) 
            //{

            // Console.WriteLine($"{num} * {i} = {num * i}");
            //}





            #endregion


            #region 8 -  Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Input number");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= num; i++)
            //{
            //    if(i%2 == 0)
            //    {

            //      Console.WriteLine(i);

            //    }
            //}



            #endregion



            #region 9 - Write a program that takes two integers then prints the power.

            //Console.WriteLine("Input Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine("Input Power");
            //int.TryParse(Console.ReadLine(), out int pow);

            //  Console.WriteLine(Math.Pow(num, pow));




            #endregion


            #region 10 - Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Input five marks to get the Average and Percentage");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //int.TryParse(Console.ReadLine(), out int num3);
            //int.TryParse(Console.ReadLine(), out int num4);
            //int.TryParse(Console.ReadLine(), out int num5);

            //int total = (num1 + num2 + num3 + num4 + num5);
            //int average = (num1+num2+num3+num4+num5)/5;

            //Console.WriteLine($"Total = {total}");
            //Console.WriteLine($"Average {average}");
            //Console.WriteLine($"percentage {average}");


            #endregion


            #region 11 - Write a program to input the month number and print the number of days in that month.

            //Console.WriteLine("Input Month Number");
            //int.TryParse(Console.ReadLine(), out int num);

            //switch (num)
            //{
            //    case 1: // January
            //    case 3: // March
            //    case 5: // May
            //    case 7: // July
            //    case 8: // August
            //    case 10: // October
            //    case 12: // December
            //       Console.WriteLine($"days = 31") ;
            //        break;
            //    case 4: // April
            //    case 6: // June
            //    case 9: // September
            //    case 11: // November
            //        Console.WriteLine($"days = 30");
            //        break;
            //    case 2: // February
            //            // Assuming non-leap year for simplicity
            //        Console.WriteLine($"days = 28");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            //        break;
            //}





            #endregion



            #region 12 - Write a program to create a Simple Calculator.

            //Console.WriteLine("Enter your first number");
            //double.TryParse(Console.ReadLine(), out double num1);

            //Console.WriteLine("Enter your Operation Character");
            //char.TryParse(Console.ReadLine(), out char c);

            //Console.WriteLine("Enter your second number");
            //double.TryParse(Console.ReadLine(), out double num2);

            //double result=0;

            //switch (c)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed");
                      
            //        }
            //        else
            //        {

            //        result = num1 / num2;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator. Please try again");
            //        break;
            //}

            //Console.WriteLine($"Result: {num1} {c} {num2} = {result}");



            #endregion

        }
    }
}
