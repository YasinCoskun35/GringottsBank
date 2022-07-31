using GringottsBank.Core.Repositories.Base;
using System.Collections.Generic;
using GringottsBank.Core.Entities;
using System.Threading.Tasks;

namespace GringottsBank.Core.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> GetAccountByCustomerID(int IDNumber, int accountId);
        Task<IEnumerable<Account>> GetAccountListByCustomerID(int IDNumber);
    }
}
