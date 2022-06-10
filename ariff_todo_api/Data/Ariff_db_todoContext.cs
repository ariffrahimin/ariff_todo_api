using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ariff_db_todo.Models;

namespace Ariff_db_todo.Data
{
    public partial class Ariff_db_todoContext : DbContext
    {
        public Ariff_db_todoContext()
        {
        }

        public Ariff_db_todoContext(DbContextOptions<Ariff_db_todoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Todolist> Todolists { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Todolist>(entity =>
            {
                entity.HasKey(e => e.ListId)
                    .HasName("PRIMARY");

                entity.ToTable("todolist");

                entity.Property(e => e.ListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ListID");

                entity.Property(e => e.ListContent).HasMaxLength(255);

                entity.Property(e => e.ListStatus).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
