using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CRUDtest.Models;
using System.Threading.Tasks;


namespace CRUDtest.Models
{
    public class AuthRepository : IDisposable
    {

        //we are depending on the “UserManager” that provides the domain logic
        //for working with user information. The “UserManager” knows when to hash 
        //a password, how and when to validate a user, and how to manage claims
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }
        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();
        }
    }
}