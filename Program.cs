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
            Heister teamMember;

            Console.WriteLine("What is the team member's name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your tema member's skill level?");
            string skillLevelString = Console.ReadLine();
            int skillLevel;

            try
            {
                skillLevel = int.Parse(skillLevelString);
            }
            catch (Exception ex)
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

            teamMember = new Heister()
            {
                Name = name,
                SkillLevel = skillLevel,
                CourageFactor = courageFactor

            };
            Console.WriteLine($"Name: {teamMember.Name}");
            Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
            Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");

        }
    }
}