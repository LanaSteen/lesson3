namespace loopsAndExeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 10;
            //int num2 = 0;
            //try {

            //    Console.WriteLine(num1 / num2);
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finalaizer");
            //}

            //int i = 0;
            //for ( ; i<10 ; )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i==5)
            //    {
            //        break;
            //    }

            //}



            //int j = 0;
            //while (j < 10)
            //{
            //    j++;
            //    if (j == 6)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(j);


            //}


            //ააწყვეთ კონსოლური კალკულატორი ისე რომ იგი არ წყვეტდეს მუშაობას

            //while (true)
            //{
            //    Console.WriteLine("Enter first number:");
            //    string num1 = Console.ReadLine();
            //    Console.WriteLine("Enter math operation (+ or - or * or / or %)");
            //    string opp = Console.ReadLine();
            //    char operation = Convert.ToChar(opp);
            //    Console.WriteLine("Enter second number:");
            //    string num2 = Console.ReadLine();

            //    try
            //    {
            //        if ((!double.TryParse(num1, out double number1) || !double.TryParse(num2, out double number2)) ||
            //            !(operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '%'))
            //        {
            //            Console.WriteLine("Invalid input for the first or second number or operation. Please enter valid numbers and math operation.");
            //            continue;
            //        }
            //        else
            //        {
            //            if (operation == '+')
            //            {
            //                Console.WriteLine($"{number1} {operation} {number2} = {number1 + number2}");
            //            }
            //            else if (operation == '-')
            //            {
            //                Console.WriteLine($"{number1} {operation} {number2} = {number1 - number2}");
            //            }
            //            else if (operation == '*')
            //            {
            //                Console.WriteLine($"{number1} {operation} {number2} = {number1 * number2}");
            //            }
            //            else if (operation == '/')
            //            {
            //                if (number2 != 0)
            //                {
            //                    Console.WriteLine($"{number1} {operation} {number2} = {number1 / number2}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{number2} can't be 0 during divide operation");
            //                }
            //            }
            //            else if (operation == '%')
            //            {
            //                if (number2 != 0)
            //                {
            //                    Console.WriteLine($"{number1} {operation} {number2} = {number1 % number2}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{number2} can't be 0 during modulus operation");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Something went wrong");
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}






            ///// teacher version
            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("FIRST NUMBER: ");
            //        if (!int.TryParse(Console.ReadLine(), out int firstNumber))
            //            continue;

            //        Console.Write("SECOND NUMBER: ");
            //        if (!int.TryParse(Console.ReadLine(), out int secondNumber))
            //            continue;

            //        Console.Write("[+  -  *  /]: ");
            //        if (!char.TryParse(Console.ReadLine(), out char operation))
            //            continue;

            //        switch (operation)
            //        {
            //            case '+':
            //                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //                break;
            //            case '-':
            //                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //                break;
            //            case '*':
            //                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //                break;
            //            case '/':
            //                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            //                break;
            //        }

            //        Console.Write("X for exit: ");
            //        char.TryParse(Console.ReadLine(), out var exit);

            //        if (exit == 'X')
            //            break;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }
    }
}
