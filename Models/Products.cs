using System.ComponentModel.DataAnnotations;

namespace Pilot.Models;

public class Products
{
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public float CostPrice { get; set; }
    public float SellingPrice { get; set; }
    public string TypeOfProduct { get; set; }
    public int Quantity { get; set; }
    public int DealerId { get; set; }
}
