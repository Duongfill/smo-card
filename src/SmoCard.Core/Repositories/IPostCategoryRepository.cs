using SmoCard.Core.Domain.Content;
using SmoCard.Core.Models.Content;
using SmoCard.Core.Models;
using SmoCard.Core.SeedWorks;

namespace SmoCard.Core.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory, Guid>
    {
        Task<PagedResult<PostCategoryDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
        Task<bool> HasPost(Guid categoryId);

        Task<PostCategoryDto> GetBySlug(string slug);

    }
}
