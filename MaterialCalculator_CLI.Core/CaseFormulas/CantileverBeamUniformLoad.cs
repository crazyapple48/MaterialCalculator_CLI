namespace MaterialCalculator_CLI.CaseFormulas;

public class CantileverBeamUniformLoad
{
    /// <summary>
    /// x is distance from left edge of beam in "in" or ft.
    /// w is the uniformly distributed load in pli or plf.
    /// l is the length of beam between reaction points.
    /// "I" is the moment of inertia of the beam.
    /// </summary>
    private static readonly double ModulusOfElasticity = 2.9 * Math.Pow(10, 7);

    public static double ReactionAtVmax(double w, double l)
    {
        return w * l;
    }

    public static double Mmax(double w, double l)
    {
        return (w * Math.Pow(l, 2)) / 2;
    }

    public static double DeflectionMax(double w, double l, double I)
    {
        return (w * Math.Pow(l, 4)) / (8 * ModulusOfElasticity * I);
    }

    public static double VerticalShearAtDistance(double w, double x)
    {
        return w * x;
    }

    public static double MomentAtDistance(double w, double x)
    {
        return (w * Math.Pow(x, 2)) / 2;
    }

    public static double DeflectionAtDistance(double w, double x, double l, double I)
    {
        return (w / (24 * ModulusOfElasticity * I)) * (Math.Pow(x, 4) - (4 * Math.Pow(l, 3) * x) + (3 * Math.Pow(l, 4)));
    }
}
