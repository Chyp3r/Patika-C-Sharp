// .Net Core 6.0
// Made by Chyper
// Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulaması

int[] kucuk67 = new int[100];
int[] buyuk67 = new int[100];
int sayackucuk=0,sayacbuyuk=0,toplamkucuk=0,toplambuyuk=0;
Console.WriteLine("Programa hoş geldiniz Bu program 67 den küçük sayıları 67 den çıkarıp toplar 67 den büyükleri de çıkartıp mutlak karelerini alır en son her kategoriyi toplayıp ekrana basar");
Console.WriteLine("0 Girmeniz durumunda ekrana sonuçlar basılır!");
// While döngüsü ile sayılar alınıyor
while(true)
{
    int sayi;
    kontrol:
    Console.WriteLine("Sayı giriniz:");
    // Try Catch ile girilen değerlerin hata vermesi engelleniyor
    try
    {
        sayi = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen sayısal bir değer giriniz");
        goto kontrol;
    }
    if (sayi == 0) // 0 ise program sonlanır
    {
        break;
    }
    else if(sayi < 67) // 67 den küçük 
    {
        kucuk67[sayackucuk] = sayi;
        sayackucuk++;
    }
    else if (sayi>67) // 67 den büyük
    {
        buyuk67[sayacbuyuk] = sayi;
        sayacbuyuk++;
    }
    else
    {
        Console.WriteLine("Bingo! 67 : )"); // 67 girilmesi durumunda 2 listeye de girmez ve easter egg i çalıştırır
    }

}
foreach (var item in kucuk67) // 67 den küçüklerin işlemleri
{
    if (item !=0)
    {
        toplamkucuk += 67- item;
    }
}
foreach (var item in buyuk67) // 67 den büyüklerin işlemleri
{
    if (item !=0)
    {
        toplambuyuk+=(67-item)*(67-item);
    }
}
Console.WriteLine("Küçüklerin sonucu {0}\nBüyüklerin sonucu {1}",toplamkucuk,toplambuyuk);
