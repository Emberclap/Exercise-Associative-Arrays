namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split()
                    .ToList();
                string username = commands[1];
                
                switch (commands[0])
                {
                    case "register":
                        string licensePlateNumber = commands[2];
                        if (!parking.ContainsKey(username))
                        {
                            parking.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                        }
                        break;
                    case "unregister":
                        if (!parking.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            parking.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;

                }
            }
            foreach (var username in parking)
            {
                Console.WriteLine($"{username.Key} => {username.Value}");
            }
        }
    }
}