using Kalkulator;

Calculator calc = new Calculator();

Console.WriteLine(calc.Add(3, 5));   
Console.WriteLine(calc.Add(10, 2.5));
Console.WriteLine(calc.Substract(10,3));
Console.WriteLine(calc.Multiply(4, 5));
Console.WriteLine(calc.Divide(10, 2));

List<double> tall = new List<double> {2, 3, 4};
Console.WriteLine(calc.Add(tall));
Console.WriteLine(calc.Substract(tall));
Console.WriteLine(calc.Multiply(tall));
Console.WriteLine(calc.Divide(tall));