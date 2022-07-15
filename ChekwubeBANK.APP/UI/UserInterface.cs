using ChekwubeBANK.APP.Core.Models;
using ChekwubeBANK.APP.Data;
using ChekwubeBANK.APP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekwubeBANK.APP.UI
{
    public class UserInterface:DataStore
    {
       // Console.WriteLine("Welcome: \"1\" to REGISTER or \"2\" to LOGIN ");
       public static void startPage()
        {
            Console.WriteLine("*****************************|| WELCOME CHEKWUBE BANK.APP||*******************************");
            Console.WriteLine(" Enter \n 1. REGISTER\n 2. LOGIN\n 3. EXIT   ");
            Console.WriteLine();
           string answer = Console.ReadLine();
            

                while(answer != "1" && answer != "2" && answer != "3")
            {
                answer = Console.ReadLine();
            }
            if(answer == "1")
            {
                Console.Clear();
                Console.WriteLine("Welcome to REGISTRATION Portal, Ensure You Follow Instructions ");
                Console.WriteLine();
                RegisterOrLogin.register();
                Console.WriteLine("Enter\n 1. Open Savings Account\n 2. Open Current Account ");
                string type = Console.ReadLine();
                RegisterOrLogin.Open(type);
                
            }
            if( answer == "2")
            {
                Console.WriteLine(" Enter Your Details to LOGIN ");
                Console.Write(" Email: ");
                string Email = Console.ReadLine();

                Console.Write("Password: ");
                string Password = Console.ReadLine();
                RegisterOrLogin.Login(Email, Password);
            }

        }
      
      
    }

}
