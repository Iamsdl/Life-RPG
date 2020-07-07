using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CharacterLibrary
{
    public class CharacterInstance : INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private string description;
        private string imagePath;
        private int level;
        private int exp;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged(); }
        }
        public string Description
        {
            get { return description; }
            set { description = value; NotifyPropertyChanged(); }
        }
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; NotifyPropertyChanged(); }
        }
        public int Level
        {
            get { return level; }
            set { level = value; NotifyPropertyChanged(); }
        }
        public int Exp
        {
            get { return exp; }
            set { exp = value; NotifyPropertyChanged(); }
        }
        #endregion

        public CharacterInstance()
        {
            ImagePath = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
            Level = 1;
            Exp = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
