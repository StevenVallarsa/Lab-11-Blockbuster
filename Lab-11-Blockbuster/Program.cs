using System;
using System.Collections.Generic;

namespace Lab_11_Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {

            Blockbuster bb = new Blockbuster();

            bb.CheckOut();

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
