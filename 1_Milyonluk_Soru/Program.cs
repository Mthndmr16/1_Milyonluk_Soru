using System;
using System.Collections.Generic;


/// <summary>
/// Soru: Türkiye'deki 81 ilin adında bu dört harften hangisi diğer üçünden daha az bulunur ? 
/// 
/// A: Ş          B: V
/// 
/// C: G          D: H
/// 
/// 
/// Bu Algoritma ile her ili teker teker arayıp 4 şıkta belirtilen harflerden en az geçeni bulabiliriz...
/// </summary>
public class Program
{
    public static void Main()
    {
        // Türkiye'deki il isimlerinin listesi
        string[] iller = {
            "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın",
            "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı",
            "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep",
            "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars",
            "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa",
            "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun",
            "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van",
            "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın",
            "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
        };
        // Harflerin kaç kere geçtiğini tutmak için bir sözlük oluşturdum
        Dictionary<char, int> harfSayilari = new Dictionary<char, int>
        {
            { 'ş', 0 }, { 'v', 0 }, { 'g', 0 }, { 'h', 0 }
        };

        // İller listesi üzerinde dönüyoruz
        foreach (string il in iller)
        {
            // İllerin ilk harfini büyük olarak yazdığım için burada küçük harfe çeviriyorum
            string kucukIl = il.ToLower();
            // Sözlükteki her bir harf için kontrol yapıyorum
            foreach (char harf in harfSayilari.Keys)
            {
                // İl ismi içerisinde bu harf geçiyorsa sayısını bir artırıyorum
                if (kucukIl.Contains(harf.ToString()))
                {
                    harfSayilari[harf]++;
                }
            }
        }
        // En az bulunan harfi ve sayısını belirlemek için başlangıç değerleri
        char enAzGecenHarf = 'ş';
        int enAzGecenSayi = int.MaxValue;

        // Sözlükteki tüm harf-sayı çiftleri üzerinde dönüyorum
        foreach (var item in harfSayilari)
        {
            // Harfin sayısı en az bulunan sayıdan küçükse bu harfi kaydediyorum
            if (item.Value < enAzGecenSayi)
            {
                enAzGecenSayi = item.Value;
                enAzGecenHarf = item.Key;
            }
        }
       
        // En az bulunan harfi ve bu harfin kaç kez bulunduğunu ekrana yazdırıyorum
        Console.WriteLine("Şıklar arasında en az bulunan harf "+ enAzGecenHarf + " harfidir ve " + enAzGecenSayi +" kere bulunmuştur.");
    }
}
