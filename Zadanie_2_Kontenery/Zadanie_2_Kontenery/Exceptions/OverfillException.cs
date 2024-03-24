namespace Zadanie_2_Kontenery.Exceptions;

public class OverfillException : Exception
{
    public OverfillException()
    {
    }

    public OverfillException(string message) : base(message){}
}