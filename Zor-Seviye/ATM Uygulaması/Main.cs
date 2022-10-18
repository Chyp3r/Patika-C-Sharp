// .Net Core 6.0
// Made by Chyper
// ATM Uygulaması

List<string> logs = new List<string>(); // Log kayıtları tutan liste değişkeni

// Giriş yapma fonksiyonu
void giris(List<user> users1)
{
    string acnumber,pass;
    label:
    int sayac =0;
    Console.Clear();
    Console.WriteLine("6 haneli hesap numarınızı giriniz");
    acnumber = Console.ReadLine();
    Console.WriteLine("Şifrenizi giriniz");
    pass = Console.ReadLine();

    // Foreach ile users1 listesi içindeki kullanıcıları gezip doğru kullanıcıyı arıyoruz
    foreach (var item in users1)
    {
        sayac ++;
        Console.WriteLine(item.accountnumber);
        if(item.accountnumber == acnumber && item.password == pass)
        {
            string l = "Saat = " + DateTime.Now.ToString("T") +" Giriş Yapıldı " + " Hesap numarası = "  + item.accountnumber + " Şifre = " + item.password;
            logs.Add(l);
            menu(item,users1);
        }
        // Eğer tüm kullanıcılara bakılmasına rağmen kullanıcı bulunamadıysa hatalı kullanıcı bilgisi döndürülür
        else if(sayac == users1.Count)
        {
            Console.WriteLine("Hatalı kullanıcı adı veya şifre");
            string l = "Saat = " + DateTime.Now.ToString("T") +" Hatalı Giriş " + " Denenen hesap numarası = "  + item.accountnumber + " Denenen şifre = " + item.password;
            logs.Add(l);
            Task.Delay(1000).Wait();
            goto label;
        }
    }
}

// Seçimlerin yapılacağı anamenü
void menu(user currentuser,List<user> users)
{
    Console.Clear();
    int value = 0;
    Console.WriteLine("Merhaba  {0}. İşleminizi seçiniz",currentuser.name);
    label:
    Task.Delay(1000).Wait();
    Console.Clear();
    Console.WriteLine("1) Para Çekme\n2) Para yatırma\n3) Hesap Bilgileri\n4) Çıkış Yap");
    // Try Catch ile verilen bilginin sayısal olup olmadığı kontrol ediliyor
    try
    {
        value = Convert.ToInt32(Console.ReadLine());
        switch (value)
        {
            case 1:
            {
                paracek(currentuser);
                break;
            }
            case 2:
            {
                parayatir(currentuser);
                break;
            }
            case 3:
            {
                hesapbilgileri(currentuser);
                break;
            }
            case 4:
            {
                Console.WriteLine("Çıkış Yapılıyor");
                string l = "Saat = " + DateTime.Now.ToString("T") +" Çıkış Yapıldı " + " Hesap numarası = "  + currentuser.accountnumber + " Şifre = " + currentuser.password;
                logs.Add(l);
                giris(users);
                break;
            }
            // Admin hesabındayken günü bitirmek için girilmesi gereken kod
            case 555:
            {
                if(currentuser.accountnumber == "123456")
                {
                    endofday(logs);
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz!");
                }
                break;
            }
            default:
            {
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz!");
                break;
            }
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Hatalı format!");
        Task.Delay(1000).Wait();
        Console.Clear();
        goto label;
    }
    goto label;
}

// Para çekme fonksiyonu
void paracek(user currentuser)
{
    Console.Clear();
    int value = 0;
    label:
    Console.WriteLine("Çekmek istediğiniz miktarı giriniz");
    // Try Catch ile verilen bilginin sayısal olup olmadığı kontrol ediliyor
    try
    {
        value = Convert.ToInt32(Console.ReadLine());
        if (currentuser.cash >= value)
        {
            currentuser.cash -= value;
            Console.WriteLine("Para çekme işlemi tamamlandı. Yeni bakiyeniz = {0}",currentuser.cash);
            string l = "Saat = " + DateTime.Now.ToString("T") + " "+currentuser.accountnumber + " numaralı hesaptan " + value + " tl çekildi. Yeni bakiye " + currentuser.cash;
            logs.Add(l); 
        }
        else
        {
            Console.WriteLine("Hesabınızda bu kadar para bulunmadığı için işleminiz gerçekleştirilemedi!");
            string l = "Saat = " + DateTime.Now.ToString("T") + " "+currentuser.accountnumber + " numaralı hesapta yetersiz bakiyeden dolayı para çekilemedi";
            logs.Add(l); 
            return;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Hatalı format!");
        Task.Delay(1000).Wait();
        Console.Clear();
        goto label;
    }
}

// Para yatırma fonksiyonu
void parayatir(user currentuser)
{
    Console.Clear();
    int value = 0;
    label:
    Console.WriteLine("Yatırmak istediğiniz miktarı giriniz");
    // Try Catch ile verilen bilginin sayısal olup olmadığı kontrol ediliyor
    try
    {
        value = Convert.ToInt32(Console.ReadLine());
        currentuser.cash += value;
        Console.WriteLine("Para yatırma işlemi tamamlandı. Yeni bakiyeniz = {0}",currentuser.cash);
        string l = "Saat = " + DateTime.Now.ToString("T") + " "+currentuser.accountnumber + " numaralı hesaba " + value + " tl yatırıldı. Yeni bakiye " + currentuser.cash;
        logs.Add(l); 
    }
    catch (System.Exception)
    {
        Console.WriteLine("Hatalı format!");
        Task.Delay(1000).Wait();
        Console.Clear();
        goto label;
    }
}

// Hesap bilgilerini ekrana bastıran fonksiyon
void hesapbilgileri(user currentuser)
{
    Console.Clear();
    string l = "Saat = " + DateTime.Now.ToString("T") + " "+currentuser.accountnumber + " numaralı hesapta bilgiler gösterildi";
    logs.Add(l); 
    Console.WriteLine("Hesap sahibinin adı = {0}\nHesap numarası = {1}\nHesap şifresi = {2}",currentuser.name,currentuser.accountnumber,currentuser.password);
    Console.WriteLine("Menuye dönmek için entera basınız");
    string a = Console.ReadLine();
    return;
}

// Gün sonunda oluşacak logfile dosyası
void endofday(List<string> log)
{
    string path = "EOD_Tarih("+DateTime.Now.ToString("d")+").txt";
    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
     
    StreamWriter sw = new StreamWriter(fs);
    foreach (var item in log)
    {
        sw.WriteLine(item);
    }
    sw.Close();
}

List<user> users = new List<user>(); 
user admin = new user();
admin.accountnumber = "123456";
admin.password="1234";
admin.cash=999; 
admin.name = "Admin";
users.Add(admin);

user user1 = new user();
user1.accountnumber = "654321";
user1.password="@5!";
user1.cash = 5000;
user1.name = "nothing";
users.Add(user1);

giris(users);

class user
{
    public string accountnumber = "000000", password = "0000",name="x"; 
    public double cash = 0.0;
}