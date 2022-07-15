using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekwubeBANK.APP.Core.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public decimal Amount;
        public decimal Balance;
        public string type { get; set; }
      
    }
}
