using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            do
            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int totalPeople = int.Parse(Console.ReadLine());

                //How much bread
                int slicesPerLoaf = 28;
                int totalSlicesNeeded = totalPeople * 2;
                double loaves = Math.Ceiling((double)totalSlicesNeeded / slicesPerLoaf);

                //How much peanut butter
                int tblsPerjar = 32;
                int totalTblsNeeded = totalPeople * 2;
                double jarsOfPeanutButter = Math.Ceiling((double)totalTblsNeeded / tblsPerjar);

                //How much jelly
                int tspPerJar = 48;
                int totalTspNeeded = totalPeople * 4;
                double jarsOfJelly = Math.Ceiling((double)totalTspNeeded / tspPerJar);

                Console.WriteLine(
                    "You need:\n" +
                        "\t" + totalSlicesNeeded + " slices of bread\n" +
                        "\t" + totalTblsNeeded + " tablespoons of peanut butter\n" +
                        "\t" + totalTspNeeded + " teaspoons of jelly\n" +

                    "which is...\n" +

                        "\t" + loaves + " loaves of bread\n" +
                        "\t" + jarsOfPeanutButter + " jars of peanut butter\n" +
                        "\t" + jarsOfJelly + " jars of jelly\n");

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                string userReply = Console.ReadLine();

                if (userReply == "yes" || userReply == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                    Console.Write("Goodbye!");
                }
            }
            while (repeat);
        }
    }
}
