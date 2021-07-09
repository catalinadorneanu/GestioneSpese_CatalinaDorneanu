using GestioneSpese_CatalinaDorneanu.ChainOfResponsability;
using GestioneSpese_CatalinaDorneanu.Factory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.Watcher
{
    public class EventHandler
    {

       

        public static void Handler(object sender, FileSystemEventArgs e)
        {

            Console.WriteLine($"=== New File Created: {e.Name} ===");

            var reader = File.OpenText(e.FullPath);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("==== End of Content ===");
            reader.Close();
        }

        public static void Approval()
        {
            List<Spesa> spese = new List<Spesa>();
            var ceo = new CEOHandler();
            var manager = new ManagerHandler();
            var opManager = new OpManagerHandler();

            ceo.SetNext(manager).SetNext(opManager);  //chain configuration...

            var livello = new List<double> { 200, 1587, 545 };

            foreach (var l in livello)
            {
                Console.WriteLine($"Chi vuole un/una {l}?");

                var result = ceo.Handle(l);  // send request to first link in the chain ...

                if (result != null)
                    Console.WriteLine($"\t{result}");
                else
                    Console.WriteLine("\tè il caso di passare da un negozio di cibo per animali");
            }
        }

        public static void Rimborso()
        {

            //List<Spesa> spese = new List<Spesa>();
            //List<Double> Rimborsi = new List<double>();
            Console.Write("Che tipo di rimborso ");
            string tipo = Console.ReadLine();
            double.TryParse(tipo, out double importo);
            //foreach (var category in spese)
            //{
                //var tipo = category.Categoria;
                //var importo = category.Importo;
             ICategory rimborso = CategoryFactory.GetRimborso(tipo);

            //    Rimborsi.Add(rimborso);
            //}
        }
        private const string path = @"C:\Users\catalina.g.dorneanu\Desktop\Spese";
        public static void SaveOnFile(string fileName)
        {

            List<Spesa> spese = new List<Spesa>
            {
                new Spesa {Data = new DateTime(2020,12,12), Categoria = "vitto", Descrizione = "ristorante", Importo = 500 },
                new Spesa {Data = new DateTime(2010,02,12), Categoria = "alloggio", Descrizione = "hotel", Importo = 1300 },
                new Spesa {Data = new DateTime(2010,02,12), Categoria = "altro", Descrizione = "benzina", Importo = 50 }
            };


            
               foreach (var s in spese)
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    StreamWriter writer = File.CreateText(Path.Combine(path, fileName));

                    writer.WriteLine(s.Data + "," );
                    writer.WriteLine(s.Categoria + ",");
                    writer.WriteLine(s.Descrizione + ",");
                    writer.WriteLine(s.Importo);
                    

                    writer.Flush();
                    writer.Close();
                
            }
            Console.WriteLine($"File {fileName} creato!");





        }


        
    }
}