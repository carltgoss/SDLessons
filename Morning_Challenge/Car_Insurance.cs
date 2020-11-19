using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge
{
    public class Car_Insurance
    {
        public string IDNumber { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Enrollment { get; set; }

        public int YearsWithCompany
        {
            get
            {
                return (int)Math.Round((DateTime.Now - Enrollment).TotalDays / 365);
            }
        }

        public bool IsGoldMember
        {
            get
            {
                if (YearsWithCompany > 5)
                {
                    Console.WriteLine("I love goooooold!!");
                }
                return false;
            }
        }
        public string GetGreetingMessage()
        {
            if (IsGoldMember)
            {
                return "Hello Gold Member, thank you for being a loyal customer.";
            }
            return "Go away now";          
        }
        public Car_Insurance() { }
        public Car_Insurance(string idNumber, string lastName, int age, DateTime enrollment)
        {
            IDNumber = idNumber;
            LastName = lastName;
            Age = age;
            Enrollment = enrollment;


        }


    }
}

