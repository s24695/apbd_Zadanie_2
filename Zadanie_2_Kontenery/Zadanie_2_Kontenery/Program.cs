using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Models;

public class Program
{
    public static void Main(String[] args)
    {
        Kontener k1 = new Kontener('A', 10, 10, 100);
        
        try
        {
            Kontener.LoadContainer(k1, 123);
        }
        catch (OverfillException e)
        {
            throw new OverfillException("Przeładowano");
        }
        
        Console.WriteLine(k1.show());

        
        
        Kontener k2 = new Kontener('C', 5, 5, 1);
        
        try
        {
            Kontener.LoadContainer(k2, 3000);
        }
        catch (OverfillException e)
        {
            throw new OverfillException($"Przeładowano kontener nr:{k2.show()}");
        }
        
        Console.WriteLine(k2.show());
    }
}