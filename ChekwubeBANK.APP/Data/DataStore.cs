using ChekwubeBANK.APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChekwubeBANK.APP.Data
{
    public class DataStore
    {
        public static List<Transaction> Transactions = new List<Transaction>();
        public static List<Account> Accounts = new List<Account>();
        public static List<Customer> Customers = new List<Customer>();
    }
}
