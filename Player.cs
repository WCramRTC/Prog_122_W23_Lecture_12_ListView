using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_12_ListView
{
    internal class Player
    {
        string _name;
        int _hp;

        public Player(string name, int hp)
        {
            _name = name;
            _hp = hp;
        }

        public string Name { get => _name; set => _name = value; }
        public int Hp { get => _hp; set => _hp = value; }
    }
}
