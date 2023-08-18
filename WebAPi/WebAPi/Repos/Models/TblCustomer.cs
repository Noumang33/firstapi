using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPi.Repos.Models;

[Table("tbl_customer")]
public partial class TblCustomer
{
    [Key]
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
}
