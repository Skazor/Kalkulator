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
            Console.WriteLine("Valgt: " + valg);
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