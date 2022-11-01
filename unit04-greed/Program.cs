using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04_greed.Game.Directing;
using Unit04_greed.Game.Services;
using Unit04_greed.Game.Casting;

namespace Unit04_greed
{
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 20;

        private static string CAPTION = "Greed";
        private static Color WHITE = new Color(255, 255, 255);
        Cast cast = new Cast();

        static void Main(string[] args)
        {
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            
            // Creates the cast
            Cast cast = new Cast();

            // Player
            Actor player = new Actor();
            player.SetText("#");
            player.SetFontSize(FONT_SIZE);
            player.SetColor(WHITE);
            player.SetPosition(new Point(MAX_X / 2, 580));
            cast.AddActor("player", player);

            // Starts the game
            director.StartGame(cast);
        }
        
    }
}
