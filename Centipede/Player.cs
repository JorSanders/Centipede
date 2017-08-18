using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Player : SpriteGameObject
    {

        public Player()
            : base("spr_player")
        {
            this.Origin = this.Center;
            position.X = 235;
            position.Y = 500;
         
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            velocity.X = 0;
            velocity.Y = 0;
            if (inputHelper.IsKeyDown(Keys.Left))
                velocity.X = -200;
            else if (inputHelper.IsKeyDown(Keys.Right))
                velocity.X = 200;
            else if (inputHelper.IsKeyDown(Keys.Up))
                velocity.Y = -200;
            else if (inputHelper.IsKeyDown(Keys.Down))
                velocity.Y = 200;

            position.X = MathHelper.Clamp(position.X, this.Width / 2, Centipede.Screen.X - this.Width / 2);
            position.Y = MathHelper.Clamp(position.Y, this.Height / 2, Centipede.Screen.Y - this.Height / 2);


            base.HandleInput(inputHelper);               
        }

    }
}
