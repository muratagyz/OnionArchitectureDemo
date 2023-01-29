namespace OnionArchitectureDemo.Application.Wrappers;

public class BaseResponse
{
    public Guid Id { get; set; }
    public bool Success { get; set; }
    public Stream message { get; set; }
}