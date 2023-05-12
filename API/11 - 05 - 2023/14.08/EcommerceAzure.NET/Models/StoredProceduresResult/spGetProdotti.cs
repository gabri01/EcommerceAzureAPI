namespace Models.StoredProceduresResult
{
    public class spGetProdotti
    {
        public long Id { get; set; }
        public int Cod { get; set;  }
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public int Quantita { get; set; }
        public byte[]? Img { get; set; }
    }
}
