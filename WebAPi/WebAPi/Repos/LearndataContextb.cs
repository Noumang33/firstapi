using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebAPi.Repos.Models;

namespace WebAPi.Repos;

public partial class LearndataContextb : DbContext
{
    public LearndataContextb()
    {
    }

    public LearndataContextb(DbContextOptions<LearndataContextb> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.Property(e => e.Code).IsFixedLength();
            entity.Property(e => e.CreditLimit).IsFixedLength();
            entity.Property(e => e.Email).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
            entity.Property(e => e.PhoneNumber).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
