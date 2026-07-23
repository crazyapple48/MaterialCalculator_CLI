namespace MaterialCalculator_CLI.CaseFormulas;

public static class SimpleBeamUniformLoad
{
    /// <summary>
    /// x is distance from left edge of beam in "in" or ft.
    /// w is the uniformly distributed load in pli or plf.
    /// l is the length of beam between reaction points.
    /// "I" is the moment of inertia of the beam. 
    /// </summary>
    
    private static double _modulusOfElasticity = 2.9 * (10 ^ 7);
    
    public static double ReactionAtVmax(double w, double l)
    {
        return (w * l) / 2;
    }

    public static double Mmax(double w, double l)
    {
        return ((w * l) * (w * l)) / 8;
    }

    public static double DeflectionMaxAtCenter(double w, double l, double I)
    {
        return (5 * w * Math.Pow(l, 4)) / (384 * _modulusOfElasticity * I);
    }

    public static double VerticalShearAtDistance(double w, double x, double l)
    {
        return w * ((l / 2) - x);
    }

    public static double MomentAtDistance(double w, double x, double l)
    {
        return ((w * l) / 2) * (l - x);
    }

    public static double DefelctionAtDistance(double w, double x, double I, double l)
    {
        return ((w * x) / (24 * _modulusOfElasticity * I)) * (Math.Pow(l, 3) - (2 * l * Math.Pow(x, 2)) + Math.Pow(x, 3));
    }
}