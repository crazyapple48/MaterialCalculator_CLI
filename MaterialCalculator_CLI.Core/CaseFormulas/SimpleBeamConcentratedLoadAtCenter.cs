namespace MaterialCalculator_CLI.CaseFormulas;

public static class SimpleBeamConcentratedLoadAtCenter
{
    private static double _modulusOfElasticity = 2.9 * (10 ^ 7);
    
    public static double Reactions(double p)
    {
        return p/2;
    }

    public static double Mmax(double p, double l)
    {
        return (p * l) / 4;
    }

    public static double DeflectionMaxAtCenter(double p, double l, double I)
    {
        return (p * Math.Pow(l, 3)) / (48 * _modulusOfElasticity * I);
    }
    
    public static double MomentAtDistance(double p, double x) // When x < l/2
    {
        return (p * x) / 2;
    }

    public static double DeflectionAtDistance(double p, double x, double I, double l)
    {
        return ((p * x) / (48   * _modulusOfElasticity * I)) * ((3 * Math.Pow(l, 3)) - (4 * Math.Pow(x, 2)));
    }
}
