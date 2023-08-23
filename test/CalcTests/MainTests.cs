using Calc;

namespace CalcTests;

public class MainTests
{
    [Fact]
    public void Should_AddTheNumbers_When_InputIsValid()
    {
        var main = new Main();

        Assert.Equal(3, main.Calc(1, 2, "+"));
    }

    [Fact]
    public void Should_Throw_When_OperatorIsUnknown()
    {
        var main = new Main();

        Assert.Throws<ArgumentException>(() => main.Calc(1, 2, "*"));
    }

    [Fact]
    public void Should_Throw_When_DividingByZero()
    {
        var main = new Main();

        Assert.Throws<DivideByZeroException>(() => main.Calc(1, 0, "/"));
    }

    [Fact]
    public void Should_DivideTheNumbers_When_InputIsValid()
    {
        var main = new Main();

        Assert.Equal(2, main.Calc(4, 2, "/"));
    }
}