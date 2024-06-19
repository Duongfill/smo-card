using SmoCard.Core.SeedWorks;
using SmoCard.Core.Domain.Identity;

namespace SmoCard.Core.Repositories
{
    public interface IUserRepository : IRepository<AppUser, Guid>
    {
        Task RemoveUserFromRoles(Guid userId, string[] roles);
    }
}
