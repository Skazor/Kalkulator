using Kalkulator;

Calculator calc = new Calculator();
bool running = true;

while (running)
{
    Console.WriteLine("\nVelg operasjon");
    Console.WriteLine("+ Addisjon");
    Console.WriteLine("- Substraksjon");
    Console.WriteLine("* Multiplakasjon");
    Console.WriteLine("/ Divisjon");
    Console.WriteLine("Q Avslutt");
    Console.WriteLine("\nDitt valg");

    string valg = Console.ReadLine()?.ToUpper() ?? "";

    switch (valg)
    {
        case "+":
        case "-":
        case "*":
        case "/":
            Console.Write("Ett tall eller flere? (1/F): ");
            string antall = Console.ReadLine()?.ToUpper() ?? "";

            if (antall == "1")
            {
               Console.Write("Tall 1: ");
               if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Ugyldig tall, prøv igjen.");
                    break;
                }


                Console.Write("Tall 2: ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Ugyldig tall, prøv igjen.");
                    break;
                }

                double resultat = valg switch
                {
                    "+" => calc.Add(a, b),
                    "-" => calc.Subtract(a, b),
                    "*" => calc.Multiply(a, b),
                    "/" => calc.Divide(a, b),
                    _   => 0
                };

                Console.WriteLine($"Resultat: {a} {valg} {b} = {resultat}");
            }
            else if (antall == "F")
            {
                Console.Write("Skriv inn tall separert med komma (eks: 2,3,4): ");
                string input = Console.ReadLine() ?? "";
                string[] deler = input.Split(',');

                List<double> tall = new List<double>();
                bool gyldig = true;

                foreach (string del in deler)
                {
                    if (!double.TryParse(del.Trim(), out double t))
                    {
                        Console.WriteLine($"'{del.Trim()}' er ikke et gyldig tall.");
                        gyldig = false;
                        break;
                    }
                    tall.Add(t);
                }

                if (!gyldig) break;

                double resultat = valg switch
                {
                    "+" => calc.Add(tall),
                    "-" => calc.Subtract(tall),
                    "*" => calc.Multiply(tall),
                    "/" => calc.Divide(tall),
                    _   => 0
                };

                Console.WriteLine($"Resultat: {string.Join($" {valg} ", tall)} = {resultat}");
            }
            else
            {
                Console.WriteLine("Ugyldig valg, prøv igjen.");
            }
            break;
        case "Q":
            Console.WriteLine("Avslutter...");
            running = false;
            break;
        default:
            Console.WriteLine("Ugyldig valg, prøv igjen.");
            break;
    }

}