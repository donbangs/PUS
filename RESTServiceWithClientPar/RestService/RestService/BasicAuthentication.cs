using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace RestService
{
    public class BasicAuthentication : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            else
            {
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                string plaintText = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                string[] adminArray = plaintText.Split(':');

                string adminid = adminArray[0];
                string adminpwd = adminArray[1];
                if (!User.AdminAuth(adminid, adminpwd))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
                else {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Accepted);
                }
            }
        }
    }
}