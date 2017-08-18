using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class SnakeSegment: SpriteGameObject
    {
        public SnakeSegment(Vector2 position):base ("spr_snakebody")
        {
            this.position = position;
            velocity = new Vector2(200, 0);
        }

        public void Bounce()
        {
            velocity = -velocity;
            position.Y += 32;
        }

        public override void Update(GameTime gameTime)
        {
            if(
                position.X < 0 ||
                position.Y < 0 ||
                position.X > Centipede.Screen.X - this.Width ||
                position.Y > Centipede.Screen.Y - this.Height              
                )               
            {
                Bounce();
            }

            base.Update(gameTime);
        }
    }
}
