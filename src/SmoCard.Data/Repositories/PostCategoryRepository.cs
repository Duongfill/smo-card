﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmoCard.Core.Domain.Content;
using SmoCard.Core.Models.Content;
using SmoCard.Core.Models;
using SmoCard.Core.Repositories;
using SmoCard.Data.SeedWorks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SmoCard.Data.Repositories
{
    public class PostCategoryRepository : RepositoryBase<PostCategory, Guid>, IPostCategoryRepository
    {
        private readonly IMapper _mapper;
        public PostCategoryRepository(SmoCardContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<PagedResult<PostCategoryDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10)
        {
            var query = _context.PostCategories.AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword));
            }
            var totalRow = await query.CountAsync();

            query = query.OrderByDescending(x => x.DateCreated)
               .Skip((pageIndex - 1) * pageSize)
               .Take(pageSize);

            return new PagedResult<PostCategoryDto>
            {
                Results = await _mapper.ProjectTo<PostCategoryDto>(query).ToListAsync(),
                CurrentPage = pageIndex,
                RowCount = totalRow,
                PageSize = pageSize
            };
        }

        public async Task<PostCategoryDto> GetBySlug(string slug)
        {
            var category = await _context.PostCategories.FirstOrDefaultAsync(x => x.Slug == slug);
            if (category == null) { throw new Exception($"Cannot find {slug}"); }
            return _mapper.Map<PostCategoryDto>(category);
        }

        public async Task<bool> HasPost(Guid categoryId)
        {
            return await _context.Posts.AnyAsync(x => x.CategoryId == categoryId);
        }
    }
}
