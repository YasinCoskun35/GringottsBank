using GringottsBank.Core.Entities;
using GringottsBank.Core.Repositories;
using GringottsBank.Infrastructure.Data;
using GringottsBank.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsBank.Infrastructure.Repository
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(GringottsContext gringottsContext) : base(gringottsContext) { }
        public async Task<Account> GetAccountByCustomerID(int IDNumber,int accountId)
        {
            return await _gringottsContext.Accounts
                .Where(account=>account.CustomerId==IDNumber && account.Id==accountId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Account>> GetAccountListByCustomerID(int IDNumber)
        {
            return await _gringottsContext.Accounts
                .Where(account => account.Id == IDNumber)
                .ToListAsync();
        }
    }
}
