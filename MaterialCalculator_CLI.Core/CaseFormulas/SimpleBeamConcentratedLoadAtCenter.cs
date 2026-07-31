namespace MaterialCalculator_CLI.CaseFormulas;

public static class SimpleBeamConcentratedLoadAtCenter
{
    private readonly static double ModulusOfElasticity = 2.9 * Math.Pow(10, 7);
    
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
        return (p * Math.Pow(l, 3)) / (48 * ModulusOfElasticity * I);
    }
    
    public static double MomentAtDistance(double p, double x) // When x < l/2
    {
        return (p * x) / 2;
    }

    public static double DeflectionAtDistance(double p, double x, double l, double I)
    {
        return ((p * x) / (48 * ModulusOfElasticity * I)) * ((3 * Math.Pow(l, 2)) - (4 * Math.Pow(x, 2)));
    }
}
