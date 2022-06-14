//using Microsoft.AspNetCore.Components.Authorization;
//using System.Security.Claims;

//namespace SuaTeoriaWebAssembly.Auth
//{
//    public class AuthStateProvider:AuthenticationStateProvider
//    {
//        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
//        {
//            var user = new ClaimsIdentity(new List<Claim>()
//            {
//                new Claim(ClaimTypes.Name,"Gabriel Silva")
//            },"selesgabriel");
//            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(user)));
//        }
//    }
//}
