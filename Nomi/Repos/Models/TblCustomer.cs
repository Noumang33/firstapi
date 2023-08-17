using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Nomi.Repos.Models;

[Table("tbl_customer")]
public partial class TblCustomer
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(10)]
    public string Name { get; set; } = null!;

    [StringLength(10)]
    public string Email { get; set; } = null!;

    [Column("Phone Number")]
    [StringLength(10)]
    public string? PhoneNumber { get; set; }

    [StringLength(10)]
    public string? CreditLimit { get; set; }

    [StringLength(10)]
    public string? IsActive { get; set; }

    [StringLength(10)]
    public string? Taxcode { get; set; }
}
