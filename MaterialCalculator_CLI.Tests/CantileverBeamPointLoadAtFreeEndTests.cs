using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI.Tests;

public class CantileverBeamPointLoadAtFreeEndTests
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
        var result = Math.Round(CantileverBeamPointLoadAtFreeEnd.ReactionAtVmax(_p), 4);

        Assert.Equal(5000, result);
    }

    [Fact]
    public void Mmax_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamPointLoadAtFreeEnd.Mmax(_p, _l), 4);

        Assert.Equal(40000, result);
    }

    [Fact]
    public void DeflectionMax_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamPointLoadAtFreeEnd.DeflectionMax(_p, _l, _i), 4);

        Assert.Equal(0.0884, result);
    }

    [Fact]
    public void MomentAtDistance_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamPointLoadAtFreeEnd.MomentAtDistance(_p, _x), 4);

        Assert.Equal(15000, result);
    }

    [Fact]
    public void DeflectionAtDistance_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamPointLoadAtFreeEnd.DeflectionAtDistance(_p, _x, _l, _i), 4);

        Assert.Equal(0.0410, result);
    }
}
