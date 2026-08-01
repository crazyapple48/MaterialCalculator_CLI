namespace MaterialCalculator_CLI.CaseFormulas;

public class SimpleBeamTwoEqualLoadsSymmetrical
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

    public static double Mmax(double p, double a)
    {
        return p * a;
    }

    public static double DeflectionMaxAtCenter(double p, double a, double l, double I)
    {
        return ((p * a) / (24 * ModulusOfElasticity * I)) * ((3 * Math.Pow(l, 2)) - (4 * Math.Pow(a, 2)));
    }

    public static double MomentAtDistance(double p, double x)
    {
        return p * x;
    }

    public static double DeflectionAtDistanceBetweenReactionAndPointLoad(double p, double x, double a, double l, double I)
    {
        return ((p * x) / (6 * ModulusOfElasticity * I)) * ((3 * l * a) - (3 * Math.Pow(a, 2)) - Math.Pow(x, 2));
    }

    public static double DeflectionAtDistanceBetweenPointLoads(double p, double x, double a, double l, double I)
    {
        return ((p * a) / (6 * ModulusOfElasticity * I)) * ((3 * l * x) - (3 * Math.Pow(x, 2)) - Math.Pow(a, 2));
    }
}
