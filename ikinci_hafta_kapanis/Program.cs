// SORU -1 
Console.WriteLine("Merhaba\n Nasıl? \n İyiyim\n Sen nasılsın?");

// SORU -2
//Bir adet metinsel bir adet tam sayı verisini tutmak için 2 adet değişken tanımlama
string metin = "Patikaplus";
int year = 2024;
Console.WriteLine(metin + year);

//SORU -3
//Rastgele bir sayı üretip yazdırın
Random rnd = new Random();
Console.WriteLine("üretilen sayıyı yazınız" + new Random());

//SORU -4
//Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırın
Random random = new Random();
int sayi = rnd.Next();
int kalan = sayi % 3;
Console.WriteLine("rastgele üretilen" + sayi +"sayısının 3e bölümünden kalan" + kalan);

//SORU -5
//Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama
Console.WriteLine("Yaşınız nedir?");
string yasMetin = Console.ReadLine();
int yasSayi = Convert.ToInt32(yasMetin);

if (yasSayi > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}

//SORU -6
//Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++) ;
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");

}

//SORU -7
//Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("Bir metin giriniz.");

string birinciMetin = Console.ReadLine(); //Gülse Birsel

Console.WriteLine("Bir metin daha giriniz");

string ikinciMetin = Console.ReadLine(); //Demet Evgar

string temp = birinciMetin;
birinciMetin = ikinciMetin;
ikinciMetin = temp;

Console.WriteLine($"birinci metin (değişen): {birinciMetin}");
Console.WriteLine($"ikinci metin (değişen): {ikinciMetin}");

//SORU -8
//Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

void BenDegerDondurmem()

{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");

}
BenDegerDondurmem();

//SORU -9
//İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız

int Topla(int x, int y)
{
    return x + y;
}
int toplam = Topla(4, 5);
Console.WriteLine("4 ve 5 sayısının gönderdğim metodun çıkardığı sonuc " + toplam);

//SORU -11
//3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

Console.WriteLine("Birinci kişinin yaşını giriniz");
int age1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci kişinin yaşını giriniz");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("üçüncü kişinin yaşını giriniz");
int age3 = Convert.ToInt32(Console.ReadLine());

// En yaşlı olan kişinin yaşını bul
int oldestAge = FindOldestAge(age1, age2, age3);

// Sonucu ekrana yazdır
Console.WriteLine($"En yaşlı kişinin yaşı: {oldestAge}");


// En yaşlı olanı döndüren metot
static int FindOldestAge(int age1, int age2, int age3)
{
    // Yaşları karşılaştırarak en yaşlı olanını bul
    int oldest = age1;

    if (age2 > oldest)
    {
        oldest = age2;
    }

    if (age3 > oldest)
    {
        oldest = age3;
    }

    return oldest;
}

//SORU -12
int enBuyukSayi = EnBuyukSayiyiBul();
Console.WriteLine("Girilen sayılar arasında en büyüğü: " + enBuyukSayi);
static int EnBuyukSayiyiBul()
{
    int enBuyuk = int.MinValue;

    while (true)
    {
        Console.Write("Bir sayı girin (çıkmak için 'q' tuşuna basın): ");
        string girdi = Console.ReadLine();

        if (girdi.ToLower() == "q")
        {
            break;
        }

        if (int.TryParse(girdi, out int sayi))
        {
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz sayı girişi. Lütfen tekrar deneyin.");
        }
    }
    return enBuyuk;
}

//SORU -13
Console.Write("Birinci ismi yazın: ");
string firstName = Console.ReadLine();

Console.Write("İkinci ismi yazın: ");
string secondName = Console.ReadLine();

// İsimlerin yerlerini değiştirme metodunu çağır
(string newFirstName, string newSecondName) = SwapNames(firstName, secondName);

// Sonuçları ekrana yazdır
Console.WriteLine($"Yer değiştiren isimler:");
Console.WriteLine($"Birinci isim (değiştirilen): {newFirstName}");
Console.WriteLine($"İkinci isim (değiştirilen): {newSecondName}");


// İki ismin yerlerini değiştiren metot
static (string, string) SwapNames(string firstName, string secondName)
{
    // İsimlerin yerlerini değiştir
    return (secondName, firstName);
}

//SORU -14
static void Main(string[] args)
{
    static bool TekMiCiftMi(int sayi)
    {
        return sayi % 2 == 0;
    }

    Console.Write("Sayı girin: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    bool sonuc = TekMiCiftMi(sayi);
    if (sonuc)
    {
        Console.Write($"{sayi} çifttir.");
    }
    else
    {
        Console.Write($"{sayi} tektir.");
    }
}

//SORU -15
void GidilenYolHesapla(int hiz, int zaman)
{
    Console.WriteLine(hiz * zaman);
}

Console.Write("zaman: ");
int zaman = Convert.ToInt32(Console.ReadLine());
Console.Write("hız: ");
int hiz = Convert.ToInt32(Console.ReadLine());
Console.Write("gidilen yol -> "); GidilenYolHesapla(hiz, zaman);

//SORU -16
void YariCapHesapla(double yaricap, double pi)
{
    Console.WriteLine(pi * yaricap * yaricap);
}
YariCapHesapla(10, 3.14);
Console.WriteLine($"alan: {YariCapHesapla}");

//SORU -17
string buyuk_kucuk = "Zaman bir GeRi SayIm";
string buyuk = buyuk_kucuk.ToUpper();
string kucuk = buyuk.ToLower();
Console.WriteLine(buyuk);
Console.WriteLine(kucuk);

//SORU -18
string text = "    Selamlar   ";

text = text.Trim();

Console.WriteLine($"{text}");

