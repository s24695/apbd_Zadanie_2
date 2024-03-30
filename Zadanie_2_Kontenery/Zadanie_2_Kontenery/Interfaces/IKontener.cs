using Zadanie_2_Kontenery.Exceptions;

namespace Zadanie_2_Kontenery.Interfaces
{
    public interface IKontener
    {
        char Type { get; set; }
        double Mass { get; set; }
        double Height { get; set; }
        double Depth { get; set; }
        double SelfWeight { get; set; }
        double MaxWeight { get; set; }
        string Number { get; set; }

        string GenerateNumber();

        void CleanContainer();

        void LoadContainer(double load);
        void LoadContainer(string hazardType, double load);

        string Show();
    }
}