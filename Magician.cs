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
        public Magician(int id, string name, string password) : base(id, name, password)
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