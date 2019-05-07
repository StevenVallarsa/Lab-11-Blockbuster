using System;
using System.Collections.Generic;

namespace Lab_11_Blockbuster
{
    public class VHS : Movie
    {

        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {

        }


        public override void Play()
        {
            if (CurrentTime == Scenes.Count)
            {
                Rewind();
            }

            Console.WriteLine(Scenes[CurrentTime]);
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    
    }

}
