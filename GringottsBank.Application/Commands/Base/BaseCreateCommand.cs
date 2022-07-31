using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsBank.Application.Commands.Base
{
    public abstract class BaseCreateCommand 
    {
        public DateTime CreatedOn { get; set; }=DateTime.Now;
        public DateTime ModifiedOn { get; set; }=DateTime.Now;
        public bool Active { get; set; } = true;

    }
}
