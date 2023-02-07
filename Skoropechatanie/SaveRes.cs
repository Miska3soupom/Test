using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoropechatanie
{
    internal class SaveRes
    {
        static public List<Info> list = new();
        static public void SaveRecords()
        {
         string path = "C:\\Users\\misha\\OneDrive\\Рабочий стол\\Result.json";
            Console.Clear();
            if (!File.Exists(path))
            {
                File.Create(path);
                File.WriteAllText(path, "");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Info.Name},");
            Console.WriteLine($"Вы печатаете со скоростью {Info.SymbMin} символов в минуту");
            Console.WriteLine($"Это {Info.SymbSec} символов в секунду");
            list.Add(new Info(Info.Name, Info.SymbMin, Info.SymbSec));
            string RecordsJson = JsonConvert.SerializeObject(list);
            File.AppendAllText(path, RecordsJson);
            Thread.Sleep(5000);
            Console.WriteLine("Общая таблица результатов:");
            List<Info> results = JsonConvert.DeserializeObject<List<Info>>(path);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
