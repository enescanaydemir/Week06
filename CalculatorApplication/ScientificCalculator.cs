using System;

namespace CalculatorApplication;

public class ScientificCalculator : Calculator
{
    public ScientificCalculator(int add, int subtract, int multiply, int divide, double sin, double cos, double tan) : base(add, subtract, multiply, divide)
    {
        Sin = sin;
        Cos = cos;
        Tan = tan;
    }

    public double Sin { get; set; }
    public double Cos { get; set; }
    public double Tan { get; set; }
}
