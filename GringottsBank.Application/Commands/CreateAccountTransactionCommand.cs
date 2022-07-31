using GringottsBank.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsBank.Application.Commands
{
    public class CreateAccountTransactionCommand
    {
        public float Amount { get; set; }

        public string Description { get; set; }
        
        public TransactionType Type { get; set; }
        
        public int UserId { get; set; }

        public int AccountId { get; set; }
    }
}
