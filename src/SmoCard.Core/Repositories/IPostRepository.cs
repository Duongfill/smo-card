﻿using SmoCard.Core.Domain.Content;
using SmoCard.Core.Models;
using SmoCard.Core.Models.Content;
using SmoCard.Core.SeedWorks;

namespace SmoCard.Core.Repositories
{
    public interface IPostRepository : IRepository<Post,Guid>
    {
        Task<PagedResult<PostInListDto>> GetAllPaging(string? keyword, Guid currentUserId, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
        Task<bool> IsSlugAlreadyExisted(string slug, Guid? currentId = null);
        Task<List<SeriesInListDto>> GetAllSeries(Guid postId);
        Task Approve(Guid id, Guid currentUserId);
        Task SendToApprove(Guid id, Guid currentUserId);
        Task ReturnBack(Guid id, Guid currentUserId, string note);
        Task<string> GetReturnReason(Guid id);
        Task<bool> HasPublishInLast(Guid id);
        Task<List<PostActivityLogDto>> GetActivityLogs(Guid id);
        Task<List<Post>> GetListUnpaidPublishPosts(Guid userId);

        Task<List<PostInListDto>> GetLatestPublishPost(int top);

        Task<PagedResult<PostInListDto>> GetPostByCategoryPaging(string categorySlug, int pageIndex = 1, int pageSize = 10);

        Task<PostDto> GetBySlug(string slug);

        Task<List<string>> GetAllTags();

        Task AddTagToPost(Guid postId, Guid tagId);

        Task<List<string>> GetTagsByPostId(Guid postId);

        Task<List<TagDto>> GetTagObjectsByPostId(Guid postId);

        Task<PagedResult<PostInListDto>> GetPostByTagPaging(string tagSlug, int pageIndex = 1, int pageSize = 10);
        Task<PagedResult<PostInListDto>> GetPostByUserPaging(string keyword,Guid userId, int pageIndex = 1, int pageSize = 10);


    }
}
