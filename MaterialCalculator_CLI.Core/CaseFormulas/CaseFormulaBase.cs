namespace MaterialCalculator_CLI.CaseFormulas;

public interface ICaseFormulaBase
{
    private static double _modulusOfElasticity = 2.9 * (10 ^ 7);

    public static abstract double ReactionAtVmax(double w, double l);

    public static abstract double Mmax(double w, double l);

    public static abstract double DeflectionMaxAtCenter(double w, double l, double I);

    public static abstract double VerticalShearAtDistance(double w, double x, double l);

    public static abstract double MomentAtDistance(double w, double x, double l);

    public static abstract double DeflectionAtDistance(double w, double x, double I, double l);
}
