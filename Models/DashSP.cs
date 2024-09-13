using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Pilot.Models;


[Keyless]
public class DashSP
{
    public string MaxItemType { get; set; }
}