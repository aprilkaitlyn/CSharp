using System;
namespace Hwk8Heishman

{
    public class Job
    {
        public int jobNumber {get; set;} //getters and setters
        public string custName { get; set; }
        public string jobDescription { get; set; }
        public int estHours { get; set; }
        public const double JOB_PRICE = 45.00;

        public Job ()
        {

        }

        public Job (int num, string name, string job, int hours) //constructor
        {
            jobNumber = num;
            custName = name;
            jobDescription = job;
            estHours = hours;
        }

        //determine if any jobs have the same job number
        public static string Equals(int oneJ, string oneN, int twoJ, string twoN, int threeJ, string threeN)
        {
            if (oneJ == threeJ)
                return $"{oneJ} for {oneN} is the same job number as {threeJ} for {threeN}";
            else if (twoJ == threeJ)
                return $"{twoJ} for {twoN} is the same job number as {threeJ} for {threeN}";
            else if (oneJ == twoJ)
                return $"{oneJ} for {oneN} is the same job number as {twoJ} for {twoN}";
            else return "";
        }

        public override int GetHashCode() //returns job number
        {
            return jobNumber;
        }

        public override string ToString() //display all job info
        {
            return $"Job {jobNumber} {custName} {jobDescription} {estHours} hours @{JOB_PRICE:C} per hour. Total price is {JOB_PRICE * estHours:C}";
        }
    }
}
