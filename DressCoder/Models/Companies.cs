using System.ComponentModel.DataAnnotations;

namespace DressCoder.Models
{
    public class Companies
    {
        [Key]
        public int CompanyId { get; set; }
        public string? CompanyName { get; set;}
    }
}
