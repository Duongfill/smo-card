using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmoCard.Core.Models.Content;
using SmoCard.Core.Models;
using SmoCard.Core.SeedWorks;
using SmoCard.Core.Domain.Content;

namespace SmoCard.Core.Repositories
{
    public interface ISeriesRepository : IRepository<Series, Guid>
    {
        Task<PagedResult<SeriesInListDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
        Task AddPostToSeries(Guid seriesId, Guid postId, int sortOrder);
        Task RemovePostToSeries(Guid seriesId, Guid postId);
        Task<List<PostInListDto>> GetAllPostsInSeries(Guid seriesId);
        Task<PagedResult<PostInListDto>> GetAllPostsInSeries(string slug, int pageIndex = 1, int pageSize = 10);
        Task<SeriesDto> GetBySlug(string slug);

        Task<bool> IsPostInSeries(Guid seriesId, Guid postId);
        Task<bool> HasPost(Guid seriesId);
    }
}
