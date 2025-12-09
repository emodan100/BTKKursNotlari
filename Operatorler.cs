//fark kat hesaplama

int char1 = 10;
int char2 = 5;
int char3 = 20;

var fark = (char1 + char3) * char2;
Console.WriteLine("Fark Kat Hesaplama Sonucu: " + fark);

//basit toplama null olabilme ihtimaliyle 

int? karakter1 = 10;
int karakter2 = 20; 

var toplam = karakter1 + karakter2;
Console.WriteLine("Toplam Sonucu: " + toplam);

//atama operatörü

int a = 5;
int b = 10;
a = b--;
Console.WriteLine("Atama Operatörü Sonucu: " + a);

//sayı tekmi çiftmi

Console.WriteLine("Bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine() ?? "0");
var sonuc = sayi % 2;
Console.WriteLine(sonuc == 0 ? "Sayı çifttir." : "Sayı tektir.");
//yada 
Console.WriteLine(sonuc); //0 ise çift 1 ise tek