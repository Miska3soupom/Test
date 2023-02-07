using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Skoropechatanie
{
    internal class Program
    {
        public static bool printtime = true;

        static void Main(string[] args)
        {
            UserName();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.WriteLine("Тест на скорость печати");
            Timer.Writing();
            SaveRes.SaveRecords();
            Console.WriteLine("До свидания!!!");
        }

        static void UserName()
        {
            Console.WriteLine("Введите свое имя: ");
            Info.Name = Console.ReadLine();
            Console.WriteLine($"Здравствуй, {Info.Name}!");
            Thread.Sleep(2300);
            Console.Clear();
        }

        public static void Secunds()
        {
            for (int stop = 10; stop >= 0; stop--)
            {
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, 0);
                if (stop >= 10)
                {
                    Console.Write($"00:{stop}");
                }
                else
                {
                    Console.Write($"00:0{stop}");
                }
                Console.SetCursorPosition(Timer.x, Timer.y);
                if (stop == 0)
                {
                    printtime = false;
                }
                else
                {
                    printtime = true;
                }
            }
        }
    }
}