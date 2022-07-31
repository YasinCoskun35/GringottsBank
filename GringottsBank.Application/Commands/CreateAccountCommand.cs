using GringottsBank.Core.Entities;
using GringottsBank.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsBank.Application.Commands
{
    public class CreateAccountCommand
    {
        
        public string Alias { get; set; }
        
        public float Balance { get; set; }
        
        public string IBAN { get; set; }
        
        public string Number { get; set; }
        
        public AccountType Type { get; set; }
        public List<Transaction> Transactions { get; set; }
        
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
