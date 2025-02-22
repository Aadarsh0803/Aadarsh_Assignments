﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AssignmentBookApp.Entities;

public partial class BookAppContext : DbContext
{
    public BookAppContext()
    {
    }

    public BookAppContext(DbContextOptions<BookAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=AADARSH\\SQLEXPRESS;Initial Catalog=BookApp;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C2076CF2C718");

            entity.ToTable("Book");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.Author)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BookName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Lang)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
