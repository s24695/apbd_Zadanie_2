using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class RefrigeratedKontener : BaseKontener
{
    
    private char Type { get; set; }
    private double Mass { get; set; }
    private double Height { get; set; }
    private double Depth { get; set; }
    private double SelfWeight { get; set; }
    private double MaxWeight { get; set; }
    private string Number { get; set; }
    
    private static int _indexCount = 1;

    private IProdukt _produkt;
    private double temp;
    private string productType;

    public RefrigeratedKontener(double height, double depth, double selfWeight, IProdukt prod)
    {
        Type = 'C';
        Mass = 0;
        Height = height;
        Depth = depth;
        SelfWeight = selfWeight;
        MaxWeight = 2000;
        Number = GenerateNumber();
        
        _produkt = prod;
        temp = prod.Temperature;
        productType = prod.Type;
    }
    
    private new string GenerateNumber()
    {
        string serialNr = _indexCount.ToString();
        _indexCount++;
        return $"KON-{Type}-{serialNr}";
    }

    public new void CleanContainer()
    {
        Mass = 0;
        Console.WriteLine("Wyzerowano Kontener.");
    }

    public new void LoadContainer(double load)
    {
        Mass += load;
        if (Mass > MaxWeight)
        {
            throw new OverfillException();
        }
        
        Console.WriteLine("Załadowano towar do kontenera.");
    }

    public new string Show()
    {
        return $"{Number}, {Mass}";
    }
}