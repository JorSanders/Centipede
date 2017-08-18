using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Bullet: SpriteGameObject
    {
        public Bullet()
            :base ("spr_bullet")
        {
            this.Origin = this.Center;
            Reset();
        }



        public override void Reset()
        {
            velocity = new Vector2(0,0);
            position = new Vector2(3000, 3000);
            
            base.Reset();
        }

        public void Fire (Vector2 position)
        {
            this.position = position;
            velocity = new Vector2(0, -200);
        }

    }
}
