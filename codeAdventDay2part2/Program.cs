
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeAdventDay2part2
{
    class Program
    {
       static string diffLetter = "";
        static int diffPosition = 0;

        static void Main(string[] args)
        {


            List<String> listOfBoxIds = new List<String>();
            int count = 0;

            string finalBoxOne = "not found";
            string finalBoxTwo = "not found";




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
                    listOfBoxIds.Remove("lobs");

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

                    Console.Write("box first " + finalBoxOne + Environment.NewLine);
                    Console.Write("box second " + finalBoxTwo + Environment.NewLine);
                    Console.Write("same letters " + same + Environment.NewLine);
                    Console.Write("letter " + diffLetter + Environment.NewLine);

                }

            }

        }
        public static bool getCloseMatch(Array boxOneChars, Array boxTwoChars)
        {
            int length = boxOneChars.Length;
            int i = 0;
            bool singleDiffAlreadyFound = false;

            while (i < length)
            {
                bool isMatch = boxOneChars.GetValue(i).Equals(boxTwoChars.GetValue(i));

                if (!isMatch)
                {
                    if (singleDiffAlreadyFound)
                    {
                        return false;
                    }
                    else
                    {
                        singleDiffAlreadyFound = true;
                    }
                }
                i++;
            }

            return singleDiffAlreadyFound;
        }



        public static string findSame(string one, string two)
        {
            List<char> charListOne = new List<char>();
            charListOne.AddRange(one);
            List<char> charListTwo = new List<char>();
            charListTwo.AddRange(two);


            int i = 0;


            while (i < charListOne.Count)
            {
                if (!charListOne.ElementAt(i).Equals(charListTwo.ElementAt(i)))
                {
                     charListOne.RemoveAt(i);

                    string same = "";


                    foreach (char c in charListOne)
                    {
                        same = same + c;
                    }


                    return same;
                }
                i++;
            }
            return "";
        }


    }



}

