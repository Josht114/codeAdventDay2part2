
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

            string finalBoxOne = "";
            string finalBoxTwo = "";

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
                        foreach (string boxTwo in listOfBoxIds)
                        {
                            char[] lettersBoxOne = box.ToCharArray();
                            char[] lettersBoxTwo = boxTwo.ToCharArray();

                            if (getCloseMatch(lettersBoxOne, lettersBoxTwo))
                            {
                                finalBoxOne = box;
                                finalBoxTwo = boxTwo;
                            }

                        }



                    }
                    string same = findSame(finalBoxOne, finalBoxTwo);

                    Console.Write("box 1 " + finalBoxOne + Environment.NewLine);
                    Console.Write("box 2 " + finalBoxTwo + Environment.NewLine);
                    Console.Write("same letters " + same + Environment.NewLine);

                }

            }

        }
        public static bool getCloseMatch(Array boxOneChars, Array boxTwoChars)
        {



            return false;
        }



        public static string findSame(string one, string two)
        {

            return "";
        }


    }



}

