using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Creature
    {
        private string Name { get; set; }
        private string Type { get; set; }
        private int Hp { get; set; }
        private int Atk { get; set; }

        private List<Moves> moves = new List<Moves>();

        public Creature(string name, string type, int hp, int atk, List<Moves> moves )
        {
            this.Name = name;
            this.Type = type;
            this.Hp = hp;
            this.Atk = atk;
            this.moves = moves;
        }

        public string ToString() {
            return "| Name: {Name} | Type: {Type} | HP: {Hp} | ATK: {Atk}";
        }
            
    }

}
