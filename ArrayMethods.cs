//Diziler ile 3 karakter belirtme ve 3 karakter can atama

string[] karakterler = new string[3];
int[] canlar = new int[3];

Console.Write("Lütfen 1 karakter ismi giriniz: ");
karakterler[0] = Console.ReadLine() ?? "";
Console.Write("Lütfen 1 karakter canını giriniz: ");
canlar[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Lütfen 2 karakter ismi giriniz: ");
karakterler[1] = Console.ReadLine() ?? "";
Console.Write("Lütfen 2 karakter canını giriniz: ");
canlar[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Lütfen 3 karakter ismi giriniz: ");
karakterler[2] = Console.ReadLine() ?? "";
Console.Write("Lütfen 3 karakter canını giriniz: ");
canlar[2] = Convert.ToInt32(Console.ReadLine());

//Karakterler dizisinin kaç elemanlı olduğunu gösterme
Console.WriteLine("Karakterler dizisinin eleman sayısı: " + karakterler.Length);
//Canlar dizisinin kaç elemanlı olduğunu gösterme
Console.WriteLine("Canlar dizisinin eleman sayısı: " + canlar.Length);

//İlk 2 karakter ve canlarını ekrana yazdırma
foreach (var karakter in karakterler[..2])
{
    Console.WriteLine("Karakter: " + karakter + ", Can: " + canlar[Array.IndexOf(karakterler, karakter)]);
}

//Karakterlerin can ortalamasını hesaplama ve ekrana yazdırma
int toplamCan = canlar[0] + canlar[1] + canlar[2];
int ortalamaCan = toplamCan / 3;

Console.WriteLine("Karakterlerin ortalama canı: " + ortalamaCan);
