
namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulačka");
            Calculator calculator = new Calculator();
            InputReader inputReader = new InputReader();
            OutputWriter outputWriter = new OutputWriter();

            bool running = true;
            while (running)
            {
                outputWriter.WriteDivider(ConsoleColor.Green);
                outputWriter.WriteLine("Vyberte operaci:", ConsoleColor.Cyan);
                outputWriter.WriteLine("1. Sčítání", ConsoleColor.Yellow);
                outputWriter.WriteLine("2. Odčítání", ConsoleColor.Yellow);
                outputWriter.WriteLine("3. Násobení", ConsoleColor.Yellow);
                outputWriter.WriteLine("4. Dělení", ConsoleColor.Yellow);
                outputWriter.WriteLine("5. Konec", ConsoleColor.Yellow);
                outputWriter.WriteDivider(ConsoleColor.Green);

                string choice = inputReader.ReadString();
                
                if (choice == "5")
                {
                    running = false;
                    continue;
                }

                outputWriter.WriteLine("Zadejte první číslo:");
                double a = inputReader.ReadDouble();
                outputWriter.WriteLine("Zadejte druhé číslo:");
                double b = inputReader.ReadDouble();
                double result;
                
                    switch (choice)
                    {
                        case "1":
                            result = calculator.Add(a, b);
                            break;
                        case "2":
                            result = calculator.Subtract(a, b);
                            break;
                        case "3":
                            result = calculator.Multiply(a, b);
                            break;
                        case "4":
                        if (b == 0)
                        {
                            outputWriter.WriteError("Chyba - nelze dělit nulou!");
                            continue;
                        }
                        else
                        {
                            result = calculator.Divide(a, b);
                        }
                        break;                        
                        default:
                            outputWriter.WriteError("Neplatná volba.");
                            continue;
                    }
                    outputWriter.WriteSuccess($"Výsledek: {result}");                                
            }
            outputWriter.WriteLine("Kalkukačka končí");
        }
    }
}
