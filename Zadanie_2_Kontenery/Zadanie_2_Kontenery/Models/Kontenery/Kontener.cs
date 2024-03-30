using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class Kontener : BaseKontener
{
    
    public char Type { get; set; }
    public double Mass { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public double SelfWeight { get; set; }
    public double MaxWeight { get; set; }
    public string Number { get; set; }
    
    private static int _indexCount = 1;

    public Kontener(double height, double depth)
    {
        Type = 'A';
        Mass = 0;
        Height = height;
        Depth = depth;
        SelfWeight = height * depth * 2;
        MaxWeight = 2000;
        Number = GenerateNumber();
    }
    
    public string GenerateNumber()
    {
        string serialNr = _indexCount.ToString();
        _indexCount++;
        return $"KON-{Type}-{serialNr}";
    }

    public void CleanContainer()
    {
        Mass = 0;
        Console.WriteLine($"Wyzerowano Kontener [{Show()}]");
    }

    public void LoadContainer(double load)
    {
        Mass += load;
        if (Mass > MaxWeight)
        {
            throw new OverfillException();
        }
        
        Console.WriteLine($"Załadowano towar do kontenera [{Show()}] {Mass}/{MaxWeight}kg");
    }

    public string Show()
    {
        return $"{Number}, {Mass}";
    }
}