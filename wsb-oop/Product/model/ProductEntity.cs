using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wsb_oop.Product.model;

public class ProductEntity(string name, string description)
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init;  }
    public string Name = name;
    public string Description = description;
}