using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Temp.Models.db
{
    public class Mydb : DbContext
    {
        public Mydb()
            : base()
        { }
        
        public DbSet<User> users {get; set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}