

using OOP;

Kitap kitap1 = new()
{
    Title = "Ihlamurlar Altında",
    PageCount = "568",
    AuthorName = "Sefa",
    AuthorSurname = "Kahraman",
};

Console.WriteLine(kitap1.ToString());


Kitap kitap2 = new Kitap() { Title = "Ver Elini", PageCount = "789", AuthorName = "Ahmet", AuthorSurname = "Hamdi" };

kitap2.PrinterBook();

Kitap kitap3 = new Kitap();
kitap3.Title = "Aynı Yıldız";
kitap3.PageCount = "421";
kitap3.AuthorName = "Mehmet";
kitap3.AuthorSurname = "Memlük";

kitap3.Print();



Kitap[] kitaplar = { kitap1, kitap2, kitap3 };

foreach (var kitap in kitaplar)
{
    kitap.Print();
}

