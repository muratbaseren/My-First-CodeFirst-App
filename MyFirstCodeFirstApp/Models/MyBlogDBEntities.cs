using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstCodeFirstApp.Models
{
    public class MyBlogDBEntities : DbContext// EntityFramework'ün nugetten yüklenmiş olması gerek.
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}