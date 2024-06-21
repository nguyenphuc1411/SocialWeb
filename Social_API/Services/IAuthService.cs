namespace Social_API.Services
{
    public interface IAuthService
    {
        Task<bool> Login();
        Task<bool> Register();
    }
}
