using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Interfaces;
using Zadanie_2_Kontenery.Models;

public class Program
{
    public static void Main(String[] args)
    {
        Kontener k1 = new Kontener(10, 10);
        
        try
        {
            k1.LoadContainer(123);
        }
        catch (OverfillException e)
        {
            throw new OverfillException("Przeładowano");
        }
        
        LiquidKontener k2 = new LiquidKontener(5, 5);
        
        try
        {
            k2.LoadContainer("safe", 600);
        }
        catch (OverfillException e)
        {
            throw new OverfillException($"Przeładowano kontener nr:{k2.Show()}");
        } 

        Banana banana = new Banana();
        RefrigeratedKontener refrigeratedKontener = new RefrigeratedKontener(10, 10, banana);
        try
        {
            refrigeratedKontener.LoadContainer(banana.Type, 1000);
        }
        catch (OverfillException e)
        {
            throw new OverfillException($"Przeładowano kontener nr:{refrigeratedKontener.Show()}");
        }

        GasKontener gasKontener = new GasKontener(10, 10);
        gasKontener.LoadContainer(800);
        gasKontener.CleanContainer();
        gasKontener.LoadContainer(1000);


        Kontenerowiec kontenerowiec = new Kontenerowiec();

        kontenerowiec.addKontener(k1);
        kontenerowiec.addKontener(k2);
        kontenerowiec.addKontener(refrigeratedKontener);
        kontenerowiec.addKontener(gasKontener);
        
        
    }

    
}