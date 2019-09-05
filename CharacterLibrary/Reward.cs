using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    public class Reward
    {
        private string name;
        private string description;
        private decimal quantity;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Quantity { get => quantity; set => quantity = value; }
    }
}
