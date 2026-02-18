using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // Achievement tracking
    private HashSet<string> _achievements = new HashSet<string>();

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\n==== Eternal Quest ====");
            DisplayScore();

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordGoal(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Level: {GetLevel()}");
        DisplayAchievements();
    }

    private string GetLevel()
    {
        if (_score >= 1000) return "Eternal Warrior";
        if (_score >= 500) return "Disciple";
        if (_score >= 200) return "Apprentice";
        if (_score >= 100) return "Beginner";
        return "Seeker";
    }

    private void CheckAchievements()
    {
        if (_goals.Count > 0 && !_achievements.Contains("Getting Started"))
        {
            UnlockAchievement("🥉 Getting Started - Created your first goal!");
        }

        if (_score >= 100 && !_achievements.Contains("Rising Star"))
        {
            UnlockAchievement("🥈 Rising Star - Reached 100 points!");
        }

        if (_score >= 500 && !_achievements.Contains("Goal Crusher"))
        {
            UnlockAchievement("🥇 Goal Crusher - Reached 500 points!");
        }

        if (_score >= 1000 && !_achievements.Contains("Eternal Champion"))
        {
            UnlockAchievement("👑 Eternal Champion - Reached 1000 points!");
        }

        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete() && !_achievements.Contains("Finisher"))
            {
                UnlockAchievement("🎯 Finisher - Completed your first goal!");
                break;
            }
        }
    }

    private void UnlockAchievement(string message)
    {
        Console.WriteLine("\n🎉 ACHIEVEMENT UNLOCKED!");
        Console.WriteLine(message);
        _achievements.Add(message.Split('-')[0].Trim());
    }

    private void DisplayAchievements()
    {
        if (_achievements.Count > 0)
        {
            Console.WriteLine("Achievements:");
            foreach (string a in _achievements)
            {
                Console.WriteLine($" - {a}");
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");

        Console.Write("Select type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (type == 2)
            _goals.Add(new EternalGoal(name, desc, points));

        else if (type == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        else if (type == 4)
            _goals.Add(new NegativeGoal(name, desc, points));

        CheckAchievements();
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordGoal()
    {
        ListGoals();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");

        CheckAchievements();
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2],
                    int.Parse(parts[3]), bool.Parse(parts[4])));

            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2],
                    int.Parse(parts[3])));

            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])));

            else if (parts[0] == "NegativeGoal")
                _goals.Add(new NegativeGoal(parts[1], parts[2],
                    int.Parse(parts[3])));
        }

        CheckAchievements();
    }
}
