﻿
using Agricola.Seguridad;
using Agricola.Seguridad.Managers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;

namespace ProyectoBase
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(SeguridadDbContext.Create);
            app.CreatePerOwinContext<AdministradorUsuariosAgricola>(AdministradorUsuariosAgricola.Create);
            app.CreatePerOwinContext<AgricolaSignInManager>(AgricolaSignInManager.Create);
            app.CreatePerOwinContext<AgricolaRoleManager>(AgricolaRoleManager.Create);

            var CookieAuthenticationOptions = new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Seguridad/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    //OnValidateIdentity =
                    //    SecurityStampValidator.OnValidateIdentity<ApptelinkUserManager,, long>
                    //    (
                    //        validateInterval: TimeSpan.FromMinutes(15),
                    //        regenerateIdentityCallback: (manager, user) =>
                    //            manager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie),
                    //        getUserIdCallback: id => id.GetUserId<long>()
                    //    )
                },
                CookieSecure = CookieSecureOption.SameAsRequest,
                ExpireTimeSpan = TimeSpan.FromDays(1),
                SlidingExpiration = true
            };

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(CookieAuthenticationOptions);
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                //Provider = new OAuthServerProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(365),
                // In production mode set AllowInsecureHttp = false
                AllowInsecureHttp = false
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //    consumerKey: "",
            //    consumerSecret: "");

            //app.UseFacebookAuthentication(
            //    appId: "",
            //    appSecret: "");

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "",
            //    ClientSecret = ""
            //});
        }
    }
}