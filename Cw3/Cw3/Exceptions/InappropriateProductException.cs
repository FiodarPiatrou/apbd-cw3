namespace Cw3.Exceptions;

public class InappropriateProductException: Exception

{
    public InappropriateProductException(string? message) : base(message)
    {
    }

    public InappropriateProductException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}