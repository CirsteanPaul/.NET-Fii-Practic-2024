using System.ComponentModel.DataAnnotations;

namespace Autovit.Models.Car;

public class CreateCarRequest
{
    [Required]
    public string Description { get; set; }
    
    [Required]
    public string[] Images { get; set; }
    
    [Required]
    public int Year { get; set; }
    
    [Required]
    public string Model { get; set; }
    
    [Required]
    public int Km { get; set; }
}