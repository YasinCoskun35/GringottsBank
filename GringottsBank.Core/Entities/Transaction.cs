using GringottsBank.Core.Entities.Base;
using GringottsBank.Core.Enums;

using System.ComponentModel.DataAnnotations;


namespace GringottsBank.Core.Entities
{
    public class Transaction : BaseEntity
    {
        [Required]
        public float Amount { get; set; }

        public string Description { get; set; }

        [Required]
        public string Ref { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public int UserId { get; set; }


        [Required]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

    }
}
