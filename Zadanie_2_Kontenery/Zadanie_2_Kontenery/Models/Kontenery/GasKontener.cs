using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class GasKontener : BaseKontener, IHazardNotifier
{
    private char Type { get; set; }
    private double Mass { get; set; }
    private double Height { get; set; }
    private double Depth { get; set; }
    private double SelfWeight { get; set; }
    private double MaxWeight { get; set; }
    private string Number { get; set; }
    
    private static int _indexCount = 1;

    private int pressure;

    public GasKontener(double height, double depth, double selfWeight)
    {
        Type = 'G';
        Mass = 0;
        Height = height;
        Depth = depth;
        SelfWeight = selfWeight;
        MaxWeight = 2000;
        Number = GenerateNumber();
    }
    
    private new string GenerateNumber()
    {
        string serialNr = _indexCount.ToString();
        _indexCount++;
        return $"KON-{Type}-{serialNr}";
    }

    public new void CleanContainer()
    {
        Mass = Mass * 0.05;
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