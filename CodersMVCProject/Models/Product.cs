using System.ComponentModel;

namespace CodersMVCProject.Models;

public class Product
{
    public int Id { get; set; }
    [DisplayName("Title")]
    public string Name { get; set; }
    public decimal Price { get; set; }
}