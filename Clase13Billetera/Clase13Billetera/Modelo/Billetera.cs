using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Billetera.Modelo
{
    internal class Billetera
    {
        public int BilleteraDe10 { get; set; }
        public int BilleteraDe20 { get; set; }
        public int BilleteraDe50 { get; set; }
        public int BilleteraDe100 { get; set; }
        public int BilleteraDe200 { get; set; }
        public int BilleteraDe500 { get; set; }
        public int BilleteraDe1000 { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal Total()
        {
            return ImporteTotal;
        }

    }
}
