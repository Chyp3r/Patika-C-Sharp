// .Net Core 6.0
// Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulaması
// Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0
// Output: Algritma Algortma Algoritma lgoritma

Console.WriteLine("Kelimeyi ve silinecek indexi yazınız(Örnek: Algoritma,3): ");

while (true)
{
    // Try catch ile alınan değerin doğru formatta olup olmadığı kontrol edilir
    try
    {
        string deger = Console.ReadLine();
        if (deger.Contains(",")) // Verilen veride , olup olmadığı tespit edilir
        {
            string[] dizi = deger.Split(","); // Veri virgülden bölünür
            int index = Convert.ToInt32(dizi[1]); // Silinecek index bilgisi alınır
            silici(dizi,index); // Silme işlemi için silici fonksiyonuna dizi ve index değerleri gönderilir
            break;
        }
        else
        {
            Console.WriteLine("Lütfen yalnız 1 kere virgül kullanın ve index numarası ve kelime arasına virgül koyunuz!");
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen doğru formatta değer giriniz!");
    }
}

// Silici fonksiyonu => Gelen diziden verilen indexdeki eleman hariç kalan tüm elemanarı yan yana bastırır
// Silici fonksiyonu silme işlemi yapmaz sadece gösterilmesi istenmeyen veriyi saklar

void silici(string[] dizi,int index)
{
    char[] chardizisi = new char[100];

    for (int i = 0; i < dizi.Length; i++)
    {
        Console.WriteLine(dizi[i]);
    }

    chardizisi = dizi[0].ToCharArray(0,dizi[0].Length); // Stringteki her bir harfi chardizisin içine atıyoruz
    int sayac = 0; // Sayaç tanımlıyoruz amacımız index ve sayaç eşitlendiğinde silinmesi istenen eleman ekranda gözükmesin

    foreach (var item in chardizisi) // Foreach ile elemanlar arasında tek tek gezilir ve if bloğuna uyanlar ekrana basılır
    {
        if (sayac != index)
        {
            Console.Write(item);
        }
        sayac++;
    }
}

