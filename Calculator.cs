namespace Kalkulator;

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Kan ikke dele på null!");
        return a / b;
    }

    public double Add(List<double> tall)
    {
        double sum = 0;
        foreach (double t in tall)
            sum += t;
        return sum;
    }

    public double Subtract(List<double> tall)
    {
        double result = tall[0];
        for (int i = 1; i < tall.Count; i++)
            result -= tall[i];
        return result;
    }

    public double Multiply(List<double> tall)
    {
        double result = tall[0];
        for (int i = 1; i < tall.Count; i++)
            result *= tall[i];
        return result; 
    }

    public double Divide(List<double> tall)
    {
        double result = tall[0];
        for (int i = 1; i < tall.Count; i++)
        {
            if (tall[i] == 0) throw new DivideByZeroException("Kan ikke dele på null");
            result /= tall[i];
        }
        
        return result;
    }
}