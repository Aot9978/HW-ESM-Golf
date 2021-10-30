using System;
/*Name: Antwoine Tomlinson
 * Professor: Ann Warren
 * Purpose: Create a program that simulates golf after user guesses
 * and inputs different values for velocity and angles
 * Date: 10/28/2021
 */
namespace HW_ESM_Golf
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare velocity and angle variables
            float velocity;
            float angle;
            Console.WriteLine("This is virtual Mario Golf!\n Your target is 751 meters away.");
            velocity = 1;
            angle = 1;
            //call back both mehtods
            input( velocity);
            input2(angle);
            // conversion
           
            //use inputs for golfing distance
            
            //use formula
            double convert = angle * Math.PI / 180;
            double sine = Math.Sin(convert);
            double cosine = Math.Cos(convert);
            double sinesquared = Math.Pow(sine, 2);
            double L = 2.0;
            double time = (velocity * Math.Sin(angle) + Math.Sqrt((velocity * velocity) * (Math.Sin(angle)) + 20.0 * L*Math.Sin(angle))) / 10.0;
            double distance = velocity * Math.Cos(angle) * time;
            Console.WriteLine("The a ball whacked at that velocity and that angle"
             +   " will result in"+ distance+ "meters near the goal");
           
        }
        //method for velocity input
        public static float input(float velocity)
        {
            Console.WriteLine("Enter the cannon's velocity[positive numbers only]");
             velocity = float.Parse(Console.ReadLine());
            //if statement to make velocity a positive input
            if (velocity > 0)
            {
                Console.WriteLine("The input {0} is valid", velocity);
            }
            //invalid if it is negative
            else
            {
                Console.WriteLine("The input is invalid, try again");
            }
            return velocity;
            
        }
        public static float input2 (float angle)
        {
            Console.WriteLine("Input an angle value [between 0 and 90 degrees]");
            angle = float.Parse(Console.ReadLine());
            if(angle>0&&angle<90){
                Console.WriteLine("The input {0} is valid", angle);
            }
            else
            {
                Console.WriteLine("This input is invalid, try again");
            }
            return angle;
        }
    }

   
}
