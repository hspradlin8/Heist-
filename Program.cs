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
            List<Heister> NewHeisters = new List<Heister>();

            bool wantsToAddName = true;
            while (wantsToAddName)
            {
                Heister NewHeister = new Heister();

                Console.WriteLine("What is the team member's name?");
                string name = Console.ReadLine();
                // Stop collecting team members when a blank name is entered.
                if (name == "")
                {
                    NewHeister = null;
                    break;
                }
                else
                {
                    NewHeister.Name = name;
                }
                bool hasValidSkillLevel = false;
                while (!hasValidSkillLevel)
                {

                    Console.WriteLine("What's your tema member's skill level?");
                    string skillLevelString = Console.ReadLine();
                    // int skillLevel;
                    try
                    {
                        NewHeister.SkillLevel = int.Parse(skillLevelString);
                        hasValidSkillLevel = true;
                    }
                    catch (Exception)
                    // ex prints message to the console when called. 
                    {
                        Console.WriteLine($"{skillLevelString} is not a valid skill level.");

                    }
                }
                bool hasValidCourageFactor = false;
                while (!hasValidCourageFactor)
                {

                    Console.WriteLine("What's your team member's courage factor?");
                    string courageFactorString = Console.ReadLine();
                    // decimal courageFactor;

                    try
                    {
                        NewHeister.CourageFactor = decimal.Parse(courageFactorString);
                        hasValidCourageFactor = true;
                    }
                    catch (Exception)
                    {
                        // M means money symbol so the compiler is ok with it. 
                        Console.WriteLine($"{courageFactorString} is not a valid courage factor.");

                    }

                    NewHeisters.Add(NewHeister);
                }

            }
            // Display a message containing the number of members of the team.
            Console.WriteLine(NewHeisters.Count);

            // Display each team member's information.

            Console.Clear();

            foreach (Heister TeamMember in NewHeisters)
            {
                Console.WriteLine($"Name: {TeamMember.Name} Skill Level: {TeamMember.SkillLevel} Courage Factor: {TeamMember.CourageFactor}");
            }

            // Stop displaying each team member's information.

            Console.ReadLine();
            Console.Clear();
            // Store a value for the bank's difficulty level. Set this value to 100.
            int bankDifficulty = 100;


            // Sum the skill levels of the team.Save that number.
            int combineSkillLevel = 0;
            foreach (Heister item in NewHeisters)
            {
                combineSkillLevel += item.SkillLevel;
            }

            // Compare the number with the bank's difficulty level. 
            // If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message
            if (combineSkillLevel >= bankDifficulty)
            {
                Console.WriteLine("Great Success!");
            }
            else
            {
                Console.WriteLine("Think of a career change!");
            }
        }
    }
}