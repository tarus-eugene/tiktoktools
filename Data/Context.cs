using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TikTokTools.Models;

namespace TikTokTools.Data
{
    internal class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<ApplicationConfig> AppConfig;
        public ApplicationConfig  defaultConfig = new ApplicationConfig
                {
                    TempFolderPath = @"C:\TikTokTools\Temp",
                    OutputFolderPath = @"C:\TikTokTools\Output",
                    TikTokApiKey = "",
                    ElevenLabsApiKey = ""
                };

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationConfig>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ApplicationConfig>()
                .HasData(defaultConfig);
        }

        public void SeedData()
        {

            AppConfig.Add(defaultConfig);
            this.SaveChanges();
        }
    }
}
