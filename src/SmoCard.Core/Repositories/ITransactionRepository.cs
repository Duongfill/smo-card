using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmoCard.Core.Domain.Royalty;
using SmoCard.Core.Models;
using SmoCard.Core.Models.Royalty;
using SmoCard.Core.SeedWorks;

namespace SmoCard.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction,Guid>
    {
        Task<PagedResult<TransactionDto>> GetAllPaging(string? userName,
         int fromMonth, int fromYear, int toMonth, int toYear, int pageIndex = 1, int pageSize = 10);
    }
}
