using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    public static class Character
    {
        private static CharacterInstance instance;

        public static CharacterInstance Instance
        {
            get => instance ?? (instance = new CharacterInstance());
            set => instance = value;
        }
    }
}
