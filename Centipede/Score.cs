using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Score : TextGameObject
    {
        public Score() :
            base("GameFont")
        {
            scoreAmount = 0;
            this.Text = ("");
        }

        private int scoreAmount;

        public int ScoreAmount
        {
            get { return scoreAmount; }
            set { scoreAmount = value; this.Text = "Score:" + scoreAmount; }
        }
    }

}
