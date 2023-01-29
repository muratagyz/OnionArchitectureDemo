namespace OnionArchitectureDemo.Application.Parameters;

public class RequestParameter
{
    public int PageSize { get; set; }
    public int PageNumber { get; set; }

    public RequestParameter(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}