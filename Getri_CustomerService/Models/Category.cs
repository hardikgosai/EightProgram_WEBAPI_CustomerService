using System.ComponentModel.DataAnnotations;

namespace Getri_CustomerService.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }

    public enum Status
    {
        Active = 1,
        Inactive =0
    }
}
