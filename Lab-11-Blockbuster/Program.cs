using System;
using System.Collections.Generic;

namespace Lab_11_Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scenes = new List<string>();
            scenes.Add("Early man");
            scenes.Add("To the moon");
            scenes.Add("Monolith");
            scenes.Add("Trip to Jupiter");
            scenes.Add("HAL freaks out");
            scenes.Add("The Star Child");
 
            Movie Blockbusters = new DVD("2001", "Sci-Fi", 160, scenes);

            Blockbusters.PrintInfo();
            Blockbusters.Play();

            /* Movie()
             * - all the props
             * - virtual 
             * - virtual void Play()           
             * 
             * VHS()
             * - int CurrentTime
             * - override void Play()
             * 
             * DVD()
             * - override void Play()           
             * 
             * Blockbuster
             * - List<Movie> Movies
             * - void PrintMovies()
             * - void CheckOut()
             * - - PrintMovies()
             * - - Prompt user to select a movie
             * - - Get user input
             * - - Use inputted index to grab a movie from the list
             * - - Play movie
             */           
        }
    }
}
