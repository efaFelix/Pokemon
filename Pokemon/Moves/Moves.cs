using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonGame;

namespace Pokemon.Moves
{
    public class Moves
    {
        int effecincy;
        string name;
        string type;
        string moveKind;

        public Moves(int effecincy,string name, string type, string moveKind)
        {
            this.effecincy = effecincy;
            this.name = name;
            this.type = type;
            this.moveKind = moveKind;
        }

        public virtual void execute(Creature user, Creature target)
        {
            Console.WriteLine(user.getName() + " uses " + name + "!");
        }
    }
}
