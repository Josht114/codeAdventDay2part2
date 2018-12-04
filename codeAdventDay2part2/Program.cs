
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeAdventDay2part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> listOfBoxIds = new List<String>();
            int count = 0;
            int twoMatchCount = 0;
            int threeMatchCount = 0;
            int checksum = 0;

            while (true) // Loop indefinitely
            {

                Console.WriteLine("Enter input:"); // Prompt
                string input = Console.ReadLine(); // Get string from user

                listOfBoxIds.Add(input);

                Console.Write("box " + count + Environment.NewLine);
                Console.Write("ID " + listOfBoxIds[count].ToString() + Environment.NewLine);
                count++;


                if (input == "lobs")
                {

                    foreach (string box in listOfBoxIds)
                    {

                        char[] letters = box.ToCharArray();


                        if (getMatchCount(letters, 2))
                        {
                            twoMatchCount++;
                            string boxString = new string(letters);
                            Console.Write("2 match- " + boxString + Environment.NewLine);
                        }
                        else
                        {
                            string boxString = new string(letters);
                            Console.Write(" 2 FAILED - " + boxString + Environment.NewLine);
                        }

                        if (getMatchCount(letters, 3))
                        {
                            threeMatchCount++;
                            string boxString = new string(letters);
                            Console.Write("3 match- " + boxString + Environment.NewLine);
                        }
                        else
                        {
                            string boxString = new string(letters);
                            Console.Write("3 FAILED - " + boxString + Environment.NewLine);
                        }
                        Console.Write(Environment.NewLine);
                    }

                    checksum = threeMatchCount * twoMatchCount;

                    Console.Write("box count " + listOfBoxIds.Count + Environment.NewLine);
                    Console.Write("2 count " + twoMatchCount + Environment.NewLine);
                    Console.Write("3 count " + threeMatchCount + Environment.NewLine);
                    Console.Write("checksum " + checksum + Environment.NewLine);

                }


            }





        }


        public static bool getMatchCount(Array chars, int matchNumber)
        {


            bool finalOnlyTwo = false;
            bool finalOnlyThree = false;



            foreach (char c in chars)
            {
                int i = 0;

                bool onlyTwo = false;
                bool onlyThree = false;

                int matchCount = 0;

                while (i < chars.Length)
                {


                    if (c.Equals(chars.GetValue(i)))
                    {
                        matchCount++;

                        // THE PROBLEM, IGNORES A 2 IF IT FINDS A THREE

                        if (matchCount == 2)
                        {
                            onlyTwo = true;
                        }

                        if (matchCount == 3)
                        {
                            onlyTwo = false;
                            onlyThree = true;
                        }

                        if (matchCount > 3)
                        {
                            onlyTwo = false;
                            onlyThree = false;
                        }

                    }
                    i++;

                }

                if (onlyTwo)
                {
                    finalOnlyTwo = onlyTwo;
                }

                if (onlyThree)
                {
                    finalOnlyThree = onlyThree;
                }

            }

            if (matchNumber == 2)
            {
                return finalOnlyTwo;
            }

            if (matchNumber == 3)
            {
                return finalOnlyThree;
            }

            return false;

        }



        public static bool getMatchCountforThree(Array chars, int count)
        {
            int matchCount = 0;

            int i = 0;

            foreach (char c in chars)
            {


                if (c.Equals(chars.GetValue(i)))
                {
                    matchCount++;

                    if (matchCount == 3 && count == 3)
                    {
                        return true;
                    }


                }
                i++;
            }
            i = 0;
            return false;
        }


    }



}

