using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI.Tests;

public class CantileverBeamUniformLoadTests
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
        var result = Math.Round(CantileverBeamUniformLoad.ReactionAtVmax(_w, _l), 4);

        Assert.Equal(40000, result);
    }

    [Fact]
    public void Mmax_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamUniformLoad.Mmax(_w, _l), 4);

        Assert.Equal(160000, result);
    }

    [Fact]
    public void DeflectionMaxAtFreeEnd_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamUniformLoad.DeflectionMaxAtFreeEnd(_w, _l, _i), 4);

        Assert.Equal(0.2651, result);
    }

    [Fact]
    public void VerticalShearAtDistance_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamUniformLoad.VerticalShearAtDistance(_w, _x), 4);

        Assert.Equal(15000, result);
    }

    [Fact]
    public void MomentAtDistance_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamUniformLoad.MomentAtDistance(_w, _x), 4);

        Assert.Equal(22500, result);
    }

    [Fact]
    public void DeflectionAtDistance_ReturnsDouble()
    {
        var result = Math.Round(CantileverBeamUniformLoad.DeflectionAtDistance(_w, _x, _l, _i), 4);

        Assert.Equal(0.1343, result);
    }
}
