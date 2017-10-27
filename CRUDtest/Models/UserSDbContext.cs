using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUDtest.Models
{
    public class UserSDbContext: DbContext
    {
        public DbSet<Users> usersAccaunt { get; set; }
    }
}


