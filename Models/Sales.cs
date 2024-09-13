using System.ComponentModel.DataAnnotations;

namespace Pilot.Models;

public class Sales
{
    [Key]
    public int SalesId { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public float Profit { get; set; }
    public string ModeOfPayment { get; set; }
}
