using Microsoft.EntityFrameworkCore;
using StorageAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageAppWeb.Context
{
    public class EFContext : DbContext
    {

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Storage> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./DB/StorageApp.db");
            //base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
