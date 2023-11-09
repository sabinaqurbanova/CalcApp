namespace CalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            double num1;
            double num2;
            double result;
            char operation = '+';
            #endregion
            char again = 'y';

            do
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.Write("First Number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Choose your operation: ");
                operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Second Number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (operation == '+')
                {
                    result = num1 + num2;
                    Console.WriteLine("The result is: " + result);
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                    Console.WriteLine("The result is: " + result);
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                    Console.WriteLine("The result is: " + result);
                }
                else if (operation == '/')
                {
                    result = num1 / num2;
                    Console.WriteLine("The result is: " + result);
                }
                else Console.WriteLine("The operation is wrong");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Calculate Again? (y/n)");
                again = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            } while (again == 'y');
        }
    }
}