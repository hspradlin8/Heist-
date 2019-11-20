using System;

namespace HeistExercise
{
    public class Heister
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        // Collect several team members' information.
        public Heister(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }

        public Heister()
        {

        }
    }


}