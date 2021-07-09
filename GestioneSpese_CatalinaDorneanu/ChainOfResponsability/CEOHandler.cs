using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.ChainOfResponsability
{
    public class CEOHandler : AbstarctHandler
    {
        public override string Handle(double importo)
        {
            if (importo > 1000 && importo <= 2500)
            {

                return "CEO";
            }
            else
            {
                return base.Handle(importo);
            }
        }
    }
}
