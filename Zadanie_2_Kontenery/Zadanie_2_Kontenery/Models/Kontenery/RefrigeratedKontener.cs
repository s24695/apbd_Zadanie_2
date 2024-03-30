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
    private double kontenerTemp;

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
        kontenerTemp = prod.Temperature;
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

    public new void LoadContainer(string productType, double load)
    {
        if (_produkt.Type.Equals(productType))
        {
            
            Mass += load;
            if (Mass > MaxWeight)
            {
                throw new OverfillException($"Przeładowano kontener [{Show()}]");
            }

            Console.WriteLine($"Załadowano towar do kontenera [{Show()}] {Mass}/{MaxWeight}kg {kontenerTemp}(st.)");
        }
        else
        {
            Console.WriteLine($"Błędny typ produktu [{Show()}]");
        }

    }

    public new string Show()
    {
        return $"{Number}, {Mass}";
    }
}