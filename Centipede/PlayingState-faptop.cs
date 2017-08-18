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
    class PlayingState: GameObjectList
    {

        SpriteGameObject background = new SpriteGameObject("spr_background", 0, "background");
        Player player = new Player();

        public PlayingState()
        {


            this.Add(background);
            this.Add(player);
        }
    }
}
