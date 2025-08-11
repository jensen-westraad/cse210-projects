using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private void CreateGoal()
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string type = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
            {
                _goals.Add(new SimpleGoal(name, desc, points));
            }
            else if (type == "2")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
            }
        }

        private void ListGoalDetails()
        {
            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        private void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    sw.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals have been saved.");
        }

        private void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                _goals.Clear();
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string type = parts[0];

                    if (type == "SimpleGoal")
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    else if (type == "EternalGoal")
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    else if (type == "ChecklistGoal")
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                    int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                }
                Console.WriteLine("Goals have been loaded.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        private void RecordEvent()
        {
            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
            }

            Console.Write("Which goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                int earned = _goals[index].RecordEvent();
                _score += earned;
                Console.WriteLine($"Congratulations! You have earned {earned} points!");
                Console.WriteLine($"You now have {_score} points.");
            }
        }
    }
}
