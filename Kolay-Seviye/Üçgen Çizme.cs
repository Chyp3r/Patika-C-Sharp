// .Net Core 6.0
// Verilen yüksekliğe göre üçgen çizen program

Console.WriteLine("Yükseliği giriniz:");

while(true)
{
    // Try catch ile verilen değerin sayı olup olmadığı kontrol ediliyor
    try
    {
        int yukseklik = Convert.ToInt32(Console.ReadLine());
        if(yukseklik>1) // Verilen değer 1 den büyük olmaz ise üçgen oluşturulamaz
        {
            ucgenciz(yukseklik); // Üçgen çizme fonksiyonuna gidiliyor
            break;
        }
        else
        {
            Console.WriteLine("Lütfen 1 den büyük bir sayı giriniz: ");
        }
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
    }
}

// Verilen yüksekliğe göre üçgen çizen foksiyon
void ucgenciz(int yukseklik)
{
    int taban = yukseklik*2,kenarbosluk=(yukseklik-1),arabosluk=0; // Matematiksel işlemler ile değişkenler tanımlanıyor
    for (int i = 0; i < yukseklik-1; i++)
    {
        for (int b = 0; b < kenarbosluk; b++) // Kenardan boşluk bırakma
        {
            Console.Write(" ");
        }

        kenarbosluk-=1;
        Console.Write("*");

        for (int c = 0; c < arabosluk; c++) // 2 * arasında boşluk bırakma
        {
            Console.Write(" ");
        }

        Console.WriteLine("*");
        arabosluk+=2;
    }

    for (int d = 0; d < taban; d++) // Tabanı bastırma
    {
        Console.Write("*");
    }
}

