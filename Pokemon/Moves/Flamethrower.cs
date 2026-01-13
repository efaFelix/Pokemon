using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon.Moves
{
    public class Flamethrower : Moves
    {
        public override void execute(Pokemon user, Pokemon target)
        {
            Console.WriteLine(user.Name + "uses " + name + "!");
            target.hp - user.atk;
        }
    }
}
