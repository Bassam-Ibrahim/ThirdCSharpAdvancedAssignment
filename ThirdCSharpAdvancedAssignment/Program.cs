class Program
{
    static void Main(string[] args)
    {
        #region First Ex


        List<int> grades = new List<int>
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

        Console.WriteLine("Grades:");
        Console.WriteLine(string.Join(", ", grades));

        Console.WriteLine("Count: " + grades.Count);
        Console.WriteLine("First: " + grades[0]);
        Console.WriteLine("Last: " + grades[grades.Count - 1]);

        grades.Sort();

        Console.WriteLine("Sorted Grades:");
        Console.WriteLine(string.Join(", ", grades));

        int firstAbove90 = grades.Find(x => x > 90);

        Console.WriteLine("First grade above 90: " + firstAbove90);

        List<int> failingGrades = grades.FindAll(x => x < 75);

        Console.WriteLine("Failing Grades:");
        Console.WriteLine(string.Join(", ", failingGrades));

        grades.RemoveAll(x => x < 75);

        Console.WriteLine("After removing failing grades:");
        Console.WriteLine(string.Join(", ", grades));

        bool has100 = grades.Contains(100);

        Console.WriteLine("Contains 100? " + has100);

        List<string> gradeStrings = new List<string>();

        foreach (int grade in grades)
        {
            gradeStrings.Add("Grade: " + grade);
        }

        Console.WriteLine("Grade Strings:");

        foreach (string grade in gradeStrings)
        {
            Console.WriteLine(grade);
        }

        Console.WriteLine();
        Console.WriteLine();

        #endregion

        #region Second Ex
        SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

        leaderboard.Add(500, "Ahmed");
        leaderboard.Add(200, "Sara");
        leaderboard.Add(800, "Ali");
        leaderboard.Add(350, "Mona");

        foreach (var playyer in leaderboard)
        {
            Console.WriteLine("Score: " + playyer.Key + " - Player: " + playyer.Value);
        }

        var first = leaderboard.First();

        Console.WriteLine("First Key: " + first.Key);
        Console.WriteLine("First Value: " + first.Value);

        bool exists = leaderboard.ContainsKey(500);

        Console.WriteLine("Score 500 exists? " + exists);

        if (leaderboard.TryGetValue(999, out string player))
        {
            Console.WriteLine("Player: " + player);
        }
        else
        {
            Console.WriteLine("Score 999 not found");
        }

        leaderboard.Remove(200);

        Console.WriteLine("Updated Leaderboard:");

        foreach (var item in leaderboard)
        {
            Console.WriteLine("Score: " + item.Key + " - Player: " + item.Value);
        }
        #endregion
        Console.WriteLine();
        Console.WriteLine();

        #region Third Ex
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook.Add("Ahmed", "01011111111");
        phoneBook.Add("Sara", "01022222222");
        phoneBook.Add("Ali", "01033333333");
        phoneBook.Add("Mona", "01044444444");

        phoneBook["Omar"] = "01055555555";

        try
        {
            phoneBook.Add("Ahmed", "01099999999");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        bool result = phoneBook.TryAdd(
            "Ahmed",
            "01099999999"
        );

        Console.WriteLine("TryAdd succeeded? " + result);

        bool isExists = phoneBook.ContainsKey("Khaled");

        Console.WriteLine("Khaled exists? " + isExists);

        string phone;

        if (phoneBook.TryGetValue("Khaled", out phone))
        {
            Console.WriteLine(phone);
        }
        else
        {
            Console.WriteLine("Not Found");
        }

        Console.WriteLine("Keys:");
        Console.WriteLine(string.Join(", ", phoneBook.Keys));

        Console.WriteLine("Values:");
        Console.WriteLine(string.Join(", ", phoneBook.Values));


        #endregion
    }
}