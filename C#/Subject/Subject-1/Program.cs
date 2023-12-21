// Uygulama: Bankamatik

// string secim = "";
// double bakiye=0;
// double ekhesap = 1000;
// double ekhesapLimiti = 1000;

// do
// {
//     Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçiminiz: ");
//     secim = Console.ReadLine();

//     switch (secim)
//     {
//         case "1":
//             Console.WriteLine("Bakiyeniz {0} TL", bakiye);
//             Console.WriteLine("Ek Hesap Bakiyeniz {0} TL", ekhesap);
//             break;
//         case "2":
//             Console.Write("Yatırmak İstediğiniz Miktar: ");
//             double yatirilan = double.Parse(Console.ReadLine());

//             if (ekhesap<ekhesapLimiti)
//             {
//                 double ekhesaptankullanilan = ekhesapLimiti - ekhesap;
//                 if (yatirilan>=ekhesaptankullanilan)
//                 {
//                     ekhesap = ekhesapLimiti;
//                     bakiye = yatirilan - ekhesaptankullanilan;
//                 }
//                 else
//                 {
//                     ekhesap += yatirilan;
//                 }
//             }
//             else
//             {
//                 bakiye+=yatirilan;
//             }
//             break;
//         case "3":
//             Console.Write("çekmek istediğiniz miktar: ");
//             double cekilecekmiktar = double.Parse(Console.ReadLine());
//             if (cekilecekmiktar>bakiye)
//             {
//                 double toplam = bakiye + ekhesap;
//                 if (toplam>=cekilecekmiktar)
//                 {
//                     Console.Write("ek hesap kullanılsın mı? (e/h)");
//                     string ekhesaptercihi = Console.ReadLine();

//                     if (ekhesaptercihi=="e")
//                     {
//                         Console.Write("paranızı alabilirsiniz.");
//                         ekhesap -= (cekilecekmiktar-bakiye);
//                         bakiye = 0;
//                     }
//                     else
//                     {
//                         Console.WriteLine("bakiyeniz yetersiz");
//                     }
//                 }
//             }
//             else
//             {
//                 Console.Write("paranızı alabilirsiniz.");
//                 bakiye-=cekilecekmiktar;
//             }
//             break;
//         case "4":
//             Console.WriteLine("çıkış");
//             break;
//         default:
//             Console.WriteLine("Hatalı Seçim");
//             break;
//     }
// } while (secim!="4");

// Console.WriteLine("uygulamadan çıkıldı.");


string kullaniciAdi = "kullanici";
        string sifre = "sifre";

        Console.Write("Kullanıcı Adı: ");
        string girilenKullaniciAdi = Console.ReadLine();
        Console.Write("Şifre: ");
        string girilenSifre = Console.ReadLine();

        if (girilenKullaniciAdi != kullaniciAdi || girilenSifre != sifre)
        {
            Console.WriteLine("Hatalı giriş. Uygulamadan çıkılıyor.");
            return;
        }

        string secim = "";
        double bakiye = 0;
        double ekHesap = 1000;
        double ekHesapLimiti = 1000;
        List<string> islemGeçmisi = new List<string>();

        do
        {
            Console.WriteLine("************************************");
            Console.WriteLine("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-İşlem Geçmişi Görüntüle\n5-Çıkış");
            Console.WriteLine("************************************");
            Console.Write("Seçiminiz: ");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz: {0} TL", bakiye);
                    Console.WriteLine("Ek Hesap Bakiyeniz: {0} TL", ekHesap);
                    break;
                case "2":
                    Console.Write("Yatırmak İstediğiniz Miktar: ");
                    double yatirilan = double.Parse(Console.ReadLine());

                    if (yatirilan <= 0)
                    {
                        Console.WriteLine("Geçersiz miktar.");
                        break;
                    }

                    if (ekHesap < ekHesapLimiti)
                    {
                        double ekHesapKullanilan = ekHesapLimiti - ekHesap;
                        if (yatirilan >= ekHesapKullanilan)
                        {
                            ekHesap = ekHesapLimiti;
                            bakiye = yatirilan - ekHesapKullanilan;
                        }
                        else
                        {
                            ekHesap += yatirilan;
                        }
                    }
                    else
                    {
                        bakiye += yatirilan;
                    }

                    islemGeçmisi.Add($"Yatırılan: +{yatirilan} TL, Bakiye: {bakiye} TL, Ek Hesap: {ekHesap} TL");
                    break;
                case "3":
                    Console.Write("Çekmek İstediğiniz Miktar: ");
                    double cekilecekMiktar = double.Parse(Console.ReadLine());

                    if (cekilecekMiktar <= 0)
                    {
                        Console.WriteLine("Geçersiz miktar.");
                        break;
                    }

                    double toplamBakiye = bakiye + ekHesap;
                    if (cekilecekMiktar > toplamBakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                        break;
                    }

                    if (cekilecekMiktar > bakiye)
                    {
                        Console.Write("Ek hesap kullanılsın mı? (E/H): ");
                        string ekHesapTercihi = Console.ReadLine().ToUpper();

                        if (ekHesapTercihi == "E")
                        {
                            ekHesap -= (cekilecekMiktar - bakiye);
                            bakiye = 0;
                            Console.WriteLine("Paranızı alabilirsiniz.");
                        }
                        else if (ekHesapTercihi == "H")
                        {
                            Console.WriteLine("İşlem iptal edildi.");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçenek.");
                        }
                    }
                    else
                    {
                        bakiye -= cekilecekMiktar;
                        Console.WriteLine("Paranızı alabilirsiniz.");
                    }

                    islemGeçmisi.Add($"Çekilen: -{cekilecekMiktar} TL, Bakiye: {bakiye} TL, Ek Hesap: {ekHesap} TL");
                    break;
                case "4":
                    Console.WriteLine("İşlem Geçmişi:");
                    foreach (var islem in islemGeçmisi)
                    {
                        Console.WriteLine(islem);
                    }
                    break;
                case "5":
                    Console.WriteLine("Uygulamadan çıkılıyor.");
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim.");
                    break;
            }
        } while (secim != "5");