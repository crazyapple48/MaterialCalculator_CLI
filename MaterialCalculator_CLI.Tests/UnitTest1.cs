using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI.Tests;

public class UnitTest1
{
    private double _l = 8;
    private double _w = 25;
    
    [Fact]
    public void ReactionAtVmax_ReturnsDouble()
    {
        var result = SimpleBeamUniformLoad.ReactionAtVmax(_w, _l);

        Assert.Equal(100, result);
    }
}