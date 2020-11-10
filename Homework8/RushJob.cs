namespace Hwk8Heishman
{
    public class RushJob : Job
    {

        public override string ToString() //display all job info
        {
            return $"Job {jobNumber} {custName} {jobDescription} {estHours} hours @{JOB_PRICE:C} per hour. Rush job adds $150 premium. Total price is {(JOB_PRICE * estHours) + 150:C}";
        }
    }
}
