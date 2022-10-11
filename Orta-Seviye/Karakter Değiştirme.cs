// .Net Core 6.0
// Made by Chyper
// Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulaması

Console.WriteLine("Ters hale getirilicek kelimeleri giriniz: ");
string deger = Console.ReadLine();
string[] dizi = deger.Split(" ");

for (int i = 0; i < dizi.Length; i++)
{
    char[] yenilemedizisi = dizi[i].ToCharArray(0,dizi[i].Length);
    Console.Write("{0}",yenilemedizisi[(dizi[i].Length)-1]);
    for (int j = 1; j < (dizi[i].Length)-1; j++)
    {
        Console.Write(yenilemedizisi[j]);
    }
    Console.Write("{0} ",yenilemedizisi[0]);
}
