using System.Text;

namespace Competency_Test
{
    public class CustomFooBar
    {
        private List<(int Divisor, string Token)> _rules = new();

        public void AddRule(int input, string output)
        {
            _rules.Add((input, output));
        }

        public string GetOutput(int number)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var rule in _rules)
            {
                if (number % rule.Divisor == 0)
                {
                    sb.Append(rule.Token);
                }
            }
            return sb.Length > 0 ? sb.ToString() : number.ToString();
        }

        public void RunSequence(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(GetOutput(i));
                if (i < n) Console.Write(", ");
                if(i % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Output Question 1 ---");
            SolveQuestion1(15);
            Console.WriteLine("--- Output Question 2 ---");
            SolveQuestion2(35);
            Console.WriteLine("--- Output Question 3 ---");
            SolveQuestion3(50);
            Console.WriteLine("--- Output Question 4 ---");
            SolveQuestion4(50);
        }

        static void SolveQuestion1(uint n)
        {
            for (int i = 1; i <= n; i++)
            {
                string output = "";
                if (i % 3 == 0) output += "foo";
                if (i % 5 == 0) output += "bar";
                
                if (string.IsNullOrEmpty(output)) output = i.ToString();
                
                Console.Write(output);
                if (i < n) Console.Write(", ");
                if(i % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void SolveQuestion2(uint n)
        {
            for (int i = 1; i <= n; i++)
            {
                string output = "";
                if (i % 3 == 0) output += "foo";
                if (i % 5 == 0) output += "bar";
                if (i % 7 == 0) output += "jazz";
                
                if (string.IsNullOrEmpty(output)) output = i.ToString();
                
                Console.Write(output);
                if (i < n) Console.Write(", ");
                if(i % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void SolveQuestion3(uint n)
        {
            for (int i = 1; i <= n; i++)
            {
                string output = "";
                if (i % 3 == 0) output += "foo";
                if (i % 4 == 0) output += "baz";
                if (i % 5 == 0) output += "bar";
                if (i % 7 == 0) output += "jazz";
                if (i % 9 == 0) output += "huzz";
                
                if (string.IsNullOrEmpty(output)) output = i.ToString();
                
                if(i % 10 == 0) Console.WriteLine();
                Console.Write(output);
                if (i < n) Console.Write(", ");
            }
            Console.WriteLine("\n");

        }

        static void SolveQuestion4(int n)
        {
            var gen = new CustomFooBar(); 
            gen.AddRule(3, "foo");
            gen.AddRule(4, "baz");
            gen.AddRule(5, "bar");
            gen.AddRule(7, "jazz");
            gen.AddRule(9, "huzz");

            gen.RunSequence(n);
        }
    }
}
