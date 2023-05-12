using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StoredProceduresResult
{
    public class spUpdateProduct
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Quantita { get; set; }
        public float Prezzo { get; set; }
        public int Cod { get; set; }
        public byte[] Img { get; set; }
    }
}
