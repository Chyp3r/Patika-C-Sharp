using BarcodeLib.BarcodeReader;
using BarcodeLib;

// Barkod olusturma fonksiyonu
void olustur()
{
    // Barkod üretliyor
    Barcode barcodLib = new Barcode();
 
    // Barkod özellikleri
    int genislik = 290; 
    int yukseklik = 120;
    Color cizgirenk = Color.Black;
    Color zeminrenk = Color.White; 

    //UPCA tipinde veri girdisi
    string girdi = "038000350216";

    Image barkodresmi = barcodLib.Encode(TYPE.UPCA, girdi, cizgirenk, zeminrenk, genislik, yukseklik);

    // Barkodun kayıt noktası
    barkodresmi.Save(@"barkod.png", ImageFormat.Png);
}

// Barkod okuma fonksiyonu
void oku()
{
    string[] BarcodeUPCA = BarcodeReader.read(@"Barkod-upca.png", BarcodeReader.UPCA);
    Console.WriteLine("UPCA Code:" + ConvertStringArrayToString(BarcodeUPCA));

    // String arayini normal strinige dönüştüren fonksiyon
    string ConvertStringArrayToString(string[] array)
    {
        // Concatenate all the elements into a StringBuilder.
        StringBuilder builder = new StringBuilder();
        foreach (string value in array)
        {
            builder.Append(value);
            
        }
        return builder.ToString();
    }
}

// Kullanmak için gerekli kütüphaneleri kurmalı ve oluşturma ve okuma fonksiyonlarını çağırmalısınız