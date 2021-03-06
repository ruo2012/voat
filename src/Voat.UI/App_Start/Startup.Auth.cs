#region LICENSE

/*
    
    Copyright(c) Voat, Inc.

    This file is part of Voat.

    This source file is subject to version 3 of the GPL license,
    that is bundled with this package in the file LICENSE, and is
    available online at http://www.gnu.org/licenses/gpl-3.0.txt;
    you may not use this file except in compliance with the License.

    Software distributed under the License is distributed on an
    "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express
    or implied. See the License for the specific language governing
    rights and limitations under the License.

    All Rights Reserved.

*/

#endregion LICENSE

using Microsoft.AspNetCore.DataProtection;
using System;

namespace Voat
{
    public partial class Startup_COREPORT
    {
        internal static IDataProtectionProvider DataProtectionProvider { get; private set; }

        //CORE_PORT: Not ported
        public void ConfigureAuth(object app)
        {
            throw new NotImplementedException("Not ported");
        }
        /*
        public void ConfigureAuth(IAppBuilder app)
        {
            DataProtectionProvider = app.GetDataProtectionProvider();

            // Enable the application to use a cookie to store information for the signed in user
            var settings = new CookieAuthenticationOptions
            {
                SlidingExpiration = true,
                ExpireTimeSpan = TimeSpan.FromDays(30.0),
                CookieName = "WhoaverseLogin", //We keeping it old school with the cookies.
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            };

            //for local testing don't set cookiedomain
            var localRequest = (HttpContext.Current != null && Context.Request != null && Context.Request.IsLocal);
            var domain = WebConfigurationManager.AppSettings["CookieDomain"];
            if (!String.IsNullOrEmpty(domain) && !localRequest)
            {
                VoatSettings.Instance.CookieDomain = domain;
            }

            app.UseCookieAuthentication(settings);

        }
        */
    }
}
