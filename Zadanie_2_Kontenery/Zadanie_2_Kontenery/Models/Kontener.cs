using Zadanie_2_Kontenery.Exceptions;

namespace Zadanie_2_Kontenery.Models;

public class Kontener
{
    private char type;
    private double mass;
    private double height;
    private double depth;
    private double selfWeight;
    private double maxWeight;
    private string number;
    
    private static int _indexCount = 1;
    
    public Kontener(char type, double height, double depth, double selfWeight)
    {
        this.type = char.ToUpper(type);
        this.mass = 0;
        this.height = height;
        this.depth = depth;
        this.selfWeight = selfWeight;
        this.maxWeight = 2000;
        this.number = GenerateNumber();
    }

    private string GenerateNumber()
    {
        string serialNr = _indexCount.ToString();
        _indexCount++;
        return $"KON-{type}-{serialNr}";
    }

    public void CleanContainer(Kontener kontener)
    {
        mass = 0;
    }

    public static void LoadContainer(Kontener kontener, double load)
    {
        kontener.mass += load;
        if (kontener.mass > kontener.maxWeight)
        {
            throw new OverfillException();
        }
        
        Console.WriteLine("Załadowano towar do kontenera.");
        
        
    }

    public string show()
    {
        return $"{number} {mass}";
    }
}