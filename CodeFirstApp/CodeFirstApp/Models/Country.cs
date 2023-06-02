using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.Models;


public abstract class Entity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
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
    public string? PlateCode { get; set; }
    public Country? Country { get; set; }
}
