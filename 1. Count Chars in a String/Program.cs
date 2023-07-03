using System.Runtime.CompilerServices;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            var dic = new Dictionary<char, int>();
            foreach (string word in words)
            {
                
                foreach (var ch in word)
                {
                    if (!dic.ContainsKey(ch))
                    {
                        dic.Add(ch, 1);
                    }
                    else
                    {
                        dic[ch]++;
                    }
                }
            }
            foreach (var chars in dic)
            {
                Console.Write($"{chars.Key} -> {chars.Value}");
                Console.WriteLine();
            }
        }
    }
}