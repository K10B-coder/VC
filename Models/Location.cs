using System.ComponentModel.DataAnnotations;

namespace Inversity_test.Models;
public class Location
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [Range(-90, 90)]
    public double Latitude { get; set; }

    [Required]
    [Range(-180, 180)]
    public double Longitude { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Cases { get; set; }

    [Required]
    [StringLength(100)]
    public string Illness { get; set; }
}
