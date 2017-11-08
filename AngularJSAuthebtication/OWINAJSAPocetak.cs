using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;
using System.Web.Http;

//“assembly” attribute which states which class to fire on start-up
[assembly:OwinStartup(typeof(AngularJSAuthebtication.API.OWINAJSAPocetak))]
namespace AngularJSAuthebtication.API
{
    public class OWINAJSAPocetak// zvala se Startup class
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            WebApiConfig.Register(config);

            app.UseWebApi(config);
         
        }
    }
}