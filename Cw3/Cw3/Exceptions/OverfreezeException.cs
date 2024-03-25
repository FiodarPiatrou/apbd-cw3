namespace Cw3.Exceptions;

public class OverfreezeException: Exception
{
    public OverfreezeException()
    {
    }

    public OverfreezeException(string? message) : base(message)
    {
    }

    public OverfreezeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}