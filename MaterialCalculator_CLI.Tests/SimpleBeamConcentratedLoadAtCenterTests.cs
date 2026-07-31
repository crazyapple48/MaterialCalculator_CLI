using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI.Tests;

public class SimpleBeamConcentratedLoadAtCenterTests
{
    private double _l = 8;
    private double _x = 3;
    private double _w = 5000;
    private double _p = 5000;
    private double _i = 0.333;


    [Fact]
    public void Reactions_ReturnsDouble()
    {
        var result = SimpleBeamConcentratedLoadAtCenter.Reactions(_p);

        Assert.Equal(2500, result);
    }

    [Fact]
    public void Mmax_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedLoadAtCenter.Mmax(_p, _l), 4);

        Assert.Equal(10000, result);
    }

    [Fact]
    public void DeflectionMaxAtCenter_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedLoadAtCenter.DeflectionMaxAtCenter(_p, _l, _i), 5);

        Assert.Equal(0.00552, result);
    }

    [Fact]
    public void MomentAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedLoadAtCenter.MomentAtDistance(_p, _x), 4);

        Assert.Equal(7500, result);
    }

    [Fact]
    public void DeflectionAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedLoadAtCenter.DeflectionAtDistance(_w, _x, _l, _i), 5);

        Assert.Equal(0.00505, result);
    }
}
