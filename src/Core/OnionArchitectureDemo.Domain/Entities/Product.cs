using OnionArchitectureDemo.Domain.Common;

namespace OnionArchitectureDemo.Domain.Entities;

public class Product : BaseEntity
{
    public String Name { get; set; }
    public decimal Value { get; set; }
    public int Quantity { get; set; }
}