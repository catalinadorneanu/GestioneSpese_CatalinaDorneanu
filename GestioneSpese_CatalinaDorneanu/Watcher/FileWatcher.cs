using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.Watcher
{
    public class FileWatcher
    {
        public static void NewFileWatcher()
        {
            Console.WriteLine("Watching... ");


            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = @"C:\Users\catalina.g.dorneanu\Desktop\Spese";
            fsw.Filter = "*.txt";
            fsw.NotifyFilter = NotifyFilters.FileName;
            fsw.EnableRaisingEvents = true;

            fsw.Created += EventHandler.Handler;

            Console.WriteLine("Press q to exit");
            while (Console.Read() != 'q') ;
        }
    }
}
