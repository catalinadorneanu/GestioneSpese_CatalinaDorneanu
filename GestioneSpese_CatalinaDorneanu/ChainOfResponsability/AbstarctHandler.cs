using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese_CatalinaDorneanu.ChainOfResponsability
{
    public abstract class AbstarctHandler : IHandler
    {
        private IHandler NextHandler;
        public virtual string Handle(double importo)
        {
            if (NextHandler != null)
            {
                return NextHandler.Handle(importo);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler next)
        {
            NextHandler = next;

            return next;
        }
    }
}
