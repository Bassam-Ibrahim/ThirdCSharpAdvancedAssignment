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



        #endregion
    }
}