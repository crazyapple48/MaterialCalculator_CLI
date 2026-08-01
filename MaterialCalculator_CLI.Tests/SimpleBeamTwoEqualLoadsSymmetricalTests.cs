using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI.Tests;

public class SimpleBeamTwoEqualLoadsSymmetricalTests
{
    private double _l = 8;
    private double _x = 3;
    private double _b = 4.5;
    private double _a = 3.5;
    private double _w = 5000;
    private double _p = 5000;
    private double _i = 0.333;

    [Fact]
    public void ReactionAtVmax_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamTwoEqualLoadsSymmetrical.ReactionAtVmax(_p), 4);

        Assert.Equal(5000, result);
    }

    [Fact]
    public void Mmax_returnsDouble()
    {
        var result = Math.Round(SimpleBeamTwoEqualLoadsSymmetrical.Mmax(_p, _a), 4);

        Assert.Equal(17500, result);
    }

    [Fact]
    public void DeflectionMaxAtCenter_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamTwoEqualLoadsSymmetrical.DeflectionMaxAtCenter(_p, _a, _l, _i), 4);

        Assert.Equal(0.0108, result);
    }

    [Fact]
    public void MomentAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamTwoEqualLoadsSymmetrical.MomentAtDistance(_p, _x), 4);

        Assert.Equal(15000, result);
    }

    [Fact]
    public void DeflectionAtDistanceBetweenReactionAndPointLoad_ReturnsDouble()
    {
        var result =
            Math.Round(SimpleBeamTwoEqualLoadsSymmetrical.DeflectionAtDistanceBetweenReactionAndPointLoad(_p, _x, _a, _l, _i), 5);

        Assert.Equal(0.00990, result);
    }

    [Fact]
    public void DeflectionAtDistanceBetweenPointLoads_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamTwoEqualLoadsSymmetrical.DeflectionAtDistanceBetweenPointLoads(_p, _x, _a, _l, _i), 5);

        Assert.Equal(0.00989, result);
    }
}
