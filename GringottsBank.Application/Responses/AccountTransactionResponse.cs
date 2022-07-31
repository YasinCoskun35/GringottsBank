using GringottsBank.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsBank.Application.Responses
{
    internal class AccountTransactionResponse
    {
        
        public float Amount { get; set; }

        public string Description { get; set; }
        
        public string Ref { get; set; }

        public TransactionType Type { get; set; }
        
        public int UserId { get; set; }
    }
}
