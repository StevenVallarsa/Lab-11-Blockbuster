using System;
using System.Collections.Generic;

namespace Lab_11_Blockbuster
{
    public class DVD : Movie
    {
        public DVD(string Title, string Category, int RunTime, List<string> Scenes) 
            : base(Title, Category, RunTime, Scenes) 
        {

        }

        public override void Play()
        {
            Console.Write("What scene would you like to view? ");

            int index = 0;
            bool run = true;
            while (run)
            {
                string input = Console.ReadLine();

                try
                {
                    index = int.Parse(input);
                    if (index < 1 || index > Scenes.Count)
                    {
                        throw new Exception("Sorry, that's out of range. Try again: ");
                    }
                    run = false;
                }
                catch (FormatException)
                {
                    Console.Write("I don't know what you mean? Try again: ");
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }



            Console.WriteLine(Scenes[index - 1]);
        }
    }
}
