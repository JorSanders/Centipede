using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Mushroom: SpriteGameObject
    {
        public Mushroom(Vector2 position):base ("spr_mushroom")
        {
            this.position = position;
        }
    }
}
