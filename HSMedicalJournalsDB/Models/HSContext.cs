using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HSMedicalJournalsDB.Models
{
    public class HSContext :DbContext
    {
        public HSContext()
            :base("HSConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}