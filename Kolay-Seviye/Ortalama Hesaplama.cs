// .Net Core 6.0 
// Made by Chyper
// Fibonacci dizisinde kullanıcıdan alınan derinliğe kadar olan sayıların aritmetik ortalamasını verene program

Console.WriteLine("Fibonacci dizisinin derinliğini giriniz: "); // Derinliğin kullanıcıdan alınması

while(true) // Döngü kullanarak hatalı bir veri girilmesi durumda verinin tekrar alınamabilmesi sağlanılıyor
{
    // Kullanıcının hatalı bir değer girmesine karşın try catch ile kontrol
    try 
    {
        int derinlik = Convert.ToInt32(Console.ReadLine());
        if (derinlik>=1) // derinlik 1 ya da 1 den büyük olmaması halinde fibonacci dizisi hesaplanamaz bu yüzden if ile bu durumu kontrol ettik
        {                
            float sonuc = fibonacci(derinlik); // Fibonacci fonksiyonuna derinliğin gönderilmesi
            Console.WriteLine("Verdiğiniz derinliğe göre Fibonacci dizisinin {0}. derinliğindeki elemanına kadar olan elemanların aritmetik ortalaması: {1}",derinlik,sonuc);
            break;
        }
        else // Derinlik 0 ya da negatif ise tekrar derinlik istenir 
        {
            Console.WriteLine("Lütfen derinlik değerini 1 den büyük olucak şekilde tam sayı giriniz!");
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen derinlik değerini 1 den büyük olucak şekilde tam sayı giriniz!"); 
    }
}

// Aritmetik ortalamayı hesaplayan fibonacci fonksiyonu
float fibonacci(int derinlik) 
{
    float toplam =1;
    if(derinlik == 1) // Verilen derinlik 1 ise dizinin tek elemanı 0 dır Bu yüzden aritmetik ortalama 0 olarak döner
    {
        return 0;
    }
    else if(derinlik == 2) // Verilen derinlik 2 ise dizinin 2 elemanı 0 ve 1 dir Aritmetik ortalama 0,5 olarak döner
    {
        return toplam/2;
    }
    else
    {
        int[] fib = new int[derinlik]; // Derinlik büyüklüğünde fibonacci dizisi tanımlaması
        fib[0]=0;
        fib[1]=1;
        for (int i = 2; i < derinlik; i++) // 3.elemandan itibaren derinliğe kadar elemanların eklenmesi
        {
            fib[i]= fib[i-1]+ fib[i-2]; // Fibonacci formülü => Dizinin n. elemanı = (n-1) + (n-2)
        }
        foreach (var item in fib) // Foreach döngüsü ile elemanların tek tek toplanması
        {
           toplam +=item;
        }
        return toplam /(derinlik+2); // Aritmetik ortalamanın hesaplanıp geri döndürülmesi
    }

}
