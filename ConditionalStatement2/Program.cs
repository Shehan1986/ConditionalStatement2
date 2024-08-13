using static System.Console;
namespace ConditionalStatement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case
            //menu driven program
            double value_1, value_2, res = 0;
            Write("Choose an option + - * /   ");

            char op = char.Parse(ReadLine());



            Write("Choose an option Add, Substract, Multipy, Divide ");
            string opt1;
            opt1 = ReadLine().ToUpper();


            Write("Choose an option 1.Add, 2.Substract, 3.Multipy, 4.Divide ");
           
            if (op == '+' || op == '-' || op == '*' || op == '/')
            {

                Write("First Number: ");
                value_1 = double.Parse(ReadLine());

                Write("Second Number: ");
                value_2 = double.Parse(ReadLine());

                switch (op)
                {
                    case '+': res = value_1 + value_2;
                        break;
                    case '-':
                        res = value_1 - value_2;
                        break;
                    case '*':
                        res = value_1 * value_2;
                        break;
                    case '/':
                        res = value_1 / value_2;
                        break;
                    default:
                        WriteLine("Similar to else");
:                       break;
                }

                WriteLine($"Result is {res}" );



            }
            else
                WriteLine("Wrong option!");








            double number1, number2, result = 0;
            string error = "";

            Write("Choose an option + - * /   ");

            char op1 = char.Parse(ReadLine());

            if (op1 == '+' || op1 == '-' || op1 == '*' || op1 == '/')
            {
                Write("First Number: ");
                number1 = double.Parse(ReadLine());

                Write("Second Number: ");
                number2 = double.Parse(ReadLine());

                if (op1 == '+')
                    result = number1 + number2;
                else if (op1 == '-')
                    result = number1 - number2;
                else if (op1 == '*')
                    result = number1 * number2;
                else if (op1 == '/')
                    result = number1 / number2;

                WriteLine($"{number1} {op} {number2} = {result}");
            }
             else
                WriteLine("Wrong option!");

            ReadKey();

        }
    }
}
