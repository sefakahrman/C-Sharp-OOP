

namespace OOP
{
    public class Kitap
    {
        private string yazarSoyadi;

        public Kitap()
        {
            Console.WriteLine("\n**KİTAP OLUŞTURULDU**");    
        }

        public string KitapAdi { get; set;}
        public string SayfaSayisi { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi
        {
            get
            {
                return yazarSoyadi;
            }
            set
            {
                yazarSoyadi = value.ToUpper();

            }

        }
        public string YazarinTamAdi => $"{YazarAdi} {YazarSoyadi}"; //lambda sadece get

        public void KitapYazdirBaskaMetodla()
        {
            Console.WriteLine($"" +
                $"\nKitap Adı: {KitapAdi}" +
                $"\nSayfa Sayısı: {SayfaSayisi}" +
                $"\nYazar Adı: {YazarAdi}" +
                $"\nYazar Soyadı: {YazarSoyadi}" +
                $"\nYazarın Tam Adı: {YazarinTamAdi}");
        }

        public override string ToString()
        {
            return $"" +
                $"\nKitap Adı: {KitapAdi}" +
                $"\nSayfa Sayısı: {SayfaSayisi}" +
                $"\nYazar Adı: {YazarAdi}" +
                $"\nYazar Soyadı: {YazarSoyadi}" +
                $"\nYazarın Tam Adı: {YazarinTamAdi}";
        }
    }
}
