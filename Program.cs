using System;

namespace Constructors_Pelky_Annalesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "FPS");

            Console.WriteLine($"My faveorite game is {myGame.title} and it is rated {myGame.genre}!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My faveorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
