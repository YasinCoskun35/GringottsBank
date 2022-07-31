using GringottsBank.Core.Entities.Base;
using GringottsBank.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsBank.Core.Entities
{
    public class Account : BaseEntity
    {
        [Required]
        public string Alias { get; set; }
        [Required]
        public float Balance { get; set; }
        [Required]
        public string IBAN { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public AccountType Type { get; set; }
        public List<Transaction> Transactions { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
