using System;

namespace CalculatorApp
{
    /// <summary>
    /// T?ída InputReader odpov?dná za ?tení vstup? z konzole.
    /// </summary>
    internal class InputReader
    {
        /// <summary>
        /// Na?te platné ?íslo typu double z konzole. Pokud vstup není platné ?íslo, opakuje se výzva.
        /// </summary>
        /// <returns>Platné ?íslo typu double.</returns>
        public double ReadDouble()
        {
            double result;
            while (true)
            {
                string? input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    return result;
                }

                // toto je zatím proti SRP (single resposibility principle) protože t?ída by m?la d?lat pouze vstup, ne výstup
                // ale zatím pro jednoduchost nechávám, ?asem m?žeme upravit
                Console.WriteLine("Neplatný vstup. Zadejte prosím platné ?íslo:");
            }
        }

        /// <summary>
        /// Na?te ?et?zec z konzole. Ošet?í, že nebude výstup nikdy null
        /// </summary>
        /// <returns>?et?zec na?tený z konzole.</returns>
        public string ReadString()
        {
            string? s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            return s;
        }
    }
}