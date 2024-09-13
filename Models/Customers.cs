using System.ComponentModel.DataAnnotations;

namespace Pilot.Models;

public class Customers
{
    [Key]
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string PhNum { get; set; }
}
