using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class User
    {
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        public User() { }

        public User(int id, string firstName, string lastName, DateTime dob)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            DoB = dob;
        }
            
        public DateTime DateOfBirth { get; set; }

        public int GetAgeInYears()
            {
                TimeSpan agespan = DateTime.Now - DoB;
                double totalAgeInYears = agespan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        

    }
}
