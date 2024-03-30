using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class LiquidKontener : BaseKontener, IHazardNotifier
{
    
    private char Type { get; set; }
    private double Mass { get; set; }
    private double Height { get; set; }
    private double Depth { get; set; }
    private double SelfWeight { get; set; }
    private double MaxWeight { get; set; }
    private string Number { get; set; }
    
    private static int _indexCount = 1;

    public LiquidKontener(double height, double depth, double selfWeight)
    {
        Type = 'L';
        Mass = 0;
        Height = height;
        Depth = depth;
        SelfWeight = selfWeight;
        MaxWeight = 1500;
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
        Console.WriteLine("Wyzerowano Kontener.");
    }

    public void LoadContainer(string hazardType, double load)
    {
        switch (hazardType)
        {
            case "unsafe":
            {
                notify();
                MaxWeight /= 2;
                break;
            }
            default:
                notify();
                MaxWeight *= 0.9;
                break;
        }
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

    public void notify()
    {
        Console.WriteLine($"Hazard Warning in [{Show()}]");
    }
}