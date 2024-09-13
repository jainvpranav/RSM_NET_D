using System.ComponentModel.DataAnnotations;
namespace Pilot.Models;

public class Dealers
{
    [Key]
    public int DealerId { get; set; }
    public string DealerName { get; set; }
    public string PhNum { get; set; }
    public string City { get; set; }
}
