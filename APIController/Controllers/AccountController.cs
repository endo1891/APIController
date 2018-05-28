using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using APIController.Contracts;
using APIController.Framework;

namespace APIController.Controllers
{
    [RoutePrefix("Lastname")]
    public class AccountBalanceController : ApiController
    {
        //PUT api/AccountBalance/BOO40003
        //Do not add currency into url

        public void Put(string id, [FromBody]AccountValueUpdateObject value)
        {
            //new BalanceUpdatingService().UpdateBalance(id, value);
        }
    }

    public class UpdateDetailsController : ApiController
    {
        //PUT api/UpdateDetails
        //need trailing slash
        [Route("api/UpdateDetails/{lastname}")]
        public void Put([FromBody]AccountValueUpdateObject value)
        {
            new BalanceUpdatingService().UpdateDetails(value);
        }
    }

}