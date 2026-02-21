using Yuksi.Application.Features.Auth.Login;
using Yuksi.Domain;

namespace Yuksi.Application.Services;

public interface IJwtProvider
{
    Task<LoginCommandResponse> CreateToken(AppUser user);
}
