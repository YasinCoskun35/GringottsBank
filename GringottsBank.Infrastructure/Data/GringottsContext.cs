using Microsoft.EntityFrameworkCore;
using GringottsBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsBank.Infrastructure.Data
{
    public class GringottsContext:DbContext
    {
        public GringottsContext(DbContextOptions<GringottsContext> options) : base(options) { }
        public DbSet<Customer> Customers
        {
            get;
            set;
        }
        public DbSet<Account> Accounts
        {
            get;
            set;
        }
        public DbSet<Transaction> Trasactions
        {
            get;
            set;
        }
    }
}
