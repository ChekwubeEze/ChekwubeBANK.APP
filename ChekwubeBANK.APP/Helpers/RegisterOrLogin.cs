using ChekwubeBANK.APP.Core.Models;
using ChekwubeBANK.APP.Data;
using ChekwubeBANK.APP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekwubeBANK.APP.Helpers
{
    public class RegisterOrLogin
    {
        public static string firstname;
        public static string lastname;
        public static string password;
        public static string email;
        public static string PhoneNumber;
        public static void register()
        {
           

            Console.Write("Enter FirstName: ");
            firstname = Console.ReadLine();
            while (!Validate.ValidateName(firstname))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Name Format, Try Again:");
                Console.ResetColor();
                firstname = Console.ReadLine();
            }

            Console.Write("Enter LastName: ");
            lastname = Console.ReadLine();
            while (!Validate.ValidateName(lastname))
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Invalid Name Format, Try Again:");
                Console.ResetColor();
                lastname = Console.ReadLine();
            }


            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            while (!Validate.IsEmailValid(email))
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine(" Invalid email format, Try again");
                Console.ResetColor();
                email = Console.ReadLine();
            }

            Console.Write("Enter password: ");
            password = Console.ReadLine();
            while (Validate.IsValidPassword(password))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password must contain minimum of 8 Character or number ");
                Console.ResetColor();
                password = Console.ReadLine();
            }
            Console.Write("Enter Phonenumber:");
            PhoneNumber = Console.ReadLine();
            while(PhoneNumber.Length != 11)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID ");
                Console.ResetColor();
                PhoneNumber = Console.ReadLine();
            }



           
        }
        public static void Login(string Email, string Passwoed)
        {
          
            
           
            foreach(var customer in DataStore.Customers)
            {
                if(customer.Email == Email && customer.Password == Passwoed)
                {
                    var User = customer;
                   
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID");
                    Console.ResetColor();                   
                }                              
            }
        }
        public static void Open(string type)
        {
            var customer = new Customer();
            
            customer.firstName = firstname;
            customer.lastName = lastname;
            customer.Email = email;
            customer.Password = password;
            customer.Id += 1;
            customer.PhoneNumber = PhoneNumber;
            Customer.IdCount++;
          
            DataStore.Customers.Add(customer);

            if (type == "1")
            {
                var account = new Account();
                account.AccountType = AccountTypes.Savings.ToString();
                account.CustomerId = customer.Id;
                account.Id += 1;
                account.AccountName = $"{customer.firstName}, {customer.lastName}";
                account.AccountNumber = AccountGenerator();
                account.amount = 0;
                account.Balance += account.amount;


                DataStore.Accounts.Add(account);
                Console.Write("How much do you want to open account with? The minimum opening balance is = 1000\n Amount:  ");
                var n = Console.ReadLine().Trim();
                var isValid = decimal.TryParse(n, out account.amount);

                if (Validate.ValidaeAmount(account.amount))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your savings account has been successfully opened.Below are your account details");
                    Console.WriteLine($"Account Name\tAcoount Number\tOpening Bal\tEmail\t\tAccountType\tPhoneNumber\n{account.AccountName}\t{account.AccountNumber}\t{account.Balance}\t\t{email}\t{account.AccountType}\t\t{PhoneNumber}");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                    
            }
            else if (type == "2")
            {
                var account = new Account();
                account.AccountType = AccountTypes.Current.ToString();
                account.CustomerId = customer.Id;
                account.Id += 1;
                account.AccountName = $"{customer.firstName}, {customer.lastName}";
                account.AccountNumber = AccountGenerator();


                DataStore.Accounts.Add(account);
                Console.Write("How much do you want to open account with? The minimum opening balance is = 1000\n Aaount:    ");
                var n = Console.ReadLine().Trim();
                var isValid = decimal.TryParse(n, out account.amount);

                if (Validate.ValidaeAmount(account.amount))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your savings account has been successfully opened.Below are your account details");
                    Console.WriteLine($"Account Name\tAcoount Number\tOpening Bal\tEmail\t\tAccountType\tPhoneNumber\n{account.AccountName}\t{account.AccountNumber}\t{account.Balance}\t\t{email}\t{account.AccountType}\t\t{PhoneNumber}");
                    Console.ResetColor();
                    Console.WriteLine();
                }


            }

        }
      /*  public static void open(string fullname, string password, string email)
        {
            if (type == "2")
            {


            }

        }*/
        private static string AccountGenerator()
        {
            var random = new Random();

            string accountNumber = string.Empty;
            for (int i = 0; i < 10; i++)
                accountNumber = String.Concat(accountNumber, random.Next(10).ToString());
            return accountNumber;
        }
    }
}
