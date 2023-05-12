using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StoredProceduresResult
{
    public class spGetOrdiniUtente
    {
        public long Id { get; set; }
        public string Note { get; set; }
        public double Costo { get; set; }
        public string Condizione { get; set; }
        public string Indirizzo { get; set; }
    }
}
