using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPi.Modal
{
    public class Customermodal
    {
        [StringLength(10)]
        public string Code { get; set; } = null!;

        [StringLength(10)]
        public string? Name { get; set; }

        [StringLength(10)]
        public string? Email { get; set; }

        [Column("Phone Number")]
        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [StringLength(10)]
        public string? CreditLimit { get; set; }

        public bool? IsActive { get; set; }

      
        public String? Statusname { get; set; }
    }
}
