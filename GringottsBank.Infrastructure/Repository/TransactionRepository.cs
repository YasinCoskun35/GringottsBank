using GringottsBank.Core.Entities;
using GringottsBank.Core.Repositories;
using GringottsBank.Infrastructure.Data;
using GringottsBank.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GringottsBank.Infrastructure.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(GringottsContext gringottsContext) : base(gringottsContext) { }
        public async Task<IEnumerable<Transaction>> GetTransactionsInTimeRange(DateTime fromDate,DateTime toDate)
        {
            return await _gringottsContext.Trasactions.Where(transaction => fromDate <= transaction.CreatedOn
                                   && transaction.CreatedOn <= toDate).ToListAsync();
        }
    }
}
