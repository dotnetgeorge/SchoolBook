namespace SchoolBook.Models
{
    using System.Security.Claims;
    using System.Security.Principal;

    public static class IdentityExtensions
    {
        public static string GetUserFullName(this IIdentity identity)
        {
            return ((ClaimsIdentity)identity).FindFirst("FullName").Value;
        }
    }
}
