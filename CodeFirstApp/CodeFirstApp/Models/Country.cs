using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.Models;


public abstract class Entity
{
    public int Id { get; set; }
    [MaxLength(255)]
    public string Name { get; set; } = null!;
    [MaxLength(5)]
    public string? PhoneCode { get; set; }
}

public class Country:Entity
{
    public Country()
    {
        this.Cities = new HashSet<City>();
    }
    public ICollection<City>? Cities { get; set; }
}
public class City : Entity
{
    //[ForeignKey("Country")]
    //public string UlkeId { get; set; }
    public int CountryId { get; set; }
    [MaxLength(10)]
    public string? PlateCode { get; set; }
    public Country? Country { get; set; }
    [MaxLength(10)]
    public string? PostalCode { get; set; }
}
