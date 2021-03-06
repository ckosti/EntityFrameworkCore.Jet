﻿using System.Data.Common;
using EntityFrameworkCore.Jet;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Jet.Integration.Test.Model16_OwnCollection
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions options)
            : base(options)
        {}

                // For migration test
        public BloggingContext()
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; } 
    }
}
