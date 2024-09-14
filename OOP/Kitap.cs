

namespace OOP
{
    public class Kitap
    {
        private string authorSurname;


        public Kitap()
        {
            Console.WriteLine("\n**KİTAP OLUŞTURULDU**");
        }

        public string Title { get; set; }
        public string PageCount { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname
        {
            get
            {
                return authorSurname;
            }
            set
            {
                authorSurname = value.ToUpper();

            }

        }
        public string AuthorFullName => $"{AuthorName} {AuthorSurname}"; //lambda sadece get

        public void PrinterBook()
        {
            Console.WriteLine($"" +
                $"\nKitap Adı: {Title}" +
                $"\nSayfa Sayısı: {PageCount}" +
                $"\nYazar Adı: {AuthorName}" +
                $"\nYazar Soyadı: {AuthorSurname}" +
                $"\nYazarın Tam Adı: {AuthorFullName}");
        }

        public string Print()
        {
            return $"" +
                $"\nKitap Adı: {this.Title}" +
                $"\nSayfa Sayısı: {this.PageCount}" +
                $"\nYazar Adı: {this.AuthorName}" +
                $"\nYazar Soyadı: {this.AuthorSurname}" +
                $"\nYazarın Tam Adı: {this.AuthorFullName}";

        }

        public override string ToString()
        {
            return $"" +
                $"\nKitap Adı: {Title}" +
                $"\nSayfa Sayısı: {PageCount}" +
                $"\nYazar Adı: {AuthorName}" +
                $"\nYazar Soyadı: {AuthorSurname}" +
                $"\nYazarın Tam Adı: {AuthorFullName}";
        }
    }
}
