using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace Calc;

class Calculator
{
    public static double divide( double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("Cannot divide by 0");
        }
        

        return num1/num2;  
    }

}

class Test
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Input first Value: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input second Value: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Answer = {Calculator.divide(num1,num2)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("input not valid");
        }
        catch (OverflowException)
        {
            Console.WriteLine("input not valid");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}










