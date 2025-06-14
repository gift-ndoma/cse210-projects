using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        string userChoice = "";

        while (userChoice != "6")
        {
            MenuOptions();
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CreateGoal();
            }
            else if (userChoice == "2")
            {
                ListGoalDetails();
            }
            else if (userChoice == "3")
            {
                SaveGoals();
            }
            else if (userChoice == "4")
            {
                LoadGoals();
            }
            else if (userChoice == "5")
            {
                RecordEvent();
            }
            else if (userChoice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid menu number.");
            }
            Console.WriteLine();
        }
    }
    public void MenuOptions()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("\n==== Player Info ====");
        Console.WriteLine($"Score: {_score} points\n");
    }
    public void ListGoalNames()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            string goalName = goal.GetName();
            Console.WriteLine($"{i}. {goalName}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\n=== Goal Details ===");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
        Console.WriteLine();
    }

    // Prompts the user to create a new goal and adds it to the goals list
    // Added a confirmation message after a goal is created to exceed requirements
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which goal would you like to create? ");
        string goal = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of point associated with this goal? ");
        string goalAmount = Console.ReadLine();
        int goalPoints = int.Parse(goalAmount);

        if (goal == "1")
        {
            Goal newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(newGoal);
            Console.WriteLine("Your Simple goal has been created successfully!");
        }
        else if (goal == "2")
        {
            Goal newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(newGoal);
            Console.WriteLine("Your Eternal goal has been created successfully!");
        }

        else if (goal == "3")
        {
            Console.Write("How many times does this goal need to be accomplish for a bonus? ");
            string goalNum = Console.ReadLine();
            int goalTarget = int.Parse(goalNum);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string goalBon = Console.ReadLine();
            int goalBonus = int.Parse(goalBon);

            Goal newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(newGoal);
            Console.WriteLine("Your Checklist goal has been created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        string goalAccomplished = Console.ReadLine();
        int goalDone = int.Parse(goalAccomplished);

        Goal goal = _goals[goalDone - 1];
        int earnedPoints = goal.RecordEvent(); 
        _score += earnedPoints;
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                string goals = goal.GetStringRepresentation();
                outputFile.WriteLine(goals);
            }
        }
        Console.WriteLine("Goals successfully saved!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(":");
            string goalType = parts[0];
            string data = parts[1];

            string[] details = data.Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = details[0].Trim();
                string description = details[1].Trim();
                int points = int.Parse(details[2].Trim());
                bool isComplete = bool.Parse(details[3].Trim());

                Goal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = details[0].Trim();
                string description = details[1].Trim();
                int points = int.Parse(details[2]);

                Goal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = details[0].Trim();
                string description = details[1].Trim();
                int points = int.Parse(details[2]);
                int target = int.Parse(details[3]);
                int bonus = int.Parse(details[4]);
                int completed = int.Parse(details[5]);

                Goal goal = new ChecklistGoal(name, description, points, target, bonus, completed);
                _goals.Add(goal);
            }
        } 
    }
}