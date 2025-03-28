using System;
using System.IO;

namespace DelegateBasicExample
{
    class Program
    {
        delegate void LogDel(string NULL);
        public static void Main(string[] args)
        {
            Log log = new Log();
            //LogDel logDel = new LogDel(log.LogTextToFile);

            LogDel LogTextToScreen, LogTextToFileDel;
            LogTextToScreen = new LogDel(log.LogTextToScreen);
            LogTextToFileDel = new LogDel(log.LogTextToFile);
            LogDel MultiLogDel = LogTextToScreen + LogTextToFileDel;

            Console.Write("Enter you name: ");
            var name = Console.ReadLine();
            MultiLogDel(name);
            LongText(LogTextToScreen, name);    

            Console.ReadKey();
        }

        static void LongText(LogDel logDel, string text)
        {
            logDel(text);
        }
    }

    public class Log
    {
        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}