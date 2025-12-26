//1-100 arasındaki sayıları döngü ile yazdırma
int toplam = 0;
for (int i = 1; i <= 100; i++)
{
    toplam += i;
    Console.WriteLine(toplam);
}
//Karakter lvl ve maxlvl arası farkların toplamı
var maxlvl = 100;
var fark = 0;
Console.Write("Lütfen karakter seviyenizi giriniz: ");
var lvl = Convert.ToInt32(Console.ReadLine());
for (int i = lvl; i <= maxlvl; i++)
{
    fark += i;
}
Console.WriteLine("Karakter seviyeniz ile maksimum seviye arasındaki farkın toplamı: " + fark);
//Dizideki karakterleri yazdırma
string[] karakterler = {"Emily","Daniel","John","Zack"};
int[] lvlleri = {10,20,30,40};
for (int i = 0; i < karakterler.Length; i++)
{
    Console.WriteLine("Karakter Adı: " + karakterler[i] + " - Seviyesi: " + lvlleri[i]);
}
//En yüksek seviyeli karakteri bulma
int enYuksekLvl = lvlleri[3];
for (int i = 0; i < lvlleri.Length; i++)
{
    if (lvlleri[i] >= enYuksekLvl)
    {
        Console.WriteLine("En yüksek seviyeli karakter: " + karakterler[i] + " - Seviyesi: " + lvlleri[i]);
    }
}
//Sayılı karakter sandık açılımı
Console.Write("Oyuncunun kaç sandığı var?: ");
var sandikSayisi = Convert.ToInt32(Console.ReadLine());
while (sandikSayisi > 0)
{
    string[] SandikKarakterleri = {"Rinat","Ahmet","Deniz","Enes"};
    Random rnd = new Random();
    int index = rnd.Next(0,3);
    Console.WriteLine("Sandıktan çıkan karakter: " + SandikKarakterleri[index]);
    sandikSayisi--;
    Console.WriteLine("Kalan sandık sayısı: " + sandikSayisi);
    continue;
}
//Sayı tahmin oyunu
Console.WriteLine("1-100 sayı tutunuz: ");
var tutulanSayi = Convert.ToInt32(Console.ReadLine());
Random rnd2 = new Random();
while (true)
{
    int tahmin = rnd2.Next(1,100);
    Console.WriteLine("Bilgisayarın tahmini: " + tahmin);
    if (tahmin == tutulanSayi)
    {
        Console.WriteLine("Bilgisayar doğru tahmin etti!");
        break;
    }
}