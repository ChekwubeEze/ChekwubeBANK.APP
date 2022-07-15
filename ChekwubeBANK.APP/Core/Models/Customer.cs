using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekwubeBANK.APP.Core.Models
{
    public class Customer
    {
        public static int IdCount = 0;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string PhoneNumber;

        public List<Account> accounts { get; set; }
       

    }
}
