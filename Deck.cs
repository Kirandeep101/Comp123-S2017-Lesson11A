using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp123_S2017_Lesson11A
{
    public class Deck:List<Card>
    {

        //private instance variable

        //public prop

        //constructors
        public Deck()
        {
            this._initialize();
        }
        //private methods
        private void _initialize()
        {
            for(int suit=0;suit <(int)Suits.Spades; suit++)
            {
                for (int face = 1; face < (int)Face.King; face++) ;
                {
                    this.Add(new Card((Face)face, (Suits)suit));
                }
            }
            this.Add(new Card(face, suit));
        }
        public override string ToString()
        {
            string outputString = "";
            foreach (Card card in this)
            {
                outputString += "The" + card.Face + "of" + card.Suits + "\n";
            }
        }
    }
}