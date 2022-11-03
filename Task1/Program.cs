using System;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }
        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();                 // коллекция стек
            Dictionary<char, char> sk = new Dictionary<char, char> // коллекция словарь
            {
                    { '(', ')'},
                    { '[', ']'},
                    { '{', '}'},
            };

            {
                foreach (char c in str)                                // цикл помещения и проверки символа в стек    
                {
                    if (c == '(' || c == '[' || c == '{')
                        stack.Push(sk[c]);
                    if (c == ')' || c == ']' || c == '}')
                    {
                        if (stack.Count == 0 || stack.Pop() != c)
                        {
                            return false;
                        }
                    }
                }
                if (stack.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
