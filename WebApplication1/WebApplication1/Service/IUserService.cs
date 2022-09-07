namespace WebApplication1.Service
{
    public interface IUserService
    {
        IHttpContextAccessor ContextAccessor { get; }
        public bool IsAuthenticated();
        string GetUserId();
    }
}