using System;
using System.Collections.Generic;

namespace task3
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            var data = input.Split(' ');
            var stack = new Stack<int>();
            var res = 0;

            for (int i = 0; i < data.Length; i++)
            {
                var (isNum, num) = IsNumeric(data[i]);
                if (isNum)
                {
                    stack.Push(num);
                }
                else if (IsOperator(data[i]))
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    var oper = data[i];

                    switch (oper)
                    {
                        case "+":
                        {
                            res = second + first;
                            break;
                        }
                        case "-":
                        {
                            res = second - first;
                            break;
                        }
                        case "*":
                        {
                            res = second * first;
                            break;
                        }
                        case "/":
                        {
                            res = second / first;
                            break;
                        }
                    }

                    stack.Push(res);
                }
            }

            return stack.Peek();
        }

        private static bool IsOperator(string data)
        {
            var operators = new HashSet<string>()
            {
                "+", "-", "/", "*"
            };
            return operators.Contains(data);
        }

        private static (bool, int) IsNumeric(string data)
        {
            int num;

            bool isNum = int.TryParse(data, out num);
            return (isNum, num);
        }
    }
}