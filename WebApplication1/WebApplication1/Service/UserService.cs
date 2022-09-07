using System.Security.Claims;

namespace WebApplication1.Service
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContext;
        public UserService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public IHttpContextAccessor ContextAccessor { get; }

        public string GetUserId()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public bool IsAuthenticated()
        {
            return _httpContext.HttpContext.User.Identity.IsAuthenticated ;
        }
    }
}
