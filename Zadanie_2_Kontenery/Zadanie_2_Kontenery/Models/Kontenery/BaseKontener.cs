using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public abstract class BaseKontener : IKontener
{
    public char Type { get; set; }
    public double Mass { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public double SelfWeight { get; set; }
    public double MaxWeight { get; set; }
    public string Number { get; set; }
    
    public string GenerateNumber()
    {
        throw new NotImplementedException();
    }

    public void CleanContainer()
    {
        throw new NotImplementedException();
    }

    public void LoadContainer(double load)
    {
        throw new NotImplementedException();
    }

    public void LoadContainer(string hazardTypeORproductType, double load)
    {
        throw new NotImplementedException();
    }

    public string Show()
    {
        throw new NotImplementedException();
    }
}