using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using BusinessLayer.BLLs;

namespace BankRestAPI.App_Start
{
    internal class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            if (context.UserName != "" && context.Password != "")
            {
                MusteriBLL musteri = new MusteriBLL();
                var Kullanici = musteri.GetByTcknPass(context.UserName, context.Password);

                if (Kullanici != null)
                {
                    var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                    identity.AddClaim(new Claim("sub", Kullanici.tckn));
                    identity.AddClaim(new Claim("role", "user"));
                    context.Validated(identity);

                }
                else
                {
                    context.SetError("invalid_grant", "Kullanıcı adı veya şifre yanlış");
                }

            }
            else
            {
                context.SetError("kullanici adi veya password giriniz");
            }
        }

    }
}