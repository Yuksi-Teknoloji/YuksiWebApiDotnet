using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using Yuksi.Application.Features.Auth.Login;
using Yuksi.Application.Services;
using Yuksi.Domain;

namespace Yuksi.Test.Features.Auth;

public class LoginCommandHandlerTest
{
    // test düzeltildi.Sağlam.
    [Fact]
    public async Task Handle_WithValidCredentials_ReturnsToken()
    {
        var user = new AppUser { Id = Guid.NewGuid(), UserName = "testuser", Email = "test@example.com", FirstName = "Test User" };
        var storeMock = new Mock<IUserStore<AppUser>>();
        var userManagerMock = new Mock<UserManager<AppUser>>(storeMock.Object, null, null, null, null, null, null, null, null);
        userManagerMock.SetupGet(u => u.Users).Returns(new List<AppUser> { user }.AsQueryable());

        var contextAccessorMock = new Mock<IHttpContextAccessor>();
        var claimsFactoryMock = new Mock<IUserClaimsPrincipalFactory<AppUser>>();
        var loggerMock = new Mock<ILogger<SignInManager<AppUser>>>();
        var schemesMock = new Mock<IAuthenticationSchemeProvider>();
        var userConfirmationMock = new Mock<IUserConfirmation<AppUser>>();

        var signInManagerMock = new Mock<SignInManager<AppUser>>(userManagerMock.Object,
            contextAccessorMock.Object,
            claimsFactoryMock.Object,
            Options.Create(new IdentityOptions()),
            loggerMock.Object,
            schemesMock.Object,
            userConfirmationMock.Object);

        signInManagerMock.Setup(s => s.CheckPasswordSignInAsync(It.IsAny<AppUser>(), "password123", true)).ReturnsAsync(SignInResult.Success);
        var jwtProviderMock = new Mock<IJwtProvider>();
        var expectedResponse = new LoginCommandResponse("token-value", "refresh-value", DateTime.UtcNow.AddHours(1));
        jwtProviderMock.Setup(j => j.CreateToken(user)).ReturnsAsync(expectedResponse);
        var handler = new LoginCommandHandler(userManagerMock.Object, signInManagerMock.Object, jwtProviderMock.Object);
        var command = new LoginCommand("testuser", "password123");
        var result = await handler.Handle(command, CancellationToken.None);
        Assert.True(result.IsSuccessful);
        var data = result.Data;
        Assert.NotNull(data);
        Assert.Equal(expectedResponse.Token, data.Token);
        Assert.Equal(expectedResponse.RefreshToken, data.RefreshToken);
    }
}
