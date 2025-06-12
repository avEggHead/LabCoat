using System;

namespace LabCoat.Experiments
{
    internal class TestQuestion1 : IExperiment
    {
        public void Experiment()
        {
            //Console.WriteLine(MinimalNumberOfPackages(16, 3, 10)); // in this scenario there would be 4 required
            //Console.WriteLine(MinimalNumberOfPackages(16, 2, 10)); // in this scenario there would be 2 + 6 = 8 required
            Console.WriteLine(MinimalNumberOfPackages(11, 2, 1)); // in this scenario there would be -1
        }

        public int MinimalNumberOfPackages(int items, int availableLargePackages, int availableSmallPackages)
        {
            int totalPackagesRequired = 0;
            int spaceInLarge = 5;
            int spaceInSmall = 1;
            // Do the items fit in the avialable large?
            int totalSpacesInLarge = availableLargePackages * 5;
            // is total space in Large enough for all?
            bool isLargeEnough = totalSpacesInLarge > items;

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
                bool isSmallEnough = totalSmallSpace > leftOvers;
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