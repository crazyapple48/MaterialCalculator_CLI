using MaterialCalculator_CLI.CaseFormulas;

namespace MaterialCalculator_CLI;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("x: ");
       
       var x = double.Parse(Console.ReadLine());
       
       Console.WriteLine("I: ");
       
       var I = double.Parse(Console.ReadLine());
       
       Console.WriteLine("l: ");
       
       var l = double.Parse(Console.ReadLine());
       
       Console.WriteLine("w: ");
       
       var w = double.Parse(Console.ReadLine());

       var result = SimpleBeamUniformLoad.Mmax(w, l);
       
       Console.WriteLine(result);
    }
}
