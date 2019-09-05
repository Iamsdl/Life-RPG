using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    class Skill
    {
        private string name;
        private string description;
        private int level;
        private int exp;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
    }
}
