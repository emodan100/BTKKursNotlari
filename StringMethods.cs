string deneme = "Oyuncunuzun toplam lvl 12";

//Sahip Karakter
int Karakter = deneme.Length;
Console.WriteLine("Deneme karakter sayısı: " + Karakter);

//Hepsini küçük harf yapma 
string kucuk = deneme.ToLower();
Console.WriteLine(kucuk);

//Karakter sorgulama
bool varmi = deneme.StartsWith("O");
Console.WriteLine(varmi);

//Replace atma
string Replace = deneme.Replace("lvl", "level");
Console.WriteLine(Replace);

//Karakter konumu bulma
var konum = deneme.IndexOf("toplam");
Console.WriteLine(konum);

//String interpolation
Console.Write("Karakterinizin leveli: ");
string? level = Console.ReadLine();
Console.Write("Karakterinizin ismi: ");
string? isim = Console.ReadLine();
Console.WriteLine($"Karakter ismi: {isim}, Karakter leveli: {level}");
