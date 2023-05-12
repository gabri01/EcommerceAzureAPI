using Models.StoredProceduresResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Remap
{
    public class Prodotto
    {
        public long Id { get; set; }
        public int Cod { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public int Quantita { get; set; }
        public byte[]? Img { get; set; }
        public List<spGetCategorieProdotto> Categorie { get; set; }
    }
}
