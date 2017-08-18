using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class WinState : GameObjectList
    {
        public WinState()
        {
            TextGameObject txt = new TextGameObject("GameFont");
            txt.Text = "Game Over!";
            Add(txt);
        }

    }
}
