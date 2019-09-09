namespace CharacterLibrary
{
    public class CharacterInstance
    {
        #region Fields
        private string name;
        private string description;
        private string imagePath;
        private int level;
        private int exp;
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
        #endregion

        public CharacterInstance()
        {
            ImagePath = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
            Level = 1;
            Exp = 0;
        }
    }
}
