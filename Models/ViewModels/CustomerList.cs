using System.ComponentModel.DataAnnotations;


namespace AspnetCoreMvcFull.Models.ViewModels
{
    public class CustomerView
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string CusType { get; set; }
        public string Address { get; set; } 
        

        
    }
}
