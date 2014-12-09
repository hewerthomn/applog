using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AppLog.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Message> Message { get; set; }

        public DbSet<MessageType> MessageType { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<ProjectUser> ProjectUser { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}