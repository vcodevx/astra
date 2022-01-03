using Astra.Business;
using Astra.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Astra.Filters
{
    public class SecurityFilter : IAuthorizationFilter
    {
        private readonly AstraContext _astraContext = null;
        public SecurityFilter(AstraContext astraContext)
        {
            _astraContext = astraContext;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var result = true;
            if (!context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                result = false;
            }

            var token = string.Empty;
            if (result)
            {
                token = context.HttpContext.Request.Headers.First(x => x.Key == "Authorization").Value;
                var userCredentials = Encoding.UTF8.GetString(Convert.FromBase64String(token));
                var credentials = userCredentials.Split(":");
                if(credentials.Length > 0)
                {
                    var username = credentials[0];
                    var password = credentials[1];

                    var user = new UserBusiness(_astraContext).CheckUserValidation(username, password);
                    if(user?.UserName != null)
                    {
                        Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(user.UserName), null);
                    }
                    else
                    {
                        //context.HttpContext.Response = context.HttpContext.Response.
                    }
                }
            }
        }
    }
}
