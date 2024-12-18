﻿using Microsoft.EntityFrameworkCore;
using ReservasApi.Models;

namespace ReservasApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Participant> Participants { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // event
        modelBuilder.Entity<Reservation>().HasKey(e => e.Id);
        modelBuilder.Entity<Reservation>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();

        //enterprise
        modelBuilder.Entity<Participant>().HasKey(e => e.Id);
        modelBuilder.Entity<Participant>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}
