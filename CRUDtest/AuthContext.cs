using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CRUDtest
{
    public class AuthContext:IdentityDbContext<IdentityUser>
    //it will provide all of the Entity Framework code-first mapping
    //and DbSet properties needed to manage the identity tables in SQL Server.
    {
        public AuthContext()
           : base("AuthContext")
        {
        }

    }
}