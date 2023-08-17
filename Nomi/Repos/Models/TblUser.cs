using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Nomi.Repos.Models;

[Keyless]
[Table("tbl_user")]
public partial class TblUser
{
    [StringLength(10)]
    public string? Name { get; set; }

    [StringLength(10)]
    public string? Email { get; set; }
}
