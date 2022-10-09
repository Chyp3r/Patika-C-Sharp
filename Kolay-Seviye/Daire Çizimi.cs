// .Net Core 6.0
// Made by Chyper
// Verilen yarıçapa göre daire çizen program


float yaricap = 0; // Yarıçap tanımlaması
double incelik = 0.6; // İncelik => Dairenin kenarların incelik kalınlık oranını belirtir Optimum aralık 0.4-0.7 arası

while (true)
{
    // Try catch ile girilen yarıçap değerinin sayısal bir veri olup olmadığı kontrol ediliyor
    Console.Write("Yarıçapını giriniz: ");
    try
    {
        yaricap = Convert.ToInt32(Console.ReadLine());
        if (yaricap <= 0) // Yarıçap 0 veya negatif olmamalı
        {
            Console.WriteLine("Negatif veya 0 yarıçaplı bir daire çizilemez");
        }
        else
        {
            break;
        }
    }   
    catch (System.Exception)
    {
        Console.WriteLine("Yarıçap bir sayı olmalıdır!");
    }
}

double ic_yaricap = yaricap - incelik, dis_yaricap = yaricap + incelik; // İç yarıçap => yarıçaptan inceliğin çıkartılması ile elde edilir
                                                                        // Dış yarıçap => yarıçapa inceliğin eklenmesi ile elde edilir

for (float y = yaricap; y >= -yaricap; y--) // Bir satır içerisinde dolaşma
{
    for (double x = -yaricap; x < dis_yaricap; x += 0.5) // Adım adım x i büyüterek merkeze doğru yazım işlemine başlanır
    {
        double cember_degeri = x * x + y * y; // Merkezi orijin olan çemberin grafiği x^2+y^2=yaricap^2 dir cember değeri buradaki yaricap^2 dir
        if (cember_degeri >= ic_yaricap * ic_yaricap && cember_degeri <= dis_yaricap * dis_yaricap) // Eğer çemberin kenarları üzerindeysek * bas
        {
            Console.Write("*");
        }
        else // Değilsek boşluk bırak
        {
            Console.Write(" ");
        }
    }
            Console.WriteLine();
}
