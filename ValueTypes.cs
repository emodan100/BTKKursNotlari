//value type ile yazdırma

int sayi = 100;
Console.WriteLine(sayi);
string metin = "Merhaba";
Console.WriteLine(metin);

//convert işlemleri

int sayi1 = 200;
Console.WriteLine(sayi1.ToString());
double sayi2 = 12.5;
int sayi3 = (int)sayi2;
Console.WriteLine(sayi3);

//nullable işlemleri

int? sayi4 = null;
string metin2 = null;
Console.WriteLine(metin2);
Console.WriteLine(sayi4.HasValue);

//basit toplama işlemi

Console.Write("Sayi 1: ");
int sayi5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayi 2: ");
int sayi6 = Convert.ToInt32(Console.ReadLine());
int toplam = sayi5 + sayi6;
Console.WriteLine("Sayılarınızın Toplamı: " + toplam);