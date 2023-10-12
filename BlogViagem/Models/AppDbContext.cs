﻿using Microsoft.EntityFrameworkCore;

namespace BlogViagem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Post> Posts { get; set; }
    }
   
}

