using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmoCard.Core.Domain.Content;
using SmoCard.Core.Models.Content;
using SmoCard.Core.Repositories;
using SmoCard.Data.SeedWorks;

namespace SmoCard.Data.Repositories
{
    public class TagRepository : RepositoryBase<Tag, Guid>, ITagRepository
    {
        private readonly IMapper _mapper;
        public TagRepository(SmoCardContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<TagDto?> GetBySlug(string slug)
        {
            var tag = await _context.Tags.FirstOrDefaultAsync(x => x.Slug == slug);
            if (tag == null) return null;
            return _mapper.Map<TagDto?>(tag);
        }
    }
}
