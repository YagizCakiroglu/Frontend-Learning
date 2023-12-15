using System.Globalization;

string[] aylar = {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"};
           DateTime simdi = DateTime.Now;

        //    Console.WriteLine(simdi);
        //    Console.WriteLine(simdi.Year);
        //    Console.WriteLine(simdi.Month);
        //    Console.WriteLine(aylar[simdi.Month-1]);
        //    Console.WriteLine(simdi.Day);
        //    Console.WriteLine(simdi.DayOfWeek);
        //    Console.WriteLine(simdi.Hour);
        //    Console.WriteLine(simdi.Minute);
        //    Console.WriteLine(simdi.Second);

        DateTime dt = new DateTime(2023,2,22,14,30,21);

        // DateTime dt1 = dt.AddDays(2);
        // DateTime dt1 = dt.AddYears(1);
        // DateTime dt1 = dt.AddHours(-5);
        
        // var fark =  simdi - dt;
        
        // Console.WriteLine(fark.TotalDays);
        // Console.WriteLine(fark.TotalHours);

        // Console.WriteLine(simdi);
        // Console.WriteLine(simdi.ToString("d"));
        // Console.WriteLine(simdi.ToString("D"));
        // Console.WriteLine(simdi.ToString("F"));
        // Console.WriteLine(simdi.ToString("M"));
        // Console.WriteLine(simdi.ToString("t"));
        // Console.WriteLine(simdi.ToString("T"));
        // Console.WriteLine(simdi.ToString("Y"));

        Console.WriteLine(simdi.ToString("hh:mm:ss"));
        Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));

        CultureInfo culture = new CultureInfo("en");
        Console.WriteLine(simdi.ToString("F",culture));