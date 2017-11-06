using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using AngularJSAuthebtication.Models;
using Microsoft.AspNet.Identity;
using System.Web.Http.Owin;


namespace AngularJSAuthebtication.Controllers
{
    [RoutePrefix("api/Account2")]
    public class Account2Controller : ApiController
    {
        private AuthRepository _repo = null;
        public Account2Controller()
        {
            _repo = new AuthRepository();
        }

        //    //POST api/Account/Register
        //    [AllowAnonymous]
        //    [Route("Register")]
        //   // [AcceptVerbs("POST")]
        //    public async Task<IHttpActionResult> Register(UserModel userModel)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        IdentityResult result = await _repo.RegisterUser(userModel);

        //        IHttpActionResult errorResult = GetErrorResult(result);
        //        if (errorResult !=null)
        //        {
        //            return errorResult;
        //        }
        //        return Ok();
        //    }
        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            _repo.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
        //    private IHttpActionResult GetErrorResult(IdentityResult result)
        //    {
        //        if (result == null)
        //        {
        //            return InternalServerError();
        //        }
        //        if (!result.Succeeded)
        //        {
        //            if (result.Errors != null)
        //            {

        //                foreach (string error in result.Errors)
        //                {
        //                    ModelState.AddModelError("", error);
        //                }
        //            }

        //            if (ModelState.IsValid)
        //            {
        //                // No ModelState errors are available to send, so just return an empty BadRequest.
        //                return BadRequest();
        //            }
        //            return BadRequest(ModelState);

        //        }
        //        return null;
        //    }
        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await _repo.RegisterUser(userModel);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }

}
