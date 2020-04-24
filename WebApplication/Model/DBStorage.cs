using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
  
    public class DBStorage : DbContext
    {
        public DbSet<DBClient> clientsList {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
                dbContextOptionsBuilder.UseSqlite("Data Source=sample.sqlite");
        }

       

    }

    [Table("Users")]
    public class DBClient 
    {
        [Key] public int id { get; set; }
        public string name { get; set; }
        public string pas { get; set; }
        public string mail { get; set; }

      
    }

    
}
