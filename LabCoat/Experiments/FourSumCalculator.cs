using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class FourSumCalculator : IExperiment
    {
        public void Experiment()
        {
            int[] input = { 1, 0, -1, 0, -2, 2 };
            int target = 0;
            IList<IList<int>> result= new List<IList<int>>();
            result = FourSum(input, target);
            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] input2 = { 2, 2, 2, 2, 2 };
            target = 8;

            result = FourSum(input2, target);
            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2.ToString() + " ");
                }
                Console.WriteLine();
            }

            //int[] input3 = { -493, -482, -482, -456, -427, -405, -392, -385, -351, -269, -259, -251, -235, -235, -202, -201, -194, -189, -187, -186, -180, -177, -175, -156, -150, -147, -140, -122, -112, -112, -105, -98, -49, -38, -35, -34, -18, 20, 52, 53, 57, 76, 124, 126, 128, 132, 142, 147, 157, 180, 207, 227, 274, 296, 311, 334, 336, 337, 339, 349, 354, 363, 372, 378, 383, 413, 431, 471, 474, 481, 492 };
            //target = 6189;

            //result = FourSum(input3, target);
            //foreach (var item in result)
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.Write(item2.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] input4 = { -494, -474, -425, -424, -391, -371, -365, -351, -345, -304, -292, -289, -283, -256, -236, -236, -236, -226, -225, -223, -217, -185, -174, -163, -157, -148, -145, -130, -103, -84, -71, -67, -55, -16, -13, -11, 1, 19, 28, 28, 43, 48, 49, 53, 78, 79, 91, 99, 115, 122, 132, 154, 176, 180, 185, 185, 206, 207, 272, 274, 316, 321, 327, 327, 346, 380, 386, 391, 400, 404, 424, 432, 440, 463, 465, 466, 475, 486, 492 };
            //target = -1211;

            //result = FourSum(input4, target);
            //foreach (var item in result)
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.Write(item2.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] input5 = { 91277418, 66271374, 38763793, 4092006, 11415077, 60468277, 1122637, 72398035, -62267800, 22082642, 60359529, -16540633, 92671879, -64462734, -55855043, -40899846, 88007957, -57387813, -49552230, -96789394, 18318594, -3246760, -44346548, -21370279, 42493875, 25185969, 83216261, -70078020, -53687927, -76072023, -65863359, -61708176, -29175835, 85675811, -80575807, -92211746, 44755622, -23368379, 23619674, -749263, -40707953, -68966953, 72694581, -52328726, -78618474, 40958224, -2921736, -55902268, -74278762, 63342010, 29076029, 58781716, 56045007, -67966567, -79405127, -45778231, -47167435, 1586413, -58822903, -51277270, 87348634, -86955956, -47418266, 74884315, -36952674, -29067969, -98812826, -44893101, -22516153, -34522513, 34091871, -79583480, 47562301, 6154068, 87601405, -48859327, -2183204, 17736781, 31189878, -23814871, -35880166, 39204002, 93248899, -42067196, -49473145, -75235452, -61923200, 64824322, -88505198, 20903451, -80926102, 56089387, -58094433, 37743524, -71480010, -14975982, 19473982, 47085913, -90793462, -33520678, 70775566, -76347995, -16091435, 94700640, 17183454, 85735982, 90399615, -86251609, -68167910, -95327478, 90586275, -99524469, 16999817, 27815883, -88279865, 53092631, 75125438, 44270568, -23129316, -846252, -59608044, 90938699, 80923976, 3534451, 6218186, 41256179, -9165388, -11897463, 92423776, -38991231, -6082654, 92275443, 74040861, 77457712, -80549965, -42515693, 69918944, -95198414, 15677446, -52451179, -50111167, -23732840, 39520751, -90474508, -27860023, 65164540, 26582346, -20183515, 99018741, -2826130, -28461563, -24759460, -83828963, -1739800, 71207113, 26434787, 52931083, -33111208, 38314304, -29429107, -5567826, -5149750, 9582750, 85289753, 75490866, -93202942, -85974081, 7365682, -42953023, 21825824, 68329208, -87994788, 3460985, 18744871, -49724457, -12982362, -47800372, 39958829, -95981751, -71017359, -18397211, 27941418, -34699076, 74174334, 96928957, 44328607, 49293516, -39034828, 5945763, -47046163, 10986423, 63478877, 30677010, -21202664, -86235407, 3164123, 8956697, -9003909, -18929014, -73824245 };
            //target = -236727523;

            //result = FourSum(input5, target);
            //foreach (var item in result)
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.Write(item2.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] input6 = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 };
            //target = 200;

            //result = FourSum(input6, target);
            //foreach (var item in result)
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.Write(item2.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            int[] input7 = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            target = 8;

            result = FourSum(input7, target);
            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2.ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            
            IList<IList<int>> finalResult = new List<IList<int>>();
            List<string> quadrupletsAsStrings = new List<string>();

            // get all quadruplet sets
            for (int i = 0; nums.Length - i >= 4; i++)
            {
                for (int j = i + 1; nums.Length - j >= 3; j++)
                {
                    for (int k = j + 1; nums.Length - k >= 2; k++)
                    {
                        for (int l = k + 1; nums.Length - l >= 1; l++)
                        {
                            if (nums[i] + nums[j] + nums[k] + nums[l] == target)
                            {
                                List<int> quadruplet = new List<int>
                                {
                                    nums[i],
                                    nums[j],
                                    nums[k],
                                    nums[l]
                                };
                                var orderedQuad = quadruplet.OrderBy(x => x);
                                string tempQuad = "";
                                foreach(var number in orderedQuad)
                                {
                                    tempQuad += number;
                                }
                                if (!quadrupletsAsStrings.Contains(tempQuad))
                                {
                                    quadrupletsAsStrings.Add(tempQuad);
                                    finalResult.Add(quadruplet);
                                }
                            }
                        }
                    }
                }
            }

            return finalResult;
        }

        private void AddIfNotInList(IList<IList<int>> allQuadruplets, List<int> quadruplet)
        {
            bool isMatch = false;
            foreach(var quad in allQuadruplets)
            {
                // if the quad finds a match remove it from both lists and go to the next element
                //var stringOfQuad = "";
                //foreach(var character in quad)
                //    { stringOfQuad += character.ToString(); }
                //var stringOfQuadruplet = "";
                //var potentialQuadruplet = quadruplet.OrderBy(number => number);
                //foreach (var character in potentialQuadruplet) { stringOfQuadruplet += character.ToString(); }
                //if (stringOfQuadruplet == stringOfQuad)
                //{
                //    isMatch = true;
                //}
                List<int> indexesUsed = new List<int>();
                for (int i = 0; i < quad.Count; i++)
                {
                    for (int j = 0; j < quadruplet.Count; j++)
                    {
                        if (quad[i] == quadruplet[j] && !indexesUsed.Contains(j))
                        {
                            indexesUsed.Add(j);
                            break;
                        }
                    }
                    if (indexesUsed.Count == 4) { return; }
                }
            }
            if(!isMatch)
            {
                allQuadruplets.Add(quadruplet.OrderBy(number => number).ToList());
            }
        }

        public string IdentifyExperiment()
        {
            return "FourSum";
        }
    }
}