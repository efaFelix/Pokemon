using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Creature
    {
        private string Name { get; set; }

        public string getName()
        {
            return this.Name;
        }
        private string Type { get; set; }
        private int Hp { get; set; }
        private int Atk { get; set; }

        private List<Pokemon.Moves.Moves> moves = new List<Pokemon.Moves.Moves>();

        public Creature(string name, string type, int hp, int atk, List<Pokemon.Moves.Moves> moves )
        {
            this.Name = name;
            this.Type = type;
            this.Hp = hp;
            this.Atk = atk;
            this.moves = moves;
        }

        public override string ToString() {
            return $"| Name: {Name} | Type: {Type} | HP: {Hp} | ATK: {Atk}";
        }


            
    }

}
