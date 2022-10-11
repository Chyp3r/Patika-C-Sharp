// .Net Core 6.0
// Made by Chyper
// Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulaması
// Örnek: Input: Merhaba Hello Question
// Output: erhabaM elloH uestionQ

Console.WriteLine("Ters hale getirilicek kelimeleri giriniz: ");
string deger = Console.ReadLine();
string[] dizi = deger.Split(" ");

for (int i = 0; i < dizi.Length; i++)
{
    char[] yenilemedizisi = dizi[i].ToCharArray(0,dizi[i].Length);
    for (int j = 1; j < dizi[i].Length; j++)
    {
        Console.Write(yenilemedizisi[j]);
    }
    Console.Write("{0} ",yenilemedizisi[0]);
}
