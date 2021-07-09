using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.Factory
{
    public class CategoryFactory
    {
        public static double GetRimborso(string type, double importo)
        {
            ICategory categoria;
            switch (type)
            {
                case "Viaggio":
                    categoria = new Viaggio();
                    break;
                case "Alloggio":
                    categoria = new Alloggio();
                    break;
                case "Altro":
                    categoria = new Altro();
                    break;
                case "Vitto":
                    categoria = new Vitto();
                    break;
                default:
                    Console.WriteLine("Vai a piedi");
                    categoria = null;
                    break;
            }
            return categoria.Rimborso(importo);
        }
    }
}
