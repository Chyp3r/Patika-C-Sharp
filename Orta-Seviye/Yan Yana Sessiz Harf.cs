// .Net Core 6.0
// Made by Chyper
// Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulaması
// Örnek: Input: Merhaba Umut Arya
// Output: True False True

Console.WriteLine("Kontrol edilecek kelimeleri giriniz: ");

// Değişken tanımlamaları
string deger = Console.ReadLine();
string[] dizi = deger.Split(" "); 
string sesli = "aeıioöuü";
bool sesli1 = true,sesli2=true;

for (int i = 0; i < dizi.Length; i++)
{
    int uzunluk = dizi[i].Length;
    char[] kontroldizisi = dizi[i].ToCharArray(0,uzunluk); // Kontrol dizisi ile sesli sessiz durumu kontrol edilecek
    for (int j = 0; j < uzunluk-1; j++)
    {
        string kont = Convert.ToString(kontroldizisi[j]);
        if(sesli.Contains(kont)) // Sesli var mı yok mu
        {
            sesli1 = true;
        }
        else
        {
            sesli1 = false;
        }
        kont = Convert.ToString(kontroldizisi[j+1]);
        if(sesli.Contains(kont)) // Sesli var mı yok mu
        {
            sesli2 = true;
        }
        else
        {
            sesli2 = false;
        }
        if (!sesli1 && !sesli2) // 2 tane karakter yan yana sessiz ise çalışır
        {
            Console.WriteLine("True ");
            break;
        }
        if(j==uzunluk-2) // Eğer programın istediği özelliği sağlamayan bir kelime girildiyse çalışır
        {
            Console.Write("False ");
            break;
        }
    }
}
