using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using CRUDtest.Providers;
using CRUDtest.Models;
using System.Web.Http;

////dodato 08.11.2017.
[assembly:OwinStartup(typeof(CRUDtest.Startup))]
namespace CRUDtest
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        
        public void ConfigureAuth(IAppBuilder app)
        {

            //dodato 08.11.2017.
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
