using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_N3_OOP
{
    public class JustClass<T>(T value)
    {
        public T value { get; protected set; } = value;
        protected List<JustClass<T>> justClasses { get; set; } = [];

        public void RevealChildValues()
        {
            Console.Write($"-> {value} ");
            int posX = Console.CursorLeft;
            for (int i = 0; i < justClasses.Count - 1; i++)
            {
                justClasses[i].RevealChildValues();
                Console.SetCursorPosition(posX, Console.CursorTop + 1);
            }
            if (justClasses.Count > 1)
            {
                justClasses[justClasses.Count - 1].RevealChildValues();
            }

        }

        public void AddChildren(JustClass<T> children) => justClasses.Add(children);
    }
}
