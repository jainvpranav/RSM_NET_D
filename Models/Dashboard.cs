using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Pilot.Models;


[Keyless]
public class Dashboard
{
    public float sumProfit { get; set; }
    public float sumInvestment { get; set; }
    public List<string> mostSelling { get; set; }
    public List<string> toOrder { get; set; }
    public List<double> totalsales { get; set; }
}