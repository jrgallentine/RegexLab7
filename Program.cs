using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegExLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone;
            string date;
            string email;
            string name;

            while (true)
            {
                Console.Write("Enter a valid Name: ");
                name = Console.ReadLine();

                if (IsName((name)) == true)
                {

                    Console.Clear();
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid entry!");
                    Console.WriteLine();
                    IsName(name);
                }
             }

            while (true)
            {
                Console.Write("Enter a valid email: ");
                email = Console.ReadLine();
                if (IsEmail((email)) == true)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry! Do better!");
                    Console.WriteLine();
                    
                    IsEmail(email);
                }
            }

            while (true)
            {
                Console.Write("Enter a valid phone number [eg. xxx-xxx-xxxx] : ");
                phone = Console.ReadLine();
                

                if (IsPhone((phone)) == true)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry! Do better!");
                    Console.WriteLine();
                    IsPhone(phone);
                }

            }



            while (true)
            {
                Console.Write("Enter a valid date [eg. dd/mm/yyyy] : ");
                date = Console.ReadLine();


                if (IsDate(date) == true)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry! Do better!");
                    Console.WriteLine();
                    IsDate(date);
                }
            }
            Console.WriteLine("-----Valid Entries-----");
            Console.WriteLine(name);
            Console.WriteLine(email);
            Console.WriteLine(phone);
            Console.WriteLine(date);
            Console.WriteLine("-----------------------");

            

        }



        public static bool IsName(string name)
        {
            
            Regex rgx0 = new Regex(@"^[A-Z]");
            Regex rgx = new Regex("^[A-Za-z ]*$");
            if ((name.Length <= 30)&&
                (rgx0.IsMatch(name)==true)&&
                (rgx.IsMatch(name)==true))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static bool IsPhone(string phone)
        {
            Regex rgx = new Regex(@"^\d\d\d-\d\d\d-\d\d\d\d$");
            if (rgx.IsMatch(phone) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool IsEmail(string email)
        {
            Regex rgx = new Regex("^[\\d\\w.]{5,30}@[\\w\\d]{5,10}\\.[\\w\\d]{2,3}$");
            if (rgx.IsMatch(email) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDate(string date)
        {
            Regex rgx = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((17|18|19|20|21)\d\d))$");
            if (rgx.IsMatch(date) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
