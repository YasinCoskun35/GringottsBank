using GringottsBank.Core.Entities;
using GringottsBank.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GringottsBank.Core.Repositories
{
    public interface ITransactionRepository:IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetTransactionsInTimeRange(DateTime fromDate,DateTime toDate);
    }
}
