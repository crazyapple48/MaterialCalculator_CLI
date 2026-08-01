namespace MaterialCalculator_CLI.CaseFormulas;

public static class SimpleBeamConcentratedAtAnyPoint
{
    private static readonly double ModulusOfElasticity = 2.9 * Math.Pow(10, 7);
    
    public static double Reaction1(double p, double b, double l)
    {
        return (p * b) / l;
    }
    
    public static double Reaction2(double p, double a, double l)
    {
        return (p * a) / l;
    }

    public static double Mmax(double p, double l, double a, double b)
    {
        return (p * a * b) / l;
    }

    public static double DeflectionMaxAtX(double p, double l, double a, double b, double I) // Look at book for how this is defined
    {
        return ((p * a * b) * (a + (2 * b)) * Math.Sqrt((3 * a) * (a + (2 * b)))) / (27 * ModulusOfElasticity * I * l);
    }

    public static double MomentAtDistance(double p, double x, double b, double l)
    {
        return (p * b * x) / l;
    }

    public static double DeflectionAtPointOfLoad(double p, double a, double b, double l, double I)
    {
        return ((p * (Math.Pow(a, 2)) * (Math.Pow(b, 2))) / (3 * ModulusOfElasticity * I * l));
    }
    
    public static double DeflectionAtDistance(double p, double x, double b, double l,  double I)
    {
        return ((p * b * x) / (6 * ModulusOfElasticity * I * l)) * ((l * l) - (b * b) - (x * x));
    }
}
