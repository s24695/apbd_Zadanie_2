using System.Collections;
using Zadanie_2_Kontenery.Exceptions;
using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class Kontenerowiec
{
    private int speed; // w węzłach
    private List<BaseKontener> listaKonteners; 
    private double maxLoadWeight; // w tonach (maks. 50 000)
    private double loadWeight;
    private int maxKontenerCount;

    public Kontenerowiec()
    {
        listaKonteners = new List<BaseKontener>();
        this.speed = 0;
        this.maxLoadWeight = 50000;
        this.maxKontenerCount = 30;
        loadWeight = 0;
    }

    public int calculateSpeed()
    {
        
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
        
        Console.WriteLine($"Prędkość statku = {speed} węzłów przy obciążeniu {loadWeight}");
        return speed;
    }

    public void addKontener(BaseKontener nowyKontener)
    {
        if (listaKonteners.Count < maxKontenerCount)
        {
            listaKonteners.Add(nowyKontener);
        }
        else
        {
            throw new OverfillException("Kontenerowiec nie ma już miejsca na więcej kontenerów.");
        }

        calculateLoadWeight();
        calculateSpeed();
        
    }

    public double calculateLoadWeight()
    {
        for (int i = 0; i < listaKonteners.Count; i++)
        {
            if (loadWeight < maxLoadWeight)
            {
                loadWeight += listaKonteners[i].Mass;
            }
        }
        return loadWeight;
    } 
}