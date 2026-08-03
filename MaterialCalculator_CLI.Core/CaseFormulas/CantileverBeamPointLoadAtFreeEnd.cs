namespace MaterialCalculator_CLI.CaseFormulas;

public class CantileverBeamPointLoadAtFreeEnd
{
    /// <summary>
    /// x is distance from left edge of beam in "in" or ft.
    /// w is the uniformly distributed load in pli or plf.
    /// l is the length of beam between reaction points.
    /// "I" is the moment of inertia of the beam.
    /// </summary>
    private static readonly double ModulusOfElasticity = 2.9 * Math.Pow(10, 7);

    public static double ReactionAtVmax(double p)
    {
        return p;
    }

    public static double Mmax(double p, double l)
    {
        return p * l;
    }

    public static double DeflectionMax(double p, double l, double I)
    {
        return (p * Math.Pow(l, 3)) / (3 * ModulusOfElasticity * I);
    }

    public static double MomentAtDistance(double p, double x)
    {
        return p * x;
    }

    public static double DeflectionAtDistance(double p, double x, double l, double I)
    {
        return (p / (6 * ModulusOfElasticity * I)) * ((2 * Math.Pow(l, 3)) - (3 * Math.Pow(l, 2) * x) + Math.Pow(x, 3));
    }
}
