using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Centipede
{
    class PlayingState : GameObjectList
    {

        SpriteGameObject background = new SpriteGameObject("spr_background", 0, "background");
        Player player = new Player();
        Bullet bullet = new Bullet();
        GameObjectList snake = new GameObjectList();
        GameObjectList mushrooms = new GameObjectList();
        Score score = new Score();

        Random random = new Random();

        public int ScoreNr { get; private set; }


        public PlayingState()
        {
            this.Add(background);
            this.Add(player);
            this.Add(bullet);

            ScoreNr = 0;

            for (int i = 0; i < 10; i++)
            {
                snake.Add(new SnakeSegment(new Vector2(i * 32, 0)));
            }
            this.Add(snake);

            for (int i = 0; i < 20; i++)
            {
                mushrooms.Add(new Mushroom(new Vector2(random.Next(0, 470), random.Next(25, 470))));
            }
            this.Add(mushrooms);

            this.Add(score);

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
                bullet.Fire(player.Position);

            base.HandleInput(inputHelper);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);


            foreach (SnakeSegment snakeSegment in snake.Objects)
            {
                foreach (Mushroom mushroom in mushrooms.Objects)
                {
                    if (snakeSegment.CollidesWith(mushroom))
                    {
                        snakeSegment.Bounce();

                    }
                }

                if (snakeSegment.CollidesWith(bullet))
                {
                    snakeSegment.Visible = false;
                    mushrooms.Add(new Mushroom(new Vector2(random.Next(0, 470), random.Next(25, 470))));
                    bullet.Reset();
                    ScoreNr += 10;
                }

                if (snakeSegment.CollidesWith(player))
                {
                    Centipede.GameStateManager.SwitchTo("WinState");
                }

            }

            foreach (Mushroom mushroom in mushrooms.Objects)
            {
                if (mushroom.CollidesWith(bullet))
                {
                    mushroom.Visible = false;
                    bullet.Reset();

                }
            }

        }
    }
}
