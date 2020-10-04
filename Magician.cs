using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicalShow
{
    public class Magician : Person
    {
        protected ArrayList favorite_tricks;

        // Constructor
        public Magician(int id, string name, string password, int level) : base(id, name, password, level)
        {
            favorite_tricks = new ArrayList();
        }

        // Add favorite trick(s)
        public void AddFavoriteTrick(string trick)
        {
            favorite_tricks.Add(trick);
        }
    }
}