namespace Calc;

public class Main
{
    public int Calc(int a, int b, string op) => op switch
    {
        "+" => Math.Addition(a, b),
        "-" => Math.Subtraction(a, b),
        "/" => Math.Division(a, b),
        _ => throw new ArgumentException()
    };
}