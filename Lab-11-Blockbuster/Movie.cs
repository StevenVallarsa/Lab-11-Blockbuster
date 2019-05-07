using System;
using System.Collections.Generic;

namespace Lab_11_Blockbuster
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Movie:    {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime:  {RunTime}");
            Console.WriteLine();
            PrintScenes();
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i + 1} - {Scenes[i]}");
            }

        }

        public virtual void Play()
        {
            // Here only to be overwritten in the VHS and DVD classes.
            // This will print if Play() is accessed from some other way.

            Console.WriteLine("The play method only works on physical media.");
        }



    }
}
