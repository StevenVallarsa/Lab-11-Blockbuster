using System;
using System.Collections.Generic;

namespace Lab_11_Blockbuster
{
    public class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();

        List<string> moviesList = new List<string>() {
        "2001,Sci-Fi,150,Early man,To the moon,Monolith,To Jupiter,HAL freaks out,The Star Child",
        "Star Wars,Sci-Fi,100,Princess capture,Droids,Ben,Han,Death Star,BOOM!",
        "Airplane!,Comedy,90,At the airport,On the plane,No pilots,Don't call me Shirley,Bad memories,Saves the day",
        "When Harry Met Sally,Romance-Comedy,91,Harry meets Sally,I'll have what she's having,Meeting again,And again,Older and wiser,Married",
        "Frozen,Family,70,Do you want to build a snowman,Queen Elsa,Frozen castle,Anna meets Christof,All is lost,Saves the day",
        "1984,Drama,98,Winston,Big Brother,Julia,Capture,Torture,He loves Big Brother"
      };

        public Blockbuster()
        {
            for (int i = 0; i < 6; i++)
            {
                string[] movieInfo = moviesList[i].Split(',');
                List<string> movieScenes = new List<string>();
                for (int j = 3; j < 9; j++)
                {
                    movieScenes.Add(movieInfo[j]);
                }

                if (i % 2 == 0)
                {
                    Movies.Add(new DVD(movieInfo[0], movieInfo[1], int.Parse(movieInfo[2]), movieScenes));
                }
                else
                {
                    Movies.Add(new VHS(movieInfo[0], movieInfo[1], int.Parse(movieInfo[2]), movieScenes));

                }
            }

        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Movies[i].Title}");
            }
        }

        public void CheckOut()
        {
            PrintMovies();
            Console.WriteLine();
            Console.Write("Which movie would you like to check out? ");

            int index = 0;
            bool run = true;
            while (run)
            {
                string input = Console.ReadLine();

                try
                {
                    index = int.Parse(input);
                    if (index < 1 || index > Movies.Count)
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

            Console.WriteLine();
            Movies[index - 1].PrintInfo();

        }
    }
}
