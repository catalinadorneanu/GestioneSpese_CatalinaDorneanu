using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.ChainOfResponsability
{
   public class OpManagerHandler:AbstarctHandler
    {
        public override string Handle(double importo)
        {
            if (importo > 400 && importo <= 1000)
            {

                return "Operational Manager";
            }
            else
            {
                return base.Handle(importo);
            }
        }
    }
}
