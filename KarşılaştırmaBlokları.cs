//Karakter Seçimi

Console.WriteLine("Lütfen bir karakter seçin:");
Console.WriteLine("1. Savaşçı Azur");
Console.WriteLine("2. Büyücü Lyra");
Console.Write("Seçiminiz (1 veya 2): ");
var karakterSecimi = Convert.ToInt32(Console.ReadLine());

if (karakterSecimi == 1)
{
    Console.WriteLine("Savaşçı Azur'u seçtiniz");
}
else if (karakterSecimi == 2)
{
    Console.WriteLine("Büyücü Lyra'yı seçtiniz!");
}
else
{
    Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 girin.");
}

//Skor Hesaplama

Console.Write("Oyun kill sayınız(Max 100): ");
var killSayisi = Convert.ToInt32(Console.ReadLine());
Console.Write("Oyun tamamlanma süreniz(Dakika.Saniye): ");
var tamamlanmaSuresi = Convert.ToDouble(Console.ReadLine());

var toplamSkor = (killSayisi + tamamlanmaSuresi) / 2;

if (toplamSkor >= 75)
{
    Console.WriteLine("S seviye skor elde ettiniz");
}
else if (toplamSkor >= 65)
{
    Console.WriteLine("A seviye skor elde ettiniz");
}
else if (toplamSkor >= 50)
{
    Console.WriteLine("B seviye skor elde ettiniz");
}
else
{
    Console.WriteLine("C seviye skor elde ettiniz");
}

//Random Karakter Seçimi

Console.WriteLine("Rastgele kutunuz var! Çıkabilcek Karakterler:");
Console.WriteLine("1. Gabriel");
Console.WriteLine("2. Azrael");
Console.WriteLine("3. Seraphina");
Console.Write("Rastgele bir karakter kutunuzun açılmasını istiyomusunuz?(E/H): ");
var rastgeleKarakter = Console.ReadLine();
bool kutuAcildimi = false;

var rastgeleSayi = new Random();
int sayi = rastgeleSayi.Next(1, 3);

if ((rastgeleKarakter == "E" || rastgeleKarakter == "e") && kutuAcildimi == false)
{
    kutuAcildimi = true;
    if (sayi == 1)
    {
        Console.WriteLine("Karakteriniz Gabriel!");
    }
    else if (sayi == 2)
    {
        Console.WriteLine("karakteriniz Azrael!");
    }
    else
    {
        Console.WriteLine("karakteriniz Seraphina!");
    }
}
else if (rastgeleKarakter == "H" || rastgeleKarakter == "h")
{
    Console.WriteLine("Rastgele kutunuzu açmadınız.");
}
else
{
    Console.WriteLine("Geçersiz giriş! Lütfen E veya H girin.");
}
