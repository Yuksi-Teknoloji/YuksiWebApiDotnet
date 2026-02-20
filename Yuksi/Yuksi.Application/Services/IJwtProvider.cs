using Yuksi.Application.Features.Auth.Login;
using Yuksi.Domain.Entities;

namespace Yuksi.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
