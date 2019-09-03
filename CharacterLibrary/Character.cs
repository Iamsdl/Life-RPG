using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    public class Character
    {
        #region Fields
        private string imagePath;
        private string name;
        private string description;
        private int level;
        private int exp;
        #endregion

        #region Properties
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
        #endregion

        public Character()
        {
            ImagePath = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
            Level = 1;
            Exp = 0;
        }
    }
}
