using System;
using System.Collections.Generic;

namespace HeistExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plan Your Heist");
            Console.WriteLine();
            Console.WriteLine("Enter bank difficulty.");
            int bankDifficulty = int.Parse(Console.ReadLine());

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
                    try
                    {
                        NewHeister.SkillLevel = int.Parse(skillLevelString);
                        hasValidSkillLevel = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"{skillLevelString} is not a valid skill level.");

                    }
                }
                bool hasValidCourageFactor = false;
                while (!hasValidCourageFactor)
                {

                    Console.WriteLine("What's your team member's courage factor?");
                    string courageFactorString = Console.ReadLine();


                    try
                    {
                        NewHeister.CourageFactor = decimal.Parse(courageFactorString);
                        hasValidCourageFactor = true;
                    }
                    catch (Exception)
                    {
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


            // After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
            Console.WriteLine("Enter in trial runs");
            int trialRun = int.Parse(Console.ReadLine());
            int Successes = 0;
            int Failures = 0;


            int combineSkillLevel = 0;
            foreach (Heister item in NewHeisters)
            {
                combineSkillLevel += item.SkillLevel;
            }



            for (int i = 0; i < trialRun; i++)
            {

                Random rand = new Random();
                int randomNumber = rand.Next(-10, 10);
                bankDifficulty += randomNumber;
                int bankTotal = bankDifficulty + randomNumber;
                if (combineSkillLevel >= bankDifficulty)
                {
                    Successes += 1;
                }
                else
                {
                    Failures += 1;
                }
            }
            Console.Clear();
            Console.WriteLine($"Successes: {Successes}");
            Console.WriteLine($"Failures: {Failures}");
        }



    }
}