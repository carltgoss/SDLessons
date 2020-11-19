using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    class Car_Insurance
    {
        public string IDNumber { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Enrollment { get; set; }
       
        public int Years
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - Enrollment;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsofAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsofAge;
            }
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
