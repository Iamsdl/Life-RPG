using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    class Task
    {
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endtDate;
        private int difficulty;
        private int urgency;
        private int fear;
        private List<Reward> rewards;
        private List<Reward> penalties;
        private List<Skill> skillRewards;
        private List<Skill> skillPenalties;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndtDate { get => endtDate; set => endtDate = value; }
        public List<Reward> Rewards { get => rewards; set => rewards = value; }
        public List<Reward> Penalties { get => penalties; set => penalties = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }
        public int Urgency { get => urgency; set => urgency = value; }
        public int Fear { get => fear; set => fear = value; }
        internal List<Skill> SkillRewards { get => skillRewards; set => skillRewards = value; }
        internal List<Skill> SkillPenalties { get => skillPenalties; set => skillPenalties = value; }
    }
}
