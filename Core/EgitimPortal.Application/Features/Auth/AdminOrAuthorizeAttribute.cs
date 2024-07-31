/*using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class AdminOrAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
       
        var user = context.HttpContext.User;

        
        if (user.IsInRole("admin"))
        {
            return; 
        }

        // Eğer kullanıcı admin değilse, yetkilendirme kontrolü yapılır
        base.OnAuthorization(context);
    }
} */