using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class Meat : IProdukt
{
    public string Name { get; } = "Meat";
    public double Temperature { get; } = -15;
    public string Type { get; } = "Meat";
}