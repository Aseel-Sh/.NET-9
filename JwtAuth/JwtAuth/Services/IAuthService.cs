using JwtAuth.Entities;
using JwtAuth.Models;

namespace JwtAuth.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);
        Task<TokenResponseDTO?> LoginAsync(LoginUserDTO request);
        Task<TokenResponseDTO?> RefreshTokensAsync(RefreshTokenDTO request);
    }
}
