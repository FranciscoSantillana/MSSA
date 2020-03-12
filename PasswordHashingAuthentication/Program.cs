using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace PasswordHashingAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome, Please Sign In or Create an Account.\n\n");           
            Selector();
              
        }
        static void Selector()
        {
            Console.Clear();
            Console.WriteLine(Menu());
            try
            {
                int selection;
                while (Int32.TryParse(Console.ReadLine(), out selection) == false || selection < 1 || selection > 3)
                {
                    Console.WriteLine(Menu());
                }
                switch (selection)
                {
                    case (1):
                        Account account = new Account();
                        UsernameMaker(account);
                        PasswordMaker(account);

                        //adds hashed password and username to my list
                        AccountRepo.Accounts.Add(account);
                        
                        Console.WriteLine("Press [Enter]");
                        Console.ReadKey();
                        
                        Console.Clear();
                        Selector();
                        break;

                    case (2):
                        Account accountChk = new Account();
                        Console.WriteLine("enter your username");
                        accountChk.username = Console.ReadLine();
                        Console.WriteLine("enter your password");
                        accountChk.password = Console.ReadLine();
                        EncryptPassword(accountChk);
                        var check = AccountRepo.Accounts.FirstOrDefault(a => a.username == accountChk.username && a.password == accountChk.password);
                        if(check !=null)
                        {
                            Console.WriteLine("Authorized\n" +
                                "Press [Enter]");
                            Console.ReadKey();
                            Selector();
                            break;
                        }
                        Console.WriteLine("Not authorized" +
                            "Press [Enter]");
                        Console.ReadKey();
                        break;

                    case (3):
                        if(AccountRepo.Accounts != null)
                        {
                            foreach (Account a in AccountRepo.Accounts)                            
                                Console.WriteLine($"username:{a.username} password:{a.password}");                                                       
                        }
                        Environment.Exit(0);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("An error brought you here");
                Console.WriteLine(Menu());
            }

            string Menu() => "PASSWORD AUTHENTICATION SYSTEM\n\n" +
                        "Please select one option:\n" +
                        "[1] Establish an account\n" +
                        "[2] Authenticate a user\n" +
                        "[3] Exit the system\n\n";
        }
        static void UsernameMaker(Account account)
        {
            
            Console.WriteLine("What is your username?\n" +
                              "(Max Characters is 20)\n");
              string username = Console.ReadLine();
            if (username.Length <= 20) 
            {
                account.username = username;
                foreach (Account a in AccountRepo.Accounts)
                {
                    if (a.username == account.username)
                    {
                        Console.WriteLine("This username already exists\n" +
                                          "press [Enter]");
                        Console.ReadKey();
                        Selector();
                    }
                }

                Console.WriteLine($"Your username input is: {username}");
            }           
            else
            {
                Console.WriteLine("The username you provided is too long. please try again.\n");
                Selector();
            }            
            

        }
        static void PasswordMaker(Account account)
        {
            Console.WriteLine("What is your desired password?\n" +
                              "==============================\n");
            string password = Console.ReadLine();

            account.password = password;
            EncryptPassword(account);

            Console.WriteLine("Your plain text password is: " + password + " \n" +
                              "Your hashed password is: " + account.password + ".");

        }
        static void EncryptPassword(Account account)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hashedPassword = GetMd5Hash(md5Hash, account.password);

                account.password = hashedPassword;
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string password)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x1"));
            }
            return stringBuilder.ToString();
        }

    }
}
