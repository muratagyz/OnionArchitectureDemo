namespace OnionArchitectureDemo.Application.Exception;

public class ValidationException : System.Exception
{
    public ValidationException() : this("Validation error occured")
    {

    }

    public ValidationException(String message) : base(message)
    {

    }

    public ValidationException(System.Exception exception) : this(exception.Message)
    {

    }
}