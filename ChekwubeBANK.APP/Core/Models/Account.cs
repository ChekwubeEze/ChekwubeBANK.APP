using ChekwubeBANK.APP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekwubeBANK.APP.Core.Models
{
    public class Account

    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal amount;
        public decimal Balance = 0;
    }
}
