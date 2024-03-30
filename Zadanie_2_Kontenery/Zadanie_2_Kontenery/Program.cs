using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Models;

public class Program
{
    public static void Main(String[] args)
    {
        Kontener k1 = new Kontener(10, 10, 100);
        
        try
        {
            k1.LoadContainer(123);
        }
        catch (OverfillException e)
        {
            throw new OverfillException("Przeładowano");
        }
        
        Console.WriteLine(k1.Show());

        
        
        LiquidKontener k2 = new LiquidKontener(5, 5, 1);
        
        try
        {
            k2.LoadContainer("safe", 1500);
        }
        catch (OverfillException e)
        {
            throw new OverfillException($"Przeładowano kontener nr:{k2.Show()}");
        }
        
        Console.WriteLine(k2.Show());
    }
}