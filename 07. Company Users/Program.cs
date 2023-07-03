namespace _07._Company_Users
{
    internal class Program
    {
        static void Main()
        {
            string input = "";

            var employeeData = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] employee = input
                    .Split(" -> ")
                    .ToArray();
                string companyName = employee[0];
                string employeeID = employee[1];

                if (!employeeData.ContainsKey(companyName))
                {
                    employeeData.Add(companyName, new List<string>());
                    employeeData[companyName].Add(employeeID);
                }
                else
                {
                    if (employeeData[companyName].Contains(employeeID))
                    {
                        continue;
                    }
                    else
                    {
                        employeeData[companyName].Add(employeeID);
                    }
                   
                }
            }

            foreach (var employee in employeeData)
            {
                Console.WriteLine(employee.Key);
                foreach (var id in employee.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}