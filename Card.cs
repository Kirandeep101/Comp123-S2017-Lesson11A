using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp123_S2017_Lesson11A
{
    public class Card
    {
        //private instance variables
        private Face _face;
        private Suits _suit;

        public Card()
        {
            throw new System.NotImplementedException();
        }

        //public properties
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }
            public Suits Suits
        {
            get
            {
                return this._suit;

            }
            set
            {
                this._suit = value;
            }
        }

        }
    }