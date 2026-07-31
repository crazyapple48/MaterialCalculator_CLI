using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI.Tests;

public class SimpleBeamConcentratedAtAnyPointTests
{
    private double _l = 8;
    private double _x = 3;
    private double _b = 4.5;
    private double _a = 3.5;
    private double _w = 5000;
    private double _p = 5000;
    private double _i = 0.333;


    [Fact]
    public void Reaction1_ReturnsDouble()
    {
        var result = SimpleBeamConcentratedAtAnyPoint.Reaction1(_p, _b, _l);

        Assert.Equal(2812.5, result);
    }

    [Fact]
    public void Reaction2_ReturnsDouble()
    {
        var result = SimpleBeamConcentratedAtAnyPoint.Reaction2(_p, _a, _l);

        Assert.Equal(2187.5, result);
    }

    [Fact]
    public void Mmax_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedAtAnyPoint.Mmax(_p, _l, _a, _b), 4);

        Assert.Equal(9843.75, result);
    }

    [Fact]
    public void DeflectionMaxAtX_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedAtAnyPoint.DeflectionMaxAtX(_p, _l, _a, _b, _i), 4);

        Assert.Equal(0.0054, result);
    }

    [Fact]
    public void MomentAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedAtAnyPoint.MomentAtDistance(_p, _x, _b, _l), 4);

        Assert.Equal(8437.5, result);
    }

    [Fact]
    public void DeflectionAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamConcentratedAtAnyPoint.DeflectionAtDistance(_p, _x, _b, _l, _i), 4);

        Assert.Equal(0.0051, result);
    }
}
