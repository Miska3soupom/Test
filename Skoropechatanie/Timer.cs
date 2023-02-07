using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Skoropechatanie
{
    public class Timer
    {
        static public int x = 0;
        static public int y = 1;

        static public void Writing()
        {
            Thread thread = new Thread(new ThreadStart(Program.Secunds));
            thread.Start();
            string text = File.ReadAllText("C:\\Users\\misha\\OneDrive\\Рабочий стол\\TextFor8.txt");
            List<char> chars = new();
            foreach (char el in text)
            {
                chars.Add(el);
                Console.Write(el);
            }
            int i = 0;
            while (i < chars.Count && Program.printtime == true)
            {
                Console.SetCursorPosition(x, y);
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                Console.CursorVisible = false;
                if (key.KeyChar.Equals(chars[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(chars[i]);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    i++; x++;
                    if (x == Console.BufferWidth)
                    {
                        x = 0;
                        y++;
                    }
                }
            }
            Info.SymbMin = i;
            Info.SymbSec = Info.SymbMin / 60;
        }
    }


}
