namespace kitap1.Models
{
    public class Kitap
    {
        public string KitapAdı { get; set; }
        public string YazarAdı { get; set; }
        public DateTime YayınlanmaTarihi { get; set; }
        public string  Türü { get; set; }
        public int SayfaSayısı { get; set; }
        public decimal Fiyat { get; set; }
    }
}