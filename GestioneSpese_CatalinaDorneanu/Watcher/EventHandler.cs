using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.Watcher
{
    class EventHandler
    {
        internal static void Handler(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"=== New File Created: {e.Name} ===");

            var reader = File.OpenText(e.FullPath);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("==== End of Content ===");
        }
    }
}
