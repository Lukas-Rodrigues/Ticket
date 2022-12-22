using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Models
{
    public class IngressosVip:Ingressos
    {
        protected decimal _valorAdicinal = 30;



        public override decimal ImprimirValor()
        {
           
            return _valorAdicinal + _valor;
        }



    }
}
