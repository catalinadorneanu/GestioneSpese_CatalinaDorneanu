using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.ChainOfResponsability
{
    public interface IHandler
    {
        IHandler SetNext(IHandler next);

        string Handle(double spese);
    }
}
