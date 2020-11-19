using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get { return _lastName.ToLower(); }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return FirstName + " " + _lastName; }
        }

        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                TimeSpan agespan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = agespan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }
        public Vehicle Transport { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            _lastName = lastName;
            DateOfBirth = dob;
        }

        public int GetAge()
        {
            TimeSpan agespan = DateTime.Now - DateOfBirth;
            double totalAgeInYears = agespan.TotalDays / 365.241;
            int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return yearsOfAge;
        }
    }

}
