using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class Kontenerowiec
{
    private int speed; // w węzłach
    private IKontener[] _konteners;
    private double maxLoadWeight; // w tonach (maks. 50 000)
    private double loadWeight;

    public Kontenerowiec(double speed, IKontener[] konteners, double maxLoadWeight)
    {
        
        _konteners = konteners;
        this.speed = calculateSpeed(konteners);
        this.maxLoadWeight = maxLoadWeight;

        loadWeight = 0;
    }

    public int calculateSpeed(IKontener[] konteners)
    {
        for (int i = 0; i < konteners.Length; i++)
        {
            loadWeight += konteners[i].Mass;
        }

        if (loadWeight < 10000)
        {
            speed = 25;
        }else if (loadWeight > 10000 && loadWeight < 25000)
        {
            speed = 20;
        }else if (loadWeight > 25000 && loadWeight < 40000)
        {
            speed = 15;
        }else if (loadWeight > 40000 && loadWeight < 50000)
        {
            speed = 10;
        }
        
        Console.WriteLine($"Prędkość statku = {speed} węzłów");
        return speed;
    }
}