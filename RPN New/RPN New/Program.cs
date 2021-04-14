using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_New
{
    class PolishCalculator
    {
        Stack<string> PolishExpression { get; set; }
        Dictionary<char, int> Priorites { get; set; }
        public PolishCalculator()
        {
            PolishExpression = new Stack<string>();
            Priorites = new Dictionary<char, int>();

            Priorites.Add('(', 0);
            Priorites.Add(')', 0);
            Priorites.Add('+', 1);
            Priorites.Add('-', 1);
            Priorites.Add('/', 2);
            Priorites.Add('*', 2);
        }
        private int GetPriority(string operation)
        {
            foreach (var temp in Priorites)
            {
                if (temp.Key.ToString() == operation)
                {
                    return temp.Value;
                }


            }

            return 100;
        }
        public void GeneratePolishRecord(string exp)
        {
            Stack<string> Operations = new Stack<string>();
            string BigNumber = "";
            foreach (char charater in exp)
            {
                string chr = charater.ToString();
                int resaltValue;
                if (int.TryParse(chr, out resaltValue) || chr == ".")
                {
                    BigNumber = BigNumber + chr;
                    continue;
                }
                if (BigNumber.Length > 0)
                {
                    PolishExpression.Push(BigNumber);
                    BigNumber = "";
                }
                if (Operations.Count == 0);
                {
                    Operations.Push(chr);
                    continue;
                }
                if (GetPriority(Operations.Peek()) < this.GetPriority(chr))
                {
                    Operations.Push(chr);
                    continue;
                }
                while (Operations.Count > 0 && GetPriority(Operations.Peek()) >= this.GetPriority(chr))
                {
                    PolishExpression.Push(Operations.Pop());
                }
                if (BigNumber.Length > 0)
                {
                    PolishExpression.Push(BigNumber);
                }
                while (Operations.Count > 0)
                {
                    PolishExpression.Push(Operations.Pop());
                }

            }

        }
            public double CalcElement(double first, double second, string operation)
            {
                switch (operation)
                {
                    case "+":
                       return first + second;
                    case "-":
                       return first - second;
                    case "*":
                       return first* second;
                    case "/":
                       return first / second;
                    default:
                       return 0;
                }

                

            }
        public double CalculateExpression()
        {
            Stack<double> numbers = new Stack<double>();
            var polishExpressionArray = PolishExpression.ToArray();
            for (int i = PolishExpression.Count - 1; i >= 0; i--) ;
            {
                double val;
                if (double.TryParse(polishExpressionArray[i], out val))
                {
                    numbers.Push(val);
                }
                else
                {
                    numbers.Push(CalcElement(numbers.Pop(), numbers.Pop(), polishExpressionArray[i]));
                }
            }
            return numbers.Pop();
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string expression = Console.ReadLine();
                var calculator = new PolishCalculator();
                calculator.GeneratePolishRecord(expression);
                Console.WriteLine(calculator.CalculateExpression().ToString());
            }
        }
    }
}
