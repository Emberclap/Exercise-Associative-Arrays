namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = " ";

            var dataBase = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> list = input
                    .Split(" : ")
                    .ToList();
                string courseName = list[0];
                string studentName = list[1];

                if (!dataBase.ContainsKey(courseName))
                {
                    dataBase.Add(courseName, new List<string>());
                    dataBase[courseName].Add(studentName);
                }
                else
                {
                    dataBase[courseName].Add(studentName);
                }
            }
            foreach (var course in dataBase)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}