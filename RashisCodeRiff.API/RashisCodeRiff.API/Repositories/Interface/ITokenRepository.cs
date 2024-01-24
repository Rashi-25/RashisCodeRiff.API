using Microsoft.AspNetCore.Identity;

namespace RashisCodeRiff.API.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
