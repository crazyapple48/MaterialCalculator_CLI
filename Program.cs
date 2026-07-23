namespace MaterialCalculator_CLI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type Something: ");

        var input = Console.ReadLine();
        
        var values = input?.Split(' ').ToList();

        var valuesf = new List<float>();
        
        if (values is null || values.Count < 1) return;
        foreach (var value in values)
        {
            if (float.TryParse(value, out var number))
            {
                valuesf.Add(number);
            }
        }
        
        var result = CalculateMmax(valuesf[0], valuesf[1],  valuesf[2],  valuesf[3]);
        
        Console.WriteLine(result);
    }

    static float CalculateMmax(float b, float l, float p, float e)
    {
        var result = (b / l) * p * e;
        return result;
    }
}
