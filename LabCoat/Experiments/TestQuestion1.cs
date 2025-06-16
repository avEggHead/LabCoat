using System;

namespace LabCoat.Experiments
{
    internal class TestQuestion1 : IExperiment
    {
        public void Experiment()
        {
            //Console.WriteLine(MinimalNumberOfPackages(16, 3, 10)); // in this scenario there would be 4 required
            //Console.WriteLine(MinimalNumberOfPackages(16, 2, 10)); // in this scenario there would be 2 + 6 = 8 required
            Console.WriteLine("Should be 3");
            Console.WriteLine(MinimalNumberOfPackages(11, 2, 1)); // in this scenario there would be -1
            Console.WriteLine("Should be -1");
            Console.WriteLine(MinimalNumberOfPackages(400, 10, 60)); // in this scenario there would be -1
            Console.WriteLine("Should be 200");
            Console.WriteLine(MinimalNumberOfPackages(400, 50, 300)); // in this scenario there would be 200
            Console.WriteLine("Should be 4");
            Console.WriteLine(MinimalNumberOfPackages(16, 5, 300)); // in this scenario there would be 4
            Console.WriteLine("Should be 16");
            Console.WriteLine(MinimalNumberOfPackages(16, 0, 300)); // in this scenario there would be 16
            Console.WriteLine(  "Should be -1");
            Console.WriteLine(MinimalNumberOfPackages(16, 2, 0)); // in this scenario there would be -1
            Console.WriteLine(  "Should be 8");
            Console.WriteLine(MinimalNumberOfPackages(16, 2, 7)); // in this scenario there would be 8
        }

        public int MinimalNumberOfPackages(int items, int availableLargePackages, int availableSmallPackages)
        {
            int totalPackagesRequired = 0;
            int spaceInLarge = 5;
            int spaceInSmall = 1;
            // Do the items fit in the avialable large?
            int totalSpacesInLarge = availableLargePackages * 5;
            // is total space in Large enough for all?
            bool isLargeEnough = totalSpacesInLarge >= items;

            if (isLargeEnough) {
                 // how many of the large were needed?
                 // do a division and round up
                 double requiredNumber = (double)items / (double)spaceInLarge;
                 //totalPackagesRequired = (int)Math.Round(requiredNumber,MidpointRounding.AwayFromZero);
                totalPackagesRequired = (int)Math.Ceiling(requiredNumber);
            } else
            {
                // subtract the total large space from the items
                int leftOvers = items - totalSpacesInLarge;
                // is there enough small space?
                int totalSmallSpace = spaceInSmall* availableSmallPackages;
                bool isSmallEnough = totalSmallSpace >= leftOvers;
                if (isSmallEnough) {
                    totalPackagesRequired += leftOvers + availableLargePackages;
                } else
                {
                    return -1;
                }
            }

            return totalPackagesRequired;
        }

        public string IdentifyExperiment()
        {
            return "packages";
        }
    }
}