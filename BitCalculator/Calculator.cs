

class Calculator
{

    public char UserSignChoice()
    {
        char choice;

        Console.WriteLine("\nChoose sign: +, -, *, / :");
        Console.Write("Choice: ");
        choice = Console.ReadKey().KeyChar;

        return choice;
    }

    public int UserCountingSystemChoice(char choiceSign)
    {
        int choice;

        Console.WriteLine("\nChoose what counting system do you want to use: \n" +
                          $"1 - Bit(X2 {choiceSign} X2) \n" +
                          $"2 - Octal(X8 {choiceSign} X8) \n" +
                          $"3 - Decimal(X10 {choiceSign} X10) \n" +
                          $"4 - Hexadecimal (X16 {choiceSign} X16) \n" +
                          "5 - Back");
        Console.Write("Choice: ");
        choice = int.Parse(Console.ReadLine());


        return choice;
    }

    public void GenericCalculator(char choiceSign, int countingSystemBase)
    {
        Console.Write($"\nEnter first number (X{countingSystemBase}): ");
        string input1 = Console.ReadLine();

        Console.Write($"\nEnter second number (X{countingSystemBase}): ");
        string input2 = Console.ReadLine();

        try
        {
            int num1 = Convert.ToInt32(input1, countingSystemBase);
            int num2 = Convert.ToInt32(input2, countingSystemBase);

            int result = 0;

            switch (choiceSign)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 != 0) { result = num1 / num2; }
                    else { Console.WriteLine("Error: Division by zero"); return; }
                    break;
                default: Console.WriteLine("Invalid sign choice"); return;
            }

            Console.WriteLine($"{input1} {choiceSign} {input2} = {Convert.ToString(result, countingSystemBase)} (X{countingSystemBase})");
        }
        catch (FormatException){ Console.WriteLine("Invalid input format for the chosen counting system."); }
    }

}