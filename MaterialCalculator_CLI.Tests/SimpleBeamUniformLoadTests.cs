using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI.Tests;

public class SimpleBeamUniformLoadTests
{
    private double _l = 8;
    private double _x = 3;
    private double _w = 5000;
    private double _i = 0.333;

    
    [Fact]
    public void ReactionAtVmax_ReturnsDouble()
    {
        var result = SimpleBeamUniformLoad.ReactionAtVmax(_w, _l);

        Assert.Equal(20000, result);
    }

    [Fact]
    public void Mmax_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamUniformLoad.Mmax(_w, _l), 4);

        Assert.Equal(40000, result);
    }

    [Fact]
    public void DeflectionMaxAtCenter_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamUniformLoad.DeflectionMaxAtCenter(_w, _l, _i), 4);

        Assert.Equal(0.0276, result);
    }

    [Fact]
    public void VerticalShearAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamUniformLoad.VerticalShearAtDistance(_w, _x, _l), 4);

        Assert.Equal(5000, result);
    }

    [Fact]
    public void MomentAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamUniformLoad.MomentAtDistance(_w, _x, _l), 4);

        Assert.Equal(37500, result);
    }

    [Fact]
    public void DeflectionAtDistance_ReturnsDouble()
    {
        var result = Math.Round(SimpleBeamUniformLoad.DeflectionAtDistance(_w, _x, _l, _i), 4);

        Assert.Equal(0.0256, result);
    }
}
