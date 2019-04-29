using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, phone, date;

            // regexr.com/4d46q

            GetValidInput("name", "^[A-Z][a-zA-Z0-9]{1,30}$", out name);

            GetValidInput("email", "([A-z0-9]{5,30})@([A-z]{5,10}).([A-z]{2,3})", out email);

            GetValidInput("phone number", "([0-9]{3}-[0-9]{3}-[0-9]{4})", out phone);

            GetValidInput("date", "([0-9]{2}/[0-9]{2}/[0-9]{4})", out date);



        }

        public static bool GetValidInput(string data, string regex, out string valid) // kept flip flopping between whether or not i wanted it to be a bool
                                                                                      // and settled on this just for the sake of coming to a decision, in hindsight
                                                                                      // theres definitely a much nicer way to go about it but this works good enough and I'm not getting paid
        {
            Console.WriteLine($"Enter {data}: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, regex))
            {
                valid = input;
                Console.WriteLine($"Valid {data}.");
                return true;
            }

            Console.WriteLine($"Sorry, {data} is not valid. Try entering something else.");

            return GetValidInput(data, regex, out valid);
        }
    }
}
