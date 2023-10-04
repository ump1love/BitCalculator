

class Program
{

    public static void Main()
    {
        Calculator calculator = new Calculator();
        start:
        char signChoice;
        do
        {
            signChoice = calculator.UserSignChoice();

        }while( signChoice != '-' && signChoice != '+' && signChoice != '/' && signChoice != '*');
        int systemChoice = calculator.UserCountingSystemChoice(signChoice);

        switch (systemChoice)
        {
            case 1: calculator.GenericCalculator(signChoice, 2); break; 
            case 2: calculator.GenericCalculator(signChoice, 8); break; 
            case 3: calculator.GenericCalculator(signChoice, 10); break;
            case 4: calculator.GenericCalculator(signChoice, 16); break;
            case 5: goto start;
            default: Console.WriteLine("\nInvalid input"); break;
        }
    }

}