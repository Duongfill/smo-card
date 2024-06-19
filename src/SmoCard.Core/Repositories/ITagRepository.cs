using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmoCard.Core.Domain.Content;
using SmoCard.Core.Models.Content;
using SmoCard.Core.SeedWorks;

namespace SmoCard.Core.Repositories
{
    public interface ITagRepository : IRepository<Tag, Guid>
    {
        Task<TagDto> GetBySlug (string slug);
    }
}
