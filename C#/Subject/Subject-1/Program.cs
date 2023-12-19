// string username = "yagizcan";
// string password = "12345";

// if (username == "yagizcan")
// {
//     if (password == "12345")
//     {
//         Console.WriteLine("Bilgileriniz Doğru");
//         Console.WriteLine("Hoş Geldiniz!");
//     }
//     else
//     {
//         Console.WriteLine("Parola Yanlış");
//     }
// }
// else
// {
//     Console.WriteLine("username yanlış");
// }

//    Console.Write("x: ");
//    int x = int.Parse(Console.ReadLine());
            
//    Console.Write("y: ");
//    int y =int.Parse(Console.ReadLine());
//     if (x>y)
//         Console.WriteLine("x y den büyük");
//     else if (x==y)
//         Console.WriteLine("x y eşit");
//     else
//         Console.WriteLine("y x den büyük");

// Console.Write("sayı: ");
// int sayi = int.Parse(Console.ReadLine());

// if (sayi>0)
//     Console.WriteLine("sayı pozitif");
// else if (sayi == 0)
//     Console.WriteLine("sayı sıfır");
// else 
//     Console.WriteLine("sayı negatif");

// 1- Kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme durumunu kontrol ediniz. Ehliyet alma koşulu en az 18 ve eğitim durumu lise ya da üniversite olmalıdır.

// Console.WriteLine("Ad: ");
// string ad = Console.ReadLine();

// Console.WriteLine("Yaş: ");
// int yas = int.Parse(Console.ReadLine());

// Console.WriteLine("Eğitim Durumu: ");
// string egitim = Console.ReadLine();

// if (yas>=18){
//     if(egitim=="lise" || egitim=="üniversite"){
//         Console.WriteLine($"{ad} Ehliyet alabilirsiniz.");
//     }else {
//         Console.WriteLine($"{ad} Ehliyet almak için eğitim durumunuz yetersiz.");
//     }
// }else{
//     Console.WriteLine($"{ad} Ehliyet almak için en az 18 yaşında olmanız gerekmektedir.");
// }

// 2- Girilen 3 sayıdan en büyüğünü bulunuz.

// Console.Write("a: ");
// int a = int.Parse(Console.ReadLine());

// Console.Write("b: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("c: ");
// int c = int.Parse(Console.ReadLine());

// if(a>b && a>c)
//     Console.WriteLine("a en büyük");
// else if (b>a && b>c)
//     Console.WriteLine("b en büyük");
// else if (c>a && c>b)
//     Console.WriteLine("c en büyük");
// else 
//     Console.WriteLine("Yanlış Bilgi");

// 3- Bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazdırınız.
// 0 -24  => 0
// 25-44  => 1
// 45-54  => 2
// 55-69  => 3
// 70-84  => 4
// 85-100 => 5

// Console.WriteLine("1. Yazılı: ");
// int not1 = int.Parse(Console.ReadLine());

// Console.WriteLine("2. Yazılı: ");
// int not2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Sözlü: ");
// int sozlu = int.Parse(Console.ReadLine());

// var ortalama = (not1 + not2 + sozlu)/3;
// int not=-1;

// if (ortalama>=0 && ortalama<25)
//     not = 0;
// else if (ortalama>=0 && ortalama<45)
//     not = 1;
// else if (ortalama>=45 && ortalama<55)
//     not = 2;
// else if (ortalama>=55 && ortalama<70)
//     not = 3;
// else if (ortalama>=70 && ortalama<85)
//     not = 4;
// else if (ortalama>=85 && ortalama<100)
//     not = 5;
// else
//     Console.WriteLine("Yanlış Not");

// System.Console.WriteLine($"not ortalaması: {ortalama} ve notunuz: {not}");

// 4- Trafiğe çıkış tarihi alınan bir aracın servis zamanını 
//    aşağıdaki bilgilere göre hesaplayınız.
//    1. Bakım => 1. yıl     
//    2. Bakım => 2. yıl      
//    3. Bakım => 3. yıl     
//    ** Süre hesabını alınan gün, ay, yıl bilgisine göre gün bazlı hesaplayınız.. 

// Console.Write("Yıl: ");
// int yıl = int.Parse(Console.ReadLine());

// Console.Write("Ay: ");
// int ay = int.Parse(Console.ReadLine());

// Console.Write("Gün: ");
// int gun = int.Parse(Console.ReadLine());

// int toplamGun = (DateTime.Now - new DateTime(yıl,ay,gun)).Days;

// if (toplamGun<=365)
//     Console.WriteLine("1.Servis");
// else if(toplamGun>365 && toplamGun<=365*2)
//     Console.WriteLine("2.Servis");
// else if(toplamGun>365*2 && toplamGun<=365*3)
//     Console.WriteLine("3.Servis");
// else
//     Console.WriteLine("Yanlış Bilgi");

// int ay = 5;

// switch (ay)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("Kış Mevsimi");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("İlkbahar Mevsimi");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Yaz Mevsimi");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Sonbahar Mevsimi");
//         break;
//     default:
//         Console.WriteLine("Yanlış Bilgi.");
//         break;
// }