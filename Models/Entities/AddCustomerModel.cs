using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models;

public class AddCustomerModel
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [Phone]
    public string Phone { get; set; }

    public string CusType { get; set; }

    [Required]
    public string Address { get; set; }
}
