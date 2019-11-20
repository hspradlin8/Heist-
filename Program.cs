using System;
using System.Collections.Generic;

namespace HeistExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 1
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine();
            // Heister teamMember;

            // Create a way to store several team members.
            List<Heister> NewHeister = new List<Heister>();

            Console.WriteLine("What is the team member's name?");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Enter a name");
            }

            Console.WriteLine("What's your tema member's skill level?");
            string skillLevelString = Console.ReadLine();
            int skillLevel;

            try
            {
                skillLevel = int.Parse(skillLevelString);
            }
            catch (Exception)
            // ex prints message to the console when called. 
            {
                Console.WriteLine($"{skillLevelString} is not a valid skill level. Using a default value of 10");
                skillLevel = 10;
            }
            Console.WriteLine("What's your team member's courage factor?");
            string courageFactorString = Console.ReadLine();
            decimal courageFactor;

            try
            {
                courageFactor = decimal.Parse(courageFactorString);
            }
            catch (Exception)
            {
                // M means money symbol so the compiler is ok with it. 
                Console.WriteLine($"{courageFactorString} is not a valid courage factor. Using a default value of 1");
                courageFactor = 1.0M;
            }

            // Collect several team members' information.

            Heister TeamMemberOne = new Heister("Seth", 10, 8);
            Heister TeamMemberTwo = new Heister("David", 10, 10);
            Heister TeamMemberThree = new Heister("Nick", 10, 8);
            Heister TeamMemberFour = new Heister("Fortunato", 10, 7);



            foreach (Heister TeamMember in NewHeister)
            {
                Console.WriteLine($"Name: {TeamMember.Name} Skill Level: {TeamMember.SkillLevel} Courage Factor: {TeamMember.CourageFactor}");
            }
            //             Console.WriteLine($"Name: {TeamMember.Name}");
            //             Console.WriteLine($"Skill Level: {TeamMember.SkillLevel}");
            //             Console.WriteLine($"Courage Factor: {TeamMember.CourageFactor}");

        }
    }
}