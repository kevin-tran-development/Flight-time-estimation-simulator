/* 
 * Purpose: To create a program to determine if current estimates of flight times are accurate by 
 * comparing the user input of estimated flight time and the actual flight time to see what the acceptable error margin in minutes is.
 * With that, you can then get a consideration whether the estimate is too large, acceptable, or too small.
 * 
 * Input: Estimated flight time in minutes and actual flight time in minutes.
 * 
 * Process: Using the chart table of acceptable error margins, compare what the user inputted and determine your acceptable error margin.
 * To get the acceptable error margin, use the estimated flight time's range such as from 0 to 29 in minutes. If the estimated time is greater 
 * than the actual flight, subtract it from the error of margin. If the estimated time is less than the actual flight, add it with the
 * error of margin. If the actual flight time is less than the estimated time subtracted or added with the error margin, subtract 
 * the actual flight time from the value and the result is deemed as too large. If the actual flight time is greater than the estimated time subtracted or added
 * with the error margin, subtract the actual flight time from the value and the result is deemed as too small. Otherwise, the estimation is 
 * acceptable.
 * 
 * Output: A time estimate that states whether if the estimated flight time is too large, small, or acceptable as well as by how many minutes. 
 * 
 * Author: Kevin Tran
 * 
 * Last Modified: 2019-10-01
 */
using System;

namespace CorePortfolio02_KevinTran
{
    class EstimatedFlightTimes
    {
        static void Main(string[] args)
        {
            // ------------ Starting of the Compound Interest App ------------

            Console.WriteLine("-------------------------");
            Console.WriteLine("| Flight Time Estimation |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("This program is used to determine if the estimated flight time is acceptable.\n");

            // ------------ Declaring Variables ------------

            int estimatedFlight;
            int actualFlight;
            int errorMargin;
            int estimateLarge;
            int estimateSmall;
            int estimateTotal;
            string userInput;

            // ------------ Asking for user input ------------
            
            Console.Write("Please enter the estimated flight time in minutes: ");
            userInput = Console.ReadLine();
            estimatedFlight = int.Parse(userInput);

            Console.Write("Please enter the actual flight time in minutes: ");
            userInput = Console.ReadLine();
            actualFlight = int.Parse(userInput);

            // ------------ Process and Output  ------------

            switch (estimatedFlight)
            {
                case int estimatedFlightRange when estimatedFlightRange >= 0 && estimatedFlightRange <= 29:

                    errorMargin = 1;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;
                    
                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of first case range (0-29)

                case int estimatedFlightRange when estimatedFlightRange >= 30 && estimatedFlightRange <= 59:

                    errorMargin = 2;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;

                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of second case range (30-59)

                case int estimatedFlightRange when estimatedFlightRange >= 60 && estimatedFlightRange <= 89:

                    errorMargin = 3;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;

                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of third case range (60-89)

                case int estimatedFlightRange when estimatedFlightRange >= 90 && estimatedFlightRange <= 119:

                    errorMargin = 4;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;

                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of fourth case range (90-119)

                case int estimatedFlightRange when estimatedFlightRange >= 120 && estimatedFlightRange <= 179:

                    errorMargin = 6;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;

                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of fifth case range (120-179)

                case int estimatedFlightRange when estimatedFlightRange >= 180 && estimatedFlightRange <= 239:

                    errorMargin = 8;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;

                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of sixth case range (180-239)

                case int estimatedFlightRange when estimatedFlightRange >= 240 && estimatedFlightRange <= 359:

                    errorMargin = 13;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;

                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of seventh case range (240-359)

                case int estimatedFlightRange when estimatedFlightRange >= 360:

                    errorMargin = 17;
                    estimateLarge = estimatedFlight - errorMargin;
                    estimateSmall = estimatedFlight + errorMargin;

                    if (actualFlight < estimateLarge)
                    {
                        estimateTotal = actualFlight - estimateLarge;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too large. (By {estimateTotal} minutes)");
                    }
                    else if (actualFlight > estimateSmall)
                    {
                        estimateTotal = actualFlight - estimateSmall;
                        estimateTotal = Math.Abs(estimateTotal);
                        Console.WriteLine($"Estimated flight time is too small. (By {estimateTotal} minutes)");
                    }
                    else
                    {
                        Console.WriteLine("Estimated flight time is acceptable.");
                    }

                    break; // End of eigth case range (360+)

            } // End of switch statement

            Console.ReadLine();

        }
    }
}
