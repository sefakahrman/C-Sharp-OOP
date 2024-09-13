

using OOP;

Kitap kitap1 = new()
{
    KitapAdi ="Ihlamurlar Altında",
    SayfaSayisi = "568",
    YazarAdi ="Sefa",
    YazarSoyadi="Kahraman",
};

Console.WriteLine(kitap1.ToString());


Kitap kitap2 = new Kitap() { KitapAdi = "Ver Elini", SayfaSayisi = "789", YazarAdi = "Ahmet", YazarSoyadi = "Hamdi" };

kitap2.KitapYazdirBaskaMetodla();

Kitap kitap3 = new Kitap();
kitap3.KitapAdi = "Aynı Yıldız";
kitap3.SayfaSayisi = "421";
kitap3.YazarAdi = "Mehmet";
kitap3.YazarSoyadi = "Memlük";

kitap3.KitapYazdirBaskaMetodla();
