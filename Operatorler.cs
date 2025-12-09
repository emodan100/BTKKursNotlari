//Oyunu oynuyabilme durumu

Console.Write("Yaşınızı giriniz:");
var yas = Convert.ToInt32(Console.ReadLine());
bool oyunuOynayabilmeDurumu = (yas >= 18);
Console.WriteLine("Oyunu oynayabilme durumu: " + oyunuOynayabilmeDurumu);

//Sayı pozitif mi?

Console.Write("Bir sayı giriniz:");
var sayi = Convert.ToInt32(Console.ReadLine());
var sayiPozitifMi = (sayi > 0) ? "sayı pozitif" : "sayı pozitif değil";
Console.WriteLine(sayiPozitifMi);

//Sayı çift mi?

Console.Write("Bir sayı giriniz:");
sayi = Convert.ToInt32(Console.ReadLine());
var sayiCiftMi = (sayi % 2 == 0) ? "sayı çift" : "sayı tek";
Console.WriteLine(sayiCiftMi);