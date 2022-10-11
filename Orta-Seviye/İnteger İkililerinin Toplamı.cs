// .Net Core 6.0
// Made by Chyper
// Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulaması

Console.WriteLine("Programa hoşgeldiniz 2 sayı giriniz 2 sayı farklı ise toplamlarını aynı ise toplamlarının karesini sana geri vereceğiz 0 ve 0 girişi programı kapatır");
while(true)
{   
    int sayi1=0,sayi2=0;
    sayi1_label:
    Console.WriteLine("Sayı 1 i giriniz:");
    //Try Catch ile veri kontrolü yapılıyor
    try
    {
        sayi1 = Convert.ToInt32(Console.ReadLine());   
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen sayısal bir değer giriniz!");
        goto sayi1_label; // Hata alınması durumunda etikete geri dönülücek
    }  
    
    sayi2_label:
    Console.WriteLine("Sayı 2 yi giriniz:");
    //Try Catch ile veri kontrolü yapılıyor
    try
    {
        sayi2 = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen sayısal bir değer giriniz!");
        goto sayi2_label; // Hata alınması durumunda etikete geri dönülücek
    }

    if (sayi1 != sayi2) // Sayılar farklıysa toplama işlemi
    {
        Console.WriteLine(sayi1+sayi2);
    }
    else if(sayi1 == sayi2 && sayi1 !=0) // Sayılar aynı ve 0 değil ise toplayıp kare alınacak
    {
        Console.WriteLine((sayi1+sayi2)*(sayi1+sayi2));
    }
    else // Sayılar 0 ise programı kapat    
    {
        Console.WriteLine("Program kapatılıyor");
        break;
    }
}
