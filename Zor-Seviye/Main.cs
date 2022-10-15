// .Net Core 6.0
// Made by Chyper
// Voting Uygulaması

kategori[] kategoris = isimlendir();

List<user> users = new List<user>();
user ali = new user();
user veli = new user();
user ahmet = new user();
user newuser = new user();
users.Add(ali);
users.Add(veli);
users.Add(ahmet);
ali.username = "Al1@y";
veli.username = "V3l1";
ahmet.username = "@HMet";
ali.password = "1234";
veli.password = "4321";
ahmet.password = ":)";
ali.oy=1;
veli.oy=2;
ahmet.oy=3;



void yenigiris()
{
    Console.Clear();
    bool statue = false;
    giris:
    Console.WriteLine("Kullanıcı adınızı giriniz");
    string username= Console.ReadLine();
    Console.WriteLine("Şifrenizi giriniz");
    string password= Console.ReadLine();
    foreach (var item in users)
    {
        if (item.username == username && item.password == password)
        {
            Console.WriteLine("Giriş yapıldı hoşgeldin {0}",item.username);
            statue = true;
            oylama(item);
            break;
        }
    }
    if (statue == false)
    {
        Console.WriteLine("Hatalı kullanıcı adı veya şifre");
        goto giris;
    }
}

void uyeol()
{
    Console.Clear();
    Console.WriteLine("Kullanıcı adı belirleyiniz:");
    newuser.username = Console.ReadLine();
    Console.WriteLine("Şifre belirleyiniz");
    newuser.password = Console.ReadLine();
    users.Add(newuser);
    yenigiris();
}

void oylama(user item)
{
    Console.Clear();
    hata:
    Console.WriteLine("1)Bilgisayar Oyunları\n2)Playstation oyunları\n3)Xbox Oyunları\n4)Mobil Oyunlar\nOyunuzu veriniz:");
    try
    {
        int oy = Convert.ToInt32(Console.ReadLine());
        if (oy == 1 || oy == 2 || oy == 3 || oy == 4)
        {
            item.oy = oy;
        }
        else
        {
            Console.WriteLine("Hatalı giriş!");
            goto hata;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Hatalı giriş");
        goto hata;
    }
    foreach (var a in users)
    {
        switch (a.oy)
        {
            case 1:
            {
                kategoris[0].oysayisi++;
                Console.WriteLine("{0} PC YE OY VERDİ",a.username);
                break;
            }
            case 2:
            {
                kategoris[1].oysayisi++;
                Console.WriteLine("{0} PS YE OY VERDİ",a.username);
                break;
            }
            case 3:
            {
                kategoris[2].oysayisi++;
                Console.WriteLine("{0} XBOX YE OY VERDİ",a.username);
                break;
            }
            case 4:
            {
                kategoris[3].oysayisi++;
                Console.WriteLine("{0} MOBİL YE OY VERDİ",a.username);
                break;
            }
        }
    }
    Task.Delay(1000).Wait();
    sonuclarigoster();
}

void sonuclarigoster()
{
    Console.Clear();
    foreach (var item in kategoris)
    {
        double yuzde = item.oysayisi*100/users.Count;
        Console.WriteLine("{0} oy sayısı: {1} oy yüzdesi {2}",item.ad,item.oysayisi,yuzde);    
    }
}

void menu()
{
    int giris;
    hata:
    Console.WriteLine("Sisteme Hoş geldiniz Üye olmak için 1 e Giriş yapmak için 2 ye basınız: ");
    try
    {
        giris = Convert.ToInt32(Console.ReadLine());
        if (giris == 1)
        {
            uyeol();
        }
        else if (giris == 2)
        {
            yenigiris();
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir işlem yapınız.");
            goto hata;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Hatalı Format");
        goto hata;
    }


}

kategori[] isimlendir()
{
    kategori pc = new kategori();
    kategori ps = new kategori();
    kategori xbox = new kategori();
    kategori mobil = new kategori();
    pc.ad ="Bilgisayar";
    ps.ad="Playstation";
    xbox.ad="Xbox";
    mobil.ad="Mobil";
    kategori[] kategoris = new kategori[4] {pc,ps,xbox,mobil};
    return kategoris;
}


menu();