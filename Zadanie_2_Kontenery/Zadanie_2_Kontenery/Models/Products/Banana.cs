using Zadanie_2_Kontenery.Interfaces;

namespace Zadanie_2_Kontenery.Models;

public class Banana : IProdukt
{
    public string Name { get; } = "Banana";
    public double Temperature { get; } = 13.3;
    public string Type { get; } = "Fruit";
}