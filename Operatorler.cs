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

//Oyun oynuyabilme durumu 2
Console.Write("Yaşınızı giriniz:");
var age = Convert.ToInt32(Console.ReadLine());
Console.Write("Ebeveyn izniniz var mı? (E/H):");
var ebeveynIzni = Console.ReadLine();
bool OyunOynanabilirDurumu = (age >= 18 || ebeveynIzni == "E");
Console.WriteLine("Oyunu oynayabilme durumu: " + OyunOynanabilirDurumu);

//Ders geçme durumu
Console.Write("Ders notunuzu giriniz:");
var not = Convert.ToInt32(Console.ReadLine());
string dersGecmeDurumu = (not >= 50 && not <= 100) ? "geçtiniz" : "kaldınız";
Console.WriteLine("Ders geçme durumu: " + dersGecmeDurumu);

//Ders geçme durumu 2
Console.Write("Ders notunuzu giriniz:");
var not2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Zayıfı var mı?(E/H):");
var zayifVarMi = Console.ReadLine();
string dersGecmeDurumu2 = (not2 >= 70 && zayifVarMi == "H") ? "geçtiniz" : "kaldınız";
Console.WriteLine("Ders geçme durumu: " + dersGecmeDurumu2);

//Şirkete girme koşulu 
Console.Write("Lisans mezunumusunuz?(E/H):");
var lisansMezunu = Console.ReadLine();
Console.Write("Ön lisansınız varmı?(E/H):");
var onLisansMezunu = Console.ReadLine();
Console.Write("Sigara içiyonuzmu?(E/H):");
var sigaraIciyorMu = Console.ReadLine();
string sirketGirisKosu = ( (lisansMezunu == "E" || onLisansMezunu == "E") && sigaraIciyorMu == "H") ? "şirkete girebilirsiniz" : "şirkete giremezsiniz";
Console.WriteLine(sirketGirisKosu);

//Hesaba giriş durumu
string username = "admin";
string password = "12345";

Console.Write("Kullanıcı adınızı giriniz:");
var girilenUsername = Console.ReadLine();
Console.Write("Parolanızı giriniz:");
var girilenPassword = Console.ReadLine();
string hesabaGirisDurumu = (girilenUsername == username && girilenPassword == password) ? "hesaba giriş başarılı" : "hesaba giriş başarısız";
//string hesabaGirisDurumu = (girilenUsername != username && girilenPassword != password) ? "şifre veya username yanlış" : "hesabınıza giriş yapılmıştır";(Farklı yolla)
Console.WriteLine(hesabaGirisDurumu);