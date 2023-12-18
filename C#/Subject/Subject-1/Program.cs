// Uygulama

// 1-) Girilen 2 sayıdan hangisi büyüktür?
// Console.Write("sayı 1: ");
// int sayi1 = int.Parse(Console.ReadLine());

// Console.Write("sayı 2: ");
// int sayi2 = int.Parse(Console.ReadLine());

// var result = (sayi1>sayi2)?"sayı1>sayı2":"sayı2>sayı1";

// System.Console.WriteLine(result);

// 2-) Parola ve email bilgisini isteyip doğruluğunu kontrol ediniz.

// string _email = "info@yagizcan.com";
// string _parola = "12345";

// Console.Write("email: ");
// string email = Console.ReadLine();

// Console.Write("parola: ");
// string parola = Console.ReadLine();

// var result = (_email==email) && (_parola==parola);
// System.Console.WriteLine("Giriş Başarılı: "+ result);

// 3-) Girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.

// Console.Write("sayı: ");
// int sayi = int.Parse(Console.ReadLine());

// var result = (sayi>0) && (sayi%2==0);
// Console.WriteLine("sayi pozitif çift sayıdır: "+ result);

// 4-) Girilen 3 sayıyı büyüklük olarak karşılaştırınız.

// Console.Write("sayı 1: ");
// int a = int.Parse(Console.ReadLine());

// Console.Write("sayı 2: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("sayı 3: ");
// int c = int.Parse(Console.ReadLine());

// var result = (a>b) && (a>c);
// Console.WriteLine("en büyük sayı a: "+ result);

// result = (b>a) && (b>c);
// Console.WriteLine("en büyük sayı b: "+ result);

// result = (c>a) && (c>b);
// Console.WriteLine("en büyük sayı c: "+ result);

// var result = ((a>b) && (a>c))
//                ?"a en büyük ": ((b>a) && (b>c))
//                ?"b en büyük ": ((c>a) && (c>b))
//                ?"c en büyük":"hatalı bilgi";
// System.Console.WriteLine(result);

// 5-) Kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp ortalama hesaplayınız.
//     Eğer ortalama 50 ve üstündeyse geçti değilse kaldı yazdırın.
//     a-) Ortalama 50 olsa bile final notu en az 50 olmalıdır.
//     b-) Finalden 70 alındığında ortalamanın önemi olmasın.

// Console.WriteLine("1.vize: ");
// int vize1 = int.Parse(Console.ReadLine());

// Console.WriteLine("2.vize: ");
// int vize2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Final: ");
// int final = int.Parse(Console.ReadLine());

// var ortalama = ((vize1+vize2)/2)*0.6 + (final*0.4);
// var durum = ortalama>=50?"geçti":"kaldı";
// var durum = (ortalama>=50) && (final>=50);
// var durum = (ortalama >= 50) || (final >=70);

// System.Console.WriteLine("ortalama: "+ ortalama);
// Console.WriteLine(durum?"geçti":"kaldı");


// 6-) Kişinin ad, kilo ve boy bilgilerini alıp kilo indekslerini hesaplayınız.
//     Formül: (kilo / boy uzunluğunun karesi)
//     Aşağıdaki tabloya göre kişi hangi gruba girmektedir.
//     0-18.4    => Zayıf
//     18.5-24.9 => Normal
//     25.0-29.9 => Fazla Kilolu
//     30.0-34.9 => Şişman(Obez)

Console.Write("ad: ");
string ad = Console.ReadLine();

Console.Write("kilo: ");
float kilo = float.Parse(Console.ReadLine());

Console.Write("boy: ");
float boy = float.Parse(Console.ReadLine());

float indeks = (kilo)/ ( boy*boy);

var zayif = (indeks>=0) && (indeks<=18.4);
var normal = (indeks>=18.4) && (indeks<=24.9);
var kilolu = (indeks>=24.9) && (indeks<=29.9);
var obez = (indeks>=29.9) && (indeks<=34.9);

System.Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen zayıf: {zayif}");
System.Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen normal: {normal}");
System.Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen kilolu: {kilolu}");
System.Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen obez: {obez}");
