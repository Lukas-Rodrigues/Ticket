using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Models
{
    public class Ingressos
    {
        protected decimal _valor = 40;

        public string _name { get; set; }




        public virtual decimal ImprimirValor()
        {

            return _valor;

        }
    }
}
