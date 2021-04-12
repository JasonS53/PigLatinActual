using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a word to be translated");
            string input = Console.ReadLine();


            testIndexOf(input);

        }

        static string testIndexOf(string input)
        {
            bool loopProgram = true;
            while (loopProgram)
            {
                int a = input.IndexOf("a");
                int e = input.IndexOf("e");
                int i = input.IndexOf("i");
                int o = input.IndexOf("o");
                int u = input.IndexOf("u");


                if (a == 0 || e == 0 || i == 0 || o == 0 || u == 0)//first letter vowel
                {
                    Console.WriteLine($"{input}way");
                }
                else //first letter consonant
                {
                    //Math.Min(Math.Min(a, e), i;
                    for (i = 0; i < input.Length; i++)
                    {

                        Console.WriteLine(input.Substring(i, 1));


                        string l = input.Substring(i, 1);
                        if ("a" == l || "e" == l || "i" == l || "o" == l || "u" == l)
                        {
                            string[] m = input.Split(l, 0);
                            Console.WriteLine(input.Substring(i, 0));
                        }
                    }
                }

                {
                    Console.WriteLine("Do you want to continue? y/n");
                    while (true)
                    {
                        string continueResult = Console.ReadLine();
                        if (continueResult == "y")
                        {
                            break;
                        }
                        else if (continueResult == "n")
                        {
                            loopProgram = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid input");
                        }

                    }
                }

            }
            return " ";
        }
    }
}
