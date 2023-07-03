namespace _6._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var Students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!Students.ContainsKey(studentName))
                {
                    Students.Add(studentName, new List<double>());
                    Students[studentName].Add(studentGrade);
                }
                else
                {
                    Students[studentName].Add(studentGrade);
                }
            }
                double averageGrade = 0;
            foreach (var student in Students)
            {
                averageGrade = student.Value.Sum() / student.Value.Count;
                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:F2}");
                }
            }
        }
    }
}