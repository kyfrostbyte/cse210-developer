using System.Collections.Generic;
using Unit04_greed.Game.Services;
using Unit04_greed.Game.Casting;
using System;

namespace Unit04_greed.Game.Directing
{
    public class Director
    {
        private KeyboardService _keyboardService = null;
        private VideoService _videoService = null;
        private int gameloop = 0;
        public int score = 0;
        private static Color WHITE = new Color(255, 255, 255);
        Random random = new Random();
        Actor banner = new Actor();

        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this._keyboardService = keyboardService;
            this._videoService = videoService;
        }

        // Calls functions to run the game
        public void StartGame(Cast cast)
        {
            _videoService.OpenWindow();
            while (_videoService.IsWindowOpen())
            {
                Scoreboard(cast);
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
                MoveObjects(cast);
                gameloop += 1;
                if (gameloop % 10 == 0)
                {
                    SpawnGems(cast);
                    SpawnRocks(cast);
                }
            }
            _videoService.CloseWindow();
        }

        // Gets keyboard inputs from user
        private void GetInputs(Cast cast)
        {
            Actor player = cast.GetFirstActor("player");
            Point velocity = _keyboardService.GetDirection();
            player.SetVelocity(velocity);     
        }

        // Causes the rocks and gems to "fall" from top of screen
        private void MoveObjects(Cast cast)
        {
            List<Actor> gems = cast.GetActors("gem");
            foreach (Actor actor in gems)
            {
                actor.MoveNext(900, 600);
            }

            List<Actor> rock = cast.GetActors("rock");
            foreach (Actor actor in rock)
            {
                actor.MoveNext(900, 600);
            }
        }

        // Allows user to move, computes score and removes objects post collision
        private void DoUpdates(Cast cast)
        {
            Actor player = cast.GetFirstActor("player");
            List<Actor> gems = cast.GetActors("gem");

            int maxX = _videoService.GetWidth();
            int maxY = _videoService.GetHeight();
            player.MoveNext(maxX, maxY);
            foreach (Actor gem in gems)
            {
                if (player.GetPosition().Equals(gem.GetPosition()))
                {
                    cast.RemoveActor("gem", gem);
                    score += 1;
                }
            } 
            List<Actor> rocks = cast.GetActors("rock");
            foreach (Actor rock in rocks)
            {
                if (player.GetPosition().Equals(rock.GetPosition()))
                {
                    cast.RemoveActor("rock", rock);
                    score += -1;
                }
            } 
            
        }

        // Displays the scoreboard in top left of screen
        private void Scoreboard(Cast cast)
        {
            banner.SetText($"Score: {score}");
            banner.SetFontSize(20);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(15, 0));
            cast.AddActor("banner", banner);
        }

  
        // Draws the actors on the screen.
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            _videoService.ClearBuffer();
            _videoService.DrawActors(actors);
            _videoService.FlushBuffer();
        }
        
        // Spawns gems randomly at the top of the screen
        public void SpawnGems(Cast cast)
        {
            string text = "*";
            int x = random.Next(1, 60);
            int y = 1;
            Point position = new Point(x, y);
            position = position.Scale(15);

            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color color = new Color(r, g, b);
            Artifact artifact = new Artifact();
            artifact.SetText(text);
            artifact.SetFontSize(20);
            artifact.SetColor(color);
            artifact.SetPosition(position);
            artifact.SetVelocityDown();
            cast.AddActor("gem", artifact);
        }

        // Spawns rocks randomly at the top of the screen
        public void SpawnRocks(Cast cast)
        {
            string text = "O";
            int x = random.Next(1, 60);
            int y = 1;
            Point position = new Point(x, y);
            position = position.Scale(15);
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color color = new Color(r, g, b);
            Artifact artifact = new Artifact();
            artifact.SetText(text);
            artifact.SetFontSize(20);
            artifact.SetColor(color);
            artifact.SetPosition(position);
            artifact.SetVelocityDown();
            cast.AddActor("rock", artifact);
        }
    }
}