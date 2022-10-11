// .Net Core 6.0
// Made by Chyper
// Alan ve Çevre hesabı yapan console uygulaması

Console.WriteLine("Şeklinizi seçiniz:\n1)Kare\n2)Daire\n3)Üçgen\n4)Diktörtgen");
bool kontrol = true;
while(kontrol)
{
    // Try Catch ile kullanıcıdan alınan veri denetlenir böylece uygulamanın hata vermesi engellenir
    try
    {
        double sekil = Convert.ToDouble(Console.ReadLine());
        // switch case ile şekil seçimi yapılır
        switch (sekil)
        {
            case 1:
            {
                kontrol = false;
                kare_dikdortgen yenikare = new kare_dikdortgen();
                yenikare.degeral();
                Console.WriteLine("Karenizin alanı {0}\nKarenizin çevresi {1}",yenikare.alanhesapla(),yenikare.cevrehesapla());
                break;
            }
            case 2:
            {
                kontrol = false;
                daire yenidaire = new daire();
                yenidaire.degeral();
                Console.WriteLine("Dairenizin alanı {0}\nDairenizin çevresi {1}",yenidaire.alanhesapla(),yenidaire.cevrehesapla());
                break;
            }
            case 3:
            {
                kontrol = false;
                ucgen yeniucgen = new ucgen();
                yeniucgen.degeral();
                Console.WriteLine("Üçgeninizin alanı {0}\nÜçgeninizin çevresi {1}",yeniucgen.alanhesapla(),yeniucgen.cevrehesapla());
                break;
            }
            case 4:
            {
                kontrol = false;
                kare_dikdortgen yenidikdortgen = new kare_dikdortgen();
                yenidikdortgen.degeral();
                Console.WriteLine("Dikdörtgeninizin alanı {0}\nDikdörtgeninizin çevresi {1}",yenidikdortgen.alanhesapla(),yenidikdortgen.cevrehesapla());
                break;
            }
            default:
            {
                Console.WriteLine("Lütfen 1-4 arası bir sayı giriniz!");
                break;
            }
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen 1-4 arası bir sayı giriniz!");   
    }
}

abstract class sekil // temel şekil sınıfı tanımlaması
{
    public virtual double alanhesapla()
    {
        return 0;
    }
    public virtual double cevrehesapla()
    {
        return 0;
    }
    public virtual void degeral()
    {
        Console.WriteLine("");
    }
}

class ucgen:sekil // Üçgen sınıfı
{
    double taban;
    double kenar1;
    double kenar2;
    double yukseklik;
    public override double alanhesapla()
    {
        return taban*yukseklik/2;
    }
    public override double cevrehesapla()
    {
        return taban+kenar1+kenar2;
    }
    public override void degeral() // Label ve goto kullanılarak her değerin doğru alınması sağlandı
    {
        kenar1_label:
        Console.WriteLine("1.kenarı giriniz:");
        try
        {
            taban = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Hatalı format!");
            goto kenar1_label;
        }

        kenar2_label:
        Console.WriteLine("2.kenarı giriniz:");
        try
        {
            kenar1 = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Hatalı format!");
            goto kenar2_label;
        }

        kenar3_label:
        Console.WriteLine("3.kenarı giriniz:");
        try
        {
            kenar2 = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Hatalı format!");
            goto kenar3_label;
        }

        yukseklik_label:
        Console.WriteLine("1.tabana göre yüksekliği giriniz");
        try
        {
            yukseklik = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Hatalı format!");
            goto yukseklik_label;
        }
    }
}
class daire:sekil // Daire sınıfı
{
    const double pi = 3.14;
    double r;
    public override double alanhesapla()
    {
        return pi*r*r;
    }
    public override double cevrehesapla()
    {
        return 2*pi*r;
    }
    public override void degeral() // Label ve goto kullanılarak her değerin doğru alınması sağlandı
    {
        r_label:
        Console.WriteLine("1.kenarı giriniz:");
        try
        {
            r = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Hatalı format!");
            goto r_label;
        }

    }
}
class kare_dikdortgen:sekil // Kare ve dikdörtgen sınıfı tek sınıf altında çünkü kare bir dikdörtgendir ve dikdörtgen özelliklerini sağlar
{
    double kenar1;
    double kenar2;
    public override double alanhesapla()
    {
        return kenar1*kenar2;
    }
    public override double cevrehesapla()
    {
        return (kenar1+kenar2)*2;
    }
    public override void degeral() // Label ve goto kullanılarak her değerin doğru alınması sağlandı
    {
        kenar1_label:
        Console.WriteLine("1.kenarı giriniz:");
        try
        {
            kenar1 = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Hatalı format!");
            goto kenar1_label;
        }

        kenar2_label:
        Console.WriteLine("2.kenarı giriniz:");
        try
        {
            kenar2 = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Hatalı format!");
            goto kenar2_label;
        }
    }
}
