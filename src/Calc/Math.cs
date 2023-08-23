namespace Calc;

public static class Math
{
    public static int Addition(int a, int b) => a + b;
    public static int Subtraction(int a, int b) => a - b;
    public static int Division(int a, int b) {
        if (a < b) {
            throw new ArgumentOutOfRangeException();
        }
        else if (b == 0) {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}
