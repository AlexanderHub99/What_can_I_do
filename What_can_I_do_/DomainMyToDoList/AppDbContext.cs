
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace What_can_I_do_.DomainMyToDoList
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>().HasData(new Task
            {
                id = new Guid("716C2E99-6F6C-4472-81A5-43C56E11637C"),
                TTask = "Новый спутник запущен на орбиту",
                performance = false,

            }) ;
        }
    }
}
