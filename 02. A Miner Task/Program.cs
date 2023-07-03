namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            var minerals = new Dictionary<string, int>();
                
            while ((input = Console.ReadLine()) != "stop")
            {
                int value = int.Parse(Console.ReadLine());
                if (!minerals.ContainsKey(input))
                {
                    minerals.Add(input, value);
                }
                else
                {
                    minerals[input]+=value;
                }
                
            }
            foreach (var item in minerals)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}