using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PokemonGame;

namespace Pokemon.Moves
{
    class Flamethrower : Moves
    {

        public Flamethrower() : base(90, "Flamethrower", "Fire", "Special")
        {
        }
        public override void execute(Creature user, Creature target)
        {

            Console.WriteLine(user.getName() + " uses " + "Flamethrower" + "!");
            // Additional logic for Flamethrower can be added here
        }
    }
}
