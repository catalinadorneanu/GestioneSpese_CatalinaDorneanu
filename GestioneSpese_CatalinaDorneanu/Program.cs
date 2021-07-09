using GestioneSpese_CatalinaDorneanu.Watcher;
using System;
using EventHandler = GestioneSpese_CatalinaDorneanu.Watcher.EventHandler;

namespace GestioneSpese_CatalinaDorneanu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //FileWatcher.NewFileWatcher();
            //EventHandler.Approval(); //funziona
            //EventHandler.Rimborso();
            EventHandler.SaveOnFile("spese.txt");

        }
    }
}
