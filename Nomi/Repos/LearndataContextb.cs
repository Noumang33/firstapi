using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Nomi.Repos.Models;

namespace Nomi.Repos;

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

    public virtual DbSet<TblUser> TblUsers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.Property(e => e.CreditLimit).IsFixedLength();
            entity.Property(e => e.Email).IsFixedLength();
            entity.Property(e => e.IsActive).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
            entity.Property(e => e.PhoneNumber).IsFixedLength();
            entity.Property(e => e.Taxcode).IsFixedLength();
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.Property(e => e.Email).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
