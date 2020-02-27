using System;

namespace CalculateBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your height: ");
            float height=Int32.Parse(Console.ReadLine());// Initialize Height
            Console.WriteLine("Please enter your weight: ");
            float weight= Int32.Parse(Console.ReadLine());// Initialize Weight
            float BMI = (weight * 703) / (height*height); // calculate BMI
            //create if -esle if statement to catagorize under, normal, over and obese 
            //create if -else if statement inside under and obese condition for sub catagories such as sever, moderate and mild for underweight
            //and I, II and II for Obese catagories.
            if (BMI<18.5)
            {
                //condition for underweight
                Console.WriteLine("Underweight");
                if (BMI < 16)
                {
                    Console.WriteLine("Sever thinness");
                }
                else if (BMI >= 16 && BMI <= 16.99)
                {
                    Console.WriteLine("Moderate thinness");
                }
                else if (BMI >= 17 || BMI <= 18.49)
                {
                    Console.WriteLine("Mild thinness");
                }

            }
            //condition for normal weight
            else if (BMI>=18.5 && BMI <= 24.9)
            {
                Console.WriteLine("Normal weight");
            }
            // condition for overweight
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("Overweight");
            }
            // condition for obese
            else
            {
                Console.WriteLine("Obese");
                
                if (BMI>=30 && BMI<=34.9)
                {
                    Console.WriteLine("Obese class I");
                }
                else if (BMI >= 35 && BMI <= 39.9)
                {
                    Console.WriteLine("Obese class II");
                }
                else 
                {
                    Console.WriteLine("Obese class III");
                }
            }
        }
    }
}
