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

            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(Scenes[index - 1]);
        }
    }
}
