using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var karakter1 = new Karakterler()
            {
                KarakterAd = "Deniz",
                KarakterYas = "17",
                KarakterUzmanlıkAlanı = "Aritmetik Programlama",
                KarakterNeSever = "Matematik Problemlerini",
            };
            var karakter2 = new Karakterler()
            {
                KarakterAd = "Utku",
                KarakterYas = "17",
                KarakterUzmanlıkAlanı = "Bilgisayar Programlama",
                KarakterNeSever = "Bilgisayar Oyunu Oynamayı",
            };
            var karakter3 = new Karakterler()
            {
                KarakterAd = "Çağatay",
                KarakterYas = "17",
                KarakterUzmanlıkAlanı = "Sprite/Art Design-Oyun Programlama",
                KarakterNeSever = "Oyun yapmayı/oynamayı",
            };
            var karakter4 = new Karakterler() 
            {
                KarakterAd = "Enes",
                KarakterYas = "17",
                KarakterUzmanlıkAlanı = "3D Modelleme-Oyun Programlama",
                KarakterNeSever = "Emodan ile takılmayı",
            };
            Karsilama karsilama = new Karsilama();
            karsilama.Selamla();
            var cevap = Console.ReadLine();
            var lesgo = true;

            if (cevap == "E" || cevap == "e")
            {
                Console.WriteLine("Harika! Hadi başlayalım o zaman!");
                Task.Delay(1000).Wait();
                while(lesgo == true)
                {
                    Console.WriteLine("Hangi karakteri tanımak istersiniz? (1-4)(Çıkmak için Q'ya basınız)");
                    var karakterSecim = Console.ReadLine();
                    Task.Delay(500).Wait();
                    if(karakterSecim == "1")
                    {
                        karakter1.KarakterBilgileri();
                    }
                    else if(karakterSecim == "2")
                    {
                        karakter2.KarakterBilgileri();
                    }
                    else if(karakterSecim == "3")
                    {
                        karakter3.KarakterBilgileri();
                    }
                    else if(karakterSecim == "4")
                    {
                        karakter4.KarakterBilgileri();
                    }
                    else if(karakterSecim == "Q" || karakterSecim == "q")
                    {
                        Console.WriteLine("Görüşmek üzere!");
                        lesgo = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir karakter numara girin yada Q basın.");
                    }
                }
            }
            else if(cevap == "H" || cevap == "h")
            {
                Console.WriteLine("Bu süper dörtlüyü tanımamak sizin kaybınız!");
            }
            else
            {
                Console.WriteLine("Geçersiz Karakter Lütfen H yada E yazınız.");
            }
        }

        class Karakterler
        {
            public string KarakterAd { get; set; }
            public string KarakterYas { get; set; }
            public string KarakterUzmanlıkAlanı { get; set; }
            public string KarakterNeSever { get; set; }

            public void KarakterBilgileri()
            {
                Console.WriteLine("Ad: " + KarakterAd);
                Task.Delay(500).Wait();
                Console.WriteLine("Yaş: " + KarakterYas);
                Task.Delay(500).Wait();
                Console.WriteLine("Uzmanlık Alanı: " + KarakterUzmanlıkAlanı);
                Task.Delay(500).Wait();
                Console.WriteLine("Ne Sever: " + KarakterNeSever);
                Task.Delay(500).Wait();
            }
        }

        class Karsilama
        {
            public void Selamla()
            {
                Console.Write("Merhaba Cennet Kovulanlar ekibinin özel 4 üyesini tanımak ister misiniz? (E/H)");
            }
        }
    }
}