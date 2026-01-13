using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Moves
{
    internal class Moves
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

        public virtual void execute(Pokemon user, Pokemon target)
        {
            Console.WriteLine(user.Name + "uses " + name + "!");
        }
    }
}
